public class Chicken : Animal
{
    public enum ChickenState
    {
        Голодная, //Голодная
        Наетая,   //Наетая
        Болеет    //Болеет
    }
    public ChickenState State { get; set; }

    public Chicken(string name) : base(name)
    {
        State = ChickenState.Голодная;
    }
    public override void Feed()
    {
        Console.WriteLine($"{Name} ест");
        State = ChickenState.Наетая;
    }
    public void Walk()
    {
        Console.WriteLine($"{Name} гуляет");
    }
    public override string ToString()
    {
        return $"Курица: {Name}, состояние: {State}";
    }
}