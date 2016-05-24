using System;
using System.Diagnostics;
using TextGame.Choices;

namespace TextGame
{
    internal class URLChoice : Choice
    {
        private string activationString;
        private string activationDescription;
        private string url;

        public URLChoice(string activationString, string activationDescription, string url)
        {
            this.activationString = activationString;
            this.activationDescription = activationDescription;
            this.url = url;
        }

        public void activate()
        {
            //Opens the url (string) in the default browser for that computer
            try
            {
                Process.Start(url);
            }
            catch
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Error: ");


                Console.ResetColor();
                Console.Write("Could not open a web browser with: \"");


                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(url);
                
                Console.ResetColor();
                Console.Write("\"");

                Console.WriteLine();
                Console.ResetColor();
                Console.ReadLine();
            }
        }

        public string getActivationDescription()
        {
            return activationDescription;
        }

        public string getActivationString()
        {
            return activationString;
        }
    }
}