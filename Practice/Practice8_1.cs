namespace Practice8_1;

class Animal
{
    public virtual void Cry()
    {
        Console.WriteLine("none");
    }
}
class Dog : Animal
{
    public override void Cry()
    {
        Console.WriteLine("bow-wow");
    }
}
