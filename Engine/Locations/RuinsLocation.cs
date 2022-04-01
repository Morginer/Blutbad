using System;
using System.Collections.Generic;
using System.Text;

namespace Engine
{
    class RuinsLocation: Location
    {
        public RuinsLocation(): base("Ruins", "This residence ruins lost it's shine a long time ago.")
        {
            this.Monster = new YoungVampire();
        }
    }
}
