using System.Net;
using System.Net.Sockets;
using System.Net.Security;
using System.Security.Authentication;
using System.Security.Cryptography.X509Certificates;
using System.Diagnostics;
using System.Collections;
using System;
using System.Text;

public class SslTcpClient
{
    private static Hashtable certtificateError = new Hashtable();

    // The following method is invoked by the RemoteCertificateValidationDelegate.
    public static bool ValidateServerCertificate(
          object sender,
          X509Certificate certificate,
          X509Chain chain,
          SslPolicyErrors sslPolicyErrors)
    {
        if (sslPolicyErrors == SslPolicyErrors.None)
            return true;

        Console.WriteLine("Certificate error: {0}", sslPolicyErrors);

        // Do not allow this client to communicate with unauthenticated servers.
        return false;
    }

    public static void RunClient(string machineName, string serverName, string inputMessage)
    {
        // Create a TCP/IP client socket.
        // machineName is the host running the server application.
        TcpClient client = new TcpClient(machineName, 8080);
        Console.WriteLine("Client connected.");
        // Create an SSL stream that will close the client's stream.
        SslStream sslStream = new SslStream(
            client.GetStream(),
            false,
            new RemoteCertificateValidationCallback(ValidateServerCertificate),
            null
            );
        // The server name must match the name on the server certificate.
        try
        {
            sslStream.AuthenticateAsClient(serverName);
        }
        catch (AuthenticationException e)
        {
            Console.WriteLine("Exception: {0}", e.Message);
            if (e.InnerException != null)
            {
                Console.WriteLine("Inner exception: {0}", e.InnerException.Message);
            }
            Console.WriteLine("Authentication failed - closing the connection.");
            client.Close();
            return;
        }

        // Encode a test message into a byte array.
        // Signal the end of the message using the "$".
        byte[] messsage = Encoding.UTF8.GetBytes(inputMessage + "$");
        // Send hello message to the server.
        sslStream.Write(messsage);
        sslStream.Flush();

        // Read message from the server.
        string serverMessage = ReadMessage(sslStream);
        Console.WriteLine("Server says: {0}", serverMessage.Substring(0, serverMessage.IndexOf("$")));


        // Close the client connection.
        client.Close();
        Console.WriteLine("Client closed.");
        Console.WriteLine();
    }

    private static string ReadMessage(SslStream sslStream)
    {
        // Read the message sent by the server.
        // The end of the message is signaled using the "$" marker
        byte[] buffer = new byte[2048];
        StringBuilder messageData = new StringBuilder();
        int bytes = -1;

        do
        {
            bytes = sslStream.Read(buffer, 0, buffer.Length);

            Decoder decoder = Encoding.UTF8.GetDecoder();
            char[] chars = new char[decoder.GetCharCount(buffer, 0, bytes)];
            decoder.GetChars(buffer, 0, bytes, chars, 0);
            messageData.Append(chars);

            if (messageData.ToString().IndexOf("$") != -1)
            {
                break;
            }
        } while (bytes != 0);

        return messageData.ToString();
    }
}

class Program
{
    static void Main(string[] args)
    {
        string inputMessage = string.Empty;

        do
        {
            Console.Write("Clients says: ");
            inputMessage = Console.ReadLine();
            SslTcpClient.RunClient("localhost", @"C:\GitHub\csharp20181230\SslServer\SslServer\SslServer_TemporaryKey.pfx", inputMessage);
        } while (inputMessage.ToLower() != "exit");

        Console.WriteLine("Press any key to continue...");
        Console.ReadLine();
    }
}