using System;
using System.Collections.Generic;
using System.Text;

namespace Engine
{
    class ForestLocation: Location
    {
        public ForestLocation(): base("Forest", "Pine forest. You don't see any animals here.") 
        {
            this.Monster = new Werewolf();
        }
    }
}
