namespace Chap10_NullableConditional;

// 名前と番号のクラス
public class Person
{
    public int No = 0;
    public string Name = "";
}

// Personクラスのフィールドを持つクラス
public class Team
{
    public Person? Member;
}

class NullableConditional1
{
    static void Main()
    {
        var t = new Team();

        string? n = t.Member.Name;
        // NullReferenceExceptionがスローされる

        Console.WriteLine(n);
    }
}

