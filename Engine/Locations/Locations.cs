using System;
using System.Collections.Generic;
using System.Text;

namespace Engine
{
    public class Locations
    {
        public enum LocationsTypes
        {
            HOME,
            VILLAGE,
            FOREST,
            RUINS
        }

        private Location Home { get; }
        private Location Village { get; }
        private Location Forest { get; }
        private Location Ruins { get; }

        public Locations()
        {
            Home = new HomeLocation();
            Village = new VillageLocation();
            Forest = new ForestLocation();
            Ruins = new RuinsLocation();
        }

        public void Initialize()
        {
            /* Initialize Home */
            Home.LocationToNorth = Village;

            /* Initialize Village */
            Village.LocationToWest = Forest;
            Village.LocationToEast = Ruins;
            Village.LocationToSouth = Home;
            
            /* Initialize Forest */
            Forest.LocationToEast = Home;

            /* Initialize Ruins */
            Ruins.LocationToWest = Village;
        }
    
        public Location GetLocation(LocationsTypes type)
        {
            switch (type)
            {
                case LocationsTypes.HOME:
                    return Home;
                case LocationsTypes.VILLAGE:
                    return Village;
                case LocationsTypes.FOREST:
                    return Forest;
                case LocationsTypes.RUINS:
                    return Ruins;
                 default:
                    return null;
            }
        }
    }
}
