using System;
using NLog.Web;
using System.IO;
namespace CompanyHR
{
    class Program
    {
        private static NLog.Logger logger = NLogBuilder.ConfigureNLog(Directory.GetCurrentDirectory() + "\\nlog.config").GetCurrentClassLogger();
        static void Main(string[] args)
        {
            logger.Info("Program has Started");

            Console.WriteLine("Hello World!");

            logger.Info("Program has ended");
        }
    }
}
