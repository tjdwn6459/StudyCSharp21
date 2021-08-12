using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap08App
{
    interface ILogger
    {
        void WriteLog(string msg);
    }

    class ConsoleLogger : ILogger
    {

        public void WriteLog(string msg)
        {
            Console.WriteLine($"{ DateTime.Now} log : {msg}");
        }

    }

    class ClimateLogger  
    {
        private ILogger logger;

        public ClimateLogger(ILogger logger)
        {
            this.logger = logger;
        }

        public void start()
        {
            while (true)
            {
                Console.WriteLine("온도를 입력:  ");
                string temp = Console.ReadLine(); //입력값을 준다 
                if (string.IsNullOrEmpty(temp)) break;

                logger.WriteLog($"현재온도 : {temp} ");
            }
        }
        
    }

    class Program
    {
        static void Main(string[] args)
        {
            ILogger logger = new ConsoleLogger();
            logger.WriteLog("로그출력");

            ClimateLogger clogger = new ClimateLogger(new ConsoleLogger());
            clogger.start();// IOc (제어의 역전(역흐름))
        }
    }
}
