using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            // DECLARACION Y USO DE VARIABLES
            Console.WriteLine("Parte 1: Declaración y Uso de Variables");

            
            int numeroEntero;
            double numeroDecimal;
            string texto;
            bool valorBooleano;

            //en esta parte se solicitan valores a el usuario 
            Console.Write("Introduce un número entero: ");
            numeroEntero = int.Parse(Console.ReadLine());

            Console.Write("Introduce un número decimal: ");
            numeroDecimal = double.Parse(Console.ReadLine());

            Console.Write("Introduce un texto: ");
            texto = Console.ReadLine();

            Console.Write("Introduce un valor verdadero o falso (true/false): ");
            valorBooleano = bool.Parse(Console.ReadLine());

            // estas lineas son las encargadas de mostrar los valores en la consola
            Console.WriteLine($"Número entero: {numeroEntero}");
            Console.WriteLine($"Número decimal: {numeroDecimal}");
            Console.WriteLine($"Texto: {texto}");
            Console.WriteLine($"Valor booleano: {valorBooleano}");

            //OPERACIONES MATEMATICAS
            Console.WriteLine("\nParte 2: Operaciones Matemáticas");

            // en esta parte se solicitan valores a el usuario 
            Console.Write("Introduce el primer número entero: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Introduce el segundo número entero: ");
            int num2 = int.Parse(Console.ReadLine());

            //estas lineas esta encargadas de las operaciones y mostrar ressultados 
            Console.WriteLine($"Suma: {num1} + {num2} = {num1 + num2}");
            Console.WriteLine($"Resta: {num1} - {num2} = {num1 - num2}");
            Console.WriteLine($"Multiplicación: {num1} * {num2} = {num1 * num2}");
            Console.WriteLine($"División: {num1} / {num2} = {(num2 != 0 ? (num1 / (double)num2).ToString() : "División por cero no permitida")}");

            // Repetir con otros tipos de datos
            Console.Write("Introduce el primer número decimal: ");
            float num3 = float.Parse(Console.ReadLine());

            Console.Write("Introduce el segundo número decimal: ");
            float num4 = float.Parse(Console.ReadLine());

            Console.WriteLine($"Suma: {num3} + {num4} = {num3 + num4}");
            Console.WriteLine($"Resta: {num3} - {num4} = {num3 - num4}");
            Console.WriteLine($"Multiplicación: {num3} * {num4} = {num3 * num4}");
            Console.WriteLine($"División: {num3} / {num4} = {(num4 != 0 ? (num3 / num4).ToString() : "División por cero no permitida")}");

            // LógicasOPERACIONES LOGICAS.
            Console.WriteLine("\nParte 3: Operaciones Lógicas");

            // Solicitar valores al usuario
            Console.Write("Introduce el primer número para comparaciones: ");
            int num5 = int.Parse(Console.ReadLine());

            Console.Write("Introduce el segundo número para comparaciones: ");
            int num6 = int.Parse(Console.ReadLine());

            // Realizar comparaciones y mostrar resultados
            Console.WriteLine($"¿{num5} es mayor que {num6}? {num5 > num6}");
            Console.WriteLine($"¿{num5} es menor que {num6}? {num5 < num6}");
            Console.WriteLine($"¿{num5} es igual a {num6}? {num5 == num6}");

            // Uso de AND (&&) y OR (||)
            Console.WriteLine($"¿{num5} es mayor que 0 y {num6} es mayor que 0? {num5 > 0 && num6 > 0}");
            Console.WriteLine($"¿{num5} es mayor que 0 o {num6} es mayor que 0? {num5 > 0 || num6 > 0}");
        }
    }
}