using System.Collections.Generic;

namespace TextGame.SpaceShip
{
    internal class PlayerShip
    {
        //TODO add get stats to ShipStation

        private List<ShipStation> stations = new List<ShipStation>();
        private List<Person> crew = new List<Person>();

        public PlayerShip()
        {
            //Nessassary
            stations.Add(new Engine(1)); //Creates the energy
            stations.Add(new AirRecycler(1));
            stations.Add(new Hull(1)); //normal Hull Midigates damage
            stations.Add(new Sensor(1)); //higher level increases radius, you can use it at a smaller radius but have higher level

            stations.Add(new Thruster(1)); //Speed in battles, if yours is higher you can escape although you have to be outside weapons range to, requires sensors
            /* //OR
            stations.Add(new FTLDrive(1)); // Can only FTL to spots you've been, because it calculates based on your current position to where you will end up, can't FTL if something is block it, better when not moving, need computer and sensors to run
            stations.Add(new Computer(1));




            //Weapons
            stations.Add(new Lasers(1)); //destroys missles
            stations.Add(new Missles(2)); //speed needs to be faster than engine
            stations.Add(new FTLBomb(1)); //Depending on your FTLDriver increase accrasy, need FTL computer and Sensor but never misses if those are high enough lvl

            //
            stations.Add(new WaterRecycler(1));
            stations.Add(new GreenHouse(1)); //Grows food if next to a sun and have WaterRecycler
            stations.Add(new LivingMetalHull(1)); //autmoatically creates an air tight space, higher levels can move stations around to avoid damage if paired with a computer, don't need everything to be connected, needs computer
            
             //useful thing that increases other systems
            stations.Add(new LivingQuarter(1)); //increases happyness and health
            // */

        }
    }
}