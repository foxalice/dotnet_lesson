using System;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ввод чисел будет продолжаться до ввода Q: ");
            int n = 10;
            int i = 0;
            int count = 0;
            string vvod;

            int[] num = new int[n];

            do
            {
                vvod = Console.ReadLine();

                if (vvod.ToUpper() == "Q")
                {

                    Console.WriteLine("Вы хотите:");
                    Console.WriteLine("1 - Продолжить ввод");
                    Console.WriteLine("2 - Очистить введенные данные");
                    Console.WriteLine("3 - Выйти");

                    int answ;

                    while (!int.TryParse(Console.ReadLine(), out answ) || answ < 1 || answ > 3)
                    {
                        Console.WriteLine("Пожалуйста, введите число (1, 2 или 3).");
                    }

                    switch (answ)
                    {
                        case 1:
                            Console.WriteLine("Продолжаем ввод...");
                            continue;
                        case 2:
                            num = new int[n];
                            count = 0;
                            i = 0;
                            Console.WriteLine("Введенные данные очищены. Продолжаем ввод:");
                            break;
                        case 3:
                            vvod = "Q";
                            break; 
                    }
                    }
                else
                    {
                        try
                        {
                            num[i] = Convert.ToInt32(vvod);
                            i++;

                            if (i == n)
                            {
                                n = n * 2;
                                int[] buf = new int[n]; 
                                Array.Copy(num, buf, num.Length); 
                                num = buf; 
                            }
                        }
                        catch (Exception)
                        {
                            count++;
                            Console.WriteLine("Данные введены неверно!");
                        }
                    }

                } while (vvod.ToUpper() != "Q") ;

                Console.WriteLine($"Количество введенных элементов: {i}");
                Console.WriteLine($"Количество ошибок ввода: {count}");

                Console.ReadLine();
            }
    }
    }
