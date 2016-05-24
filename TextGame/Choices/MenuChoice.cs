using System;
using TextGame.Choices;

namespace TextGame.Menus
{
    public class MenuChoice : Choice
    {
        private string activationString;
        private string activationDescription;
        private Menu newMenu;

        public MenuChoice(String activationString, String activationDescription, Menu newMenu)
        {
            this.activationString = activationString;
            this.activationDescription = activationDescription;
            this.newMenu = newMenu;
        }

        public void activate()
        {
            Program.currentMenu = newMenu;
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