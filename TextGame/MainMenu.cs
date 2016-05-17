namespace TextGame
{
    internal class MainMenu : Menu
    {
        public MainMenu()
        {
            base.addChoice(new QuitChoice());
            base.addChoice(new NewMenuChoice<MainMenu>("MainMenu", "Do you really want to do this?"));
            base.addChoice(new NewLinkChoice("Google", "Opens Google", "https://www.google.com/"));
        }
    }
}