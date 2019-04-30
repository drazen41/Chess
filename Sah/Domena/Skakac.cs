using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sah.Domena.Iznimke;

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
            int horizontalno = this.Pozicija.Horizontalno > novaPozicija.Horizontalno ? 
                this.Pozicija.Horizontalno - novaPozicija.Horizontalno : novaPozicija.Horizontalno - this.Pozicija.Horizontalno;
            int vertikalno = this.Pozicija.Vertikalno > novaPozicija.Vertikalno ?
                this.Pozicija.Vertikalno - novaPozicija.Vertikalno : novaPozicija.Vertikalno - this.Pozicija.Vertikalno;
            if (!((horizontalno == 2 && vertikalno == 1) || (horizontalno == 1 && vertikalno == 2)))
                throw new IllegalMoveException("Illegal move");

            var figura = ploca.VratiFiguru(novaPozicija);
            if (figura != null && figura.Boja == this.Boja)
                throw new IllegalMoveException("Figura " + figura.GetType().Name + " na putu.");
            return true;
        }

        public override bool PodZastitom(Ploca ploca)
        {
            throw new NotImplementedException();
        }

        public override string ToString(Pozicija pozicija)
        {
            //return this.Boja.ToString() + " Skakac " + pozicija.Horizontalno + "," + pozicija.Vertikalno;
            return "S" + Ploca.SkracenaBoja(this.Boja) + "-" + this.Id;
        }
    }
}
