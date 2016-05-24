using System;
using TextGame.Choices;

namespace TextGame
{
    public class QuitChoice : Choice
    {
        public void activate()
        {
            Program.endGame();
        }

        public string getActivationString()
        {
            return "Q";
        }

        public string getActivationDescription()
        {
            return "quit the game";
        }
    }
}