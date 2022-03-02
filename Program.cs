using System;
using System.Collections.Generic;
using System.Text;

namespace Class_c_sharp
{
    class Program
    {
        static void Main(string[] args) 
        {
            
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
            
            Inimene mees = new Inimene();
            Inimene2 Mees = new Inimene2();
            mees.Eesnimi = "Mati";
            Mees.Perekonanimi = "Munamagi";
            
            Console.WriteLine($"Ma olen {mees.Eesnimi} {Mees.Perekonanimi} ma emakeel .Kui vana ma olen");
            mees.Vanus = int.Parse(Console.ReadLine());
            mees.Tervetame();


            Inimene naine = new Inimene("Marina",18,Emakeel.eesti);
            
            //naine.Tervetame();
            naine.Palk = 1000;
            double minutulu = naine.Tulumaks();
            Console.WriteLine("Muni Tulumaks on " + minutulu);



            Console.ReadLine();
        }
    }
}
