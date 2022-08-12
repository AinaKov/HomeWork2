using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Введите число");
        long number = Convert.ToInt64(Console.ReadLine());
        if (number > 99)
        {
            Console.WriteLine("Третья цифра в числе - " + number.ToString()[2]);
        }
        else
        {
            Console.WriteLine("Третьей цифры нет");
        }
    }
}