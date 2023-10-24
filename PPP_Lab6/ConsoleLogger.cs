using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPP_Lab6
{
    public class ConsoleLogger : Logger
    {
        private DateTime _loggerCreateDate;
        private int _numberOfSuccessfulLogs = 0;
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
        /// Получение и изменение имени логгера
        /// </summary>
        public string LoggerName
        {
            get => _loggerName;
            set => _loggerName = !string.IsNullOrEmpty(value) ? value.Trim() : throw new ArgumentException("Строка пуста или равна null.");
        }

        /// <summary>
        /// Конструктор консоль логгера
        /// </summary>
        /// <param name="logFilePath">Путь к логу</param>
        /// <param name="loggerCreateDate">Время создания логгера</param>
        /// <param name="loggerName">Имя логгера</param>
        public ConsoleLogger(string logFilePath, DateTime loggerCreateDate, string loggerName) : base(logFilePath)
        {
            LoggerCreateDate = loggerCreateDate;
            LoggerName = loggerName;
        }

        /// <summary>
        /// Метод логирования в конлось
        /// </summary>
        /// <param name="content">Строка, должна быть не пустой</param>
        public override void Log(string content)
        {
            if (!string.IsNullOrEmpty(content))
            {
                Console.WriteLine(content);
                LogInfo($"Это {++_numberOfSuccessfulLogs} удачное логирование.");
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
            Console.WriteLine($"Успешное логирование в консоль выше. {message}");
        }

        /// <summary>
        /// Информация о ошибке логгера
        /// </summary>
        /// <param name="error">Ошибка что нужно вывести</param>
        public override void LogError(string error)
        {
            Console.WriteLine($"Неудачное ({_numberOfSuccessfulLogs + 1}) логирование в консоль: {error}");
        }

        /// <summary>
        /// Переопределение вывода класса ConsoleLogger
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{base.ToString()}LoggerCreateDate: {LoggerCreateDate},\nNumberOfSuccessfulLogs: {_numberOfSuccessfulLogs},\nLoggerName: {LoggerName}.\n";
        }
    }
}
