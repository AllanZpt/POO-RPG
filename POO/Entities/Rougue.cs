using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Entities
{
    public class Rougue : Hero
    {
        public Rougue(string Name, int Level, string HeroType, int HealthPoint, int ManaPoint) : base(Name, Level, HeroType, HealthPoint, ManaPoint)
        {
        }

        public override string Attack()
        {
            return this.Name + " Atacou com sua adaga";
        }
        public string Attack(bool Furtivo)
        {
            if (true)
            {
                return this.Name + " Deu um ataque critico!";

            }
        }
    }
}
