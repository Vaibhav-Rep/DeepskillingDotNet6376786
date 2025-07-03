namespace FactoryMethodPatternExample
{
    public class Program
    {
        public static void Main(string[] args)
        {
            DocumentFactory wordFactory = new WordDocumentFactory();
            IDocument wordDoc = wordFactory.CreateDocument();
            wordDoc.Open();
            wordDoc.Modify();
            wordDoc.Save();
            wordDoc.Close();


            DocumentFactory pdfFactory = new PdfDocumentFactory();
            IDocument pdfDoc = pdfFactory.CreateDocument();
            pdfDoc.Open();
            pdfDoc.Modify();
            pdfDoc.Save();
            pdfDoc.Close();
           
            DocumentFactory excelFactory = new ExcelDocumentFactory();
            IDocument excelDoc = excelFactory.CreateDocument();
            excelDoc.Open();
            excelDoc.Modify();
            excelDoc.Save();
            excelDoc.Close();
        }
    }
}
