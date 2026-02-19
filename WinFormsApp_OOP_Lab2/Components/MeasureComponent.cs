using System.Diagnostics;
using WinFormsApp_OOP_Lab1.Model;
using WinFormsApp_OOP_Lab2.Stack;
using WinFormsApp_OOP_Lab2.Utils;

namespace WinFormsApp_OOP_Lab2.Components
{
    /// <summary>
    /// Статический класс для сравнения производительности стэка и списка
    /// </summary>
    public static class MeasureComponent
    {
        /// <summary> Статический объект Stopwatch для замера времени </summary>
        private static readonly Stopwatch _STOPWATCH = new();

        /// <summary> Статический обект Random для генерации случайных чисел </summary>
        private static readonly Random _RND = new();

        /// <summary> Статическая переменная - размер структур данных </summary>
        private static readonly int _SIZE = 100_000;

        /// <summary> Статический объект List - представляет список </summary>
        private static List<Person> _PERSONS = new(_SIZE);

        /// <summary> Статический объект PersonStack - представляет стэк объектов Person </summary>
        private static PersonStack _PERSON_STACK = new(_SIZE);

        /// <summary> Статический массив объектов Person для запоминания данных </summary>
        private static Person[] _ARRAY = new Person[_SIZE];

        /// <summary>
        /// Метод для замера времени вставки в стэк
        /// </summary>
        /// <returns> Время вставки </returns>
        public static int InsertInStack()
        {
            _PERSON_STACK.Clear();
            _STOPWATCH.Reset();
            _STOPWATCH.Start();
            for (int i = 0; i < _SIZE; i++)
                _PERSON_STACK.AddItem(RandomValuesGenerator.CreateRandomPerson());
            _STOPWATCH.Stop();
            return (int)_STOPWATCH.ElapsedMilliseconds;
        }

        /// <summary>
        /// Метод для замера времени вставки в список
        /// </summary>
        /// <returns> Время вставки </returns>
        public static int InsertInArray()
        {
            Array.Clear(_ARRAY);
            _STOPWATCH.Reset();
            _STOPWATCH.Start();
            for (int i = 0; i < _SIZE; i++)
                _ARRAY[i] = RandomValuesGenerator.CreateRandomPerson();
            _STOPWATCH.Stop();
            return (int)_STOPWATCH.ElapsedMilliseconds;
        }

        /// <summary>
        /// Метод для замера времени последовательной выборки из стэка
        /// </summary>
        /// <returns> Время выборки </returns>
        public static int ConsistentStackSelection()
        {
            _PERSONS.Clear();
            _STOPWATCH.Reset();
            _STOPWATCH.Start();
            for (int i = 0; i < _SIZE; i++)
                _PERSONS.Add(_PERSON_STACK.Stack.First()); // исправить
            _STOPWATCH.Stop();
            return (int)_STOPWATCH.ElapsedMilliseconds;
        }

        /// <summary>
        /// Метод для замера времени последовательной выборки из массива
        /// </summary>
        /// <returns> Время выборки </returns>
        public static int ConsistentArraySelection()
        {
            _PERSONS.Clear();
            _STOPWATCH.Reset();
            _STOPWATCH.Start();
            for (int i = 0; i < _SIZE; i++)
                _PERSONS.Add(_ARRAY[i]);
            _STOPWATCH.Stop();
            return (int)_STOPWATCH.ElapsedMilliseconds;
        }

        /// <summary>
        /// Метод для замера времени случайной выборки из стэка
        /// </summary>
        /// <returns> Время выборки </returns>
        public static int RandomStackSelection()
        {
            _PERSONS.Clear();
            var personArray = _PERSON_STACK.Stack.ToArray();
            _STOPWATCH.Reset();
            _STOPWATCH.Start();
            for (int i = 0; i < _SIZE; i++)
                _PERSONS.Add(personArray[_RND.Next(_SIZE - 1)]);
            _STOPWATCH.Stop();
            return (int)_STOPWATCH.ElapsedMilliseconds;
        }

        /// <summary>
        /// Метод для замера времени случайной выборки из списка
        /// </summary>
        /// <returns> Время выборки </returns>
        public static int RandomArraySelection()
        {
            _PERSONS.Clear();
            _STOPWATCH.Reset();
            _STOPWATCH.Start();
            for (int i = 0; i < _SIZE; i++)
                _PERSONS.Add(_ARRAY[_RND.Next(_SIZE - 1)]);
            _STOPWATCH.Stop();
            return (int)_STOPWATCH.ElapsedMilliseconds;
        }
    }
}
