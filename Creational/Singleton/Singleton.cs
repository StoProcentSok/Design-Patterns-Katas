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
            Logger.Log("Singleton constructor called");
        }


        public static Singleton SingletonInstance
        {
            get
            {
                
                if (singletonInstance is null)
                {
                    singletonInstance = new Singleton();
                }

                Logger.Log("Singleton returned");
                return singletonInstance;
            }
        }
    }
}
