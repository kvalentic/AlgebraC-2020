using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolaci_App
{
    public class Kolac
    {
        public string _nazivKolaca;
        public Dictionary<string, int> sastojci;
        public int TrajanjePecenja { get; set; }
        public bool pecen = false;

        public Kolac(string nazivKolaca)
        {
            _nazivKolaca = nazivKolaca;
        }

        public void DodajSastojak(string nazivSastojka, int kolicinaSastojka)
        {
            if (sastojci == null) sastojci = new Dictionary<string, int>();
            if (!pecen) { 
                sastojci.Add(nazivSastojka, kolicinaSastojka);
            }
            else
            {
                Console.WriteLine("Kolač {0} je pečen, ne možete dodati sastojak {1}", _nazivKolaca, nazivSastojka);
            }
        }
    }
}
