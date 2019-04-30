using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sah.Domena.Iznimke;

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
                throw new IllegalMoveException("Illegal move",true);
            Figura figura = null;
            if (this.Pozicija.Horizontalno > novaPozicija.Horizontalno )
            {
                int ver = this.Pozicija.Vertikalno;
                for (int i = this.Pozicija.Horizontalno; i > novaPozicija.Horizontalno; i--)
                {
                    int hor = i - 1;
                    if (this.Pozicija.Vertikalno > novaPozicija.Vertikalno)
                    {
                        figura = ploca.VratiFiguru(new Pozicija().PostaviHorizontalno(hor).PostaviVertikalno(--ver));
                        if (figura != null)
                        {
                            if (hor == novaPozicija.Horizontalno && ver == novaPozicija.Vertikalno)
                            {
                                if (this.Boja == figura.Boja)
                                    throw new IllegalMoveException("Figura " + figura.GetType().Name + " na putu.");
                            }
                            else
                            {
                                throw new IllegalMoveException("Figura " + figura.GetType().Name + " na putu.");
                            }
                        }
                    }
                    else
                    {
                        figura = ploca.VratiFiguru(new Pozicija().PostaviHorizontalno(hor).PostaviVertikalno(++ver));
                        if (figura != null)
                        {
                            if (hor == novaPozicija.Horizontalno && ver == novaPozicija.Vertikalno)
                            {
                                if (this.Boja == figura.Boja)
                                    throw new IllegalMoveException("Figura " + figura.GetType().Name + " na putu.");
                            }
                            else
                            {
                                throw new IllegalMoveException("Figura " + figura.GetType().Name + " na putu.");
                            }
                        }
                    }
                }
            } else
            {
                int ver = this.Pozicija.Vertikalno;
                for (int i = this.Pozicija.Horizontalno; i < novaPozicija.Horizontalno; i++)
                {
                    int hor = i + 1;
                    
                    if (this.Pozicija.Vertikalno > novaPozicija.Vertikalno)
                    {
                        //ver = this.Pozicija.Vertikalno - i;
                        figura = ploca.VratiFiguru(new Pozicija().PostaviHorizontalno(hor).PostaviVertikalno(--ver));
                        if (figura != null)
                        {
                            if (hor == novaPozicija.Horizontalno && ver == novaPozicija.Vertikalno)
                            {
                                if (this.Boja == figura.Boja)
                                    throw new IllegalMoveException("Figura " + figura.GetType().Name + " na putu.");
                            }
                            else
                            {
                                throw new IllegalMoveException("Figura " + figura.GetType().Name + " na putu.");
                            }
                        }
                    }
                    else
                    {
                        
                        figura = ploca.VratiFiguru(new Pozicija().PostaviHorizontalno(hor).PostaviVertikalno(++ver));
                        if (figura != null)
                        {
                            if (hor == novaPozicija.Horizontalno && ver == novaPozicija.Vertikalno)
                            {
                                if (this.Boja == figura.Boja)
                                    throw new IllegalMoveException("Figura " + figura.GetType().Name + " na putu.");
                            }
                            else
                            {
                                throw new IllegalMoveException("Figura " + figura.GetType().Name + " na putu.");
                            }
                        }

                    }
                    
                        
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
