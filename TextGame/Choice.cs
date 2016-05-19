namespace TextGame
{
    public interface Choice
    {
        string getActivationString();
        string getActivationDescription();
        void activate();
    }
}