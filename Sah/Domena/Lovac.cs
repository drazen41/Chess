using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sah.Domena
{
    public class Lovac : Figura
    {
        public Lovac(Boja boja, int id)
        {
            this.Boja = boja;
            this.Id = id;
        }

        public override bool LegalanPotez(Pozicija novaPozicija, Ploca ploca)
        {
            base.LegalanPotez(novaPozicija, ploca);
            int horizontalno = Math.Abs(this.Pozicija.Horizontalno - novaPozicija.Horizontalno);
            int vertikalno = Math.Abs(this.Pozicija.Vertikalno - novaPozicija.Vertikalno);
            if (horizontalno != vertikalno)
                throw new Exception("Illegal move");
            Figura figura = null;
            if (this.Pozicija.Horizontalno > novaPozicija.Horizontalno )
            {
                for (int i = this.Pozicija.Horizontalno; i > novaPozicija.Horizontalno; i--)
                {
                   
                }
            }


            return true;
        }

        public override string ToString(Pozicija pozicija)
        {
            //return this.Boja.ToString() + " Lovac " + pozicija.Horizontalno + "," + pozicija.Vertikalno;
            return "L" + Ploca.SkracenaBoja(this.Boja) + "-" + this.Id;
        }
    }
}
