public class Chicken : Animal
{
    public Chicken(string name) : base(name) { }
    public override void Feed()
    {
        Console.WriteLine($"{Name} ест");
    }
    public void Walk()
    {
        Console.WriteLine($"{Name} гуляет");
    }
    public override string ToString()
    {
        return $"Курица: {Name}";
    }
}
