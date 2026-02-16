namespace WinFormsApp_OOP_Lab3
{
    public class PersonValidationException : Exception
    {
        /// <summary>
        /// Свойство для отображения имени поля
        /// </summary>
        public string FieldName { get; }

        /// <summary>
        /// Свойство для отображения некорректных данных
        /// </summary>
        public string InvalidValue { get; }

        /// <summary>
        /// Свойство для отображения времени вызова ошибки
        /// </summary>
        public DateTime ErrorTime { get; }

        /// <summary>
        /// Конструктор с параметрами
        /// </summary>
        /// <param name="message"> Сообщение об ошибке </param>
        /// <param name="fieldName"> Имя поля </param>
        /// <param name="invalidValue"> Некорректное значение </param>
        public PersonValidationException(string message,
                                         string fieldName,
                                         string invalidValue)
            : base(message)
        {
            FieldName = fieldName;
            InvalidValue = invalidValue;
            ErrorTime = DateTime.Now;
        }

        /// <summary>
        /// Переопределённый метод ToString() для вывода сообщений
        /// </summary>
        /// <returns> Строка сообщение об ошибке </returns>
        public override string ToString()
        {
            return $"{Message}\nПоле: {FieldName}\nЗначение: {InvalidValue}\nВремя: {ErrorTime}";
        }
    }
}
