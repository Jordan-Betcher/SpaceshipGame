using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextGame.Menus;

namespace TextGame.Choices
{
    class BackChoice : MenuChoice
    {
        public BackChoice(String activationDescription) : base("Back", activationDescription, Program.getLastMenu()) { }
    }
}
