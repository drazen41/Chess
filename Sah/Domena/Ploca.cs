using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sah.Domena
{
    public class Ploca
    {
        private Figura[,] stanje ;
        private Dictionary<string, Figura> dict;
        private Dictionary<Pozicija, Figura> pozicijaFigura;
        public static int Potez = 0;

        public static bool KraljSahiran { get; internal set; }

        public Ploca()
        {
            stanje = new Figura[8, 8];
            dict = new Dictionary<string, Figura>();
            pozicijaFigura = new Dictionary<Pozicija, Figura>();
            Inicijalizacija();
            PostaviDict();
        }

        internal bool IgraGotova()
        {
            throw new NotImplementedException();
        }

        private void PostaviDict()
        {
            string kol = "";
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    kol = PoljeZaKolonu(j) + (i+1);
                    dict[kol] = stanje[i, j];
                    if (stanje[i,j] != null)
                        pozicijaFigura[stanje[i, j].Pozicija] = stanje[i, j];
                }
            }
        }
        public string PoljeZaKolonu(int kolona )
        {
            string kol = "";
            switch (kolona)
            {
                case 0:
                    kol = "A";
                    break;
                case 1:
                    kol = "B";
                    break;
                case 2:
                    kol = "C";
                    break;
                case 3:
                    kol = "D";
                    break;
                case 4:
                    kol = "E";
                    break;
                case 5:
                    kol = "F";
                    break;
                case 6:
                    kol = "G";
                    break;
                case 7:
                    kol = "H";
                    break;
                default:
                    break;
            }
            return kol;
        }
        public Pozicija PozicijaZaPolje(string polje)
        {
            var slovo = polje[0].ToString().ToUpper();
            var kolona = polje[1].ToString();
            Pozicija pozicija = new Pozicija();
            switch (slovo)
            {
                case "A":
                    pozicija.PostaviVertikalno(0).PostaviHorizontalno(int.Parse(kolona)-1);
                    break;
                case "B":
                    pozicija.PostaviVertikalno(1).PostaviHorizontalno(int.Parse(kolona) - 1);
                    break;
                case "C":
                    pozicija.PostaviVertikalno(2).PostaviHorizontalno(int.Parse(kolona) - 1);
                    break;
                case "D":
                    pozicija.PostaviVertikalno(3).PostaviHorizontalno(int.Parse(kolona) - 1);
                    break;
                case "E":
                    pozicija.PostaviVertikalno(4).PostaviHorizontalno(int.Parse(kolona) - 1);
                    break;
                case "F":
                    pozicija.PostaviVertikalno(5).PostaviHorizontalno(int.Parse(kolona) - 1);
                    break;
                case "G":
                    pozicija.PostaviVertikalno(6).PostaviHorizontalno(int.Parse(kolona) - 1);
                    break;
                case "H":
                    pozicija.PostaviVertikalno(7).PostaviHorizontalno(int.Parse(kolona) - 1);
                    break;
                
                default:
                    break;
            }
            return pozicija;

        }
        private void Inicijalizacija()
        {
            stanje[0, 0] = new Top(Boja.Bijeli,1).PostaviPoziciju(new Pozicija().PostaviHorizontalno(0).PostaviVertikalno(0));
            stanje[0, 1] = new Skakac(Boja.Bijeli,1).PostaviPoziciju(new Pozicija().PostaviHorizontalno(0).PostaviVertikalno(1));
            stanje[0, 2] = new Lovac(Boja.Bijeli,1).PostaviPoziciju(new Pozicija().PostaviHorizontalno(0).PostaviVertikalno(2));
            stanje[0, 3] = new Kraljica(Boja.Bijeli).PostaviPoziciju(new Pozicija().PostaviHorizontalno(0).PostaviVertikalno(3));
            stanje[0, 4] = new Kralj(Boja.Bijeli).PostaviPoziciju(new Pozicija().PostaviHorizontalno(0).PostaviVertikalno(4));
            stanje[0, 5] = new Lovac(Boja.Bijeli,2).PostaviPoziciju(new Pozicija().PostaviHorizontalno(0).PostaviVertikalno(5));
            stanje[0, 6] = new Skakac(Boja.Bijeli,2).PostaviPoziciju(new Pozicija().PostaviHorizontalno(0).PostaviVertikalno(6));
            stanje[0, 7] = new Top(Boja.Bijeli,2).PostaviPoziciju(new Pozicija().PostaviHorizontalno(0).PostaviVertikalno(7));
            for (int i = 0; i < 8; i++)
            {
                stanje[1, i] = new Pjesak(Boja.Bijeli,i+1).PostaviPoziciju(new Pozicija().PostaviHorizontalno(1).PostaviVertikalno(i));
            }
            stanje[7, 0] = new Top(Boja.Crni,1).PostaviPoziciju(new Pozicija().PostaviHorizontalno(7).PostaviVertikalno(0));
            stanje[7, 1] = new Skakac(Boja.Crni,1).PostaviPoziciju(new Pozicija().PostaviHorizontalno(7).PostaviVertikalno(1));
            stanje[7, 2] = new Lovac(Boja.Crni,1).PostaviPoziciju(new Pozicija().PostaviHorizontalno(7).PostaviVertikalno(2));
            stanje[7, 3] = new Kraljica(Boja.Crni).PostaviPoziciju(new Pozicija().PostaviHorizontalno(7).PostaviVertikalno(3));
            stanje[7, 4] = new Kralj(Boja.Crni).PostaviPoziciju(new Pozicija().PostaviHorizontalno(7).PostaviVertikalno(4));
            stanje[7, 5] = new Lovac(Boja.Crni,2).PostaviPoziciju(new Pozicija().PostaviHorizontalno(7).PostaviVertikalno(5));
            stanje[7, 6] = new Skakac(Boja.Crni,2).PostaviPoziciju(new Pozicija().PostaviHorizontalno(7).PostaviVertikalno(6));
            stanje[7, 7] = new Top(Boja.Crni,2).PostaviPoziciju(new Pozicija().PostaviHorizontalno(7).PostaviVertikalno(7));
            for (int i = 0; i < 8; i++)
            {
                stanje[6, i] = new Pjesak(Boja.Crni,i+1).PostaviPoziciju(new Pozicija().PostaviHorizontalno(6).PostaviVertikalno(i));
            }
        }

        internal void AzurirajStanje(Figura figura, Pozicija novaPozicija)
        {
            var staraPozicija = figura.Pozicija;
            pozicijaFigura[staraPozicija] = null;
            
            stanje[figura.Pozicija.Horizontalno, figura.Pozicija.Vertikalno] = null;
            string kljuc = PoljeZaKolonu(figura.Pozicija.Vertikalno) + (figura.Pozicija.Horizontalno+1);
            var fig = dict[kljuc];
            dict[kljuc] = null;
            figura.Pozicija = novaPozicija;
            pozicijaFigura[novaPozicija] = figura;
            kljuc = PoljeZaKolonu(novaPozicija.Vertikalno) + novaPozicija.Horizontalno;
            dict[kljuc] = figura;
            stanje[novaPozicija.Horizontalno, novaPozicija.Vertikalno] = figura;
        }
        
        public Figura VratiFiguru(Pozicija pozicija)
        {
            return stanje[pozicija.Horizontalno, pozicija.Vertikalno];
        }
        public void IspisiPlocu()
        {
            
            //Console.SetWindowSize(600, 400);
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (stanje[i, j] == null)
                        Console.Write("----");
                    else
                    {
                        Figura figura = stanje[i, j];
                        Console.Write(figura.ToString(figura.Pozicija));
                    }
                    Console.Write("  |  ");   
                    
                }
                Console.WriteLine();
                Console.Write("--------------------------------------------------------------------");
                Console.WriteLine();

            }
        }
        public static string SkracenaBoja(Boja boja)
        {
            switch (boja)
            {
                case Boja.Crni:
                    return "c";
                case Boja.Bijeli:
                    return "b";
                default:
                    break;
            }
            return "";
        }
    }
}
