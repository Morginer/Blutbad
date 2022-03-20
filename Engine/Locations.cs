using System;
using System.Collections.Generic;
using System.Text;

namespace Engine
{
    public class Locations
    {
        
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Locations LocationToNorth { get; set; }
        public Locations LocationToWest { get; set; }
        public Locations LocationToEast { get; set; }
        public Locations LocationToSouth { get; set; }
        

        public Locations(int ID,string Name, string Description)
        {
            this.ID = ID;
            this.Name = Name;
            this.Description = Description;
        }
    }
}
