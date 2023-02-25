using System;
namespace Chap8_ClsCast
{
    class ClsCastDown
    {
        static void Main()
        {
            var m = new Song();

            var s = m as Song;
            //var m2 = m as Music2; // ダウンキャストできないので、nullを返す

            Console.WriteLine(s == null);   // 出力値：False
            //Console.WriteLine(m2 == null);  // 出力値：True
        }
    }
}
