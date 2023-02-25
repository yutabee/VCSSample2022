namespace Chap3_InitEnum1;

class InitEnum
{
    enum Day
    {
        Sun, Mon, Tue = 10,
        Wed, Thu, Fri = Sun, // 他のメンバーも代入できる
        Sat
    }
    static void Main()
    {
        Console.WriteLine((int)Day.Wed); // 出力値：11（Tueの値+1）
        Console.WriteLine((int)Day.Fri); // 出力値：0（代入されたSunの値）
        Console.WriteLine((int)Day.Sat); // 出力値：1（Friの値+1）
    }
}

