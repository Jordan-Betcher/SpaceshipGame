using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextGame
{
    class Program
    {

        public static Boolean isPlayerPlaying = true;
        public static Menu currentMenu;
        private static PlayerShip playerShip = new PlayerShip();

        static void Main(string[] args)
        {
            currentMenu = new MainMenu();
            gameLoop();
        }

        private static void gameLoop()
        {
            while(isPlayerPlaying)
            {
                Console.Clear();

                currentMenu.printChoices();

                currentMenu.runActions(getInput());
            }
        }

        

        private static string getInput()
        {
            Console.ForegroundColor = currentMenu.getChoiceColor();

            return Console.ReadLine();
        }
    }
}
