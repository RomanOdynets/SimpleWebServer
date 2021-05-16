using System;
using System.Threading;
using SimpleWebServer.Core;

namespace SimpleWebServer
{
    class Program
    {
        public const bool IsDebugEnabled = true;
        public const string DefaultFileName = "index.html";
        public const string FileFolder = "www";
        static void Main(string[] args)
        {
            var maxThreadsCount = Environment.ProcessorCount * 4;
            ThreadPool.SetMaxThreads(maxThreadsCount, maxThreadsCount);
            ThreadPool.SetMinThreads(2, 2);

            var server = new Server();

            Console.ReadLine();
        }
    }
}