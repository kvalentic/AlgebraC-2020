using System;

namespace Prvi
{
    class Program
    {
        static void Main(string[] args)
        {
<<<<<<< HEAD
            Console.WriteLine("Hello World! Promjena na prvom... 123");
=======
            Console.WriteLine("Hello World!");
            Console.WriteLine("Evo dopunio sam!");
            Automobil a1 = new Automobil();
            Console.WriteLine(a1);
            a1.boja = "Mar\"oon";
            Console.WriteLine(a1);
            
            a1.PostaviSnagu(100);
            Console.WriteLine(a1);
            

        }
    }
}
namespace SecondNamespace
{
    class Program
    {
        public void Tester(string[] args)
        {
            Console.WriteLine("Hello World!");
>>>>>>> c59571a1f83baeb9b5ce77c63a39361f8e747b42
        }
    }
}
