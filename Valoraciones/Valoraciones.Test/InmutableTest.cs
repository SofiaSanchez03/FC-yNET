using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valoraciones.Test
{
    [TestClass]
    public class InmutableTest
    {
        [TestMethod]
        public void InmutableTestMetodo()
        {
            string nombre = "Sofía";
            nombre = nombre.ToUpper();

            Assert.AreEqual("SOFÍA", nombre);

            LibroValoraciones libro1 = new LibroValoraciones();
            libro1.Nombre = "Sofía";
            libro1.Nombre = libro1.Nombre.ToUpper();

            Assert.AreEqual("SOFÍA", libro1.Nombre);

            DateTime fecha = new DateTime(1977, 8, 26);
            fecha = fecha.AddDays(1);

            Assert.AreEqual(27, fecha.Day);
        }
    }
}
