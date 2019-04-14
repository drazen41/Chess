using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SahTests
{
    public class Adder
    {
        public event EventHandler OnMultipleOfFiveReached;

        public int Add(int x, int y)
        {
            int iSum = x + y;
            if ((iSum % 5 == 0) && (OnMultipleOfFiveReached != null))
            { OnMultipleOfFiveReached(this, EventArgs.Empty); }
            return iSum;
        }
    }
}
