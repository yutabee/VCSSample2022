namespace Practice7_3;

class Animal
{
    // 足の数
    public int Legs { get; protected set; }

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
        var c = new Dog();
        Console.WriteLine(c.Legs);

    }
}

