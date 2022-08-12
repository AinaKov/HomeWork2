using System;
class Program
{
    static void Main()
    {
                Console.WriteLine("Введите трехзначное число");
        int number1 = Convert.ToInt32(Console.ReadLine());
        if (number1 > 99 & number1 < 1000)
        {
            while (number1 > 99)
            {
                number1 = number1 - 100;
            }
            int number = number1 / 10;
            Console.WriteLine("Вторая цифра - " + number);
        }
        else
        {
            Console.WriteLine("Число не трехзначное");
        }
    }
}