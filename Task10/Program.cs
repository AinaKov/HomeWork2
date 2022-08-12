using System;
class Program
{
    static void Dozens()
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
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Необходимо узнать разряд десятков в трехзначном числе? Для выхода из программы - напишите end");
            string answer = Console.ReadLine();
            if (answer == "end")
            {
                break;
            }
            Dozens();
        }
    }
}