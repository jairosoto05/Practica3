using System;

namespace ejercicio_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int mil = 9000;
            int quinientos = 9500;
            int cien = 9900;
            int total;

            int limiteDia = 10000;
            

            int billeteMil = 0;
            int billeteQuinientos = 0;
            int billeteCien = 0;

            void cajero()
            {
                total = mil + quinientos + cien;
                Console.WriteLine("ingrese el monto que desea retirar");
                int monto = Convert.ToInt32(Console.ReadLine());

                if (monto <= 2000 & monto <= limiteDia & monto % 100 == 0)
                {
                    while (monto >= 100 & monto < total & (cien != 0 || quinientos != 0 || mil != 0))
                    {
                        while (monto >= 500 & (quinientos != 0 || mil != 0))
                        {
                            while (monto >= 1000 & mil != 0)
                            {
                                if (mil != 0)
                                {
                                    billeteMil += 1;
                                    monto -= 1000;
                                    mil -= 1000;
                                }
                                else
                                {
                                    break;
                                }

                            }
                            if (monto >= 500 & quinientos != 0)
                            {
                                billeteQuinientos += 1;
                                monto -= 500;
                                quinientos -= 500;
                            }
                            else
                            {
                                break;
                            }

                        }
                        if (monto >= 100 & cien != 0)
                        {
                            billeteCien += 1;
                            monto -= 100;
                            cien -= 100;
                        }
                        else
                        {
                            break;
                        }


                    }
                    if (monto == 0)
                    {
                        Console.WriteLine("billetes de mil: {0}\nbilletes de quinientos: {1}\nbilletes de cien: {2}\n", billeteMil, billeteQuinientos, billeteCien);

                        int transTotal = (billeteMil * 1000) + (billeteQuinientos * 500) + (billeteCien * 100);
                        limiteDia -= transTotal;
                        billeteMil = 0;
                        billeteQuinientos = 0;
                        billeteCien = 0;
                        bank();
                    }
                    else
                    {
                        Console.WriteLine("el cajero no tiene billetes para esta transaccion\n");
                        mil += billeteMil * 1000;
                        quinientos += billeteQuinientos * 500;
                        cien += billeteCien * 100;
                        billeteMil = 0;
                        billeteQuinientos = 0;
                        billeteCien = 0;

                        Console.WriteLine(total);

                        bank();
                    }
                }
                else if (monto % 100 != 0)
                {
                    Console.WriteLine("monto invalido");
                    cajero();
                }
                else if (monto > 2000)
                {
                    Console.WriteLine("el limite de retiro por transaccion es de RD$2000");
                    cajero();
                }
                else
                {
                    Console.WriteLine("esta transaccion excede el limite diario de retiro");
                    cajero();
                }
                
            }

            void bank()
            {
                
                Console.WriteLine("seleccione su banco\n1-Banco ABC\n2-Banco DEF");
                int banco = Convert.ToInt32(Console.ReadLine());

                if (limiteDia != 0)
                {
                    switch (banco)
                    {
                        case 1:

                            cajero();
                            break;

                        case 2:
                            Console.WriteLine("este banco no esta disponible");
                            bank();
                            break;

                    }
                }
                else
                {
                    Console.WriteLine("usted a alcanzado el monto limite de retiros diarios");
                    bank();
                }

            }

            bank();

            Console.ReadKey();

        }
    }
}
