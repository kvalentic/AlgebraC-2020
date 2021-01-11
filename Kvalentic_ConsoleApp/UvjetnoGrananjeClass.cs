using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kvalentic_ConsoleApp
{
    class UvjetnoGrananjeClass
    {
        //Konstruktor možeš definirati ali i ne moraš
        public void _5_2_1_Pozitivan_ili_negativan_broj()
        {
            //Napišite program koji traži unos broja, te ispisuje je li broj pozitivan, negativan ili nula.

            bool isTrue = true;

            while (isTrue)
            {
                Console.WriteLine("Unesite neki broj:");
                int inputNumber = int.Parse(Console.ReadLine());

                if (inputNumber > 0)
                {
                    Console.WriteLine("Broj je pozitivan!");
                }
                else if (inputNumber < 0)
                {
                    Console.WriteLine("Broj je negativan!");
                }
                //else if(inputNumber == 0)
                //{
                //    Console.WriteLine("Broj je nula...");
                //}
                else if (inputNumber == 0)
                {
                    Console.WriteLine("Broj je nula...");
                }

                Console.WriteLine("Za prekid programa unesite x,a za nastavak unesite bilo koji znak...");

                string key = Console.ReadLine();
                if (key.Equals("x")) isTrue = false;
                //if (key.Equals("x")) break;
            }
        } 
        public void _5_2_2_Kalkulator()
        {
            //Napišite program -kalkulator s osnovnim računskim operacijama. Program traži unos 2 cijela
            //broja, a zatim unos računske operacije. Nakon toga ispisuje rezultat i omogućuje korisniku
            //ponovno računanje ili prekid programa. Program treba ispisivati sve poruke za korisnika.



            while (true)
            {
                Console.WriteLine("Unesi prvi broj:");
                int firstNumber = int.Parse(Console.ReadLine());

                Console.WriteLine("Unesi drugi broj:");
                int secondNumber = int.Parse(Console.ReadLine());

                float rez = 0;

                Console.WriteLine("Unesi računski operator...");
                string operation = Console.ReadLine();

                switch (operation)
                {
                    case "+":
                        rez = firstNumber + secondNumber;
                        Console.WriteLine("{0} + {1} = {2}", firstNumber, secondNumber, rez);
                        break;
                    case "-":
                        rez = firstNumber - secondNumber;
                        Console.WriteLine("{0} - {1} = {2}", firstNumber, secondNumber, rez);
                        break;
                    case "*":
                        rez = firstNumber * secondNumber;
                        Console.WriteLine("{0} * {1} = {2}", firstNumber, secondNumber, rez);
                        break;
                    case "/":
                        rez = (float)firstNumber / secondNumber;
                        Console.WriteLine("{0} / {1} = {2}", firstNumber, secondNumber, rez);
                        break;

                    default:
                        Console.WriteLine("Niste unijeli adekvatnu računsku opraciju.");
                        break;
                }

                Console.WriteLine("Za prekid programa unesite x,a za nastavak unesite bilo koji znak...");

                string key = Console.ReadLine();
                if (key.Equals("x")) break;
            }

            Console.WriteLine("_5_2_2_Kalkulator");

        }
        public void _5_2_3_Velik_broj()
        {
            //Napišite program koji traži unos broja i zatim
            //    ∙ ako broj ima više od 3 znamenke, ispisuje poruku "Broj je velik."
            //    ∙ inače ispisuje poruku "Broj NIJE velik."

            Console.WriteLine("Unesi cijeli broj");
            int inputNumber = int.Parse(Console.ReadLine());

            if (inputNumber > 999)
            {
                Console.WriteLine("Broj je velik.");
            }
            else
            {
                Console.WriteLine("Broj NIJE velik.");
            }

            Console.ReadKey();
        }
        public void _5_2_4_X_znamenkasti_broj()
        {
            //Napišite program koji traži unos broja i zatim ispisuje je li taj broj jednoznamenkast,
            //dvoznamenkast, troznamenkast ili višeznamenkast. Program treba raditi i s negativnim
            //brojevima!

            Console.WriteLine("napiši neki broj:");
            int inputNumber = int.Parse(Console.ReadLine());

            //if (inputNumber < 0)
            //{
            //    inputNumber = inputNumber * -1;
            //}

            inputNumber = Math.Abs(inputNumber);

            switch (inputNumber)
            {
                case int n when (n <= 9):
                    Console.WriteLine("Jednoznamenkasti broj");
                    break;

                case int n when (n <= 99):
                    Console.WriteLine("Dvoznamenkasti broj");
                    break;

                case int n when (n <= 999):
                    Console.WriteLine("Troznamenkasti broj");
                    break;

                case int n when (n > 999):
                    Console.WriteLine("Višeznamenkasti broj");
                    break;

                default:
                    break;
            }

            Console.ReadKey();
        }
        public void _5_2_5_U_intervalu()
        {
            //Napišite program koji traži unos broja i ispisuje je li broj u intervalu[100, 200] ili ne.
            Console.WriteLine("Unesi cijeli broj");
            int inputNumber = int.Parse(Console.ReadLine());

            if ((inputNumber >= 100) && (inputNumber <= 200))
            {
                Console.WriteLine("Broj {0} je u intervalu [100, 200]", inputNumber);
            }
            else
            {
                Console.WriteLine("Broj {0} nije u intervalu [100, 200]", inputNumber);
            }

            Console.ReadKey();
        }
        public void _5_2_6_Dobar_broj_1()
        {
            //Napišite program koji traži unos broja i ispituje je li taj broj djeljiv s 5 ili s 3.Ako jest, ispisati
            //"Broj je dobar.", inače ispisati "Broj NIJE dobar!"

            Console.WriteLine("Unesi cijeli broj");
            int inputNumber = int.Parse(Console.ReadLine());

            if ((inputNumber % 3 == 0) || (inputNumber % 5 == 0))
            {
                Console.WriteLine("Broj {0} je dobar", inputNumber);
            }
            else
            {
                Console.WriteLine("Broj {0} nije dobar", inputNumber);
            }

            Console.ReadKey();
        }
        public void _5_2_7_Dobar_broj_2()

        {
            //Napišite program koji traži unos broja i ispituje je li taj broj djeljiv sa 4 i nije manji od 100.Ako
            //jest, ispisuje "Broj je dobar." Inače ispisuje "Broj NIJE dobar!".Programski kod treba osigurati
            //od grešaka!

            try
            {
                Console.WriteLine("Unesi cijeli broj");
                int inputNumber = int.Parse(Console.ReadLine());

                if ((inputNumber % 4 == 0) && (inputNumber >= 100))
                {
                    Console.WriteLine("Broj {0} je dobar", inputNumber);
                }
                else
                {
                    Console.WriteLine("Broj {0} nije dobar", inputNumber);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Dogodila se greška: {0}", ex.Message);
            }

            Console.ReadKey();

        }
        public void _5_2_8_Prijestupna_godina()
        {
            //Napišite program koji traži unos godine i ispisuje je li ta godina prijestupna ili ne(godina je
            //prijestupna ako je djeljiva sa 4, nije djeljiva sa 100, osim ako je djeljiva sa 400).

            try
            {
                Console.WriteLine("Unesi godinu:");
                int year = int.Parse(Console.ReadLine());

                if ((year % 4 == 0) && ((year % 100 != 0) || (year % 400 == 0)))
                {
                    Console.WriteLine("Godina {0}. je prijestupna", year);
                }
                else
                {
                    Console.WriteLine("Godina {0}. nije prijestupna", year);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Dogodila se greška: {0}", ex.Message);
            }

            Console.ReadKey();

        }
        public void _5_2_9_Cjelobrojno_dijeljenje()
        {
            //Napišite program koji traži unos broja te ispisuje je li taj broj paran ili neparan, te je li broj
            //djeljiv s 3 ili koliki je ostatak pri dijeljenju s brojem 3.

            try
            {
                Console.WriteLine("Unesi broj:");
                int number = int.Parse(Console.ReadLine());

                if (number % 2 == 0)
                {
                    Console.WriteLine("Broj {0} je paran", number);
                }
                else
                {
                    Console.WriteLine("Broj {0} je neparan", number);
                }


                if (number % 3 == 0)
                {
                    Console.WriteLine("Broj {0} je djeljiv s 3 i ostatak je nula", number);
                }
                else
                {
                    float restOfNumber = number % 3;
                    Console.WriteLine("Broj {0} nije djeljiv s 3 bez ostatka, ostatak dijeljenja je {1}", number, restOfNumber);
                }


            }
            catch (Exception ex)
            {
                Console.WriteLine("Dogodila se greška: {0}", ex.Message);
            }

            Console.ReadKey();
        }

    }
}

