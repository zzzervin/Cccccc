using System;
using System.Collections.Generic;
using System.Text;

namespace Class_c_sharp
{
    class Inimene2
    {
        string perekonanimi;//поля
        int palk;
        

        public Inimene2() { }//конструктор
        public string Perekonanimi
        {
            set
            {
                if (perekonanimi == null) perekonanimi = value;
            }
            get { return perekonanimi; }
        }//св-ва

        
    }
}
