using WinFormsApp_OOP_Lab4.Models.PersonModel;
using WinFormsApp_OOP_Lab4.Utils;

namespace WinFormsApp_OOP_Lab4.Models.PersonProxy
{
    /// <summary>
    /// Proxy-класс для базового класса Person
    /// Реализует функционал интерфейса IPeron
    /// </summary>
    public class PersonProxy : IPerson
    {
        /// <summary> Объект Person </summary>
        private Person _person;

        /// <summary> Список событий </summary>
        private List<string> _events;

        /// <summary> Событие для отслеживания последних действий </summary>
        public event EventHandler<string>? SomeAction;

        /// <summary>
        /// Свойство - пол человека
        /// </summary>
        public Gender Gen
        {
            get => _person.Gen;
            set { 
                _person.Gen = value;
                AddEvent($"В поле {nameof(_person.Gen)} сохранено значение: \"{value}\"!");
            }
        }

        /// <summary>
        /// Свойство - имя человека
        /// </summary>
        public string Name
        {
            get => _person.Name;
            set
            {
                Validator.StringParamValidation(value, nameof(_person.Name));
                if (value != _person.Name)
                {
                    _person.Name = value;
                    AddEvent($"В поле {nameof(_person.Name)} сохранено значение: \"{value}\"!");
                }

            }
        }

        /// <summary>
        /// Свойство - рост человека
        /// </summary>
        public double Height
        {
            get => _person.Height;
            set
            {
                Validator.HeightValidation(value);
                if (value != _person.Height)
                {
                    _person.Height = value;
                    AddEvent($"В поле {nameof(_person.Height)} сохранено значение: \"{value}\"!");
                }
            }
        }

        /// <summary>
        /// Свойство - вес человека
        /// </summary>
        public double Weight
        {
            get => _person.Weight;
            set
            {
                Validator.WidthValidation(value);
                if (value != _person.Weight)
                {
                    _person.Weight = value;
                    AddEvent($"В поле {nameof(_person.Weight)} сохранено значение: \"{value}\"!");
                }
            }
        }

        /// <summary>
        /// Свойство - страна проживания
        /// </summary>
        public string Country
        {
            get => _person.Country;
            set
            {
                Validator.StringParamValidation(value, nameof(_person.Country));
                if (value != _person.Country)
                {
                    _person.Country = value;
                    AddEvent($"В поле {nameof(_person.Country)} сохранено значение: \"{value}\"!");
                }
            }
        }

        /// <summary>
        /// Свойство - город проживания
        /// </summary>
        public string City
        {
            get => _person.City;
            set
            {
                Validator.StringParamValidation(value, nameof(_person.City));
                if (value != _person.City)
                {
                    _person.City = value;
                    AddEvent($"В поле {nameof(_person.City)} сохранено значение: \"{value}\"!");
                }
            }
        }

        /// <summary>
        /// Свойство - возраст
        /// </summary>
        public int Age
        {
            get => _person.Age;
            set
            {
                Validator.AgeValidation(value);
                if (value != _person.Age)
                {
                    _person.Age = value;
                    AddEvent($"в поле {nameof(_person.Age)} сохранено значение \"{value}\"!");
                }
            }
        }

        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public PersonProxy()
        {
            _person = PersonValuesGenerator.CreateRandomPerson();
            _events = [];
            AddEvent($"создан объект Person {_person.Name}");
            
        }

        /// <summary>
        /// Конструктор с параметрами
        /// </summary>
        /// <param name="gen"> пол </param>
        /// <param name="name"> имя </param>
        /// <param name="height"> рост </param>
        /// <param name="width"> вес </param>
        /// <param name="country"> страна </param>
        /// <param name="city"> город </param>
        /// <param name="age"> возраст </param>
        public PersonProxy(Gender gen, string name,  double height, double width, string country, string city, int age)
        {
            Validator.StringParamValidation(name, nameof(_person.Name));
            Validator.HeightValidation(height);
            Validator.WidthValidation(width);
            Validator.StringParamValidation(country, nameof(_person.Country));
            Validator.StringParamValidation(city, nameof(_person.City));
            Validator.AgeValidation(age);

            _person = new(gen, name, height, width, country, city, age);
            _events = [];
            AddEvent($"Создан объект Person: {_person}");
        }

        /// <summary>
        /// Метод для вывода пола
        /// </summary>
        /// <returns> строка - пол человека </returns>
        public string GetGenderToString()
        {
            return _person?.Gen == Gender.MALE ? "Муж" : "Жен" ??
                throw new Exception("Человек не создан!");
        }

        /// <summary>
        /// Переопределённый метод ToString() для класса
        /// </summary>
        /// <returns> имя человека </returns>
        public override string ToString()
        {
            if (_person != null)
                return _person.ToString();
            throw new Exception("Человек не создан!");
        }

        /// <summary>
        /// Метод для сохранения события
        /// </summary>
        /// <param name="message"> сообщение события </param>
        public void AddEvent(string message)
        {
            _events.Add(message);
            SomeAction?.Invoke(this, message);
        }

        /// <summary>
        /// Метод для получения списка всех событий
        /// </summary>
        /// <returns> список всех событий </returns>
        public List<string> GetEvents()
        {
            return _events;
        }
    }
}
