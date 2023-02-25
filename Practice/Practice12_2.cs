namespace Practice12_2;

class Practice
{
    static readonly HttpClient Client = new HttpClient();
    static void Main()
    {
        // 指定のファイル名のファイルに文字列を上書きで書き込む
        static void WriteContents(string name, string contents)
        {
            using var sw = new StreamWriter(name, false, System.Text.Encoding.Default);
            sw.Write(contents);
        }

        // 非同期メソッド
        static async Task GetWebAsync(string url)
        {
            // Webページの内容を文字列で取得する
            string c = await Client.GetStringAsync(url);
            WriteContents("yahoo.txt", c);
        }
        try
        {
            Task t = GetWebAsync("http://www.yahoo.co.jp/");
            t.Wait();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}

