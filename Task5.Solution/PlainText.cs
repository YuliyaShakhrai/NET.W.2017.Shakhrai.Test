using Task5.Solution;

namespace Task5
{
    public class PlainText : DocumentPart
    {
        public override string Convert(IDocumentConverter converter)
        {
            return converter.Convert(this);
        }
    }
}
