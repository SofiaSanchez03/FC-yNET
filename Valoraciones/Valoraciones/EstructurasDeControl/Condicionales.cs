using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valoraciones.EstructurasDeControl
{
    public class Condicionales
    {
        // Comparaciones que devuelven un valor de tipo boolean verdadero / false

        int num = 10;
        int num2 = 20;

        public void CondicionalBasico()
        {
            if (num == num2)
            {
                Console.WriteLine("Estos números SI son iguales");
            }
        }

        public void CondicionalBasico2 ()
        {
            if (num == num2)
            {
                Console.WriteLine("Estos números SI son iguales");
            } 
            else
            {
                Console.WriteLine("Estos números NO son iguales");
            }
        }

        public void CondicionalAnidado()
        {
            if (num == num2)
            {
                Console.WriteLine("Estos números SI son iguales");
            }
            else if (num >= num2)
            {
                Console.WriteLine(num + "es mayor o igual que" + num2);
            }
            else if (num <= num2)
            {
                Console.WriteLine(num2 + "es mayor o igual que" + num);
            }
            else
            {
                Console.WriteLine("Estos números NO son iguales");
            }
        }

        public void ComprobacionesConRetorno()
        {
            int resultado1 = Prueba(0);
            int resultado2 = Prueba(50);
            int resultado3 = Prueba(-1);

            Console.WriteLine("Resultado 1:" + resultado1);
            Console.WriteLine("Resultado 2:" + resultado2);
            Console.WriteLine("Resultado 3:" + resultado3);
        }

        public int Prueba(int valor)
        {
            if (valor == 0)
            {
                return -1;
            }
            else if (valor <= 10)
            {
                return 0;
            }
            else if (valor <= 100)
            {
                return 1;
            }
            else
            {
                return 2;
            }
        }
    }
}
