using System;

namespace _01_domaci_zadatak
{
    class Program
    {
        static void Main(string[] args)
        {
            //4.1.2 - Ispis brojeva
            //Napišite program koji na konzoli ispisuje
            //brojeve 1,2,3 svaki u novi red.
            Console.WriteLine(1);
            Console.WriteLine(2);
            Console.WriteLine(3);

            //4.1.3 - Ledište/Vrelište
            //Napišite program koji će ispisivati temperaturu ledišta i vrelišta
            //vode, svaku u novi red
            Console.WriteLine("Temperatura ledišta je 0 stupnjeva celzijusa.");
            Console.WriteLine("Temperatura vrelišta je 100 stupnjeva celzijusa.");

            //5.1.1 - Zbroj i razlika
            //Program koji traži unos 2 cijela broja i prikazuje
            //na ekranu njihov zbroj te razliku
            int prviBroj;
            Console.WriteLine("Unesi prvi broj: ");
            prviBroj = int.Parse(Console.ReadLine());

            int drugiBroj;
            Console.WriteLine("Unesi drugi broj: ");
            drugiBroj = int.Parse(Console.ReadLine());

            int rezZbbrj, rezRazlika;

            rezZbbrj = prviBroj + drugiBroj;
            rezRazlika = prviBroj - drugiBroj;

            Console.WriteLine("Zbroj unesenih brojeva je: {0} ", rezZbbrj);
             Console.WriteLine("Razlika unesenih brojeva je: {0} ", rezRazlika);

            //5.1.2 - Umnožak i kvocijent
            //Program koji traži unos 2 cijela broja i prikazuje 
            //umnožak i kvocijent
            
            Console.WriteLine("Unesi prvi broj: ");
            prviBroj = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Unesi drugi broj: ");
            drugiBroj = int.Parse(Console.ReadLine());

            int rezUmnozak;
            float rezKvocijent;

            rezUmnozak = prviBroj * drugiBroj;
            rezKvocijent = (float)prviBroj / (float)drugiBroj; 
            
            Console.WriteLine("Umnožak unesenih brojeva je: {0} ", rezUmnozak);
            Console.WriteLine("Kvocijent unesenih brojeva je: {0} ", rezKvocijent);

        }
    }
}
