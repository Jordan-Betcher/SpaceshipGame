using System;

namespace TextGame
{
    public class QuitChoice : Choice
    {
        public void activate()
        {
            Program.isPlayerPlaying = false;
        }

        public string activationString()
        {
            return "Q";
        }

        public string getActivationDescription()
        {
            return "quit the game";
        }
    }
}