namespace Chap12_FileBinary;

class FileBinary
{
    static void Main()
    {
        try
        {
            // バイナリファイルをバイト型配列に読み込む
            var bytes = File.ReadAllBytes("sample.png");

            // データの先頭10バイトを16進表示する
            Console.WriteLine(BitConverter.ToString(bytes, 0, 10)); // 出力値：89-50-4E-47-0D-0A-1A-0A-00-00

            byte[] bytes2 = { 0x1, 0x2, 0x3 };

            // バイト型配列の内容を書き込む
            File.WriteAllBytes("test.dat", bytes2);

            Console.WriteLine(BitConverter.ToString(File.ReadAllBytes("test.dat"))); // 出力値：01-02-03
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}

