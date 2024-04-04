using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valoraciones.Test.tipos
{
    [TestClass]
    public class TiposDeReferenciaTest
    {
        [TestMethod]
        public void VariabllesTipoReferencia()
        {
            LibroValoraciones l1 = new LibroValoraciones();
            l1.Nombre = "Libro Sofía";
            LibroValoraciones l2 = l1;
            l1.Nombre = "Libro...";

            // l1 = new LibroValoraciones(); error

            Assert.AreEqual(l1.Nombre, l2.Nombre);
        }

        [TestMethod]
        public void MyArrayTestMethod()
        {
            // string[] letras;
            letras = new string[3];
            AgregarLetraA("A");
            Assert.AreEqual("A", letras[0]);
        }

        [TestMethod]
        public void IntTestMethod()
        {
            numerosReferencia = new int[2];
            numerosReferencia[0] = 1; 
            numerosReferencia[1] = 2; 
            numerosReferencia[2] = 3;

            int[] numerosReferencia2 = numerosReferencia;

            Assert.AreEqual(numerosReferencia[0], numerosReferencia2[0]);
        }

        public void AgregarLetraA(string L)
        {
            letras[0] = L;
        }
        string[] letras;
        int[] numerosReferencia;
    }
}
