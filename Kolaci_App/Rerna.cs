using System;
using System.Threading;

namespace Kolaci_App
{
    internal static class Rerna
    {
        private static int brojPecenihKolaca = 0;
        internal static void Ispeci(ref Kolac kolac)
        {         
            int kolacJePecen = 0;            

            while (kolacJePecen < kolac.TrajanjePecenja)
            {
                Thread.Sleep(1000);
                kolacJePecen++;

                if (kolacJePecen == kolac.TrajanjePecenja)
                {
                    kolac.pecen = true;
                    IspisiPodatkeOKolacu(kolac);
                    brojPecenihKolaca++;
                    break;
                }                
                else
                {
                    Console.WriteLine("Kolač {0} se još uvjek peče...", kolac._nazivKolaca);
                }
            }
        }

        private static void IspisiPodatkeOKolacu(Kolac kolac)
        {

            Console.WriteLine("Kolač {0} je pečen.", kolac._nazivKolaca);
            Console.WriteLine("Sastojci kolača:", kolac._nazivKolaca);

            float ukupnaMasaKolaca = 0;

            foreach (var item in kolac.sastojci)
            {
                Console.WriteLine("Naziv sastojka: " + item.Key + " Količina: " + item.Value + "grama");
                ukupnaMasaKolaca = ukupnaMasaKolaca + item.Value;
            }

            Console.WriteLine("Ukupna masa kolača: {0:F2}", ukupnaMasaKolaca + "grama");

        }

        public static void IspisiPodatkeOKolacima()
        {
            Console.WriteLine("Broj pečenih kolača je: {0}", brojPecenihKolaca);
        }
    }
}