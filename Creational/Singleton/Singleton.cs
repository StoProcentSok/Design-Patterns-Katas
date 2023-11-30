using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public sealed class Singleton
    {
        private static Singleton singletonInstance;

        private Singleton()
        {
            Logger.Log(SingletonLoggerEntries.SingletonConstructorCalledEntry);
        }


        public static Singleton SingletonInstance
        {
            get
            {
                
                if (singletonInstance is null)
                {
                    singletonInstance = new Singleton();
                }

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
