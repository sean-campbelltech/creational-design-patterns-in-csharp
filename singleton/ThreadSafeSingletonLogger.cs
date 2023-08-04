using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleSingletonCSharp
{
    public class ThreadSafeSingletonLogger : SingletonBase
    {
        private static readonly object threadsafeLock = new object();
        private static ThreadSafeSingletonLogger instance;

        private ThreadSafeSingletonLogger() { }

        public static ThreadSafeSingletonLogger GetInstance()
        {
            if (instance == null)
            {
                lock (threadsafeLock)
                {
                    if (instance == null)
                    {
                        instance = new ThreadSafeSingletonLogger();
                    }
                }
            }

            return instance;
        }
    }
}