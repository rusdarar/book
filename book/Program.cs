﻿using System;
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
            // Ожидание нажатия клавиши <Enter>.
            Console.ReadKey();

        }
    }
}
