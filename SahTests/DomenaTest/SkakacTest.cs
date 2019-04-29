using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sah.Domena;
using Sah.Domena.Iznimke;

namespace SahTests.DomenaTest
{
    [TestClass]
    public class SkakacTest
    {
        [TestMethod]
        [ExpectedException(typeof(IllegalMoveException))]
        public void SkakacBacaIznimkuZaZauzetoPolje()
        {
            Ploca ploca = new Ploca();
            Pozicija novaPozicija = new Pozicija();
            novaPozicija.PostaviHorizontalno(1).PostaviVertikalno(3);
            Boja boja = Boja.Bijeli;
            Skakac skakac = new Skakac(boja, 1);
            skakac.Pozicija.PostaviHorizontalno(0).PostaviVertikalno(1);
            bool nelegalno = skakac.LegalanPotez(novaPozicija, ploca);
        }
    }
}
