using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите порядковый номер простого числа: ");
        int n = 0;
        try
        {
            n = int.Parse(Console.ReadLine());
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }


        int count = 0;
        int num = 2;

        while (count < n)
        {
            if (IsSimple(num))
            {
                count++;
            }
            num++;
        }

        Console.WriteLine($"Простое число под номером {n} : {num - 1}");
    }

    static bool IsSimple(int number)
    {
        if (number <= 1)
        {
            return false;
        }

        for (int i = 2; i * i <= number; i++)
        {
            if (number % i == 0)
            {
                return false;
            }
        }

        return true;
    }
}