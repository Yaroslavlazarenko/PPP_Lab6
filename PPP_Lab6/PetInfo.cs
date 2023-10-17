namespace PPP_Lab6
{
    public class PetInfo
    {
        private string _name;
        private string _breed;
        private int _weightInGrams;
        private int _age;
        private string _coloring;
        public static readonly int MaxWeightInGrams = 155000;
        public static readonly int MaxAge = 69;

        /// <summary>
        /// Получить изи записать имя питомца. Строка должна быть не пустой.
        /// </summary>
        public string Name 
        { 
            get => _name; 
            set => _name = !string.IsNullOrEmpty(value) ? value.Trim() : throw new Exception("Строка пуста или равна null."); 
        }

        /// <summary>
        /// Получить или записать породу питомца. Строка должна быть не пустой.
        /// </summary>
        public string Breed 
        { 
            get => _breed; 
            set => _breed = !string.IsNullOrEmpty(value) ? value.Trim() : throw new Exception("Строка пуста или равна null."); 
        }

        /// <summary>
        /// Получить или записать вес питомца в граммах. Вес должен быть больше 0 и меньше 155000.
        /// </summary>
        public int WeightInGrams 
        { 
            get => _weightInGrams; 
            set => _weightInGrams = value > 0 && value <= MaxWeightInGrams ? value : throw new ArgumentOutOfRangeException(); 
        }

        /// <summary>
        /// Получить или записаь возраст питомца с момента рождения. Значение дольжно быть больше 0 и меньше 69.
        /// </summary>
        public int Age 
        { 
            get => _age; 
            set => _age = value > 0 && value <= MaxAge ? value : throw new ArgumentOutOfRangeException(); 
        }

        /// <summary>
        /// Получить или записать раскраску питомца. Строка должна быть не пустой.
        /// </summary>
        public string Coloring 
        { 
            get => _coloring; 
            set => _coloring = !string.IsNullOrEmpty(value) ? value.Trim() : throw new Exception("Строка пуста или равна null."); 
        }

        /// <summary>
        /// Конструктор класса информации о питомце
        /// </summary>
        /// <param name="name">Имя питомца. Должно быть не пустым</param>
        /// <param name="breed">Порода питомца. Должно быть не пустым</param>
        /// <param name="weightInGrams">Вес питомца в граммах. Больше 0 и меньше 155000</param>
        /// <param name="age">Возраст питомца. Больше нуля и меньше 69</param>
        /// <param name="coloring">Расцветка питомца. Должно быть не пустым</param>
        public PetInfo(string name, string breed, int weightInGrams, int age, string coloring)
        {
            Name = name;
            Breed = breed;
            WeightInGrams = weightInGrams;
            Age = age;
            Coloring = coloring;
        }

        public override string ToString()
        {
            return $"\nName: {Name}, \nBreed: {Breed}, \nWeightInGrams: {WeightInGrams}, \nAge: {Age}, \nColoring: {Coloring},\n";
        }
    }
}
