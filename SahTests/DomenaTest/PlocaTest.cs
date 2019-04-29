using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Sah.Domena;

namespace SahTests.DomenaTest
{
    [TestClass]
    public class PlocaTest
    {
        [TestMethod]
        public void KonstruktorSaFiguramaOk()
        {
            List<Figura> lista = new List<Figura>();
            Boja boja = Boja.Bijeli;
            Figura lovac = new Lovac(boja,1);
            lovac.PostaviPoziciju(new Pozicija().PostaviHorizontalno(3).PostaviVertikalno(4));
            lista.Add(lovac);
            Figura skakac = new Skakac(boja, 2);
            skakac.PostaviPoziciju(new Pozicija().PostaviHorizontalno(4).PostaviVertikalno(5));
            lista.Add(skakac);
            Ploca ploca = new Ploca(lista);
            
        }
    }
}
