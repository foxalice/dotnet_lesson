public class Duck : Animal
{
    public Duck(string name) : base(name) { }
    public override void Feed()
    {
        Console.WriteLine($"{Name} ест");
    }
    public void Swim()
    {
        Console.WriteLine($"{Name} плавает");
    }
    public void Walk()
    {
        Console.WriteLine($"{Name} гуляет");
    }
    public override string ToString()
    {
        return $"Утка: {Name}";
    }
}
