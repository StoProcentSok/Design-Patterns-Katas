namespace Singleton
{
    public sealed class Singleton
    {
        private static Singleton? singletonInstance;
        //Lazy<T> apporach:
        //public static readonly Lazy<Singleton> lazy = new Lazy<Singleton>(() => new Singleton());

        private Singleton()
        {
            Logger.Log(SingletonLoggerEntries.SingletonConstructorCalledEntry);
        }


        public static Singleton SingletonInstance
        {
            get
            {
                singletonInstance ??= new Singleton();

                Logger.Log(SingletonLoggerEntries.SingletonInstanceReturnedEntry);
                return singletonInstance;
            }
        }
    }

    public static class SingletonLoggerEntries
    {
        public static string SingletonConstructorCalledEntry = "Singleton constructor called";
        public static string SingletonInstanceReturnedEntry = "Singleton instance returned";
    }
}
