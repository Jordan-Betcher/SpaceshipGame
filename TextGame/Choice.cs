namespace TextGame
{
    interface Choice
    {
        string activationString();
        string getActivationDescription();
        void activate();
    }
}