using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sah.Domena
{
    public class Kraljica : Figura
    {
        public Kraljica(Boja boja)
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
            //return this.Boja.ToString() + " Kraljica " + pozicija.Horizontalno + "," + pozicija.Vertikalno;
            return "Q" + Ploca.SkracenaBoja(this.Boja) + "-" + this.Id;
        }
    }
}
