using System;
using System.Collections.Generic;
using System.Text;

namespace Engine
{
    public class World
    {
        public static Player player { get; } 
        public static Locations locations { get; }
        static World()
        {
            /* Initialize locations */
            locations = new Locations();
            /* Initialize plaeyr */
            player = new Player(1, 10, 10, 0, 0, 1);
            player.CurrentLocation = locations.GetLocation(Locations.LocationsTypes.HOME);
        }
    }
}
