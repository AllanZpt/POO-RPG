using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Entities
{
    public abstract class Hero
    {
        public Hero(string Name,int Level,string HeroType, int HealthPoint, int ManaPoint)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.HealthPoint = HealthPoint;
            this.ManaPoint = ManaPoint;

        }

        public string Name;
        public int Level;
        public string HeroType;
        public int HealthPoint;
        public int ManaPoint;

        public override string ToString()
        {
            return this.Name + " " + this.Level + " " + this.HeroType + " " + this.HealthPoint + " Pontos de vida " + this.ManaPoint + " Pontos de mana";

        }
        public virtual string Attack()
        {
            return this.Name + " Atacou com sua espada";
        }
    }
}
