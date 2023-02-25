using System.Net;
using System.Net.Sockets;

namespace Chap12_SocketServer;
class SocketServer
{
    static void Main()
    {
        // ①接続準備
        TcpListener listener = new(IPAddress.Any, 30000);
        Console.WriteLine("①接続を準備しています");

        // ②接続待機を開始する
        listener.Start();
        Console.WriteLine("②接続を待機しています");

        while (true)
        {
            // ③接続要求を受け入れる
            using (var client = listener.AcceptTcpClient())
            {
                Console.WriteLine("③接続しました");

                // NetworkStreamの取得
                using var ns = client.GetStream();

                // ④データ受信
                byte[] rb = new byte[3];
                ns.Read(rb, 0, rb.Length);
                Console.WriteLine($"④受信 ← {BitConverter.ToString(rb)}");

                // ④データ送信
                byte[] sb = { 3, 4, 5 };
                ns.Write(sb, 0, sb.Length);
                Console.WriteLine($"④送信 → {BitConverter.ToString(sb)}");
            }
            // ⑤切断
            Console.WriteLine("⑤切断しました");
        }
    }
}

