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
            if (Math.Abs(this.Pozicija.Horizontalno - novaPozicija.Horizontalno) > 1 || Math.Abs(this.Pozicija.Vertikalno - novaPozicija.Vertikalno) > 1)
                throw new IllegalMoveException("Illegal move", true);


            return true;
        }

        public override string ToString(Pozicija pozicija)
        {
            //return this.Boja.ToString() + " Kralj " + pozicija.Horizontalno + "," + pozicija.Vertikalno;
            return "K" + Ploca.SkracenaBoja(this.Boja) + "-" + this.Id;
        }
        public static Kralj VratiKraljaSaPloce(Figura figura, Ploca ploca)
        {
            Kralj kralj = null;
            if (figura.Boja == Boja.Bijeli)
                kralj = new Kralj(Boja.Bijeli);
            else
                kralj = new Kralj(Boja.Crni);
            return ploca.VratiFiguruIstogTipaBoje(kralj) as Kralj;
        }

        public override bool PodZastitom(Ploca ploca)
        {
            throw new NotImplementedException();
        }
    }
}
