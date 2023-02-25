namespace Practice7_2;

class Animal
{
    // 足の数
    protected int _Legs;

    public void PrintLegs()
    {
        Console.WriteLine(_Legs);
    }
}

class Dog : Animal
{
    public int Legs
    {
        get
        {
            return _Legs;
        }
    }

    public Dog()
    {
        // コンストラクタでLegsを初期化
        this._Legs = 4;
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
