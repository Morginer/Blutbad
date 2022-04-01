using System;
using System.Collections.Generic;
using System.Text;

namespace Engine
{
    public static class World
    {
        public static Player player { get; } 
        public static Locations locations { get; }
        static World()
        {
            /* Initialize locations */
            locations = new Locations();
            locations.Initialize();
            /* Initialize plaeyr */
            player = new Player(1, 10, 10, 0, 0, 1);
            player.CurrentLocation = locations.GetLocation(Locations.LocationsTypes.HOME);
        }
        public static void DevelopMonsters()
        {
            Monsters werewolf = new Monsters(MONSTERS_ID_WEREWOLF, "Werewolf", 10, 10, 2, 5, 10);
            Monsters youngVampire = new Monsters(MONSTERS_ID_YOUNG_VAMPIRE, "Young Vampire", 15, 15, 4, 8, 15);

            monsters.Add(werewolf);
            monsters.Add(youngVampire);
        }
    }
}
