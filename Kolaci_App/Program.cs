using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolaci_App
{
    class Program
    {
        static void Main(string[] args)
        {
            //Prvi kolac
            Kolac k1 = new Kolac("Cokoladna ekstaza 1");
            k1.DodajSastojak("Margarin", 200);
            k1.DodajSastojak("Secer", 100);
            k1.DodajSastojak("Cokolada", 300);
            k1.DodajSastojak("Jaje", 50);
            k1.TrajanjePecenja = 3;

            Rerna.Ispeci(ref k1);

            //Drugi kolac
            Kolac k2 = new Kolac("Cokoladna ekstaza 2");
            k2.DodajSastojak("Margarin", 300);
            k2.DodajSastojak("Secer", 200);
            k2.DodajSastojak("Cokolada", 400);
            k2.DodajSastojak("Jaje", 100);
            k2.TrajanjePecenja = 5;

            Rerna.Ispeci(ref k2);

            Rerna.IspisiPodatkeOKolacima();

            Console.ReadKey();

        }
    }
}
