namespace TextGame
{
    internal class MainMenu : Menu
    {
        public MainMenu()
        {
            base.addChoice(new QuitChoice());
            base.addChoice(new NewMenu<MainMenu>("MainMenu", "Do you really want to do this?"));
        }
    }
}