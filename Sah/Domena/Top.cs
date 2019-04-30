using Sah.Domena.Iznimke;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sah.Domena
{
    public class Top : Figura
    {
        public Top(Boja boja, int id)
        {
            this.Boja = boja;
            this.Id = id;
        }

        public override bool LegalanPotez(Pozicija novaPozicija, Ploca ploca)
        {
            base.LegalanPotez(novaPozicija, ploca);
           
            Figura figura = null;
            if (this.Pozicija.Horizontalno != novaPozicija.Horizontalno && this.Pozicija.Vertikalno != novaPozicija.Vertikalno)
                throw new IllegalMoveException("Illegal move", true);
            if (this.Pozicija.Vertikalno < novaPozicija.Vertikalno)
            {
                for (int i = this.Pozicija.Vertikalno + 1; i <= novaPozicija.Vertikalno; i++)
                {
                    figura = ploca.VratiFiguru(new Pozicija().PostaviHorizontalno(novaPozicija.Horizontalno).PostaviVertikalno(i));
                                       
                    if (figura != null && figura.Boja == this.Boja)
                        throw new IllegalMoveException("Figura " + figura.GetType().Name + " na putu.");
                    else if (figura != null && figura.Pozicija.Vertikalno < novaPozicija.Vertikalno)
                        throw new IllegalMoveException("Figura " + figura.GetType().Name + " na putu.");
                }
            }
            if (this.Pozicija.Vertikalno > novaPozicija.Vertikalno)
            {
                for (int i = this.Pozicija.Vertikalno - 1; i >= novaPozicija.Vertikalno; i--)
                {
                    figura = ploca.VratiFiguru(new Pozicija().PostaviHorizontalno(novaPozicija.Horizontalno).PostaviVertikalno(i));
                    if (figura != null && figura.Boja == this.Boja)
                        throw new IllegalMoveException("Figura " + figura.GetType().Name + " na putu.");
                    else if (figura != null && figura.Pozicija.Horizontalno < novaPozicija.Horizontalno)
                        throw new IllegalMoveException("Figura " + figura.GetType().Name + " na putu.");
                }

            }
            
            if (this.Pozicija.Horizontalno < novaPozicija.Horizontalno)
            {
                for (int i = this.Pozicija.Horizontalno + 1; i <= novaPozicija.Horizontalno; i++)
                {
                    figura = ploca.VratiFiguru(new Pozicija().PostaviHorizontalno(i).PostaviVertikalno(novaPozicija.Vertikalno));
                    if (figura != null && figura.Boja == this.Boja)
                        throw new IllegalMoveException("Figura " + figura.GetType().Name + " na putu.");
                    else if (figura != null && figura.Pozicija.Horizontalno < novaPozicija.Horizontalno)
                        throw new IllegalMoveException("Figura " + figura.GetType().Name + " na putu.");
                }
            }
            if (this.Pozicija.Horizontalno > novaPozicija.Horizontalno)
            {
                for (int i = this.Pozicija.Horizontalno - 1; i >= novaPozicija.Horizontalno; i--)
                {
                    figura = ploca.VratiFiguru(new Pozicija().PostaviHorizontalno(i).PostaviVertikalno(novaPozicija.Vertikalno));
                    if (figura != null && figura.Boja == this.Boja)
                        throw new IllegalMoveException("Figura " + figura.GetType().Name + " na putu.");
                    else if (figura != null && figura.Pozicija.Horizontalno < novaPozicija.Horizontalno)
                        throw new IllegalMoveException("Figura " + figura.GetType().Name + " na putu.");
                }
            }
            
            var kralj = Kralj.VratiKraljaSaPloce(this, ploca);

            return true;
        }
        public override string ToString(Pozicija pozicija)
        {
            //return this.Boja.ToString() + " Top " + pozicija.Horizontalno + "," + pozicija.Vertikalno;   
            return "T" + Ploca.SkracenaBoja(this.Boja) + "-" + this.Id;
        }

        
    }
}
