using System;

namespace Quest12
{
    class Program
    {
        static void Main(string[] args)
        {
            string dayOne = Console.ReadLine();
            const string MondayOne = "Понедельник";
            const string MondayTwo = "понедельник";
            const string TuesdayOne = "Вторник";
            const string TuesdayTwo = "вторник";
            const string WednesdayOne = "Среда";
            const string WednesdayTwo = "среда";
            const string ThursdayOne = "Четверг";
            const string ThursdayTwo = "четверг";
            const string FridayOne = "Пятница";
            const string FridayTwo = "пятница";
            const string SatterdayOne = "Суббота";
            const string SatterdayTwo = "суббота";
            const string SundayOne = "Воскресенье";
            const string SundayTwo = "воскресенье";
            switch (dayOne)
            {
                case MondayOne:
                    Console.WriteLine("Будний день");
                    break;
                case MondayTwo:
                    Console.WriteLine("Будний день");
                    break;
                case TuesdayOne:
                    Console.WriteLine("Будний день");
                    break;
                case TuesdayTwo:
                    Console.WriteLine("Будний день");
                    break;
                case WednesdayOne:
                    Console.WriteLine("Будний день");
                    break;
                case WednesdayTwo:
                    Console.WriteLine("Будний день");
                    break;
                case ThursdayOne:
                    Console.WriteLine("Будний день");
                    break;
                case ThursdayTwo:
                    Console.WriteLine("Будний день");
                    break;
                case FridayOne:
                    Console.WriteLine("Ура! Пятничка!");
                    break;
                case FridayTwo:
                    Console.WriteLine("Ура! Пятничка!");
                    break;
                case SatterdayOne:
                    Console.WriteLine("Сегодня выходной!");
                    break;
                case SatterdayTwo:
                    Console.WriteLine("Сегодня выходной!");
                    break;
                case SundayOne:
                    Console.WriteLine("Сегодня выходной!");
                    break;
                case SundayTwo:
                    Console.WriteLine("Сегодня выходной!");
                    break;
                default:
                    Console.WriteLine("Похоже, вы неправильно ввели день недели");
                    break;
            }
        }
    }
}
