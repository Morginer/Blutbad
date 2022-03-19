using System;
using System.Collections.Generic;
using System.Text;

namespace Engine
{
    public class Player
    {
        public int ID { get; set; }
        public int MaximumHealthPoints { get; set; }
        public int CurrentHealthPoints { get; set; }
        public int Exp { get; set; }
        public int Gold { get; set; }
        public int Level { get; set; }
        public Locations CurrentLocation { get; set; }

        public Player(int ID, int MaximumHealthPoints, int CurrentHealthPoints, int Exp,
            int Gold, int Level)
        {
            this.ID = ID;
            this.MaximumHealthPoints = MaximumHealthPoints;
            this.CurrentHealthPoints = CurrentHealthPoints;
            this.Exp = Exp;
            this.Gold = Gold;
            this.Level = Level;

        }
    }
}
