using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5.Solution
{
    public class LaTeXConverter : IDocumentConverter
    {
        public string Convert(BoldText bold)
        {
            if (bold == null)
            {
                throw new ArgumentNullException($"{nameof(bold)} is null.");
            }

            return "\\textbf{" + bold.Text + "}";
        }

        public string Convert(PlainText plain)
        {
            if (plain == null)
            {
                throw new ArgumentNullException($"{nameof(plain)} is null.");
            }

            return plain.Text;
        }

        public string Convert(Hyperlink link)
        {
            if (link == null)
            {
                throw new ArgumentNullException($"{nameof(link)} is null.");
            }

            return "\\href{" + link.Url + "}{" + link.Text + "}";
        }
    }
}
