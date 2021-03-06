﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sah.Domena.Iznimke
{
    public class IllegalMoveException : Exception
    {
        public IllegalMoveException(string message) : base(message){}
        public IllegalMoveException(string message,bool nemogucPotez) : base(message)
        {
            this.NemogucPotez = nemogucPotez;
        }
        public bool NemogucPotez { get; set; }
    }
}
