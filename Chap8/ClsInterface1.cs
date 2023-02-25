namespace Chap8_ClsInterface;

// インターフェイス
interface IGetInfo
{
    void GetInfo();
}

// 派生クラス
class SampleClass : IGetInfo
{
    public void GetInfo()
    {
        Console.WriteLine("SampleClass");
    }
}

class ClsInterface1
{
    static void Main()
    {
        var s = new SampleClass();
        s.GetInfo();                        // 出力値："SampleClass"
    }
}
