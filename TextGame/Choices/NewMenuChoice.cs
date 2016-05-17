using System;

namespace TextGame
{
    public class NewMenuChoice<menu> : Choice where menu : Menu, new()
    {
        private string activationString;
        private string activationDescription;

        public NewMenuChoice(String activationString, String activationDescription)
        {
            this.activationString = activationString;
            this.activationDescription = activationDescription;
        }

        public void activate()
        {
            Program.currentMenu = new menu();
        }

        public string getActivationString()
        {
            return activationString;
        }

        public string getActivationDescription()
        {
            return activationDescription;
        }
    }
}