﻿using System;


//interface 계약을 정의한다 (기본구성에 대한 기본 구현을 정의)
namespace LoggerTestApp
{

    //ILogger 클래쓰는 매개변수가 없고 void 를 반환하는 writeLog 메서드를 구현
    interface ILogger
    {

        void WriteLog(string message);
    }

    class ConsoleLogger : ILogger
    {
        public void WriteLog(string message)
        {
            //DateTime.Now 현재시간을 나타낸다 
            Console.WriteLine($"{DateTime.Now} : { message}");
        }
    }

    interface IFormattableLogger : ILogger
    {
        void WriteLog(string format, params Object[] args);
    }

    class ConsoleFormatLogger : IFormattableLogger
    {
        public void WriteLog(string format, params object[] args)
        {
            string message = String.Format(format, args); //?
            Console.WriteLine($"{DateTime.Now.ToLocalTime()} / {message}");
        }

        public void WriteLog(string message)
        {
            Console.WriteLine($"{DateTime.Now.ToLocalTime()} / {message}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ConsoleLogger 테스트");
            ConsoleLogger logger = new ConsoleLogger();
            logger.WriteLog("로그메세지");

            IFormattableLogger logger2 = new ConsoleFormatLogger();
            logger2.WriteLog("{0} * {1} = {2}", 3, 4, 12); //IFormattableLogger.WriteLog (format, args);
        }
    }
}
