namespace PPP_Lab6
{
    public class Pet
    {
        private PetInfo _petInfo;
        private string _gender;

        /// <summary>
        /// Получить базовую информацию о питомце.
        /// </summary>
        public PetInfo petInfo
        {
            get => _petInfo;
        }

        /// <summary>
        /// Получить или записать гендер. Гендеры бывают разные, их очень много, поэтому строка только не должна быть пустой.
        /// </summary>
        public string Gender 
        { 
            get => _gender; 
            set => _gender = !string.IsNullOrEmpty(value) ? value.Trim() : throw new ArgumentException("Строка пуста или равна null.") ; 
        }

        /// <summary>
        /// Конструктор класса пета
        /// </summary>
        /// <param name="name">Имя питомца. Должно быть не пустым</param>
        /// <param name="breed">Порода питомца. Должно быть не пустым</param>
        /// <param name="weightInGrams">Вес питомца в граммах. Больше 0 и меньше 155000</param>
        /// <param name="age">Возраст питомца. Больше нуля и меньше 69</param>
        /// <param name="coloring">Расцветка питомца. Должно быть не пустым</param>
        /// <param name="gender">Гендер питомца. Должно быть не пустым</param>
        public Pet(string name, string breed, int weightInGrams, int age, string coloring, string gender)
        {
            _petInfo = new PetInfo(name, breed, weightInGrams, age, coloring);
            Gender = gender;
        }

        public override string ToString()
        {
            return $"{_petInfo}Gender: {Gender},\n";
        }
    }
}
