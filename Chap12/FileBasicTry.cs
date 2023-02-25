namespace Chap12_FileBasicTry;

class FileBasicTry
{
    static void Main()
    {
        try
        {
            // ファイルのオープン
            StreamReader sr =
                new("sample.txt", System.Text.Encoding.Default);

            // ファイルの内容すべてを、1つの文字列に読み込む
            string text = sr.ReadToEnd();

            // ファイルのクローズ
            sr.Close();

            // 読み込んだファイルの内容の出力
            Console.Write(text);
        }
        catch (Exception e)
        {
            // 例外の内容の出力
            Console.WriteLine(e.Message);
        }
    }
}

