using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson9_Abstraction_LoggerExample
{
    public class ConsoleLogger : Logger
    {
        public override void Delete(Guid id)
        {
            Log l = Search(id);
            Logs.Remove(l);
        }

        public override void Log(Log log)
        {
            Logs.Add(log);
            Console.WriteLine($"Message: {log.Message}, Date: {log.Date}, Type: {log.Type}, It happened: {log.WhereItHappened}");
        }

        public override void MarkAsReviewed(Guid id)
        {
            Log l = Search(id);
            if(l != null)
            {
                l.Reviewed = true;
            }
        }

        public override Log Search(Guid id)
        {
            foreach(Log item in Logs)
            {
                if(item.Id == id)
                {
                    return item;
                }
            }
            return null;
        }

        public void ShowLog(Log log)
        {
            Console.WriteLine($"Message: {log.Message}, Date: {log.Date}, Type: {log.Type}, It happened: {log.WhereItHappened}");
        }
    }
}
