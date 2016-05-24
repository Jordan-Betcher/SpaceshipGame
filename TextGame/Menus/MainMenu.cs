using TextGame.Choices;

namespace TextGame.Menus
{
    internal class MainMenu : Menu
    {
        public MainMenu()
        {
            Choice quitChoice = new QuitChoice();

            base.addChoice(quitChoice);
            base.addChoice(new MenuChoice("Main Menu", "Do you really want to do this?", this));
            base.addChoice(new URLChoice("Google", "Opens Google", "https://www.google.com/"));

            base.setDefaultChoice(quitChoice);
        }
    }
}