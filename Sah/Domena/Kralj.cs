﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sah.Domena.Iznimke;

namespace Sah.Domena
{
    public class Kralj : Figura
    {
        public Kralj(Boja boja)
        {
            this.Boja = boja;
            this.Id = 1;
        }

        public override bool LegalanPotez(Pozicija novaPozicija, Ploca ploca)
        {
            base.LegalanPotez(novaPozicija, ploca);
            


            return true;
        }

        public override string ToString(Pozicija pozicija)
        {
            //return this.Boja.ToString() + " Kralj " + pozicija.Horizontalno + "," + pozicija.Vertikalno;
            return "K" + Ploca.SkracenaBoja(this.Boja) + "-" + this.Id;
        }
    }
}