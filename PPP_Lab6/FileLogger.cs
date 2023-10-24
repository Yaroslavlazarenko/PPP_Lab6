using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPP_Lab6
{
    public class FileLogger : Logger
    {
        private DateTime _loggerCreateDate;
        private string _logFileName;
        private string _loggerName;

        /// <summary>
        /// Получение и изменение даты создания логгера
        /// </summary>
        public DateTime LoggerCreateDate
        {
            get => _loggerCreateDate;
            set => _loggerCreateDate = value; 
        }

        /// <summary>
        /// Добавление и изменение название файла куда сохраняется лог
        /// </summary>
        public string LogFileName
        {
            get => _logFileName;
            set => _logFileName = !string.IsNullOrEmpty(value) ? value.Trim() : throw new Exception("Строка пуста или равна null.");
        }

        /// <summary>
        /// Добавление и изменение имени логгера
        /// </summary>
        public string LoggerName
        {
            get => _loggerName;
            set => _loggerName = !string.IsNullOrEmpty(value) ? value.Trim() : throw new Exception("Строка пуста или равна null.");
        }

        /// <summary>
        /// Конструктор логгера
        /// </summary>
        /// <param name="logFilePath">Путь к логу</param>
        /// <param name="loggerCreateDate">Дата создания логгера</param>
        /// <param name="logFileName">Имя файла для лога</param>
        /// <param name="loggerName">Имя логгера</param>
        public FileLogger(string logFilePath, DateTime loggerCreateDate, string logFileName, string loggerName) : base(logFilePath)
        {
            LoggerCreateDate = loggerCreateDate;
            LogFileName = logFileName;
            LoggerName = loggerName;
        }

        /// <summary>
        /// Метод логирования в файл
        /// </summary>
        /// <param name="content">Информация которую нужно залогировать</param>
        /// <exception cref="Exception">Информация должна быть не пустой</exception>
        public override void Log(string content)
        {
            if(!string.IsNullOrEmpty(content))
            {
                try
                {
                    File.WriteAllText(@$"{base.LogFilePath}{LogFileName}.txt", content);
                    LogInfo($"Путь: {base.LogFilePath}.");
                }
                catch (Exception e)
                {
                    LogError($"{e.Message}");
                }
            }
            else
            {
                LogError("Строка пуста или равна null.");
                throw new ArgumentException("Строка пуста или равна null.");
            }
        }

        /// <summary>
        /// Информация если лог успешен
        /// </summary>
        /// <param name="message">Сообщение что нужно вывести</param>
        public override void LogInfo(string message)
        {
            Console.WriteLine($"Файл {LogFileName} был успешно создан.{message}");
        }

        /// <summary>
        /// Информация о ошибке логгера
        /// </summary>
        /// <param name="error">Ошибка что нужно вывести</param>
        public override void LogError(string error)
        {
            Console.WriteLine($"Произошла ошибка при записи в файл {LogFileName}: {error}");
        }

        public override string ToString()
        {
            return $"{base.ToString()}LoggerCreateDate: {LoggerCreateDate},\nLogFileName: {LogFileName},\nLoggerName: {LoggerName}.\n";
        }
    }
}
