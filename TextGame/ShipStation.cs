using System.Collections.Generic;

namespace TextGame
{
    interface ShipStation
    {
        int getDamageCanTakeBeforeDestroyed();
        int getDamageCanTakeBeforeDisabled();
        void fix(int repairLevel);
        bool hasChoices();
        List<Choice> getChoices();
    }
}