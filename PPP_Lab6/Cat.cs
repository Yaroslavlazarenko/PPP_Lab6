namespace PPP_Lab6
{
    public class Cat : Pet
    {
        private int _lengthOfLongestWhiskerInCentimeters;
        private int _numberOfMiceCaught;
        private int _purringFrequencyInDay;
        public static readonly int MaxLengthOfWhiskerInCentimeters = 49;
        public static readonly int MaxNumberOfMiceCaught = 28889;
        public static readonly int MaxPurringFrequencyInDay = 2400;


        /// <summary>
        /// Получить или записать значение длины самого длинного уса кота в сантиметрах. Значение должно быть больше 0 и меньше 49.
        /// </summary>
        public int LengthOfLongestWhiskerInCentimeters 
        { 
            get => _lengthOfLongestWhiskerInCentimeters; 
            set => _lengthOfLongestWhiskerInCentimeters = value > 0 && value <=MaxLengthOfWhiskerInCentimeters ? value : throw new ArgumentOutOfRangeException(); 
        }

        /// <summary>
        /// Получить или записать количество спойманных котом мышей. Значение должно быть больше 0 и меньше 28889.
        /// </summary>
        public int NumberOfMiceCaught 
        { 
            get => _numberOfMiceCaught; 
            set => _numberOfMiceCaught = value <0 || value > MaxNumberOfMiceCaught ? throw new ArgumentOutOfRangeException() : value; 
        }

        /// <summary>
        /// Получить или записать сколько раз кот мурчал за день. Значение должно быть больше 0 и меньше 2400.
        /// </summary>
        public int PurringFrequencyInDay 
        { 
            get => _purringFrequencyInDay; 
            set => _purringFrequencyInDay = value <0 || value > MaxPurringFrequencyInDay ? throw new ArgumentOutOfRangeException() : value; 
        }

        /// <summary>
        /// Конструктор класса кота
        /// </summary>
        /// <param name="name">Имя кота. Должно быть не пустым</param>
        /// <param name="breed">Порода кота. Должно быть не пустым</param>
        /// <param name="weightInGrams">Вес кота в граммах. Больше 0 и меньше 155000</param>
        /// <param name="age">Возраст кота. Больше нуля и меньше 69</param>
        /// <param name="coloring">Расцветка кота. Должно быть не пустым</param>
        /// <param name="gender">Гендер кота. Должно быть не пустым</param>
        /// <param name="lengthOfLongestWhiskerInCentimeters">Длина самого длинного уса в сантиметрах. Больше нуля и меньше 49</param>
        /// <param name="numberOfMiceCaught">Количесто спойманных мышей. От 0 до 28889</param>
        /// <param name="purringFrequencyInDay">Количество раз которое кот мурчал за день. От 0 до 2400</param>
        public Cat(string name, string breed, int weightInGrams, int age, string coloring, string gender, int lengthOfLongestWhiskerInCentimeters, int numberOfMiceCaught, int purringFrequencyInDay) : base(name, breed, weightInGrams, age, coloring, gender)
        {
            LengthOfLongestWhiskerInCentimeters = lengthOfLongestWhiskerInCentimeters;
            NumberOfMiceCaught = numberOfMiceCaught;
            PurringFrequencyInDay = purringFrequencyInDay;
        }

        public override string ToString()
        {
            return $"\nType of pet: Cat{base.ToString()}LengthOfLongestWhiskerInCentimeters: {LengthOfLongestWhiskerInCentimeters}, \nNumberOfMiceCaught: {NumberOfMiceCaught}, \nPurringFrequencyInDay: {PurringFrequencyInDay};\n";
        }
    }
}
