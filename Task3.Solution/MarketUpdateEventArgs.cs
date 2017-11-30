using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3.Solution
{
    public class MarketUpdateEventArgs : EventArgs
    {
        public virtual string Msg { get; set; }
    }
}
