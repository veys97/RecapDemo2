using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace _02112024_RecapDemo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
        CustomerManager customerManager = new CustomerManager();
        customerManager.Logger = new DatabaseLogger();
        customerManager.Logger = new FileLogger();
        customerManager.Logger = new SmSLogger();
        customerManager.Add();   
        Console.ReadLine();
        }
        #region CustomerManager Class
        class CustomerManager
        {
            public ILogger Logger { get; set; }
            public void Add()
            {
                Logger.Log();
                Console.WriteLine("Customer Added!");
            }
        }
        #endregion
        #region DatabaseLogger Class
        class DatabaseLogger : ILogger
        {
            public void Log()
            {
                Console.WriteLine("Logged to database!");
            }
        }
        #endregion
        #region Interface ILogger
        interface ILogger 
        {
            void Log();
        }
        #endregion
        #region FileLogger Class
        class FileLogger : ILogger
        {
            public void Log()
            {
                Console.WriteLine("Logged to file!");
            }
        }
        #endregion
        #region SmSLogger Class
        class SmSLogger : ILogger
        {
            public void Log()
            {
                Console.WriteLine("Logged to SmS!");
            }
        }
        #endregion
    }
}
