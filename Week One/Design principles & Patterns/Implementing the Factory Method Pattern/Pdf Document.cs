namespace FactoryMethodPatternExample
{
    public class PdfDocument : IDocument
    {
        public void Open()
        {
            Console.WriteLine("Opening PDF Document");
        }
        public void Modify()
        {
            Console.WriteLine("Modifying PDF Document");
        }
        public void Save()
        {
            Console.WriteLine("Saving PDF Document");
        }
        public void Close()
        {
            Console.WriteLine("Closing PDF Document");
        }
    }
}
