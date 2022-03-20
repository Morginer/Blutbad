using System;
using System.Collections.Generic;
using System.Text;

namespace Engine
{
    public static class World

    {
        public static Player player { get; } 
        public static List<Locations> locations = new List<Locations>();

        public const int LOCATIONS_ID_HOME = 1;
        public const int LOCATIONS_ID_VILLAGE = 2;
        public const int LOCATIONS_ID_FOREST = 3;
        public const int LOCATIONS_ID_RUINS = 4;


        static World()
        {
            player = new Player(1, 10, 10, 0, 0, 1);
            DevelopLocations();        
        }
        public static void DevelopLocations()
        {
            Locations home = new Locations(LOCATIONS_ID_HOME, "Home", "Your old wooden house.");
            Locations village = new Locations(LOCATIONS_ID_VILLAGE, "Village", "This village looks like nobody lives here.");
            Locations forest = new Locations(LOCATIONS_ID_FOREST, "Forest", "Pine forest. You don't see any animals here.");
            Locations ruins = new Locations(LOCATIONS_ID_RUINS, "Ruins", "This residence ruins lost it's shine a long time ago.");

            home.LocationToNorth = village;

            village.LocationToWest = forest;
            village.LocationToEast = ruins;
            village.LocationToSouth = home;

            forest.LocationToEast = village;

            ruins.LocationToWest = village;


            locations.Add(home);
            locations.Add(village);
            locations.Add(forest);
            locations.Add(ruins);

            player.CurrentLocation = home;
        }

        
    }
}
