using System;
using System.Collections.Generic;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;
using Valoraciones.EstructurasDeControl;

namespace Valoraciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Crear objeto libro
            LibroValoraciones libro = new LibroValoraciones();
            libro.Idioma = IdiomaLibro.ES;
            libro.Nombre = "El libro de valoraciones de Sofía";
            libro.Nombre = null;
            Console.WriteLine(libro.Nombre);

            // Crear el objeto para hablar
            SpeechSynthesizer hablar = new SpeechSynthesizer();

            // Crear el objeto de array
            MisArrays miArray = new MisArrays();

            // Métodos de array
            miArray.ArrayTrabajando();

            // Crear el objeto del vector
            Vector3D miVector;
            miVector.x = 10;
            miVector.y = 20;
            miVector.z = 30.30f;

            // Asignar valoraciones
            libro.AgregarValoracion(3.5f);
            libro.AgregarValoracion(5.1f);
            libro.AgregarValoracion(4);
            libro.AgregarValoracion(1);
            libro.AgregarValoracion(2);

            //hablar.Speak("Bienvenido a las valoraciones. Aquí se muestra el promedio de las valoraciones y las valoraciones mínima y máxima");

            CalcularValoraciones publicar = libro.PublicarValoraciones();
            float valoracionMax = publicar.valoracionMax;
            float valoracionMin = publicar.valoracionMin;
            float promedioValoraciones = publicar.promedioValoraciones;
            
            // Imprimir por consola
            EscribirValoraciones("El promedio de las valoraciones es: ", promedioValoraciones);
            EscribirValoraciones("La valoración mínima es:", valoracionMin);
            EscribirValoraciones("La valoración máxima es:", (int)valoracionMax);
            EscribirValoraciones("La letra de tu valoración es: " + libro.ValoracionesLetras);

            // Estructura de Switch Case
            SwitchCase misCasos = new SwitchCase();
            misCasos.EjemploSwitchCase1();
            misCasos.EjemploSwitchCase2();
            misCasos.EjemploSwitchCase3();

            // Condicionales
            Condicionales condicionales = new Condicionales();
            condicionales.ComprobacionesConRetorno();

            // Bucles
            Bucles miBucle = new Bucles();
            miBucle.BuclesForEach();
            miBucle.BuclesForLoop();
            miBucle.BuclesWhile();
            miBucle.BuclesDoWhile();
            
            Console.ReadLine();
        }

        private static void EscribirValoraciones(string descripcion)
        {
            Console.WriteLine("{0}", descripcion);
        }
        private static void EscribirValoraciones(string descripcion, int valoracion)
        {
            Console.WriteLine("{0}" + "{1}", descripcion, valoracion);
        }
        private static void EscribirValoraciones(string descripcion, float valoracion)
        {
            Console.WriteLine("{0}" + "{1}", descripcion, valoracion);
        }
    }
}
