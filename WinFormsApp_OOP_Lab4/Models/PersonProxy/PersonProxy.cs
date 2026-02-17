using WinFormsApp_OOP_Lab4.Models.PersonModel;
using WinFormsApp_OOP_Lab4.Utils;

namespace WinFormsApp_OOP_Lab4.Models.PersonProxy
{
    public class PersonProxy : IPerson
    {
        private Person _person;

        private List<string> _events;

        public event EventHandler<string>? SomeAction;

        public Gender Gen
        {
            get => _person.Gen;
            set => _person.Gen = value;
        }

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

        public PersonProxy()
        {
            _person = PersonRandomGenerator.CreateRandomPerson();
            _events = [];
            AddEvent($"создан объект Person {_person.Name}");
            
        }

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

        public string GetGenderToString()
        {
            return _person?.Gen == Gender.MALE ? "Муж" : "Жен" ??
                throw new Exception("Человек не создан!");
        }

        public override string ToString()
        {
            if (_person != null)
                return _person.ToString();
            throw new Exception("Человек не создан!");
        }

        public void AddEvent(string message)
        {
            _events.Add(message);
            SomeAction?.Invoke(this, message);
        }

        public List<string> GetEvents()
        {
            return _events;
        }
    }
}
