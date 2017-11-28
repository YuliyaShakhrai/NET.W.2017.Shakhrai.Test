using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3.Solution
{
    public sealed class MarketUpdateEventArgs : EventArgs
    {
        public string Msg { get; set; }
    }
}
