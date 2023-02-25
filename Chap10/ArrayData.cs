namespace Chap10_ArrayData;

class ArrayData
{
    static void Main()
    {
        int[] array2 = { 1, 3, 5 };
        string[] weekDays = { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };

        Console.WriteLine(weekDays[array2[1]]); // 出力値: Wed
    }
}

