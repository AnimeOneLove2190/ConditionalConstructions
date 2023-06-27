using System;

namespace Quest11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Привет");
            Console.WriteLine("Введите ваше имя");
            string name = Console.ReadLine();
            Console.WriteLine("Теперь введите ваш возраст");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("А теперь введите ваш пол");
            string floor = Console.ReadLine();
            if (age < 14)
            {
                string messageOne = $"Увы, {name}, наш ресурс доступен только для людей старше 14 лет";
                Console.WriteLine(messageOne);
            }
            else if (floor == "м")
            {
                string messageTwo = $"Дорогой {name}, добро пожаловать на наш ресурс!";
                Console.WriteLine(messageTwo);
            }
            else if (floor == "ж")
            {
                string messageThree = $"Дорогая {name}, добро пожаловать на наш ресурс!";
                Console.WriteLine(messageThree);
            }
            else
            {
                Console.WriteLine("Увы, похоже, вы ввели неправильный пол.");
            }
        }
    }
}
