namespace TextGame
{
    internal class MainMenu : Menu
    {
        public MainMenu()
        {
            Choice quitChoice = new QuitChoice();

            base.addChoice(quitChoice);
            base.addChoice(new NewMenuChoice<MainMenu>("Main Menu", "Do you really want to do this?"));
            base.addChoice(new NewLinkChoice("Google", "Opens Google", "https://www.google.com/"));

            base.setDefaultChoice(quitChoice);
        }
    }
}