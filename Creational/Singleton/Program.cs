namespace Singleton
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            var singleton = Singleton.SingletonInstance;
            var logs = Logger.GetLog();
            logs.ForEach(x => Console.WriteLine(x));

            Console.WriteLine("Hello world end");
        }
    }
}