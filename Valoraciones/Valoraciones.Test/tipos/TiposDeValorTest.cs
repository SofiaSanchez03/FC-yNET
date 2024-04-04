using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valoraciones.Test.tipos
{
    [TestClass]
    public class TiposDeValorTest
    {
        int x;
        float y;
        double z;
        string cadenas;

        [TestMethod]
        public void VariablesTipoDeValor()
        {
            int x1 = 10;
            int x2 = x1;

            // x1 = 20;

            Assert.AreEqual(x1, x2);
        }

        [TestMethod]
        public void VariableTiposDeValorEnum()
        {
            LibroValoraciones libro = new LibroValoraciones();
            libro.Idioma = IdiomaLibro.ES;

            Assert.AreEqual(libro.Idioma, IdiomaLibro.ES);
        }

    }
}
