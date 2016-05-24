using System;
using System.Collections.Generic;

namespace TextGame
{
    public abstract class Menu
    {

        private ConsoleColor choiceColor = ConsoleColor.DarkCyan;
        private List<Choice> choices = new List<Choice>();
        private Choice defaultChoice;

        public Menu()
        {

        }

        public Menu(Choice defaultChoice) : this()
        {
            setDefaultChoice(defaultChoice);
        }

        /*  Note: For trouble with duplicate choices caused by default
                it will print both the choice and the default choice if they are both different objects
                So you have to create a variable to store the choice instead of typing "new CHOICE_NAME()" 
                when adding Choice and DefaultChoice
        */
        public void printChoices()
        {
            foreach(Choice choice in this.choices)
            {
                if(choice != defaultChoice)
                {
                    print(choice);
                }
            }

            printDefaultChoice();
        }

        private void printDefaultChoice()
        {
            Console.ResetColor();
            Console.Write("Press ");

            Console.ForegroundColor = choiceColor;
            Console.Write("Enter");

            Console.ResetColor();
            Console.Write(" OR ");
            Console.ResetColor();

            print(this.defaultChoice);
        }

        private void print(Choice choice)
        {
            Console.ResetColor();
            Console.Write("Type \"");

            Console.ForegroundColor = choiceColor;
            Console.Write(choice.getActivationString());

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

                if (input.Equals(choice.getActivationString().ToLower()))
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
                if (input.Equals("") || input.Equals(defaultChoice.getActivationString()))
                {
                    defaultChoice.activate();
                }

            }
        }

        public void setDefaultChoice(Choice defaultChoice)
        {
            this.defaultChoice = defaultChoice;
        }

        public Choice getDefaultChoice()
        {
            return this.defaultChoice;
        }

        public ConsoleColor getChoiceColor()
        {
            return this.choiceColor;
        }

        public void addChoice(Choice choice)
        {
            choices.Add(choice);
        }
    }
}