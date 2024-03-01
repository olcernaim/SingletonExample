using System;

namespace SingletonExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            Logger log1 = Logger.CrateAsSingleton();
            Logger log2 = Logger.CrateAsSingleton();
            Logger log3 = Logger.CrateAsSingleton();

            log3.Info("bla bla");
        }
    }
}
