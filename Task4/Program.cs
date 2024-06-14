using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите сумму вклада: ");
        double deposit = Convert.ToDouble(Console.ReadLine());
        double interestRate;

        if (deposit < 100)
        {
            interestRate = 0.05;
        }
        else if (deposit >= 100 && deposit <= 200)
        {
            interestRate = 0.07;
        }
        else
        {
            interestRate = 0.10;
        }

        double finalAmount = deposit + (deposit * interestRate);
        Console.WriteLine($"Сумма вклада с процентами: {finalAmount}");

        Console.WriteLine("Нажмите любую клавишу для выхода...");
        Console.ReadKey();
    }
}
