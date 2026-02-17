using WinFormsApp_OOP_Lab4.Utils;

namespace WinFormsApp_OOP_Lab4.Models.PersonModel
{
    public class Person : IPerson
    {
        public Gender Gen {  get; set; }
        public string Name { get; set; }
        public double Height { get; set; }
        public double Weight { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public int Age { get; set; }

        public Person (Gender gen, string name, double height, double width, string country, string city, int age)
        {
            Gen = gen;
            Name = name;
            Height = height;
            Weight = width;
            Country = country;
            City = city;
            Age = age;
        }

        public string GetGenderToString()
        {
            if (Gen == Gender.MALE)
                return "Муж";
            return "Жен";
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
