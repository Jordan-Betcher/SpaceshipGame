using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextGame.Choices;

namespace TextGame.Menus
{
    class PlayerMenu : Menu
    {
        public PlayerMenu()
        {
            base.addChoice(new URLChoice("Google", "Opens Google", "https://www.google.com/"));
            //base.addChoice(new MenuChoice("Player Menu", "Shows you your player stats", new PlayerMenu()));
            //base.addChoice(new BackChoice("Go to previous menu"));
        }

    }
}
