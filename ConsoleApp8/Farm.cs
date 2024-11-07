using System;
using System.Collections.Generic;
public class Farm
{
    private List<Animal> animals;
    public Farm()
    {
        animals = new List<Animal>();
    }
    public void AddAnimal(Animal animal)
    {
        animals.Add(animal);
    }
    public void FeedAnimals()
    {
        foreach (var animal in animals)
        {
            animal.Feed();
        }
    }
    public void ShowAnimals()
    {
        foreach (var animal in animals)
        {
            Console.WriteLine(animal);
        }
    }
}