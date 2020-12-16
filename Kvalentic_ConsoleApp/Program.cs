using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kvalentic_ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Pozivi po poglavljima u zbirki zadataka
            //Varijable();
            UvjetnoGrananje();
        }

        //Pozivi Po po
        public static void Varijable()
        {
            VarijableClass vc = new VarijableClass();
            vc._5_1_1_Zbroj_i_razlika();
            vc._5_1_2_Umnožak_i_kvocijent();
        }

        public static void UvjetnoGrananje()
        {
            UvjetnoGrananjeClass ug = new UvjetnoGrananjeClass();
            //ug._5_2_1_Pozitivan_ili_negativan_broj();
            ug._5_2_2_Kalkulator();

        }
    }
}
