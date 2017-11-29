using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5.Solution
{
    public interface IDocumentConverter
    {
        string Convert(BoldText bold);
        string Convert(PlainText plain);
        string Convert(Hyperlink link);
    }
}
