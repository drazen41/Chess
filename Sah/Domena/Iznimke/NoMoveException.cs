using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sah.Domena.Iznimke
{
    public class NoMoveException : Exception
    {
        public NoMoveException(string message) : base(message){}
    }
}
