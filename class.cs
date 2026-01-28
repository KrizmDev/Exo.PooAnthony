using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
/*

namespace Exo.Poo.Class
{


    internal class Personnage
    {

        public string Name { get; private set; }
        public int Health { get; private set; }
        public int Damage { get; private set; }
        public int Critical { get; private set; }
        public int Evade { get; private set; }



        public Personnage(string name, int health, int damage,int critical , int evade)
        {
            Name = name;
            Health = health;
            Damage = damage;
            Critical = critical;
            Evade = evade;
        }


        public bool IsAlive()
        {
            return Health > 0;
        }

        public void Attack(Personnage perso)
        {
            Random rnd2 = new Random();
            int evadeC = rnd2.Next(1, 100);

            Random rnd = new Random();
            int critC = rnd.Next(1, 100);
            if (evadeC <= perso.Evade && evadeC > 0)
            {
                critC = -10;
            }
            if (!IsAlive())
            {
                return;
            }
            Console.WriteLine($"{Name} attaque {perso.Name}");
            if (critC < 2 && critC > 0)
            {
                Damage = Damage * int.MaxValue;
                perso.Health -= Damage;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Le coup a infligé {Damage}dégats");
                Console.ForegroundColor = ConsoleColor.White;
            }
            if (critC < Critical && critC >0)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Vous avez crit!!");
                Console.ForegroundColor = ConsoleColor.White;
             
                perso.Health -= Damage*2;
                Console.WriteLine($"Le coup a infligé {Damage*2}dégats");

            }
            else if (critC > 0)
            {
                perso.Health -= Damage;
                Console.WriteLine($"Le coup a infligé {Damage}dégats");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"{perso.Name} à esquivé ");
                Console.ForegroundColor = ConsoleColor.White;
            }



            if (perso.Health < 0)
            {
                perso.Health = 0;
            }

            Console.WriteLine($"{perso.Name} a maintenant {perso.Health} HP");
            Console.WriteLine();
        }

     
            
    }
}
*/
namespace Exo.Poo.Class
{


    internal class Chien
    {
        private string nom;
        private string race;
        private int age;
        private static string nomDuChenil;
        private static int nbChiens;

        public string Nom {  get =>  nom; set => nom = value; }
        public int Age { get => age; set => age = value; }
           
        public string Race { get => race; set => race = value; }
        public static string NomDuChenil { get => nomDuChenil; set => nomDuChenil = value; }
        public static int NbChiens { get => nbChiens; set => nbChiens = value; }

        public  Chien(string Nom, int Age, string race, int NbChiens , string NomDuChenil)
        {
            nom = Nom;
            age = Age;
            Race = race;
            nomDuChenil = NomDuChenil;
            nbChiens = NbChiens;

        }


        public void Constructeur(string Nom , int Age , string race , int NbChiens)
        {

        }
        public void Accesseurs() { }
    }
}