namespace WinFormsApp_OOP_Lab3
{
    public static class Validation
    {
        /// <summary>
        /// Статический метод для валидации строковых полей 
        /// </summary>
        /// <param name="value"> Проверяемое значение </param>
        /// <param name="typeName"> Имя поля </param>
        /// <exception cref="PersonValidationException"> Ошибка валидации </exception>
        public static void StringParamValidation(string value, string typeName)
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new PersonValidationException(
                    "Строка не может быть пустой!",
                    typeName,
                    value
                );
            if (value.Length < 2)
                throw new PersonValidationException(
                    "Минимальная длина — 2 символа!",
                    typeName,
                    value
                );
            if (value.Any(char.IsDigit))
                throw new PersonValidationException(
                    "Строка не должна содержать цифры!",
                    typeName,
                    value);
        }

        /// <summary>
        /// Статический метод для валидации роста человека
        /// </summary>
        /// <param name="value"> Проверяемое значение </param>
        /// <exception cref="PersonValidationException"> Ошибка валидации </exception>
        public static void HeightValidation(double value)
        {
            if (value <= 0 || value > 250)
                throw new PersonValidationException(
                    "Некорректный рост! Рост должен быть в пределах от 0 до 250 см!",
                    "Height",
                    value.ToString()
                );
        }

        /// <summary>
        /// Статический метод для валидации веса пользователя
        /// </summary>
        /// <param name="value"> Проверяемое значение </param>
        /// <exception cref="PersonValidationException"> Ошибка валидации </exception>
        public static void WidthValidation(double value)
        {
            if (value <= 0 || value > 300)
                throw new PersonValidationException(
                    "Некорректный вес! Вес должен быть в пределах от 0 до 300 кг!",
                    "Weight",
                    value.ToString()
                );
        }

        /// <summary>
        /// Статический метод для валидации возраста
        /// </summary>
        /// <param name="value"> Проверямое значение </param>
        /// <exception cref="PersonValidationException"> Ошибка валидации </exception>
        public static void AgeValidation(int value)
        {
            if (value < 0 || value > 120)
                throw new PersonValidationException(
                    "Некорректный возраст! Возраст должен быть в пределах от 0 до 120 лет!",
                    "Age",
                    value.ToString()
                );
        }
    }
}
