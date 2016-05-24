using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextGame.Menus;

namespace TextGame
{
    class Program
    {
        private static Boolean isPlayerPlaying = true;
        private static Menu currentMenu = new MainMenu();
        private static Player player = new Player();
        private static Queue<Menu> menuHistory;
        ///*
        private static Queue<Menu> createMenuHistory()
        {
            Queue<Menu> menuHistory = new Queue<Menu>();
            menuHistory.Enqueue(currentMenu);
            return menuHistory;
        }
        //*/

        static void Main(string[] args)
        {
            menuHistory = createMenuHistory();
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

        public static void endGame()
        {
            isPlayerPlaying = false;
        }

        public static Menu getCurrentMenu()
        {
            return currentMenu;
        }

        public static void setCurrentMenu(Menu newMenu)
        {
            menuHistory.Enqueue(currentMenu);

            currentMenu = newMenu;
        }
        ///*
        public static Menu getLastMenu()
        {
            return menuHistory.Last();
        }

        //*/

        public static Player getPlayer()
        {
            return player;
        }

    }
}
