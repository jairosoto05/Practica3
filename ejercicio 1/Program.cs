using System;

namespace ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el numero inicial");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el numero final");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\r");


            int c = b-1;

            while (a < c)
            {
                ++a;
                Console.Write(" {0} ", a);
            }
            Console.ReadKey();
        }
    }
}