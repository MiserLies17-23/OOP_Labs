namespace WinFormsApp_OOP_Lab8.Utils
{
    public static class Validator
    {
        /// <summary>
        /// Статический метод для валидации строковых полей 
        /// </summary>
        /// <param name="value"> Проверяемое значение </param>
        /// <param name="typeName"> Имя поля </param>
        /// <exception cref="ArgumentException"> Ошибка валидации </exception>
        public static void StringParamValidation(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException(
                    "Строка не может быть пустой!"
                );
            if (value.Length < 2)
                throw new ArgumentException(
                    "Минимальная длина — 2 символа!"
                );
            if (value.Any(char.IsDigit))
                throw new ArgumentException(
                    "Строка не должна содержать цифры!"
                );
        }
    }
}
