using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Entidades;

namespace UnitTest
{
    [TestClass]
    public class Test
    {
        /// <summary>
        /// Verifica que los objetos de tipo BiciMontaña y BiciCarrera que no sean iguales sus colores
        /// </summary>
        
        [TestMethod]        
        public void Bicis_Are_Equals()
        {
            BiciCarrera biciCarrera1 = new BiciCarrera("Negro", "Shimano", "Specialized");

            BiciMontaña biciMontaña1 = new BiciMontaña("Blanco", "Scott", "Supra", BiciMontaña.NumeroDeSerie.Serie_1);
            Assert.AreNotEqual(biciCarrera1.Color, biciMontaña1.Color);
        }

        /// <summary>
        /// Verifica que la lista de las bicicletas no estén vacias y no sea nula
        /// </summary>
        /*
        [TestMethod]

       
        public void Bicis_No_Vacia()
        {
            Fabrica fabrica1 = new Fabrica(5);
            BiciCarrera biciCarrera1 = new BiciCarrera("Negro", "Shimano", "Specialized");

            fabrica1 += biciCarrera1;
            Assert.IsNotNull(fabrica1.Bicicletas);
            Assert.IsTrue(fabrica1.Bicicletas.Count > 0);
        }*/
        
    }
}
