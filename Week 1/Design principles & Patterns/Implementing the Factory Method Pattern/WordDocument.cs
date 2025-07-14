namespace FactoryMethodPatternExample
{
    public class WordDocument : IDocument
    {
        public void Open()
        {
            Console.WriteLine("Opening Word Document");
        }
        public void Modify()
        {
            Console.WriteLine("Modifying Word Document");
        }
        public void Save()
        {
            Console.WriteLine("Saving Word Document");
        }
        public void Close()
        {
            Console.WriteLine("Closing Word Document");
        }
    }
    
}
