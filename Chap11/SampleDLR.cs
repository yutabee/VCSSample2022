using IronPython.Hosting;
namespace Chap11_SampleDLR;

class SampleDLR
{
    static void Main()
    {
        var py = Python.CreateRuntime();
        dynamic sample = py.UseFile("sample.py");

        // Pythonのクラスのインスタンス生成
        var p = sample.PythonSample();

        Console.WriteLine(p.getMessage("C#"));
        // 出力値：Hello Python + C#
    }
}
