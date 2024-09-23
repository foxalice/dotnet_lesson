using System;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String FirstName;
            String LastName;
            String SurName;
            Console.WriteLine("Представьтесь, пожалуйста");

            Console.Write("Фамилия: ");
            LastName = Console.ReadLine();

            Console.Write("Имя: ");
            FirstName = Console.ReadLine();

            Console.Write("Отчество: ");
            SurName = Console.ReadLine();

            Console.WriteLine($"Введены данные: {LastName} {FirstName} {SurName}") ;
            Console.ReadLine();
        }
    }
}
