namespace Chap12_FileBasic;

class FileBasicLine
{
    static void Main()
    {
        try
        {
            // ファイルのオープン
            using StreamReader sr =
                new("sample.txt", System.Text.Encoding.Default);

            string? line = default;
            while ((line = sr.ReadLine()) != null) // 1行ずつ読み込み
            {
                // 読み込んだ1行の出力
                Console.WriteLine(line);
            }
            
        }
        catch (Exception e)
        {
            // 例外の内容の出力
            Console.WriteLine(e.Message);
        }
    }
}

