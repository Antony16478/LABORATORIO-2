using System;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombreCorrecto = "usuario";
            string contraseñaCorrecta = "contraseña123";

            Console.WriteLine("Ingrese su nombre de usuario:");
            string nombreIngresado = Console.ReadLine();

            Console.WriteLine("Ingrese su contraseña:");
            string contraseñaIngresada = Console.ReadLine();

            string mensaje = VerificarAcceso(nombreIngresado, contraseñaIngresada, nombreCorrecto, contraseñaCorrecta);
            Console.WriteLine(mensaje);
        }

        static string VerificarAcceso(string nombreIngresado, string contraseñaIngresada, string nombreCorrecto, string contraseñaCorrecta)
        {
            if (nombreIngresado == nombreCorrecto)
            {
                if (contraseñaIngresada == contraseñaCorrecta)
                {
                    return "Acceso concedido";
                }
                else
                {
                    return "Contraseña incorrecta";
                }
            }
            else
            {
                return "Usuario no registrado";
            }
        }
    }
}