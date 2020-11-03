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

            
            // creates instance of company
            Company company = new Company();

              // validation test  
          //  company.hireEmployee("Jane", "", "333-33-3333");

            // hires employee 
            company.hireEmployee("John", "Doe", "444-44-4444");

            logger.Info("Program has ended");
        }
    }
}
