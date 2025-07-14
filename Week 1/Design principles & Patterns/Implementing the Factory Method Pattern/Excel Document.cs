namespace FactoryMethodPatternExample
{
    public class ExcelDocument : IDocument
    {
        public void Open()
        {
            Console.WriteLine("Opening Excel Document");
        }
        public void Modify()
        {
            Console.WriteLine("Modifying Excel Document");
        }
        public void Save()
        {
            Console.WriteLine("Saving Excel Document");
        }
        public void Close()
        {
            Console.WriteLine("Closing Excel Document");
        }
    }
    
}
