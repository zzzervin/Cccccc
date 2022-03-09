using CCCCC2;
using System;
using System.Collections.Generic;
using System.Text;

namespace Class_c_sharp
{
    class Program
    {
        static void Main(string[] args) 
        {
            /*
            Inimene[] inimesed = new Inimene[1];
            for (int i = 0; i < 1; i++)
            {
                inimesed[i] = new Inimene();
                Console.WriteLine("Nimi:");
                inimesed[i].Eesnimi = Console.ReadLine();
                Console.WriteLine("Vanus:");
                inimesed[i].Vanus = int.Parse(Console.ReadLine());
            }
            foreach (Inimene inimene in inimesed)
            {
                inimene.Tervetame();
            }
            */
            Inimene mees = new Inimene();
            
            mees.Eesnimi = "Mati";
            mees.Perekonanimi = "Munamagi";
            
            Console.WriteLine($"Ma olen {mees.Eesnimi} {mees.Perekonanimi} ma emakeel .Kui vana ma olen");
            mees.Vanus = 18;
            mees.Tervetame();

            /*
            Inimene naine = new Inimene("Marina",18,Emakeel.eesti);
            naine.Tervetame();
                 
            
            naine.Palk = 1000;
            double minutulu = naine.Tulumaks();
            Console.WriteLine("Muni Tulumaks on " + minutulu);
            */

            Opilane Men = new Opilane("Eduart", "Verenavskiy", 18, "TARpv21");
            
            Men.Hinne = 3;
            Men.Info();

            Console.ReadLine();
        }
    }
}
