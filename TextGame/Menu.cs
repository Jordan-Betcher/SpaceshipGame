using System;
using System.Collections.Generic;

namespace TextGame
{
    public abstract class Menu
    {

        private ConsoleColor choiceColor = ConsoleColor.DarkCyan;
        private List<Choice> choices = new List<Choice>();
        private Choice defaultChoice;


        public void printChoices()
        {
            foreach(Choice choice in this.choices)
            {
                print(choice);
            }
        }

        private void print(Choice choice)
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

        public void runActions(string input)
        {
            input = input.ToLower();

            for (int i = 0; i < choices.Count; i++)
            {
                Choice choice = choices[i];

                if (input.Equals(choice.activationString().ToLower()))
                {
                    choice.activate();
                }
            }

            checkDefault(input);
        }

        private void checkDefault(string input)
        {
            if(defaultChoice != null)
            {
                if (input.Equals("") || input.Equals(defaultChoice.activationString()))
                {
                    defaultChoice.activate();
                }

            }
        }

        internal ConsoleColor getChoiceColor()
        {
            return this.choiceColor;
        }

        internal void addChoice(Choice choice)
        {
            choices.Add(choice);
        }
    }
}