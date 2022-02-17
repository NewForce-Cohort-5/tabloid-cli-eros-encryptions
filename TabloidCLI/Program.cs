using TabloidCLI.UserInterfaceManagers;
using System;

namespace TabloidCLI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------------------");
            Console.WriteLine("Choose a background color, press 0 to leave as is");
            //background colors

            
            //loop here

            //string choice = Console.ReadLine();
            //switch (choice)
            //{
            //    case "0":
            //        break;
            //    case "1":
            //        Console.BackgroundColor = ConsoleColor.Blue;
            //        Console.Clear();
            //    case "2":
            //        Console.BackgroundColor = ConsoleColor.Green;
            //        Console.Clear();
            //    case "3":
            //        Console.BackgroundColor = ConsoleColor.Red;
            //        Console.Clear();
            //    case "4":
            //        Console.BackgroundColor = ConsoleColor.Yellow;
            //        Console.Clear();
            //    case "5":
            //        Console.BackgroundColor = ConsoleColor.White;
            //        Console.Clear();
            //}

            // MainMenuManager implements the IUserInterfaceManager interface
            IUserInterfaceManager ui = new MainMenuManager();
            while (ui != null)
            {
                // Each call to Execute will return the next IUserInterfaceManager we should execute
                // When it returns null, we should exit the program;
                ui = ui.Execute();
            }
        }
    }
}
