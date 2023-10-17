namespace PPP_Lab6
{
    public class Dog : Pet
    {
        private int _runningSpeed;
        private int _withersHeightInCentimeters;
        private int _tailLengthInCentimeters;
        public static readonly int MaxRunningSpeed = 67;
        public static readonly int MinWithersHeightInCentimeters = 15;
        public static readonly int MaxWithersHeightInCentimeters = 112;
        public static readonly int MaxTailLength = 77;

        /// <summary>
        /// Получить или записать скорость бега собаки. Значение должно быть больше 0 и меньше 67 км/ч.
        /// </summary>
        public int RunningSpeed 
        { 
            get => _runningSpeed; 
            set => _runningSpeed = value > 0 && value <= MaxRunningSpeed ? value : throw new ArgumentOutOfRangeException(); 
        }

        /// <summary>
        /// Получить или записать высоту в холке в сантиметрах. Значение должно быть больше 15 и меньше 112.
        /// </summary>
        public int WithersHeightInCentimeters 
        { 
            get => _withersHeightInCentimeters; 
            set => _withersHeightInCentimeters = value > MinWithersHeightInCentimeters && value <= MaxWithersHeightInCentimeters ? value : throw new ArgumentOutOfRangeException(); 
        }

        /// <summary>
        /// Получить или записать длину хвоста в сантиметрах. Значение должно быть от 0 до 77.
        /// </summary>
        public int TailLengthInCentimeters 
        { 
            get => _tailLengthInCentimeters; 
            set => _tailLengthInCentimeters = value >= 0 && value <= MaxTailLength ? value : throw new ArgumentOutOfRangeException(); 
        }

        /// <summary>
        /// Конструктор класса собаки
        /// </summary>
        /// <param name="name">Имя собаки. Должно быть не пустым</param>
        /// <param name="breed">Порода собаки. Должно быть не пустым</param>
        /// <param name="weightInGrams">Вес собаки в граммах. Больше 0 и меньше 155000</param>
        /// <param name="age">Возраст собаки. Больше нуля и меньше 69</param>
        /// <param name="coloring">Расцветка собаки. Должно быть не пустым</param>
        /// <param name="gender">Гендер собаки. Должно быть не пустым</param>
        /// <param name="runningSpeed">Скорость бега собаки. Больше нуля и меньше 67 км/ч</param>
        /// <param name="withersHeightInCentimeters">Высота собаки в холке в сантиметрах. Больше 15 и меньше 112</param>
        /// <param name="tailLengthInCentimeters">Длина хвоста в сантиметрах. От 0 до 77</param>
        public Dog(string name, string breed, int weightInGrams, int age, string coloring, string gender, int runningSpeed, int withersHeightInCentimeters, int tailLengthInCentimeters) : base(name, breed, weightInGrams, age, coloring, gender)
        {
            RunningSpeed = runningSpeed;
            WithersHeightInCentimeters = withersHeightInCentimeters;
            TailLengthInCentimeters = tailLengthInCentimeters;
        }

        public override string ToString()
        {
            return $"\nType of pet: Dog{base.ToString()}RunningSpeed: {RunningSpeed}, \nWithersHeightInCentimeters: {WithersHeightInCentimeters}, \nTailLengthInCentimeters: {TailLengthInCentimeters};\n";
        }
    }
}
