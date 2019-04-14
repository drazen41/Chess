using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sah.Domena.Events;
using Sah.Domena.Iznimke;

namespace Sah.Domena
{
    public abstract class Figura
    {
        public event EventHandler OnPozicijaSeMijenja;
        public event EventHandler OnPozicijaPromijenjena;
        public Pozicija Pozicija { get; set; }
        public Boja Boja { get; protected set; }
        public int Id { get; protected set; }
        public Figura()
        {
            
        }
        public Figura PostaviPoziciju(Pozicija pozicija )
        {
            if (Ploca.Potez != 0)
                throw new Exception("Krivi poziv metode");
            this.Pozicija = pozicija;
            return this;
        }
        
        public Figura PostaviPoziciju(Pozicija pozicija, Ploca ploca)
        {
            this.OnPozicijaSeMijenja += PozicijaSeMijenja;
            this.OnPozicijaPromijenjena += PozicijaPromijenjena;
            OnPozicijaSeMijenja(this, new PozicijaEventArgs { Pozicija = pozicija, Ploca = ploca });
            OnPozicijaPromijenjena(this, new PozicijaEventArgs { Pozicija = pozicija, Ploca = ploca });
            this.Pozicija = pozicija;

            return this;
        }

        private void PozicijaPromijenjena(object sender, EventArgs e)
        {
            PozicijaEventArgs pea = e as PozicijaEventArgs;
            Ploca ploca = pea.Ploca;
            Figura figura = sender as Figura;
            Pozicija pozicija = pea.Pozicija;
            ploca.AzurirajStanje(figura, pozicija);

        }

        public virtual bool LegalanPotez(Pozicija pozicija, Ploca ploca)
        {
            if (this.Pozicija.Horizontalno == pozicija.Horizontalno && this.Pozicija.Vertikalno == pozicija.Vertikalno)
                throw new NoMoveException("No move");
            return true;
        }
        public void PozicijaSeMijenja(object sender, EventArgs eventArgs)
        {
            Figura figura = (Figura)sender;
            PozicijaEventArgs pea = eventArgs as PozicijaEventArgs;
            if (figura.Pozicija != null) 
                figura.LegalanPotez(pea.Pozicija, pea.Ploca);
        }
        public abstract string ToString(Pozicija pozicija);
    }
}
