using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleSingletonCSharp
{
    public class ClassicSingletonLogger : SingletonBase
    {
        private static ClassicSingletonLogger instance;

        private ClassicSingletonLogger() { }

        public static ClassicSingletonLogger GetInstance()
        {
            if (instance == null)
            {
                instance = new ClassicSingletonLogger();
            }

            return instance;
        }
    }
}