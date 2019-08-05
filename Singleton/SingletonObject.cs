namespace Singleton
{
    public sealed class SingletonObject
    {
        private static volatile SingletonObject _instance = null;
        private static readonly object _lockObject = new object();

        private SingletonObject()
        {
        }

        public static SingletonObject GetInstance()
        {
            if (_instance == null)
            {
                lock(_lockObject)
                {
                    if (_instance == null)
                    {
                        _instance = new SingletonObject();
                    }
                }
            }
            return _instance;
        }

        // additional
        public string Name = "Some Name";
    }
}