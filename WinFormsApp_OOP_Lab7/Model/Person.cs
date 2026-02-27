namespace WinFormsApp_OOP_Lab7.Model
{
    public class Person
    {
        public int Id { get; set; }
        public Gender Gender { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(Gender gender, string name, int age)
        {
            Gender = gender;
            Name = name;
            Age = age;
        }

        public string GetGenderToString()
        {
            return Gender == Gender.MALE ? "Муж" : "Жен";
        }
    }
}
