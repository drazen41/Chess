using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sah.Domena
{
    public class Skakac : Figura
    {
        public Skakac(Boja boja, int id)
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
            //return this.Boja.ToString() + " Skakac " + pozicija.Horizontalno + "," + pozicija.Vertikalno;
            return "S" + Ploca.SkracenaBoja(this.Boja) + "-" + this.Id;
        }
    }
}
