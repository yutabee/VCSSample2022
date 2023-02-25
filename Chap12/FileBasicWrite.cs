namespace Chap12_FileBasic;

class FileBasicWrite
{
    static void Main()
    {
        // ファイル書き込み（常に上書き）
        void Write(string name)
        {
            using StreamWriter sw = new(name, false, System.Text.Encoding.Default);

            // 1行書き込み
            sw.WriteLine("サンプル1");
            sw.WriteLine("サンプル2");
            sw.WriteLine("サンプル3");
        }

        // ファイル読み込み
        void Read(string name)
        {
            using StreamReader sr = new(name, System.Text.Encoding.Default);

            string? line = default;
            while ((line = sr.ReadLine()) != null) // 1行ずつ読み込み
            {
                Console.WriteLine(line);
            }
        }

        try
        {
            string name = "sample.txt";

            // ファイル書き込み
            Write(name);

            // ファイル読み込み
            Read(name);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}

