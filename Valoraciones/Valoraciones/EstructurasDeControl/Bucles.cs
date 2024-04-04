using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valoraciones.EstructurasDeControl
{
    public class Bucles
    {
        // Funcionalidad: Recorrer colecciones de datos (Array, ArrayList, listas, diccionarios)

        public void BuclesForEach()
        {
            int[] array1 = { 1, 2, 3, 4, 5 };

            // Con numéricos
            foreach (int n in array1)
            {
                // break;
                // continue;
                // return;
                // goto Hola;
                Console.WriteLine("For each string: " + n.ToString());

                // Hola:
                // Console.WriteLine("Me salto el bucle")
            }

            // Con strings
            string[] array2 = { "Hola", "Mundo" };

            foreach (string s in array2)
            {
                Console.WriteLine("For each string: " + s);
            }
        }

        public void BuclesForLoop()
        {
            // Array de enteros
            int[] array1 = { 1, 2, 3, 4, 5 };

            for (int i = 0; i < array1.Length; i++)
            {
                Console.WriteLine("For loop int " + array1[i].ToString());
            }

            // Con strings
            string[] array2 = { "Hola", "Mundo" };

            for (int i = 0; i < array2.Length; i++)
            {
                Console.WriteLine("For each string: " + array2[i]);
            }
        }

        public void BuclesWhile()
        {
            int[] array1 = { 0, 1, 2, 3, 4, 5 };
            int x = 0;

            while (x < 6)
            {
                Console.WriteLine("While int" + array1[x].ToString());
                x++;
            }

            // Con strings
            string[] array2 = { "Hola", "Mundo" };
            int y = 0;

            while (y < 2)
            {
                Console.WriteLine("While int" + array2[y].ToString());
                y++;
            }
        }
        
        public void BuclesDoWhile()
        {
            int[] array1 = { 0, 1, 2, 3, 4, 5 };
            int x = 0;
            do
            {
                Console.WriteLine("While int" + array1[x].ToString());
                x++;
            } while (x < 6);

            // Con strings
            string[] array2 = { "Hola", "Mundo" };
            int y = 0;

            do
            {
                Console.WriteLine("While int" + array2[y].ToString());
                y++;
            } while (y < 2) ;
            
        }
    }
}
