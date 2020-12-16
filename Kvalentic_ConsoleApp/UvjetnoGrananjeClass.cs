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


    }
}
