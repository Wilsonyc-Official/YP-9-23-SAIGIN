using System;

namespace Zadanie_YP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Tom";

            switch (name)
            {
                case "Bob":
                    Console.WriteLine("Ваше имя - Bob");
                    break;
                case "Tom":
                    Console.WriteLine("Ваше имя - Tom");
                    break;
                case "Sam":
                    Console.WriteLine("Ваше имя - Sam");
                    break;
                default:
                    Console.WriteLine("Имя не найдено");
                    break;
            }

            Console.ReadKey();
        }
    }
}
