namespace SingletonPatternExample{
    public class Logger
    {
        private static Logger _instance;


        public static Logger GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Logger();
            }
            return _instance;
        }


    }
}
