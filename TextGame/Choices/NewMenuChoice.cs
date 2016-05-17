using System;

namespace TextGame
{
    public class NewMenu<menu> : Choice where menu : Menu, new()
    {
        private string activationString;
        private string activationDescription;

        public NewMenu(String activationString, String activationDescription)
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