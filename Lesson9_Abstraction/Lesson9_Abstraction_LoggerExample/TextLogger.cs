using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson9_Abstraction_LoggerExample
{
    public class TextLogger : Logger, IFileHandler
    {
        public void Export(string filename)
        {
            //list of logs ====> an array of strings
            string[] lines = new string[Logs.Count];
            for (int i = 0; i < Logs.Count; i++ )
            {
                Log log = Logs[i];
                lines[i] = $"Message: {log.Message}, Date: {log.Date}, Type: {log.Type}, It happened: {log.WhereItHappened}";       
            }

            if (System.IO.File.Exists(filename))
            {
                System.IO.File.Delete(filename);
            }

            System.IO.File.WriteAllLines(filename, lines);
        }

        public override void Delete(Guid id)
        {
            Log l = Search(id);
            Logs.Remove(l);
        }

        public override void Log(Log log)
        {
            Logs.Add(log);
        }

        public override void MarkAsReviewed(Guid id)
        {
            Log l = Search(id);
            if (l != null)
            {
                l.Reviewed = true;
            }
        }

        public override Log Search(Guid id)
        {
            foreach (Log item in Logs)
            {
                if (item.Id == id)
                {
                    return item;
                }
            }
            return null;
        }
    }
}
