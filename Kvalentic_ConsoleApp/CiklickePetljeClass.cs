using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Kvalentic_ConsoleApp
{
    class CiklickePetljeClass
    {
        public void _5_3_1_Neparni_do_20()
        {
            //Napišite program koji ispisuje sve neparne brojeve veće od 1, a manje ili jednake 20.

            for (int i = 1; i < 21; i++)
            {
                if ((i % 2 != 0) && (i > 1))
                {
                    Console.WriteLine("Broj {0} je neparan", i);
                }
            }

            Console.ReadKey();
        }

        public void _5_3_2_Djeljiv_s_5()
        {
            //Napišite program koji ispisuje sve brojeve od 1 do 100 djeljive s 5.

            for (int i = 1; i < 101; i++)
            {
                if (i % 5 == 0)
                {
                    Console.WriteLine("Broj {0} je djeljiv s 5", i);
                }
            }

            Console.ReadKey();
        }
        public void _5_3_3_Suma_100_brojeva()
        {
            //Napišite program koji ispisuje sumu prvih 100 prirodnih brojeva.

            int sum = 0;

            for (int i = 1; i < 101; i++)
            {
                //sum = sum + i;
                sum += i;
            }

            Console.WriteLine("suma prvih 100 brojeva je {0}", sum);
            Console.ReadKey();
        }

        public void _5_3_4_Faktorijel()
        {
            //Napišite program koji za uneseni broj X računa X!(faktorijel).

            //Console.WriteLine("Unesite neki broj:");
            //int inputFaktorijel = int.Parse(Console.ReadLine());

            //int faktorijelSum = 1;

            //for (int i = 1; i <= inputFaktorijel; i++)
            //{
            //    faktorijelSum = faktorijelSum * i;
            //}

            //Console.WriteLine("Faktorijel broja {0} je broj {1}", inputFaktorijel, faktorijelSum);
            //Console.ReadKey();

            //Rješenje zadatka sa while petljom

            Console.WriteLine("Unesite neki broj:");
            int faktorijelSum = 1;
            int inputNumber = int.Parse(Console.ReadLine());
            int counter = 1;

            while (counter <= inputNumber)
            {
                faktorijelSum = faktorijelSum * counter;
                counter++;
            }

            Console.WriteLine("Faktorijel broja {0} je broj {1}", inputNumber, faktorijelSum);
            Console.ReadKey();
        }

        public void _5_3_5_Djeljivi_s_3()
        {
            //Napišite program koji ispisuje sve prirodne brojeve iz intervala[1, 100] koji su djeljivi s
            //brojem 3.

            int counter = 0;

            for (int i = 0; i < 100; i++)
            {
                if ((i + 1) % 3 == 0) Console.WriteLine("{0}. broj {1} je dijeljiv sa tri", ++counter, i + 1);
            }

            Console.ReadKey();

        }
        public void _5_3_6_Prijestupne_godine()
        {
            //Napišite program koji ispisuje sve prijestupne godine od 1900. do 2007. (Godina je
            //prijestupna ako je djeljiva sa 4, nije djeljiva sa 100, osim ako je djeljiva sa 400).

            for (int i = 1900; i <= 2007; i++)
            {
                if ((i % 4 == 0) && (i % 100 != 0 || i % 400 == 0))
                {
                    Console.WriteLine("Godina {0} je prijestupna.", i);
                }
            }

            Console.ReadKey();
        }
        public void _5_3_7_Ispis()
        {
            //Napišite program koji ispisuje sve brojeve iz intervala[1, 100] koji su djeljivi sa 7, ali nisu
            //djeljivi s 3.

            for (int i = 1; i < 100; i++)
            {
                if ((i % 7 == 0) && (i % 3 != 0)) Console.WriteLine("Broj {0} je djeljiv sa 7 i nije djeljiv sa 3", i);
            }

            Console.ReadKey();
        }
        public void _5_3_8_Koliko()
        {
            //Napišite program koji ispisuje koliko ima brojeva djeljivih sa 7 i nedjeljivih s 3 u intervalu[1,
            //1000].

            int counter = 1;

            for (int i = 1; i <= 1000; i++)
            {
                if ((i % 7 == 0) && (i % 3 != 0)) counter++;
                //Console.WriteLine("{0}. Broj u intervalu [1, 1000] je {1} koji je djeljiv sa 7 i nije dijeljiv sa 3 ", counter++, i);
            }

            Console.WriteLine("U intervalu [1, 1000] je {0} brojeva djeljivih sa 7 i ne dijeljivih sa 3 ", counter++);
            Console.ReadKey();
        }

        public void _5_3_9_Djelitelji()
        {
            //Napišite program koji za uneseni prirodni broj ispisuje sve njegove djelitelje.

            Console.WriteLine("Unesite neki prirodni broj:");
            int inputNumber = int.Parse(Console.ReadLine());
            //int divider = 1;

            //while (divider <= inputNumber)
            //{  
            //    if (inputNumber % divider == 0)
            //        Console.WriteLine("Djelitelji broja {0} je {1}.", inputNumber, divider);

            //    divider++;
            //}

            //Example with for loop
            for (int divider = 1; divider <= inputNumber; divider++)
            {
                if (inputNumber % divider == 0)
                    Console.WriteLine("Djelitelji broja {0} je {1}.", inputNumber, divider);
            }

            Console.ReadKey();
        }
        public void _5_3_10_Savršen_broj()
        {
            //Napišite program koji ispisuje je li uneseni broj savršen ili ne. Savršen broj je broj koji je
            //jednak zbroju svojih djelitelja(bez njega samoga).

            Console.WriteLine("Unesite neki prirodni broj:");
            int inputNumber = int.Parse(Console.ReadLine());
            int perfectSum = 0;

            for (int i = 1; i < inputNumber; i++)
            {
                if (inputNumber % i == 0) perfectSum = perfectSum + i;
            }

            if (perfectSum == inputNumber)
            {
                Console.WriteLine("Broj {0} je savršen.", inputNumber);
            }
            else
            {
                Console.WriteLine("Broj {0} nije savršen.", inputNumber);
            }

            Console.ReadKey();
        }

        public void _5_3_11_Savršen_broj2()
        {
            //Napišite program koji ispisuje sve savršene brojeve iz intervala[1, 1000]
            int counter = 1;
            int cellNumber = 1000000;
            int perfectSum;           

            //for (int perfectNumber = 1; perfectNumber <= cellNumber; perfectNumber++)
            //{

            Parallel.For(1, cellNumber, perfectNumber =>
            {
                perfectSum = 0;
                //Console.WriteLine("Novi paralel for....");
                

                for (int j = 1; j < perfectNumber; j++)
                {
                    if (perfectNumber % j == 0) perfectSum = perfectSum + j;
                }

                if (perfectSum == perfectNumber)
                {
                    Console.WriteLine("{0}. Broj {1} je savršen.", counter++, perfectNumber);
                }
            });

            //}

            Console.ReadKey();
        }
    }

}

