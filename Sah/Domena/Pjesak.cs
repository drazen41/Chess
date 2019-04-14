using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sah.Domena
{
    public class Pjesak : Figura
    {
        public Pjesak(Boja boja, int id)
        {
            this.Boja = boja;
            this.Id = id;
        }

        public override bool LegalanPotez(Pozicija novaPozicija, Ploca ploca)
        {
            base.LegalanPotez(novaPozicija, ploca);



            return true;
        }

        public override string ToString(Pozicija pozicija)
        {
            //return this.Boja.ToString() + " Pjesak " + pozicija.Horizontalno + "," + pozicija.Vertikalno;
            return "P" + Ploca.SkracenaBoja(this.Boja) + "-" + this.Id;
        }
    }
}
