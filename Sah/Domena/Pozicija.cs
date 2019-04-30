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
        public string PoljeNaPloci()
        {
            string polje = "";
            switch (this.Horizontalno)
            {
                case 0:
                    polje += "a";
                    break;
                case 1:
                    polje += "b";
                    break;
                case 2:
                    polje += "c";
                    break;
                case 3:
                    polje += "d";
                    break;
                case 4:
                    polje += "e";
                    break;
                case 5:
                    polje += "f";
                    break;
                case 6:
                    polje += "g";
                    break;
                case 7:
                    polje += "h";
                    break;
                default:
                    break;
            }
            switch (this.Horizontalno)
            {
                case 0:
                    polje += "1 ";
                    break;
                case 1:
                    polje += "2 ";
                    break;
                case 2:
                    polje += "3 ";
                    break;
                case 3:
                    polje += "4 ";
                    break;
                case 4:
                    polje += "5 ";
                    break;
                case 5:
                    polje += "6 ";
                    break;
                case 6:
                    polje += "7 ";
                    break;
                case 7:
                    polje += "8 ";
                    break;
                default:
                    break;
            }


            return polje;
        }

    }
}