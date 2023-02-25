namespace Practice7_1;

class Animal
{
    // 足の数
    protected int Legs;

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
        this.Legs = 4;
    }
}


class Practice
{
    static void Main()
    {
        var c = new Dog();
        c.PrintLegs();

    }
}

