namespace WinFormsApp_OOP_Lab6
{
    public class VectorAsync
    {
        
        public event EventHandler<string>? SomeAction;

        public async Task<List<int>> CreateVector(int length, int min, int max)
        {
            Random rnd = new();
            return await Task.Run(() =>
            {
                SomeAction?.Invoke(this, "Начало создание вектора");
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
                SomeAction?.Invoke(this, $"Минимальное: {min}");
                return min;
            });
        }
    }
}
