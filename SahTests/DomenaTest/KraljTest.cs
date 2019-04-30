using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Sah.Domena;
using Sah.Domena.Iznimke;

namespace SahTests.DomenaTest
{
    [TestClass]
    public class KraljTest
    {
        [TestMethod]
        public void LegalanPotez()
        {
            List<Figura> lista = new List<Figura>();
            Figura kralj = new Kralj(Boja.Bijeli);
            kralj.Pozicija.PostaviHorizontalno(0).PostaviVertikalno(3);
            lista.Add(kralj);
            Pozicija pozicija = new Pozicija().PostaviHorizontalno(0).PostaviVertikalno(2);
            Ploca ploca = new Ploca(lista);
            bool legalan = kralj.LegalanPotez(pozicija, ploca);
            Assert.IsTrue(legalan);
        }
        [TestMethod]
        public void NemogucPotez()
        {
            List<Figura> lista = new List<Figura>();
            Figura kralj = new Kralj(Boja.Bijeli);
            kralj.Pozicija.PostaviHorizontalno(0).PostaviVertikalno(3);
            lista.Add(kralj);
            Pozicija pozicija = new Pozicija().PostaviHorizontalno(0).PostaviVertikalno(1);
            Ploca ploca = new Ploca(lista);
            bool legalan = false;
            bool nemoguc = false;
            try
            {
                legalan = kralj.LegalanPotez(pozicija, ploca);

            }
            catch (IllegalMoveException ime)
            {
                if (ime.NemogucPotez)
                    nemoguc = true;
            }
            Assert.IsFalse(legalan);
            Assert.IsTrue(nemoguc);
        }
    }
}
