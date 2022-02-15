using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Entities
{
    internal class Knight : Hero
    {
        public Knight(string Name, int Level, string HeroType, int HealthPoint, int ManaPoint) : base(Name, Level, HeroType, HealthPoint, ManaPoint)
        {
        }
    }
}
