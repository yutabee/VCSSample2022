using System;
namespace Chap8_ClsCast;

class ClsCastIs
{
    static void Main()
    {
        var m = new Song();
        var s = (Song)m;

        Console.WriteLine(m is Song);   // 出力値：True
        Console.WriteLine(m is Music2); // 出力値：False
    }
}
