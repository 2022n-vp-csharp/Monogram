using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Monogram.Tests
{
    [TestClass]
    public class MonogramTests
    {
        [TestMethod]
        [DataRow("dr. Kuspel Gábor", true, "dr. KG")]
        [DataRow("dr. Kis-Tóth Lajos", true, "dr. K-TL")]
        [DataRow("jr. John Smith", false, "jr. JS")]
        [DataRow("Kis Nagy László", true, "KNL")]
        public void MonogramTeszt(string nev, bool magyar, string elvart)
        {
            string eredmeny = Monogram.Kepzes(nev, magyar);
            Assert.AreEqual(eredmeny, elvart);
        }   
    }
}
