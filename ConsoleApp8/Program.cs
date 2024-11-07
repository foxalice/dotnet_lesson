using System;
class Program
{
    static void Main(string[] args)
    {
        Farm farm = new Farm();
        Chicken chicken1 = new Chicken("Ряба");
        Chicken chicken2 = new Chicken("Белуха");
        Duck duck1 = new Duck("Ники");
        Duck duck2 = new Duck("Тимми");
        farm.AddAnimal(chicken1);
        farm.AddAnimal(chicken2);
        farm.AddAnimal(duck1);
        farm.AddAnimal(duck2);
        farm.FeedAnimals();
        chicken1.Walk();
        duck1.Swim();
        duck1.Walk();
        farm.ShowAnimals();
    }
}
