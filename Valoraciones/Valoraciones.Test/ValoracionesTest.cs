using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valoraciones.Test
{
    public class ValoracionesTest
    {
        [TestClass] 
        public class Valoraciones
        {
            [TestMethod]
            public void CalcularValoracionMax()
            {
                LibroValoraciones libro = new LibroValoraciones();
                // Asignar valoraciones
                libro.AgregarValoracion(3.5f);
                libro.AgregarValoracion(5);
                libro.AgregarValoracion(4);
                libro.AgregarValoracion(1);
                libro.AgregarValoracion(2);

                CalcularValoraciones resultado = libro.PublicarValoraciones();
                Assert.AreEqual(5, resultado.valoracionMax);
            }
            
            [TestMethod]
            public void CalcularValoracionMin()
            {
                LibroValoraciones libro = new LibroValoraciones();
                // Asignar valoraciones
                libro.AgregarValoracion(3.5f);
                libro.AgregarValoracion(5);
                libro.AgregarValoracion(4);
                libro.AgregarValoracion(1);
                libro.AgregarValoracion(2);

                CalcularValoraciones resultado = libro.PublicarValoraciones();
                Assert.AreEqual(1, resultado.valoracionMin);
            }
            
            [TestMethod]
            public void CalcularValoracionPromedio()
            {
                LibroValoraciones libro = new LibroValoraciones();
                // Asignar valoraciones
                libro.AgregarValoracion(3.5f);
                libro.AgregarValoracion(5);
                libro.AgregarValoracion(4);
                libro.AgregarValoracion(1);
                libro.AgregarValoracion(2);

                CalcularValoraciones resultado = libro.PublicarValoraciones();
                Assert.AreEqual(3.1f, resultado.promedioValoraciones);
                //Assert.AreEqual(2.83f, resultado.promedioValoraciones, 0.01);
            }
        }
    }
}
