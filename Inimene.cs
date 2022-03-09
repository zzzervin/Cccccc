using System;
using System.Collections.Generic;
using System.Text;

namespace Class_c_sharp
{
    class Inimene
    {
        string eesnimi;//поля
        int vanus;
        string staatus;
        string perekonanimi;
        Emakeel emakeel;
        public Inimene() { }//конструктор

        public Inimene(string Eesnimi, int Vanus, Emakeel emakeel)
        {
            eesnimi = Eesnimi;
            this.emakeel = emakeel;
            vanus = Vanus;
        }

        public Inimene(int Vanus)
        {
            vanus = Vanus;
        }

        public Inimene(string eesnimi, string perekonanimi, int vanus)
        {
            this.eesnimi = eesnimi;
            this.perekonanimi = perekonanimi;
        }

        public Emakeel Emakeel
        {
            get { return emakeel; }
        }

        public string Eesnimi
        {
            set
            {
                if (eesnimi == null) eesnimi = value;
            }
            get { return eesnimi; }


        }//св-ва


        public int Vanus
        {
            set
            { vanus = value;
            }
            get { return vanus; }


        }
        public string Staatus
        {

            get
            {
                var staatus = "";
                if (vanus < 7)
                { staatus = "vaike laps"; }
                else if (vanus < 17)
                { staatus = "kooli laps"; }
                else if (vanus < 65)
                { staatus = "tööline laps"; }
                else
                { staatus = "senior"; }
                return staatus; }

        }


        public void Tervetame()
        {
            Console.WriteLine("Tere");
            Console.WriteLine("Minu nimi on {0} . Olen {1} aastat vana. Minu staatus {2} ", eesnimi, vanus, staatus);
        }//метод
        public string Perekonanimi
        {
            set
            {
                if (perekonanimi == null) perekonanimi = value;
            }
            get { return perekonanimi; }


        }

        }
    }
