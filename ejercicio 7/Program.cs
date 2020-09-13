using System;

namespace ejercicio_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int multiplos = 1000 / 5;
            for (int i = 1; i < multiplos; i++)
            {
                int multiplo = i * 5;
                int u = 1;
                Console.WriteLine("\n======{0}=====", multiplo);
                while (u <= 10)
                {  
                    Console.WriteLine("{0} x {1} = {2}",multiplo,u,multiplo*u);
                    u++;
                }
                
            }
            Console.ReadKey();
        }
    }
}
