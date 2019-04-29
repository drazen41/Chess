using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sah.Domena.Iznimke;
using Sah.Domena;
using System.Collections.Generic;

namespace SahTests.DomenaTest
{
    [TestClass]
    public class LovacTest
    {
        [TestMethod]
        [ExpectedException(typeof(IllegalMoveException))]
        public void LovacSeNeKreceKaoLovacIznimka()
        {
            Ploca ploca = new Ploca();
            Pozicija novaPozicija = new Pozicija();
            novaPozicija.PostaviHorizontalno(1).PostaviVertikalno(2);
            Figura lovac = ploca.VratiFiguru(new Pozicija().PostaviHorizontalno(0).PostaviVertikalno(2));
            bool legalanPotez = lovac.LegalanPotez(novaPozicija, ploca);
        }
        [TestMethod]
        public void LegalanPotez()
        {
            List<Figura> lista = new List<Figura>();
            Figura lovac = new Lovac(Boja.Bijeli, 1);
            lovac.PostaviPoziciju(new Pozicija().PostaviHorizontalno(1).PostaviVertikalno(3));
            lista.Add(lovac);
            Ploca ploca = new Ploca(lista);
            Pozicija novaPozicija = new Pozicija();
            novaPozicija.PostaviHorizontalno(2).PostaviVertikalno(4);
            bool legalanPotez = lovac.LegalanPotez(novaPozicija, ploca);
            Assert.IsTrue(legalanPotez);
        }
        [TestMethod]
        [ExpectedException(typeof(IllegalMoveException))]
        public void FiguraNaPutuGoreBacaIllegalMoveIznimku()
        {
            List<Figura> lista = new List<Figura>();
            Figura lovac = new Lovac(Boja.Bijeli, 1);
            lovac.PostaviPoziciju(new Pozicija().PostaviHorizontalno(3).PostaviVertikalno(1));
            lista.Add(lovac);
            Figura pjesak = new Pjesak(Boja.Bijeli, 2);
            pjesak.PostaviPoziciju(new Pozicija().PostaviHorizontalno(6).PostaviVertikalno(4));
            lista.Add(pjesak);
            Ploca ploca = new Ploca(lista);
            Pozicija novaPozicija = new Pozicija();
            novaPozicija.PostaviHorizontalno(6).PostaviVertikalno(4);
            bool legalanPotez = lovac.LegalanPotez(novaPozicija, ploca);
        }
        [TestMethod]
        [ExpectedException(typeof(IllegalMoveException))]
        public void FiguraNaPolaPutaDrugeBojeGoreBacaIllegalMoveIznimku()
        {
            List<Figura> lista = new List<Figura>();
            Figura lovac = new Lovac(Boja.Bijeli, 1);
            lovac.PostaviPoziciju(new Pozicija().PostaviHorizontalno(3).PostaviVertikalno(1));
            lista.Add(lovac);
            Figura pjesak = new Pjesak(Boja.Crni, 2);
            pjesak.PostaviPoziciju(new Pozicija().PostaviHorizontalno(4).PostaviVertikalno(2));
            lista.Add(pjesak);
            Ploca ploca = new Ploca(lista);
            Pozicija novaPozicija = new Pozicija();
            novaPozicija.PostaviHorizontalno(6).PostaviVertikalno(4);
            bool legalanPotez = lovac.LegalanPotez(novaPozicija, ploca);
        }
        [TestMethod]
        public void LovacJedePjesaka()
        {
            List<Figura> lista = new List<Figura>();
            Figura lovac = new Lovac(Boja.Bijeli, 1);
            lovac.PostaviPoziciju(new Pozicija().PostaviHorizontalno(3).PostaviVertikalno(1));
            lista.Add(lovac);
            Figura pjesak = new Pjesak(Boja.Crni, 2);
            pjesak.PostaviPoziciju(new Pozicija().PostaviHorizontalno(6).PostaviVertikalno(4));
            lista.Add(pjesak);
            Ploca ploca = new Ploca(lista);
            Pozicija novaPozicija = new Pozicija();
            novaPozicija.PostaviHorizontalno(6).PostaviVertikalno(4);
            bool legalanPotez = lovac.LegalanPotez(novaPozicija, ploca);
            Assert.IsTrue(legalanPotez);
        }
        [TestMethod]
        [ExpectedException(typeof(IllegalMoveException))]
        public void FiguraNaPolaPutaDrugeBojeDoljeBacaIllegalMoveIznimku()
        {
            List<Figura> lista = new List<Figura>();
            Figura lovac = new Lovac(Boja.Bijeli, 1);
            lovac.PostaviPoziciju(new Pozicija().PostaviHorizontalno(6).PostaviVertikalno(6));
            lista.Add(lovac);
            Figura pjesak = new Pjesak(Boja.Crni, 2);
            pjesak.PostaviPoziciju(new Pozicija().PostaviHorizontalno(4).PostaviVertikalno(4));
            lista.Add(pjesak);
            Ploca ploca = new Ploca(lista);
            Pozicija novaPozicija = new Pozicija();
            novaPozicija.PostaviHorizontalno(1).PostaviVertikalno(1);
            bool legalanPotez = lovac.LegalanPotez(novaPozicija, ploca);
        }
        [TestMethod]
        public void LovacJedePjesakaOpet()
        {
            List<Figura> lista = new List<Figura>();
            Figura lovac = new Lovac(Boja.Bijeli, 1);
            lovac.PostaviPoziciju(new Pozicija().PostaviHorizontalno(6).PostaviVertikalno(6));
            lista.Add(lovac);
            Figura pjesak = new Pjesak(Boja.Crni, 2);
            pjesak.PostaviPoziciju(new Pozicija().PostaviHorizontalno(1).PostaviVertikalno(1));
            lista.Add(pjesak);
            Ploca ploca = new Ploca(lista);
            Pozicija novaPozicija = new Pozicija();
            novaPozicija.PostaviHorizontalno(1).PostaviVertikalno(1);
            bool legalanPotez = lovac.LegalanPotez(novaPozicija, ploca);
            Assert.IsTrue(legalanPotez);
        }
    }
}
