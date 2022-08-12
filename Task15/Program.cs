using System;
class Program
{
    static void WriteSelect(string[] namesArray)
    {
        for (int i = 0; i < namesArray.Length - 1; i++)
        {
            Console.Write(i + 1 + " - " + namesArray[i] + ", ");
        }
        Console.WriteLine(namesArray.Length + " - " + namesArray[namesArray.Length - 1] + ".");
    }
    static void SelectDay()
    {
        string[] namesDay = { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье" };
        WriteSelect(namesDay);
        Console.WriteLine("Укажите день недели");
        int indexDay = Convert.ToInt32(Console.ReadLine());
        if (indexDay > 5)
        {
            Console.WriteLine(namesDay[indexDay - 1] + " - выходной");
        }
        else
        {
            Console.WriteLine(namesDay[indexDay - 1] + " - будний день");
        }
    }

    static void Main(string[] args)
    {
        SelectDay();
    }
}