
namespace PPP_Lab6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Parrot parrot = new Parrot("Kesha", "Macaw", 1000, 5, "Bright red", "Male", 5, 2, 3);
            Cat cat = new Cat("Vasya", "Siamese", 4300, 2, "Orange", "Cisgender", 8, 42, 12);
            Dog dog = new Dog("Baron", "Labrador", 25000, 3, "Chocolate", "Genderfluid", 25, 60, 40);
            Dog dog1 = new Dog("Barsik", "Stray", 10000, 4, "Black", "Female", 20, 45, 20);

            Household household = new Household(parrot, cat, dog, dog1);

            Logger fileLogger = new FileLogger(@$"{Directory.GetCurrentDirectory()}\", DateTime.Now, "fileLog1", "Logger log1");
            Logger fileLogger1 = new FileLogger(@$"{Directory.GetCurrentDirectory()}\", DateTime.Now, "fileLog2", "Logger log2");
            Logger consoleLogger = new ConsoleLogger("Console", DateTime.Now, "ConsoleLogger Met");

            //Добавляем логгеры в массив
            LoggersArray loggersArray = new LoggersArray(fileLogger, fileLogger1);

            Console.WriteLine("Вывод массива логгеров с помощью консоль логгера");
            consoleLogger.Log(loggersArray.ToString());

            //Добавляем логгер в массив логгеров
            loggersArray.AddLogger(consoleLogger);

            Console.WriteLine("Массив логгеров после добавления ещё одного");
            Console.WriteLine(loggersArray);

            //Удаление логгера с массива логгеров и вывод с помощью консоль логгера
            loggersArray.RemoveLogger(0);
            Console.WriteLine("Массив после удаления первого логгера с массива логгеров");
            consoleLogger.Log(loggersArray.ToString());

            //Изменение логгера и вывод нового массива с помощью консоль логгера
            loggersArray.EditLogger(0, new FileLogger(@$"{Directory.GetCurrentDirectory()}\", DateTime.Now, "logFile", "EditLogger"));
            Console.WriteLine("Массив после изменеия первого логгера в массиве логгеров");
            consoleLogger.Log(loggersArray.ToString());

            //Создание файлов с информацией о питомцах и о итоговом массиве логгеров с помощью файл логгеров
            fileLogger.Log(household.ToString());
            fileLogger1.Log(loggersArray.ToString());

        }

    }
}