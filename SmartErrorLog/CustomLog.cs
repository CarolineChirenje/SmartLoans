using SmartHelper;
using System;
using System.Globalization;
using System.IO;

namespace SmartLog
{
    public class CustomLog
    {
        public static void Log(LogSource errorType, Exception ex)
        {
            SmartHelper.SmartLog log = GetData.SmartLogData();
            if (!log.EnableSmartLog)
                return;

            if (log.LogToFile)
                LogEntryToFile(log.LogDirectory, errorType, ex);

            if (log.LogToDatabase)
                return;

            if (log.LogToRabbitMQ)
                return;
        }

        static void LogEntryToFile(string logDirectory,  LogSource errorType, Exception ex)
        {
            try
            {
                if (String.IsNullOrEmpty(logDirectory))
                    return;

                if (Directory.Exists(logDirectory))
                {
                    string path = $"{logDirectory}\\SmartLog{DateTime.Now.Year}{DateTime.Now.Month}{DateTime.Now.Day}.Log";
                    using (StreamWriter sw = new StreamWriter(path, true))
                    {
                        sw.WriteLine($"{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss:ff", CultureInfo.InvariantCulture)} :{errorType.ToString().Replace("_"," ")} : {ex}");
                        sw.Flush();
                    }
                }
            }
            catch (Exception)
            {

                // throw;
            }

        }
    }
}
