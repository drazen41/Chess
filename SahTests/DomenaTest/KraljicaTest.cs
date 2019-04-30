using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sah.Domena;
using System.Collections.Generic;
using Sah.Domena.Iznimke;

namespace SahTests.DomenaTest
{
    [TestClass]
    public class KraljicaTest
    {
        [TestMethod]
        public void LegalanPotezTop()
        {
            List<Figura> lista = new List<Figura>();
            Figura kraljica = new Kraljica(Boja.Bijeli, 1);
            kraljica.Pozicija.PostaviHorizontalno(0).PostaviVertikalno(4);
            lista.Add(kraljica);
            Ploca ploca = new Ploca(lista);
            Pozicija pozicija = new Pozicija().PostaviHorizontalno(0).PostaviVertikalno(7);
            bool legalan = kraljica.LegalanPotez(pozicija, ploca);
            Assert.IsTrue(legalan);
        }
        [TestMethod]
        public void LegalanPotezLovac()
        {
            List<Figura> lista = new List<Figura>();
            Figura kraljica = new Kraljica(Boja.Bijeli, 1);
            kraljica.Pozicija.PostaviHorizontalno(0).PostaviVertikalno(4);
            lista.Add(kraljica);
            Ploca ploca = new Ploca(lista);
            Pozicija pozicija = new Pozicija().PostaviHorizontalno(4).PostaviVertikalno(4);
            bool legalan = kraljica.LegalanPotez(pozicija, ploca);
            Assert.IsTrue(legalan);
        }
        [TestMethod]
        public void NemogucPotez()
        {
            List<Figura> lista = new List<Figura>();
            Figura kraljica = new Kraljica(Boja.Bijeli, 1);
            kraljica.Pozicija.PostaviHorizontalno(0).PostaviVertikalno(4);
            lista.Add(kraljica);
            Ploca ploca = new Ploca(lista);
            Pozicija pozicija = new Pozicija().PostaviHorizontalno(1).PostaviVertikalno(7);
            bool legalan = true;
            bool nemoguc = false;
            try
            {
                legalan = kraljica.LegalanPotez(pozicija, ploca);
            }
            catch (IllegalMoveException ime)
            {
                if (ime.NemogucPotez)
                    nemoguc = true;
            }
            Assert.IsTrue(nemoguc);
        }
        [TestMethod]
        public void NelegalanPotezTop()
        {
            List<Figura> lista = new List<Figura>();
            Figura kraljica = new Kraljica(Boja.Bijeli, 1);
            kraljica.Pozicija.PostaviHorizontalno(0).PostaviVertikalno(4);
            lista.Add(kraljica);
            Figura kralj = new Kralj(Boja.Bijeli);
            kralj.Pozicija.PostaviHorizontalno(0).PostaviVertikalno(3);
            lista.Add(kralj);
            Ploca ploca = new Ploca(lista);
            Pozicija pozicija = new Pozicija().PostaviHorizontalno(0).PostaviVertikalno(0);
            bool legalan = false;
            try
            {
                legalan = kraljica.LegalanPotez(pozicija, ploca);
            }
            catch (IllegalMoveException ime)
            {
                string poruka = ime.Message;
            }
            Assert.IsFalse(legalan);
        }
        [TestMethod]
        public void NelegalanPotezLovac()
        {
            List<Figura> lista = new List<Figura>();
            Figura kraljica = new Kraljica(Boja.Bijeli, 1);
            kraljica.Pozicija.PostaviHorizontalno(0).PostaviVertikalno(4);
            lista.Add(kraljica);
            Figura pjesak = new Pjesak(Boja.Bijeli,2);
            pjesak.Pozicija.PostaviHorizontalno(1).PostaviVertikalno(3);
            lista.Add(pjesak);
            Ploca ploca = new Ploca(lista);
            Pozicija pozicija = new Pozicija().PostaviHorizontalno(3).PostaviVertikalno(1);
            bool legalan = false;
            string poruka = "";
            try
            {
                legalan = kraljica.LegalanPotez(pozicija, ploca);
            }
            catch (IllegalMoveException ime)
            {
                poruka = ime.Message;
            }
            Assert.IsFalse(legalan);
            Assert.AreEqual(poruka, "Figura " + pjesak.GetType().Name + " na putu.");
        }
        [TestMethod]
        public void KraljicaUzimaFiguruKaoTop()
        {
            List<Figura> lista = new List<Figura>();
            Figura kraljica = new Kraljica(Boja.Bijeli, 1);
            kraljica.Pozicija.PostaviHorizontalno(0).PostaviVertikalno(4);
            lista.Add(kraljica);
            Figura pjesak = new Pjesak(Boja.Crni, 2);
            pjesak.Pozicija.PostaviHorizontalno(4).PostaviVertikalno(4);
            lista.Add(pjesak);
            Ploca ploca = new Ploca(lista);
            Pozicija pozicija = new Pozicija().PostaviHorizontalno(4).PostaviVertikalno(4);
            bool legalan = kraljica.LegalanPotez(pozicija, ploca);
            Assert.IsTrue(legalan);
        }
        [TestMethod]
        public void KraljicaUzimaFiguruKaoLovac()
        {
            List<Figura> lista = new List<Figura>();
            Figura kraljica = new Kraljica(Boja.Bijeli, 1);
            kraljica.Pozicija.PostaviHorizontalno(0).PostaviVertikalno(4);
            lista.Add(kraljica);
            Figura pjesak = new Pjesak(Boja.Crni, 2);
            pjesak.Pozicija.PostaviHorizontalno(4).PostaviVertikalno(0);
            lista.Add(pjesak);
            Ploca ploca = new Ploca(lista);
            Pozicija pozicija = new Pozicija().PostaviHorizontalno(4).PostaviVertikalno(0);
            bool legalan = kraljica.LegalanPotez(pozicija, ploca);
            Assert.IsTrue(legalan);
        }
    }
}
