namespace Practice10_4;

class Practice
{
    class Competition
    {
        public string? City { get; set; }
        readonly int Year;
        readonly int Month;
        readonly int Day;

        public Competition(int y, int m, int d)
        {
            Year = y; Month = m; Day = d;
        }
        public (string?, int, int, int) GetOpening()
        {
            return (City, Year, Month, Day);
        }
    }
    static void Main()
    {
        var os = new Competition(2020, 7, 24) { City = "東京" };
        Console.WriteLine(os.GetOpening()); // 出力値：(東京, 2020, 7, 24)
    }
}

