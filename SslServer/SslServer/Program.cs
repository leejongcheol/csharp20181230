﻿using System.Net;
using System.Net.Sockets;
using System.Net.Security;
using System.Security.Authentication;
using System.Security.Cryptography.X509Certificates;
using System.Diagnostics;
using System;
using System.Text;

public sealed class SslServer
{
    static X509Certificate serverCertificate = null;

    public static void RunServer(string certificate, string password)
    {
        try
        {
            serverCertificate = new X509Certificate(certificate, password);

            TcpListener listener = new TcpListener(IPAddress.Any, 8080);
            listener.Start();

            while (true)
            {
                Console.WriteLine("Waiting for a client to connect...");
                Console.WriteLine();

                TcpClient client = listener.AcceptTcpClient();
                ProcessClient(client);
            }
        }
        catch (Exception ex)
        {
            Trace.WriteLine(string.Format("Error : {0}", ex.Message));
        }
    }

    static void ProcessClient(TcpClient client)
    {
        SslStream sslStream = new SslStream(client.GetStream(), false);

        try
        {
            sslStream.AuthenticateAsServer(serverCertificate, false, SslProtocols.Tls, true);

            // Set timeouts for the read and write to 5 seconds.
            //sslStream.ReadTimeout = 5000;
            //sslStream.WriteTimeout = 5000;

            // Read a message from the client.
            Console.WriteLine("Waiting for client message...");
            string messageData = ReadMessage(sslStream);
            Console.WriteLine("Received : {0}", messageData.Substring(0, messageData.IndexOf("$")));

            // Write a message to the client
            messageData = "[reply] " + messageData;
            byte[] message = Encoding.UTF8.GetBytes(messageData);
            sslStream.Write(message);
            Console.WriteLine("Sending hello message");
            Console.WriteLine();
        }
        catch (AuthenticationException e)
        {
            Console.WriteLine("Exception: {0}", e.Message);
            if (e.InnerException != null)
            {
                Console.WriteLine("Inner exception: {0}", e.InnerException.Message);
            }
            Console.WriteLine("Authentication failed - closing the connection.");
            sslStream.Close();
            client.Close();
            return;
        }
        finally
        {
            // The client stream will be closed with the sslStream
            // because we specified this behavior when creating
            // the sslStream.
            sslStream.Close();
            client.Close();
        }
    }

    static string ReadMessage(SslStream sslStream)
    {
        // Read the  message sent by the client.
        // The client signals the end of the message using the
        // "$" marker.
        byte[] buffer = new byte[2048];
        StringBuilder messageData = new StringBuilder();
        int bytes = -1;
        do
        {
            // Read the client's test message.
            bytes = sslStream.Read(buffer, 0, buffer.Length);

            // Use Decoder class to convert from bytes to UTF8
            // in case a character spans two buffers.
            Decoder decoder = Encoding.UTF8.GetDecoder();
            char[] chars = new char[decoder.GetCharCount(buffer, 0, bytes)];
            decoder.GetChars(buffer, 0, bytes, chars, 0);
            messageData.Append(chars);
            // Check for EOF or an empty message.
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
        SslServer.RunServer(@"C:\GitHub\csharp20181230\SslServer\SslServer\SslServer_TemporaryKey.pfx", "12345");

        Console.WriteLine("Press the any key to continue...");
        Console.ReadLine();
    }
}
