using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleSingletonCSharp
{
    public abstract class SingletonBase
    {
        public void Log(Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }

        public void Log(string message)
        {
            Console.WriteLine(message);
        }
    }
}