using POO.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace POO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Knight arus = new Knight("Arus", 23, "Knight", 500, 30);
            Wizard wizard = new Wizard("Jennica", 23, "White Wizard", 100, 200);
            Rougue thief = new Rougue("Alf", 20, "Rougue", 150, 50);
            Console.WriteLine("Para a aventura, esses serão nossos herois...");
            Console.WriteLine(" ");
            Console.WriteLine(arus);
            Console.WriteLine(wizard);
            Console.WriteLine(thief);
            Console.WriteLine(" ");
            Console.WriteLine("E aqui damos inicio ao combate");
            Console.WriteLine("");
            Console.WriteLine(arus.Attack());
            Console.WriteLine(wizard.Attack(1));
            Console.WriteLine(wizard.Attack(7));
            Console.WriteLine(thief.Attack(true));
            Console.WriteLine(thief.Attack());
        } 
    }
}
