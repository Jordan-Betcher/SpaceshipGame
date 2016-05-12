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
        public static List<Choice> choices = new List<Choice>();
        public static Choice defaultChoice = new QuitChoice();
        private static ConsoleColor choiceColor = ConsoleColor.Cyan;
        private static PlayerShip playerShip = new PlayerShip();

        static void Main(string[] args)
        {
            addDefaultChoices();
            gameLoop();
        }

        private static void addDefaultChoices()
        {

        }

        private static void gameLoop()
        {
            while(isPlayerPlaying)
            {
                showPossibleActions();

                String userInput = getInput();

                RunActions(userInput);
            }
        }

        private static void showPossibleActions()
        {
            for(int i = 0; i < choices.Count(); i++)
            {
                print(choices[i]);
            }

            print(defaultChoice);
        }

        private static void print(Choice choice)
        {
            Console.ResetColor();
            Console.Write("Type \"");

            Console.ForegroundColor = choiceColor;
            Console.Write(choice.activationString());

            Console.ResetColor();
            Console.Write("\" to ");

            Console.ForegroundColor = choiceColor;
            Console.Write(choice.getActivationDescription());

            Console.ResetColor();

            Console.WriteLine();
        }

        private static string getInput()
        {
            Console.ForegroundColor = choiceColor;

            return Console.ReadLine();
        }

        private static void RunActions(string userInput)
        {
            for (int i = 0; i < choices.Count(); i++)
            {
                Choice choice = choices[i];

                if(userInput.Equals(choice.activationString()))
                {
                    choice.activate();
                }
            }

            if(userInput.Equals("") || userInput.Equals(defaultChoice.activationString()))
            {
                defaultChoice.activate();
            }
        }
    }
}
