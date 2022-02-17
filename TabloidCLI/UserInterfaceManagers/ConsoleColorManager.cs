using System;


namespace TabloidCLI.UserInterfaceManagers
{
    public class ConsoleColorManager : IUserInterfaceManager
    {
        private readonly IUserInterfaceManager _parentUI;
        public ConsoleColorManager(IUserInterfaceManager parentUI, string connectionString)
        {
            _parentUI = parentUI;
            
        }
        public IUserInterfaceManager Execute()
        {
            // Get the list of available colors
            // that can be changed
            ConsoleColor[] consoleColors
                = (ConsoleColor[])ConsoleColor
                      .GetValues(typeof(ConsoleColor));

            // Display the list
            // of available console colors
            Console.WriteLine("Select which color background you would like: "
                              + "Console Colors:");
            foreach (var color in consoleColors)
                Console.WriteLine(color);
            return this;    
        }
    }
}
