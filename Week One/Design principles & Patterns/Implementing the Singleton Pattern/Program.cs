namespace SingletonPatternExample
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Logger logger1 = Logger.GetInstance();
            Logger logger2 = Logger.GetInstance();


            Console.WriteLine("HashCode of Logger 1: " + logger1.GetHashCode());
            Console.WriteLine("HashCode of Logger 2: " + logger2.GetHashCode());


            if (logger1 == logger2)
            {
                Console.WriteLine("Both logger1 and logger2 are the same instance.");
            }
        }
    }
}
