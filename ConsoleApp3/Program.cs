using System;
using System.Diagnostics.CodeAnalysis;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Считаем среднее арифметическое. Введите количество элементов от 3х до 7: ");

            int n = 0;
            int i = 0;
            decimal result = 0;

            try
            {
                n = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            if (n != 0 && n >= 3 && n <= 7)
            {
                decimal[] nums = new decimal[n];
                Console.WriteLine("Введите числа: ");
                i = 0;
                while (n > i)
                {
                    try
                    {
                        nums[i] = Convert.ToDecimal(Console.ReadLine());
                        result += nums[i];
                        i += 1;
                    }

                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
                Console.WriteLine($"Результат : {result}/{n}={result / n}");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Ошибка параметра ввода количества");
            }
        }
    }
}
