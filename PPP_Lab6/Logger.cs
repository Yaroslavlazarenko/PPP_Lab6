using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPP_Lab6
{
    public abstract class Logger : ILogger
    {
        private readonly string _logFilePath;

        /// <summary>
        /// Получение и изменение пути к логу
        /// </summary>
        public string LogFilePath 
        {
            get => _logFilePath;
            init => _logFilePath = (@$"{value}").Replace(@"\\\", @"\");
        }

        /// <summary>
        /// Конструктор лоррега
        /// </summary>
        /// <param name="logFilePath">Путь к логу</param>
        public Logger(string logFilePath)
        {
            LogFilePath = logFilePath;
        }

        public abstract void Log(string message);
        public abstract void LogInfo(string message);
        public abstract void LogError(string error);

        public override string ToString()
        {
            return $"\nLogFilePath: {LogFilePath}\n";
        }
    }
}
