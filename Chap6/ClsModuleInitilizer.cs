namespace Chap6_ClsModuleInitilizer;

using System.Runtime.CompilerServices;

class ClsModuleInitilizer
{
    [ModuleInitializer]
    public static void InitMethod()
    {
        // Console.WriteLine("最初の1回だけ実行");
        // 明示的に呼び出さなくても表示される
    }
}