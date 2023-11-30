using System.Collections.Concurrent;

namespace Singleton
{
    public static class Logger
    {
        private static ConcurrentQueue<string> _log = new ConcurrentQueue<string>();

        public static void Log(string message)
        {
            _log.Enqueue(message);
        }

        public static void Clear()
        {
            _log.Clear();
        }

        public static List<string> GetLog()
        {
            return _log.ToList();
        }
    }
}
