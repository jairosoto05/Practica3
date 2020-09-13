using System;

namespace ejercicio_5
{
    class Program
    {
        static void Main(string[] args)
        {
            string meses(int mes)
            {
                switch (mes)
                {
                    case 1:
                        return "Enero";
                        break;
                    case 2:
                        return "Febrero";
                        break;
                    case 3:
                        return "Febrero";
                        break;
                    case 4:
                        return "Marzo";
                        break;
                    case 5:
                        return "Abril";
                        break;
                    case 6:
                        return "Mayo";
                        break;
                    case 7:
                        return "Junio";
                        break;
                    case 8:
                        return "Julio";
                        break;
                    case 9:
                        return "Agosto";
                        break;
                    case 10:
                        return "Septiembre";
                        break;
                    case 11:
                        return "Noviembre";
                        break;
                    case 12:
                        return "Diciembre";
                        break;
                    default:
                        return "numero de mes invalido";
                }
            }

            Console.WriteLine("ingrese el numero del mes");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(meses(a));

            Console.ReadKey();

        }
    }
}
