using Task5.Solution;

namespace Task5
{
    public class Hyperlink : DocumentPart
    {
        public string Url { get; set; }

        public override string Convert(IDocumentConverter converter)
        {
            return converter.Convert(this);
        }
    }
}
