using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book
{
    class Program
    {
        static void Main(string[] args)
        {
            // Настройка консольного пользовательского интерфейса.
            Console.Title = "My Rocking App";
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine(" *************************************");
            Console.WriteLine(" ***** Welcome to My Rocking App *****");
            Console.WriteLine(" *************************************");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Beep(650, 700);
            GetUserData();
            // Ожидание нажатия клавиши <Enter>.
            Console.ReadKey();
        }
        private static void GetUserData()
        {
            Console.Write("Your name: ");
            var user_name = Console.ReadLine();
            Console.Write("Your age: ");
            var user_age = int.Parse(Console.ReadLine());
            Console.WriteLine("Hi, {0}! You are {1} years old!", user_name, user_age);

        }
    }
}
