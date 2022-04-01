using System;
using System.Collections.Generic;
using System.Text;

namespace Engine
{
    public class Location
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Location LocationToNorth { get; set; }
        public Location LocationToWest { get; set; }
        public Location LocationToEast { get; set; }
        public Location LocationToSouth { get; set; }
        public Monsters Monster { get; set; }
        
        public Location(string Name, string Description)
        {
            this.ID = Guid.NewGuid();
            this.Name = Name;
            this.Description = Description;
        }
    }
}
