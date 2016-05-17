namespace TextGame
{
    internal class MainMenu : Menu
    {
        public MainMenu()
        {
            base.addChoice(new QuitChoice());
        }
    }
}