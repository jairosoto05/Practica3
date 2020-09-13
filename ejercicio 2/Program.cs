using System;

namespace ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int cant = 0;

            void Suma()
            {

                Console.WriteLine("ingrese un numero diferente a cero");
                int a = Convert.ToInt32(Console.ReadLine());

                if (a != 0)
                {
                    sum += a;
                    cant++;
                    Suma();

                }
                else { 

                Console.WriteLine("la suma de los {0} numero digitados es {1}", cant, sum);

                }
               
            }


            Suma();

            Console.ReadKey();
            
        }
    }
}
