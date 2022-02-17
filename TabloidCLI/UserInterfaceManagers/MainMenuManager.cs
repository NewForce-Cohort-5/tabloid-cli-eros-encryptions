using System;
using System.Collections.Generic;

namespace TabloidCLI.UserInterfaceManagers
{
    public class MainMenuManager : IUserInterfaceManager
    {
        private const string CONNECTION_STRING = 
            @"Data Source=localhost\SQLEXPRESS;Database=TabloidCLI;Integrated Security=True";

        public IUserInterfaceManager Execute()
        {
            Moose();
            
            //System.Threading.Thread.Sleep(5000);
            
            ChooseColor();

            Console.WriteLine("Main Menu");

            Console.WriteLine(" 1) Journal Management");
            Console.WriteLine(" 2) Blog Management");
            Console.WriteLine(" 3) Author Management");
            Console.WriteLine(" 4) Post Management");
            Console.WriteLine(" 5) Tag Management");
            Console.WriteLine(" 6) Search by Tag");
            Console.WriteLine(" 7) Note Management");
            Console.WriteLine(" 0) Exit");

            Console.Write("> ");
            string choice = Console.ReadLine();
            switch (choice)
            {

                case "1": return new JournalManager(this, CONNECTION_STRING);
                case "2": return new BlogManager(this, CONNECTION_STRING);
                case "3": return new AuthorManager(this, CONNECTION_STRING);
                case "4": return new PostManager(this, CONNECTION_STRING);
                case "5": return new TagManager(this, CONNECTION_STRING);
                case "6": return new SearchManager(this, CONNECTION_STRING);
                case "7": return new NoteManager(this, CONNECTION_STRING);
                case "0":
                    Console.WriteLine("Good bye");
                    return null;
                default:
                    Console.WriteLine("Invalid Selection");
                    return this;
            }
        }


        private void ChooseColor()
        {
            // Get the list of available colors
            // that can be changed
            ConsoleColor[] consoleColors
                = (ConsoleColor[])ConsoleColor
                      .GetValues(typeof(ConsoleColor));
            
            // Display the list
            // of available console colors
            int i = 1;
            Console.WriteLine("Select which color background you would like:");
            List<KeyValuePair<System.ConsoleColor, int>> colors = new List<KeyValuePair<System.ConsoleColor, int>>();
            foreach (System.ConsoleColor color in consoleColors)
            {
                
                string colorString = color.ToString();
                Console.WriteLine($"{i} {color}");
                colors.Add(new KeyValuePair<System.ConsoleColor, int>(color, i));
                i++;
            }
            //int colorChoice = int.Parse(Console.ReadLine()) - 1;
            //Console.WriteLine(colors[colorChoice].Key);
            //System.ConsoleColor cc = colors[colorChoice].Key;
            //Console.WriteLine(cc.GetType());

            Console.WriteLine("17 Random");

            int colorChoice2 = int.Parse(Console.ReadLine());

            Random random = new Random();
            int rnumber = new Random().Next(1, 16);

            int rChoice = colorChoice2;
            if (colorChoice2 == 17)
            {
                colorChoice2 = rnumber;
            }

            switch (colorChoice2)
            {
                case 1:
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.Clear();
                    break;
                case 2:
                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                    Console.Clear();
                    break;
                case 3:
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.Clear();
                    break;
                case 4:
                    Console.BackgroundColor = ConsoleColor.DarkCyan;
                    Console.Clear();
                    break;
                case 5:
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    Console.Clear();
                    break;
                case 6:
                    Console.BackgroundColor = ConsoleColor.DarkMagenta;
                    Console.Clear();
                    break;
                case 7:
                    Console.BackgroundColor = ConsoleColor.DarkYellow;
                    Console.Clear();
                    break;
                case 8:
                    Console.BackgroundColor = ConsoleColor.Gray;
                    Console.Clear();
                    break;
                case 9:
                    Console.BackgroundColor = ConsoleColor.DarkGray;
                    Console.Clear();
                    break;
                case 10:
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.Clear();
                    break;
                case 11:
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.Clear();
                    break;
                case 12:
                    Console.BackgroundColor = ConsoleColor.Cyan;
                    Console.Clear();
                    break;
                case 13:
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.Clear();
                    break;
                case 14:
                    Console.BackgroundColor = ConsoleColor.Magenta;
                    Console.Clear();
                    break;
                case 15:
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.Clear();
                    break;
                case 16:
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.Clear();
                    break;
                default:
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.Clear();
                    break;
            }

            // MainMenuManager implements the IUserInterfaceManager interface
        }

        private void Moose()
        {
            Console.WriteLine($@"
                                            _.--^^^--,
                                            .'          `\
        .-^^^^^^-.                      .'              |
        /          '.                   /            .-._/
        |             `.                |             |
        \              \          .-._ |          _   \
        `^^'-.         \_.-.     \   `          ( \__/
                |             )     '=.       .,   \
            /             (         \     /  \  /
            /`               `\        |   /    `'
            '..-`\        _.-. `\ _.__/   .=.
                |  _    / \  '.-`    `-.'  /
                \_/ |  |   './ _     _  \.'
                    '-'    | /       \ |
                            |  .-. .-.  |
                            \ / o| |o \ /
                            |   / \   |     Welcome to Tabloid!
                            / `^`   `^` \
                            /             \
                            | '._.'         \
                            |  /             |
                            \ |             |
                            ||    _    _   /
                            /|\  (_\  /_) /
                            \ \'._  ` '_.'
                            `^^` `^^^`

                        
                    ");
        }
    }
}
