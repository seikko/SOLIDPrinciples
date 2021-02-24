using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ConsoleSOLIDPrinciples.SRP.Validated
{
   public  class GoodLoggerProcess
    {
        public void LogFile(string filePath,string log)
        {
            File.WriteAllText(filePath, log);
        }
        public string BuildLog(string information)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Data : ");
            sb.AppendLine();
            sb.Append(DateTime.Now.ToString());
            sb.AppendLine();
            sb.Append("Information : ").Append(information);
            return sb.ToString();
        }
    }
}
