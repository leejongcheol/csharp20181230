using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
class Server
{
    public static void Main()
    {
        NetworkStream stream = null;
        TcpListener tcpListener = null;
        Socket clientsocket = null;
        StreamReader reader = null;
        StreamWriter writer = null;
        try
        {
            //IP주소를 나타내는 객체를 생성,TcpListener를 생성시 인자로 사용할려고
            IPAddress ipAd = IPAddress.Parse("192.168.2.54");
            //TcpListener Class를 이용하여 클라이언트의 연결을 받아 들인다.
            tcpListener = new TcpListener(ipAd, 5001);
            tcpListener.Start();
            clientsocket = tcpListener.AcceptSocket();


            //클라이언트의 데이터를 읽고, 쓰기 위한 스트림을 만든다.
            stream = new NetworkStream(clientsocket);
            Encoding encode = Encoding.GetEncoding("utf-8");
            reader = new StreamReader(stream, encode);
            writer = new StreamWriter(stream, encode) { AutoFlush = true };
            while (true)
            {
                string str = reader.ReadLine();
                Console.WriteLine(str);
                writer.WriteLine(str);
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.ToString());
        }
        finally
        {
            clientsocket.Close();
        }
    }
}