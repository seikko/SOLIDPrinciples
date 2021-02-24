using ConsoleSOLIDPrinciples.SRP.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ConsoleSOLIDPrinciples.SRP.Validated
{
   public class GoodEmployeeProcess
    {
        GoodLoggerProcess _logger;
        string _log;
        public GoodEmployeeProcess()
        {
            _logger = new GoodLoggerProcess();
        }
        //Görüleceği üzere InsertEmployees sadece veri girişinden sorumlu hale gelecek. Son adım olarak void olan metodlarımızı bool tipine çevirerek ekrana yazdırma işlemlerinin consolda yazdırma yapılabilmesi için konsol işinide kolaylaştırcagız.Böylece consol'a yazdırma işlemi Program.cs tarafından yazdırılacak.

        public bool InsertEmployee(Employee newEmployee)
        {
            StringBuilder sb = new StringBuilder();
            try
            {
                sb.Append(newEmployee.ID);
                sb.AppendLine();
                sb.Append(newEmployee.FirstName);
                sb.AppendLine();
                sb.Append(newEmployee.FirstName);
                sb.AppendLine();
                sb.Append(newEmployee.HireDate);
                //burada loglama işlemini GoodLoggerProcess yapacaktır.
                _log = _logger.BuildLog(sb.ToString());
                _logger.LogFile(@"Desktop:\EmployeeData.txt", _log);
                //32 ve 33 üncü satır loglama işlemini yaptı yanı logger sınıfı Yaptı.
                sb = new StringBuilder();
                sb.Append("Personel Added : ");
                sb.AppendLine();
                sb.Append(newEmployee.FirstName);
                sb.AppendLine();
                sb.Append(newEmployee.LastName);
                _log = _logger.BuildLog(sb.ToString());
                _logger.LogFile(@"Desktop:\Log.txt", _log);
                return true;
            }
            catch (Exception ex)
            {
                sb = new StringBuilder();
                sb.Append("Hata mesajı : ");
                sb.AppendLine();
                sb.Append(ex.Message);
                _log = _logger.BuildLog(sb.ToString());
                _logger.LogFile(@"Desktop:\LogHata.txt", _log);
                return false;
                
            }
        }
    }
}
