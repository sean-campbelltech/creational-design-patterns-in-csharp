using SimpleSingletonCSharp;

SingletonBase singleton1 = StaticSingletonLogger.GetInstance();
SingletonBase singleton2 = StaticSingletonLogger.GetInstance();

if (singleton1 == singleton2)
{
    Console.WriteLine("Same instance, singleton pattern correctly implemented.");
}

singleton1.Log("This message is logged using a singleton logging system.");
