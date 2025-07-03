namespace FactoryMethodPatternExample
{
    public interface IDocument
    {
        void Open();
        void Modify();
        void Save();
        void Close();
    }


    public abstract class DocumentFactory
    {
        public abstract IDocument CreateDocument();
    }


    public class WordDocumentFactory : DocumentFactory
    {
        public override IDocument CreateDocument()
        {
            return new WordDocument();
        }
    }
    public class PdfDocumentFactory : DocumentFactory
    {
        public override IDocument CreateDocument()
        {
            return new PdfDocument();
        }
    }
    public class ExcelDocumentFactory : DocumentFactory
    {
        public override IDocument CreateDocument()
        {
            return new ExcelDocument();
        }
    }
   
}
