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
            Console.WriteLine($"{DateTime.Now.ToString()} log : {msg}");
        }
    }

    class CustomLogger : ILogger
    {
        public void WriteLog(string msg)
        {
            Console.WriteLine($"Log : {msg}\a\a");  // \a : 알림소리
        }
    }

    class ClimateLogger
    {
        private ILogger logger;
        public ClimateLogger(ILogger logger)
        {
            this.logger = logger;
        }

        public void Start()
        {
            while (true)
            {
                Console.Write("온도를 입력 : ");
                string temp = Console.ReadLine();   //
                if (string.IsNullOrEmpty(temp)) break;

                logger.WriteLog($"현재온도 : {temp}");
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                //ILogger logger = new ILogger();       // 인터페이스의 인스턴스는 만들 수 없음
                ILogger logger = new ConsoleLogger(); // 가능(consolelogger가 ilogger을 상속받았기 때문에)
                //ConsoleLogger logger = new ConsoleLogger();
                logger.WriteLog("로그 출력");   // 직접 제어

                ClimateLogger clogger = new ClimateLogger(new ConsoleLogger());
                clogger.Start();    // 제어 역전, 역흐름0(Inversion of Control(IOC))

               /* ClimateLogger clogger = new ClimateLogger(new CustomLogger()); 
                clogger.Start();    // 제어 역전, 역흐름0(Inversion of Control(IOC))*/
            }
        }
    }
}