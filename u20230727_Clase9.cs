using System;       //Roberto Carlos Iglesias Álvarez U20230727
using System.Globalization;

namespace MyApp// Note: actual namespace depends on the project name.
{
    internal class Program
    {
         static void Main(string[] args)
        {
            //Ejercicio practico claso 09

            Console.WriteLine("\n------Programa que determina las notas------\n");

            Console.WriteLine("Ingrese cual es su nota: ");
              string notaStr = Console.ReadLine();
            double nota=Convert.ToDouble(notaStr, CultureInfo.InvariantCulture);

            if (nota >= 9.5)
            {
                Console.WriteLine("\nTu nota es " + nota + " La calificación obtenida es Excelente =)");
            }
            else if (nota >= 8.5)
            {
                Console.WriteLine("\nTu nota es " + nota + "  La calificación obtenida es Muy Buena =)");
            }
            else if (nota >= 7)
            {
                Console.WriteLine("\nTu nota es " + nota + " La calificación obtenida es Buena =)");
            }
            else {
                Console.WriteLine("\nTu nota es Deficiente");
            }
        }
    }
}