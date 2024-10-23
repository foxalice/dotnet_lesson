using System;

    class Program
    {
        static void Main(string[] args)
        {
            int grainsEaten = 0;
            bool hasEgg = false;
            bool isAlive = true;

            while (isAlive)
            {
                Console.WriteLine("Выберите действие:");
                Console.WriteLine("1 - Покормить курицу");
                Console.WriteLine("2 - Забрать яйцо");
                Console.WriteLine("3 - Ничего не делать");
                Console.WriteLine("Введите номер действия (1, 2 или 3):");

                string input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        FeedChicken(ref grainsEaten, ref hasEgg);
                        break;
                    case "2":
                        TakeEgg(ref hasEgg);
                        break;
                    case "3":
                        Console.WriteLine("Вы ничего не сделали.");
                        grainsEaten = EatGrains(grainsEaten); // Курица доедает остаток зерен
                        break;
                    default:
                        Console.WriteLine("Некорректный ввод. Пожалуйста, введите 1, 2 или 3.");
                        break;
                }

                // Проверка на жизнь курицы
                isAlive = IsAlive(grainsEaten);
                if (!isAlive)
                {
                    Console.WriteLine("Курица умерла.");
                }
            }
        }

        static void FeedChicken(ref int grainsEaten, ref bool hasEgg)
        {
            Console.WriteLine("Введите количество зерен для кормления курицы (минимум 3):");
            if (int.TryParse(Console.ReadLine(), out int grains) && grains >= 3)
            {
                grainsEaten += grains;
                hasEgg = true; // Если курицу покормили, она может высиживать яйцо
                Console.WriteLine($"Вы покормили курицу {grains} зернами.");
            }
            else
            {
                Console.WriteLine("Некорректный ввод. Пожалуйста, введите положительное число.");
            }
        }

        static void TakeEgg(ref bool hasEgg)
        {
            if (hasEgg)
            {
                hasEgg = false; 
                Console.WriteLine("Вы забрали яйцо.");
            }
            else
            {
                Console.WriteLine("Яиц нет для забирания.");
            }
        }

        static int EatGrains(int grainsEaten)
        {
            if (grainsEaten < 4)
            {
                Console.WriteLine($"Курица не покормлена. Осталось {grainsEaten} зерен.");
                return 0; // Курица умирает
            }
            else
            {
                Console.WriteLine($"Курица съела 4 зерна.");
                grainsEaten -= 4;
                return grainsEaten;
            }
        }

        static bool IsAlive(int grainsEaten)
        {
            // Проверка на жизнь курицы
            return grainsEaten >= 4; // Курица жива, если зерен 4 или больше
        }

        }

