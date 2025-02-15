using System;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese su edad:");
            int edad = int.Parse(Console.ReadLine());
            string categoria = DeterminarCategoria(edad);
            Console.WriteLine($"Categoría: {categoria}");
        }

        static string DeterminarCategoria(int edad)
        {
            if (edad < 12)
            {
                return "Niño";
            }
            else if (edad >= 12 && edad <= 17)
            {
                return "Adolescente";
            }
            else if (edad >= 18 && edad <= 59)
            {
                return "Adulto";
            }
            else
            {
                return "Adulto mayor";
            }
        }
    }
}