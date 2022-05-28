using System;

namespace homework007
{
    class Program
    {
        static void Main(string[] args)
        {
            string text;
            int howManyTimes;
            Console.Write("Введите текст: ");
            text = Convert.ToString(Console.ReadLine());
            Console.Write("Количество повторов Текста: ");
            howManyTimes = Convert.ToInt32(Console.ReadLine());
            while (howManyTimes > 0)
            { Console.WriteLine(text); howManyTimes--;}
        }
    }
}
