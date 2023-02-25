using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap8_ClsCaseWhen
{
    class ClsCaseWhen1
    {
        static void Main()
        {
            object obj = "visual";

            switch (obj)
            {
                // objがint型のとき
                case int n:
                    Console.WriteLine(n);
                    break;

                // objが文字列かつ長さが３より大きいとき
                case string str when str.Length > 3:
                    Console.WriteLine(str); // 出力値：visual
                    break;
            }
        }
    }
}
