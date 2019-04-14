using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sah.Domena
{
    public class Igrac
    {
        public Boja Boja { get; set; }
        public Igrac(Boja boja)
        {
            this.Boja = boja;
        }
        public bool DobraFigura(Figura figura)
        {
            return this.Boja == figura.Boja;
        }
    }
}
