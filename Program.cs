using Exo.Poo.Class;
/*
namespace Program
{
    class Program
    {
        public static void Main(string[] args)
        {
            Random rndH = new Random();
            int H = rndH.Next(150, 1000);
            int H2 = rndH.Next(150, 1000);
            int D = rndH.Next(5, 65);
            int D2 = rndH.Next(5, 65);
            int C = rndH.Next(1, 100);
            int C2 = rndH.Next(1, 100);
            int C3 = rndH.Next(1, 100);
            int C4 = rndH.Next(1, 100);
            Personnage p1 = new Personnage("polo", H, D,C,C3);
            Personnage p2 = new Personnage("lele",H2,D2,C2,C4);
         
            int cpt = 0;
            Console.WriteLine("=== DEBUT ===");
            while (p1.IsAlive() && p2.IsAlive())
            {
               
                cpt++;
                Console.WriteLine($"Tour numéro {cpt}");
           
                    p1.Attack(p2);
                

                if (!p2.IsAlive())
                {
                    break;
                }

                    p2.Attack(p1);

                Random rnd = new Random();
                ConsoleColor[] colors = (ConsoleColor[])ConsoleColor.GetValues(typeof(ConsoleColor));
                  
                Console.ForegroundColor = colors[rnd.Next(colors.Length)];
                    

                    Thread.Sleep(250);
                    Console.Write('R');
                    Thread.Sleep(250);
                    Console.Write('O');
                    Thread.Sleep(250);
                    Console.Write('U');
                    Thread.Sleep(250);
                    Console.Write('N');
                     Thread.Sleep(250);
                    Console.Write('D');
                    Thread.Sleep(250);
                    Console.Write("  " + (cpt+1));
                    Thread.Sleep(250);
                    Console.Clear();
                Console.ForegroundColor = ConsoleColor.White;

             
            }

            Console.WriteLine("=== FIN ===");
            if (p1.IsAlive())
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine($"{p1.Name} a Annihilé {p2.Name} !");
            }
            else
            {
                Console.WriteLine($"{p2.Name} a gagné !");
            }

        }

      
    }
}*/


using Exo.Poo.Class;

namespace Program
{
    class Program
    {
        public static void Main(string[] args)
        {
        }
    }
}