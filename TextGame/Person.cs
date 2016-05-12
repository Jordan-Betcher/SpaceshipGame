using System.Collections.Generic;

namespace TextGame
{
    interface Person
    {
        int getFoodConsumption();
        int getWaterConsumption();
        int getAirConsumption();
        int getHealth();
        List<Skills> getSkills();
        int getHappyness();
    }
}