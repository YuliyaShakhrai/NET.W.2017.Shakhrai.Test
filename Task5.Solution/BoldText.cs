using Task5.Solution;

namespace Task5
{
    public class BoldText : DocumentPart
    {
        public override string Convert(IDocumentConverter converter)
        {
            return converter.Convert(this);
        }
    }
}