namespace Practice7_4;

class Animal
{
    // 足の数
    public int Legs { get; set; }

    public void PrintLegs()
    {
        Console.WriteLine(Legs);
    }
}

class Dog : Animal
{

    public Dog()
    {
        // コンストラクタでLegsを初期化
        Legs = 4;
    }
}


class Practice
{
    static void Main()
    {
        var a = new Animal { Legs = 8 };

        Console.WriteLine(a.Legs); // 出力値:8

    }
}

