using System;

namespace EdadLegal
{
    class Program
    {
        static void Main(string[] args) {
            Console.WriteLine("Escriba su nombre y pulse Enter:");
            string nombre = Console.ReadLine();
            Console.WriteLine("Escriba su edad y pulse Enter:");
            int edad = int.Parse(Console.ReadLine());
            if (edad >= 18)
            {
                Console.WriteLine("Tu nombre es " + nombre + " y legalmente eres mayor de edad.");
            } else
            {
                Console.WriteLine("Tu nombre es " + nombre + " y legalmente NO eres mayor de edad.");
            }
        }
    }
}