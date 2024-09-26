using System;
using System.Diagnostics.CodeAnalysis;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Каталог пользователей. Введите количество от 3 до 5: ");
            int n = 0;
            int i = 0;
            try
            {
                n = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            if (n >= 3 && n <= 5)
            {
                string[][] users = new string[n][];

                for (i = 0; i < n; i++)
                {
                    users[i] = new string[2];

                    Console.WriteLine($"Введите данные {i + 1}-го пользователя: ");
                    Console.Write("Введите фамилию: ");
                    users[i][0] = Console.ReadLine();
                    Console.Write("Введите имя: ");
                    users[i][1] = Console.ReadLine();
                }

                Console.WriteLine($"Данные какого пользователя найти и показать? (Введите номер от 1 до {n}): ");
                try
                {
                    i = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

                if (i >= 1 && i <= n)
                {
                    Console.WriteLine($"{users[i-1][0]} {users[i-1][1]}");
                }
                else
                {
                    Console.WriteLine("Неверный номер пользователя");
                }
            }
            else
            {
                Console.WriteLine("Ошибка параметра ввода количества");
            }

            Console.ReadLine();
        }
    }
}
