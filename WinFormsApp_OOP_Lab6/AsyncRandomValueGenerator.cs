namespace WinFormsApp_OOP_Lab6
{
    /// <summary>
    /// Статический класс для генерации случайных чисел в диапазоне
    /// </summary>
    public static class AsyncRandomValueGenerator
    {
        /// <summary> Объект класса Random для генерации случайных чисел </summary>
        public static readonly Random _RND = new Random();

        /// <summary>
        /// Статический асинхронный метод для генерации случайных чисел
        /// </summary>
        /// <param name="down"> Нижняя граница диапазона </param>
        /// <param name="top"> Верхняя граница диапазона </param>
        /// <returns> Случайное число </returns>
        public async static Task<int> Generate(int down, int top)
        {
            return await Task.Run(() =>
            {
                return _RND.Next( down, top);
            });
        }
    }
}
