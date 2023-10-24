using System.Reflection;
using System.Text;

namespace PPP_Lab6
{
    public class LoggersArray
    {
        private Logger[] _loggers;
        public Logger[] Loggers => _loggers;

        /// <summary>
        /// Зоздание массива с логами и добавление в него сразу необходимое количество
        /// </summary>
        /// <param name="loggers"></param>
        public LoggersArray(params Logger[] loggers)
        {
            if(loggers != null)
            {
                _loggers = loggers;
            }
            else
            {
                throw new ArgumentException("Входной класс не должен быть пустым");
            }
        }

        /// <summary>
        /// Добавление логгера
        /// </summary>
        /// <param name="logger">Новый логгер</param>
        public void AddLogger(Logger logger)
        {
            if (logger != null)
            {
                Array.Resize(ref _loggers, _loggers.Length + 1);
                _loggers[^1] = logger;
            }
            else
            {
                throw new ArgumentNullException();
            }
        }

        /// <summary>
        /// Удаление логгера
        /// </summary>
        /// <param name="index">Индекс логгера в массиве логгеров </param>
        /// <exception cref="IndexOutOfRangeException">Индекс логгера которого следует удалить должен иметься в массиве логгеров</exception>
        public void RemoveLogger(int index)
        {
            if (index < 0 || index >= _loggers.Length)
            {
                throw new IndexOutOfRangeException();
            }

            for (int i = index; i < _loggers.Length - 1; i++)
            {
                _loggers[i] = _loggers[i + 1];
            }
            Array.Resize(ref _loggers, _loggers.Length - 1);
        }

        /// <summary>
        /// Изменение информации логгера на новую
        /// </summary>
        /// <param name="index">Индекс логгера в массиве</param>
        /// <param name="newLoggerInfo">Новая информация про логгер</param>
        /// <exception cref="IndexOutOfRangeException">Индекс логгера которого следует удалить должен иметься в массиве логгеров</exception>
        public void EditLogger(int index, Logger newLoggerInfo)
        {
            if (newLoggerInfo != null)
            {
                if (index < 0 || index >= _loggers.Length)
                {
                    throw new IndexOutOfRangeException();
                }
                _loggers[index] = newLoggerInfo;
            }
            else
            {
                throw new ArgumentNullException();
            }

        }

        public override string ToString()
        {
            return string.Join(Environment.NewLine, _loggers.Select(logger => logger.ToString()));
        }
    }
}
