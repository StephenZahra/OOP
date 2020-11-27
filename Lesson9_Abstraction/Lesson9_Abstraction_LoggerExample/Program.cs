using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson9_Abstraction_LoggerExample
{
    class Program
    {
        static void Main(string[] args)
        {
            TextLogger myLogger = new TextLogger();

            myLogger.Log(new Log()
            {
                Id = Guid.NewGuid(),
                Date = DateTime.Now,
                Message = "This is my first log",
                Reviewed = false,
                Type = LogType.Info, WhereItHappened="Main Method"
            }) ;
        }
    }
}
