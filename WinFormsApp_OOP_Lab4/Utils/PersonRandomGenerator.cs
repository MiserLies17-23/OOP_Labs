using WinFormsApp_OOP_Lab4.Models.PersonModel;

namespace WinFormsApp_OOP_Lab4.Utils
{
    public static class PersonRandomGenerator
    {
        private static Random RND = new();

        private static Array GENDERS = Enum.GetValues(typeof(Gender));

        private static string[] MALE_NAMES =
        {
            "Максим", "Михаил", "Андрей", "Александр", "Артём", "Павел", "Вадим", "Иван"
        };

        private static string[] FEMALE_NAMES =
        {
            "Елизавета", "Екатерина", "София", "Александра", "Евгения", "Наталья", "Елена", "Ольга"
        };

        private static Dictionary<string, string[]> COUNTRY_CITY = new()
        {
            {"Россия", ["Москва", "Пенза", "Ростов", "Самара", "Саранск", "Владивосток"] },
            {"Китай", ["Пекин", "Шанхай"] }
        };

        private static Gender GetRandomGender()
        {
            return (Gender)GENDERS.GetValue(RND.Next(GENDERS.Length));
        }

        private static string GetRandomMaleName()
        {
            return (string)MALE_NAMES.GetValue(RND.Next(MALE_NAMES.Length));
        }

        private static string GetRandomFemaleName()
        {
            return (string)FEMALE_NAMES.GetValue(RND.Next(FEMALE_NAMES.Length));
        }

        private static double GetRamdomWidth()
        {
            return (double)RND.Next(1, 250);
        }

        private static double GetRamdomHeight()
        {
            return (double)RND.Next(1, 250);
        }

        private static int GetRandomAge()
        {
            return (int)RND.Next(0, 100);
        }

        private static string GetRandomCountry(out int index)
        {
            index = RND.Next(COUNTRY_CITY.Count);
            return (string)COUNTRY_CITY.Keys.ElementAt(index);
        }

        private static string GetRandomCity(int countryIndex)
        {
            string[] currentValues = COUNTRY_CITY.Values.ElementAt(countryIndex);
            return (string)currentValues.GetValue(RND.Next(currentValues.Length));
        }

        public static Person CreateRandomPerson()
        {
            Gender gen = GetRandomGender();
            string name = "";
            if (gen == Gender.MALE)
                name = GetRandomMaleName();
            else
                name = GetRandomFemaleName();
            double height = GetRamdomHeight();
            double width = GetRamdomWidth();
            int age = GetRandomAge();
            string country = GetRandomCountry(out int index);
            string city = GetRandomCity(index);
            return new Person(gen, name, height, width, country, city, age);
        }
    }
}
