using System.Collections.Generic;
using Task5.Solution;
using NUnit.Framework;


namespace Task5.Tests
{
    [TestFixture]

    public class Task5SolutionTests
    {
        [Test]
        public void HTMLConverter_Test()
        {
            List<DocumentPart> parts = new List<DocumentPart>
                {
                    new PlainText {Text = "Some plain text"},
                    new Hyperlink {Text = "google.com", Url = "https://www.google.by/"},
                    new BoldText {Text = "Some bold text"}
                };
            Document document = new Document(parts);
            var htmlConverter = new HTMLConverter();

            var expected = "Some plain text\r\n<a href=\"https://www.google.by/\">google.com</a>\r\n<b>Some bold text</b>\r\n";

            Assert.AreEqual(expected, (string)document.Convert(htmlConverter));
        }

        [Test]
        public void PlainConverter_Test()
        {
            List<DocumentPart> parts = new List<DocumentPart>
                {
                    new PlainText {Text = "Some plain text"},
                    new Hyperlink {Text = "google.com", Url = "https://www.google.by/"},
                    new BoldText {Text = "Some bold text"}
                };
            Document document = new Document(parts);
            var plainConverter = new PlainTextConverter();

            var expected = "**Some plain text**\r\ngoogle.com [https://www.google.by/]\r\nSome bold text\r\n";

            Assert.AreEqual(expected, (string)document.Convert(plainConverter));
        }

        [Test]
        public void LaTeXConverter_Test()
        {
            List<DocumentPart> parts = new List<DocumentPart>
                {
                    new PlainText {Text = "Some plain text"},
                    new Hyperlink {Text = "google.com", Url = "https://www.google.by/"},
                    new BoldText {Text = "Some bold text"}
                };
            Document document = new Document(parts);
            var latexConverter = new LaTeXConverter();

            var expected = "Some plain text\r\n\\href{https://www.google.by/}{google.com}\r\n\\textbf{Some bold text}\r\n";

            Assert.AreEqual(expected, (string)document.Convert(latexConverter));
        }



    }
}
