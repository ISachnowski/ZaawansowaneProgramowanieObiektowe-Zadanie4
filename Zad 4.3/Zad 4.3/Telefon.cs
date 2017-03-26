using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zad_4._3
{
    class Telefon
    {
        public void zalozObudowe(string firma)
        {
            Console.WriteLine("Zakładam obudowę. Producent: " + firma);
        }

        public void wlozEkran(string firma)
        {
            Console.WriteLine("Wkładam ekran. Producent: " + firma);
        }
    }
}
