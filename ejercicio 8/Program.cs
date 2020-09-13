using System;

namespace ejercicio_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingresa tu salario bruto");
            double sBruto = Convert.ToDouble(Console.ReadLine());
            double[] limite = new double[3] {34685.00, 52027.42, 72260.25};
            double ARS = sBruto * 0.0304;
            double AFP = sBruto * 0.0287;
            double sNeto = sBruto - ARS - AFP;
            double ISR;
            double excedente;
            double salario;

            void impSalario(double slr)
            {
                Console.WriteLine("descuento ARS: RD${0:n}\ndescuento AFP: RD${1:n}\ndescuento ISR: RD${2:n}\nsalario neto: RD${3:n}", ARS,AFP,ISR,slr);
            }

            if (sNeto >= limite[2])
            {
                excedente = sNeto - limite[2];
                ISR = 6648 + (excedente * 0.25);
                salario = sNeto - ISR;
                impSalario(salario);
            }
            else if(sNeto > limite[1])
            {
                excedente = sNeto - limite[1];
                ISR = 2601.33 + (excedente * 0.20);
                salario = sNeto - ISR;
                impSalario(salario);
            }
            else if (sNeto > limite[0])
            {
                excedente = sNeto - limite[0];
                ISR = excedente * 0.15;
                salario = sNeto - ISR;
                impSalario(salario);
            }
            else
            {
                ISR = 0.00;
                impSalario(sNeto);
            }

            Console.ReadKey();
        }
    }
}
