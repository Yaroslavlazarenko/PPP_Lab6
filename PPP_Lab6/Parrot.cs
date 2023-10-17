namespace PPP_Lab6
{
    public class Parrot : Pet
    {
        private int _beakLengthInCentimeters;
        private int _beakWidthInCentimeters;
        private int _beakHeightInCentimeters;
        public static readonly int MaxBeakLengthInCentimeters = 40;
        public static readonly int MaxBeakWidthInCentimeters = 13;
        public static readonly int MaxBeakHeightInCentimeters = 25;

        /// <summary>
        /// Получить или записать значение длины клюва попугая в сантиметрах. Значение должно быть больше 0 и меньше 40.
        /// </summary>
        public int BeakLengthInCentimeters 
        { 
            get => _beakLengthInCentimeters; 
            set => _beakLengthInCentimeters = value > 0 && value <=MaxBeakLengthInCentimeters ? value : throw new ArgumentOutOfRangeException(); 
        }

        /// <summary>
        /// Получить или записать значение ширины клюва попугая в сантиметрах. Значение должно быть больше 0 и меньше 13.
        /// </summary>
        public int BeakWidthInCentimeters 
        { 
            get => _beakWidthInCentimeters; 
            set => _beakWidthInCentimeters = value > 0 && value <=MaxBeakWidthInCentimeters ? value : throw new ArgumentOutOfRangeException(); 
        }

        /// <summary>
        /// Получить или записать значение высоты клюва попугая в сантиметрах. Значение должно быть больше 0 и меньше 25.
        /// </summary>
        public int BeakHeightInCentimeters 
        { 
            get => _beakHeightInCentimeters; 
            set => _beakHeightInCentimeters = value > 0 && value <=MaxBeakHeightInCentimeters ? value : throw new ArgumentOutOfRangeException(); 
        }

        /// <summary>
        /// Конструктор класса попугая
        /// </summary>
        /// <param name="name">Имя попугая. Должно быть не пустым</param>
        /// <param name="breed">Порода попугая. Должно быть не пустым</param>
        /// <param name="weightInGrams">Вес попугая в граммах. Больше 0 и меньше 155000</param>
        /// <param name="age">Возраст попугая. Больше нуля и меньше 69</param>
        /// <param name="coloring">Расцветка попугая. Должно быть не пустым</param>
        /// <param name="gender">Гендер попугая. Должно быть не пустым</param>
        /// <param name="beakLengthInCentimeters">Длина клюва в сантиметрах. Больше нуля и меньше 40</param>
        /// <param name="beakWidthInCentimeters">Ширина клюва в сантиметрах. Больше нуля и меньше 13</param>
        /// <param name="beakHeightInCentimeters">Высота клюва в сантиметрах. Больше нуля и меньше 25</param>
        public Parrot(string name, string breed, int weightInGrams, int age, string coloring, string gender, int beakLengthInCentimeters, int beakWidthInCentimeters, int beakHeightInCentimeters) : base(name, breed, weightInGrams, age, coloring, gender)
        {
            BeakLengthInCentimeters = beakLengthInCentimeters;
            BeakWidthInCentimeters = beakWidthInCentimeters;
            BeakHeightInCentimeters = beakHeightInCentimeters;
        }

        public override string ToString()
        {
            return $"\nType of pet: Parrot{base.ToString()}BeakLengthInCentimeters: {BeakLengthInCentimeters}, \nBeakWidthInCentimeters: {BeakWidthInCentimeters}, \nBeakHeightInCentimeters: {BeakHeightInCentimeters};\n";
        }
    }
}
