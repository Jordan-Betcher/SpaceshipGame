namespace TextGame
{
    interface Choice
    {
        string getActivationString();
        string getActivationDescription();
        void activate();
    }
}