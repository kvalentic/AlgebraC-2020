using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kvalentic_ConsoleApp
{
    public class VarijableClass
    {
        //public VarijableClass()
        //{

        //}

        public void _5_1_1_Zbroj_i_razlika()
        {
            //Napišite program koji traži unos 2 cijela broja i prikazuje na ekranu njihov zbroj te razliku. 

            Console.WriteLine("Unesi prvi broj:");
            int firstNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Unesi drugi broj:");
            int secondNumber = int.Parse(Console.ReadLine());

            int sum = firstNumber + secondNumber;
            int difference = firstNumber - secondNumber;

            Console.WriteLine("Zbroj je:  {0} + {1} = {2}", firstNumber, secondNumber, sum);
            Console.WriteLine("Razlika brojeva je: {0} - {1} = {2}\n", firstNumber, secondNumber, difference);

            Console.WriteLine();
            Console.WriteLine("Unesi bilo koji znak za izlaz iz programa...");
            Console.ReadKey();
        }

        public void _5_1_2_Umnožak_i_kvocijent()
        {
            //Napišite program koji traži unos 2 cijela broja i prikazuje na ekranu njihov umnožak i kvocijent.

            Console.WriteLine("Unesi prvi broj:");
            int firstNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Unesi drugi broj:");
            int secondNumber = int.Parse(Console.ReadLine());

            int multiplication = firstNumber * secondNumber;
            decimal quotient = firstNumber / (decimal)secondNumber;

            Console.WriteLine("Umnožak brojeva je: {0} * {1} = {2}", firstNumber, secondNumber, multiplication);
            Console.WriteLine("Kvocijent brojeva je: {0} / {1} = {2}", firstNumber, secondNumber, quotient.ToString("F2"));

            Console.WriteLine();
            Console.WriteLine("Unesi bilo koji znak za izlaz iz programa...");
            Console.ReadKey();

        }
    }
}
