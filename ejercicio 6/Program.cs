using System;
using System.IO;

namespace ejercicio_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion;
            void Convertidor(){
                Console.WriteLine("1-Convertir de grados Celsius a Fahrenheit \n2-Convertir de dolares a pesos\n3-convertir de metros a pies\n4-Salir\n");
                opcion = Convert.ToInt32(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Ingrese grados Celsius que desea convertir");
                        double grados = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("{0} grados celsius son {1} grados fahrenheit\n", grados,(grados * 1.8 ) + 32);
                        break;

                    case 2:
                        Console.WriteLine("Ingrese la cantidad de dolares que desea convertir");
                        double dolares = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("{0} dolares son {1} pesos\n", dolares,Math.Round(dolares * 58.50,2));
                        break;

                    case 3:
                        Console.WriteLine("Ingrese la cantidad de metros que desea convertir");
                        double metros = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("{0} metros son {1} pies\n", metros,Math.Round(metros * 3.281,2));
                        break;
                }

                if(opcion != 4)
                {
                    Convertidor();
                }
            }
            Convertidor();
        }
    }
}
