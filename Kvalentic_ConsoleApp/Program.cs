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
            //UvjetnoGrananje();
            CiklickePetlje();
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
            ug._5_2_1_Pozitivan_ili_negativan_broj();
            ug._5_2_2_Kalkulator();
            ug._5_2_3_Velik_broj();
            ug._5_2_4_X_znamenkasti_broj();
            ug._5_2_5_U_intervalu();
            ug._5_2_6_Dobar_broj_1();
            ug._5_2_7_Dobar_broj_2();
            ug._5_2_8_Prijestupna_godina();
            ug._5_2_9_Cjelobrojno_dijeljenje();
        }
        public static void CiklickePetlje()
        {
            CiklickePetljeClass cp = new CiklickePetljeClass();
            //cp._5_3_1_Neparni_do_20();
            //cp._5_3_2_Djeljiv_s_5();
            //cp._5_3_3_Suma_100_brojeva();
            //cp._5_3_4_Faktorijel();
            //cp._5_3_5_Djeljivi_s_3();
            //cp._5_3_6_Prijestupne_godine();
            //cp._5_3_7_Ispis();
            //cp._5_3_8_Koliko();
            //cp._5_3_9_Djelitelji();
            //cp._5_3_10_Savršen_broj();
            cp._5_3_11_Savršen_broj2();



        }
    }
}
