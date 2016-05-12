using System;
using System.Collections.Generic;

namespace TextGame
{
    internal class Thruster : ShipStation
    {

        private int energyConsumption = 1;
        private int speed = 1;
        private int health = 10;

        public Thruster(int speed)
        {
            this.speed = speed;
        }

        public void fix(int repairLevel)
        {

        }

        public List<Choice> getChoices()
        {
            throw new NotImplementedException();
        }

        public int getDamageCanTakeBeforeDestroyed()
        {
            throw new NotImplementedException();
        }

        public int getDamageCanTakeBeforeDisabled()
        {
            throw new NotImplementedException();
        }

        public bool hasChoices()
        {
            throw new NotImplementedException();
        }
    }
}