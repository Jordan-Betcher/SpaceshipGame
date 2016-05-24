namespace TextGame.Choices
{
    public interface Choice
    {
        string getActivationString();
        string getActivationDescription();
        void activate();
    }
}