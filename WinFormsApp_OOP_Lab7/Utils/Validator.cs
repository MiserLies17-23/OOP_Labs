namespace WinFormsApp_OOP_Lab7.Utils
{
    /// <summary>
    /// Статический утилитный класс для валидации
    /// </summary>
    public static class Validator
    {
        /// <summary>
        /// Статический метод для валидации строковых полей 
        /// </summary>
        /// <param name="value"> Проверяемое значение </param>
        /// <param name="typeName"> Имя поля </param>
        /// <exception cref="ArgumentException"> Ошибка валидации </exception>
        public static void NameValidation(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Имя не может быть пустым!");
            if (value.Length < 2)
                throw new ArgumentException("Минимальная длина имени — 2 символа!");
            if (value.Any(char.IsDigit))
                throw new ArgumentException("Строка не должна содержать цифры!");
        }

        /// <summary>
        /// Статический метод для валидации возраста
        /// </summary>
        /// <param name="value"> Проверямое значение </param>
        /// <exception cref="ArgumentException"> Ошибка валидации </exception>
        public static void AgeValidation(int value)
        {
            if (value < 0 || value > 120)
                throw new ArgumentException("Некорректный возраст! Возраст должен быть в пределах от 0 до 120 лет!");
        }
    }
}