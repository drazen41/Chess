using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sah.Domena;

namespace Sah.Domena.Events
{
    public class PozicijaEventArgs : EventArgs
    {
        public Pozicija Pozicija { get; set; }
        public Ploca Ploca { get; set; }
    }
}
