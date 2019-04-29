using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sah.Domena;

namespace Sah
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Play game?(0=no)");
            string yes = "yes";
            yes = Console.ReadLine();
            Igrac bijeli = new Igrac(Boja.Bijeli);
            Igrac crni = new Igrac(Boja.Crni);
            Ploca ploca = new Ploca();
            ploca.IspisiPlocu();

            bool gotovo = false;
            //gotovo = ploca.IgraGotova();
            while (!gotovo)
            {
                Pozicija poz = new Pozicija();
                Console.WriteLine("Potez: " + (Ploca.Potez + 1));
                //Figura figura = ploca.VratiFiguru(new Pozicija().PostaviHorizontalno(0).PostaviVertikalno(4));
                //figura.PostaviPoziciju(new Pozicija().PostaviHorizontalno(0).PostaviVertikalno(5), ploca);
                //figura = ploca.VratiFiguru(new Pozicija().PostaviHorizontalno(0).PostaviVertikalno(3));
                //figura.PostaviPoziciju(new Pozicija().PostaviHorizontalno(3).PostaviVertikalno(5), ploca);
                //ploca.IspisiPlocu();
                Console.WriteLine("Bijeli na potezu");
                bool ok = false;
                Figura figura = null;
                string potez = "";
                while (!ok)
                {
                    Console.Write("Odaberite figuru iz polja (npr.A1):");
                    potez = Console.ReadLine();
                    poz = ploca.PozicijaZaPolje(potez);

                    figura = ploca.VratiFiguru(poz);
                    if (figura == null )
                    {
                        continue;
                    }
                        
                    Console.Write("Odigrajte potez (npr. A3):");
                    potez = Console.ReadLine();
                    poz = ploca.PozicijaZaPolje(potez);
                    try
                    {
                        bijeli.OdigrajPotez(figura,poz,ploca);
                        ok = true;
                    }
                    catch (Exception ex)
                    {
                        ok = false;
                        Console.WriteLine(ex.Message);
                    }
                    
                }
                
                
                ploca.IspisiPlocu();

                Console.WriteLine("Crni na potezu");
                ok = false;
                while(!ok)
                {
                    Console.Write("Odaberite figuru iz polja (npr.A1):");
                    potez = Console.ReadLine();
                    poz = ploca.PozicijaZaPolje(potez);
                    figura = ploca.VratiFiguru(poz);
                    if (figura != null)
                        ok = true;
                    Console.Write("Odigrajte potez (npr. A3):");
                    potez = Console.ReadLine();
                    poz = ploca.PozicijaZaPolje(potez);
                    try
                    {
                        crni.OdigrajPotez(figura,poz,ploca);
                        ok = true;
                    }
                    catch (Exception ex)
                    {

                        Console.WriteLine(ex.Message);
                        ok = false;
                        
                    }
                }
                
                
                
                
                
                ploca.IspisiPlocu();
                Ploca.Potez++;

            }
           
        }
    }
}
