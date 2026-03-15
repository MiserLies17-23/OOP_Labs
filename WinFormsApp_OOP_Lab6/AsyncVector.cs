namespace WinFormsApp_OOP_Lab6
{
    /// <summary>
    /// Класс для асинхронной работы с вектором
    /// </summary>
    public class AsyncVector
    {
        /// <summary> Событие о каком-либо действии </summary>
        public event EventHandler<string>? SomeAction;

        /// <summary>
        /// Асинхронный метод для создания вектора
        /// </summary>
        /// <param name="length"> длина </param>
        /// <param name="min"> значение минимального элемента </param>
        /// <param name="max"> значение максимального элемента </param>
        /// <returns> вектор </returns>
        public async Task<List<int>> CreateVector(int length, int min, int max)
        {
            Random rnd = new();
            return await Task.Run(() =>
            {
                SomeAction?.Invoke(this, "Начало создания вектора");
                List<int> list = [];
                for (int i = 0; i < length; i++)
                {
                    list.Add(rnd.Next(min, max));
                    SomeAction?.Invoke(this, "Создание вектора...");
                }
                SomeAction?.Invoke(this, "Вектор создан!");
                return list;
            });
        }

        /// <summary>
        /// Асинхронный метод для поиска минимального
        /// </summary>
        /// <param name="list"> вектор </param>
        /// <returns> минимальный элемент вектора </returns>
        public async Task<int> FoundMinimum(List<int> list)
        {
            return await Task.Run(() =>
            {
                SomeAction?.Invoke(this, "Поиск минимального...");
                int min = list[0];
                for (int i = 1; i < list.Count; i++)
                {
                    if (list[i] < min)
                    {
                        min = list[i];
                        SomeAction?.Invoke(this, $"Текущее минимальное: {min}");
                    }
                }
                SomeAction?.Invoke(this, $"Минимальное найдено!");
                return min;
            });
        }

        /// <summary>
        /// Асинхронный метод для сортировки вектора
        /// </summary>
        /// <param name="list"> вектор </param>
        /// <returns></returns>
        public async Task InclusiveSorting(List<int> list)
        {
            await Task.Run(() =>
            {
                SomeAction?.Invoke(this, "Начало сортировки");
                int minIndex = 0;
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i] < list[minIndex])
                        minIndex = i;
                }
                SomeAction?.Invoke(this, "Сортировка...");
                (list[0], list[minIndex]) = (list[minIndex], list[0]);
                for (int i = 2; i < list.Count; i++)
                {
                    int key = list[i];
                    int j = i - 1;
                    while (list[j] > key)
                    {
                        list[j + 1] = list[j];
                        
                        j = j - 1;
                    }
                    list[j + 1] = key;
                }
                SomeAction?.Invoke(this, "Сортировка закончена!");
            });
        }

        /// <summary>
        /// Асинхронный метод для првоерки сортированности
        /// </summary>
        /// <param name="list"> вектор </param>
        /// <returns> true - если сортирован, иначе - false </returns>
        public async Task<bool> SortingCheck(List<int> list)
        {
            return await Task.Run(() =>
            {
                for (int i = 1; i < list.Count; i++)
                {
                    if (list[i - 1] > list[i])
                        return false;
                }
                return true;
            });
        }
    }
}
