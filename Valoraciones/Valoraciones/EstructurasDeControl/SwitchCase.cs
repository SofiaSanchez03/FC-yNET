using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valoraciones.EstructurasDeControl
{
    public class SwitchCase
    {
        public void EjemploSwitchCase1()
        {
            int caseSwitch = 1;
            switch ( caseSwitch )
            {
                case 1:
                    Console.WriteLine("caso 1");
                    break;

                case 2:
                    Console.WriteLine("caso 2");
                    break;

                default:
                    Console.WriteLine("deafault case");
                    break;
            }
        }

        public void EjemploSwitchCase2()
        {
            int switchExpression = 3;
            switch ( switchExpression )
            {
                // Puede tener más de un caso
                case 0:

                case 1:
                    Console.WriteLine("Case 0 o 1");
                    // Casi todos tienen un salto llamado break
                    break;

                case 2: 
                    Console.WriteLine("Case 2");
                    break;
                // Esta línea genera un warning ya que va después del salto
                // Console.WriteLine("Warning: Unreachable code");

                // Se pueden saltar números de casos
                case 7 - 4:
                    Console.WriteLine("Case 3");
                    break;
            }
        }

        public void EjemploSwitchCase3()
        {
            Console.WriteLine("Elige un tamaño de vaso");
            Console.WriteLine("Tamaño vaso: 1=pequeño 2=mediano 3=grande");
            Console.WriteLine("Ingresa tu selección: ");
            string str = Console.ReadLine();
            int cost = 0;
            switch (str)
            {
                case "1":
                case "pequeño":
                    cost += 25;
                    break;
                case "2":
                case "mediano":
                    cost += 25;
                    goto case "1";
                case "3":
                case "grande":
                    cost += 50;
                    goto case "1";
                default:
                    Console.WriteLine("Selección no válida. Ingresa 1, 2 o 3.");
                    break;
            }
            if (cost != 0)
            {
                Console.WriteLine("El coste es de {0} céntimos.", cost); 
            }
            Console.WriteLine("Gracias por elegir un vaso");
        }
    }
}
