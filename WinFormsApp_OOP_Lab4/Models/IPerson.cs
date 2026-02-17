using WinFormsApp_OOP_Lab4.Models.PersonModel;

namespace WinFormsApp_OOP_Lab4.Models
{
    public interface IPerson
    {
        Gender Gen { get; set; }
        string Name { get; set; }
        double Height { get; set; }
        double Weight { get; set; }
        string Country { get; set; }
        string City { get; set; }
        int Age { get; set; }

        string GetGenderToString();
        string ToString();
    }
}
