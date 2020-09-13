using System;

namespace ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string User = "admin";
            string Pass = "1234";
            int i = 3;

            bool validarUsuario(string user, string pass)
            {
                if(User == user & Pass == pass)
                {
                    Console.WriteLine("ha iniciado sesion correctamente");
                    return true;
                }
                else
                {
                    if (i == 1)
                    {
                        Console.WriteLine("has ingresado una contraseña incorrecta varias veces, \ntu cuenta ha sido bloqueada.");
                        return false;
                    }
                    else
                    {
                        --i;
                        Console.WriteLine("usuario o contraseña incorrecta {0} intentos restantes \n",i);
                        
                        login();
                        return false;
                        
                    }
                }
            }

            void login()
            {
                if (i != 0)
                {
                    Console.WriteLine("Ingrese nombre de usuario");
                    string a = Console.ReadLine();
                    Console.WriteLine("Ingrese la contraseña");
                    string b = Console.ReadLine();

                    validarUsuario(a, b);
                }


            }


            login();

            Console.ReadKey();







        }
    }
}
