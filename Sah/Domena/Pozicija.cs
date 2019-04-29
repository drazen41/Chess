using System;
using Sah.Domena.Events;
namespace Sah.Domena
{
    public class Pozicija
    {
        public event EventHandler OnPozicijaSeMijenja;
        public int Horizontalno { get; private set; }
        public int Vertikalno { get; private set; }
        public Pozicija()
        {
            
        }
        //public Pozicija(int horizontalno, int vertikalno)
        //{
            
        //    this.Horizontalno = horizontalno;
        //    this.Vertikalno = vertikalno;
        //}
        public Pozicija PostaviHorizontalno(int vrijednost)
        {
            if (this == null)
            {
                Pozicija pozicija = new Pozicija();
                pozicija.Horizontalno = vrijednost;
                return pozicija;
            }
            else
            {
                this.Horizontalno = vrijednost;
                return this;
            }
            
        }
        public Pozicija PostaviVertikalno(int vrijednost)
        {
            if (this == null)
            {
                Pozicija pozicija = new Pozicija();
                pozicija.Vertikalno = vrijednost;
                return pozicija;
            }
            else
            {
                this.Vertikalno = vrijednost;
                return this;
            }
            
        }
        

    }
}