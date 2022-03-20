using System;
using System.Collections.Generic;
using System.Text;

namespace Engine
{
    public class Monsters
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int CurrentHealthPoints { get; set; }
        public int MaximumHealthPoints { get; set; } 
        public int MinimumDamage { get; set; }
        public int MaximumDamage { get; set; }
        public int ExpValue { get; set; }

        public Monsters(int ID,string Name,int CurrentHealthPoints,int MaximumHealthPoints,int MinimumDamage,int MaximumDamage, int ExpValue)
        {
            this.ID = ID;
            this.Name = Name;
            this.CurrentHealthPoints = CurrentHealthPoints;
            this.MaximumHealthPoints = MaximumHealthPoints;
            this.MinimumDamage = MinimumDamage;
            this.MaximumDamage = MaximumDamage;
            this.ExpValue = ExpValue;
        }
    }
}
