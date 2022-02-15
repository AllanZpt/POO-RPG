using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Entities
{
    public class Wizard : Hero
    {
        public Wizard(string Name, int Level, string HeroType, int HealthPoint, int ManaPoint) : base(Name, Level, HeroType, HealthPoint, ManaPoint)
        {
        }

        public override string Attack()
        {
            return this.Name + " Lançou magia";
        }
        public string Attack(int Bonus)
        {
            if (Bonus > 6)
            {
                return this.Name + " Lançou magia super efetiva com bonus de ataque de " + Bonus;
            }
            else { 
            return this.Name + " Lançou magia fraca com bonus de ataque de " + Bonus;
            }
        }
    }
}
