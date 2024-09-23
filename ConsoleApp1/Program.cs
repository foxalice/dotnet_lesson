using System;
using System.Diagnostics.CodeAnalysis;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Миникалькулятор в деле. Выберите режим: ");
            Console.WriteLine("1: сложение");
            Console.WriteLine("2: вычитание");
            Console.WriteLine("3: умножение");
            Console.WriteLine("4: деление");
            int type = Convert.ToInt32(Console.ReadLine());
            decimal Result = 0;

            switch (type) 
                {
                case 1:
                    {
                        Console.Write("Введите 1 слагаемое: ");
                        decimal answer = Convert.ToDecimal(Console.ReadLine());
                        Result += answer;
                        Console.Write("Введите 2 слагаемое: ");
                        answer = Convert.ToDecimal(Console.ReadLine());
                        Result += answer;
                        break;
                    }

                case 2:
                    {
                        Console.Write("Введите уменьшаемое: ");
                        decimal answer = Convert.ToDecimal(Console.ReadLine());
                        Result = answer;
                        Console.Write("Введите вычитаемое: ");
                        answer = Convert.ToDecimal(Console.ReadLine());
                        Result -= answer;
                        break;
                    }
                case 3:
                    {
                        Console.Write("Введите 1 множитель: ");
                        decimal answer = Convert.ToDecimal(Console.ReadLine());
                        Result = answer;
                        Console.Write("Введите 2 множитель: ");
                        answer = Convert.ToDecimal(Console.ReadLine());
                        Result *= answer;
                        break;

                    }
                case 4:
                    {
                        Console.Write("Введите делимое: ");
                        decimal answer = Convert.ToDecimal(Console.ReadLine());
                        Result = answer;
                        Console.Write("Введите делитель: ");
                        answer = Convert.ToDecimal(Console.ReadLine());
                        Result /= answer;
                        break;

                    }
                default: {
                        Console.WriteLine("Я такое не умею, запустите еще раз пожалуйста");
                        break;
                    }
            }

            Console.WriteLine($"Результат: {Result}");
            Console.ReadLine();

        }

    }
}
