using WinFormsApp_OOP_Lab1.Model;

namespace TestProject_OOP_Lab1
{
    [TestClass]
    public class PersonTest
    {
        [TestMethod]
        public void ConstructorTest1()
        {
            Person person = new();

            Assert.AreEqual(Gender.MALE, person.Gen);
            Assert.AreEqual("Undefinded", person.Name);
            Assert.AreEqual(20, person.Age);
            Assert.AreEqual(170, person.Height);
            Assert.AreEqual(65, person.Width);
            Assert.AreEqual("Undefinded", person.Country);
            Assert.AreEqual("Undefinded", person.City);
        }

        [TestMethod]
        public void ConstructorTest2()
        {
            Person person = new(Gender.FEMALE);

            Assert.AreEqual(Gender.FEMALE, person.Gen);
            Assert.AreEqual("Undefinded", person.Name);
            Assert.AreEqual(20, person.Age);
            Assert.AreEqual(170, person.Height);
            Assert.AreEqual(65, person.Width);
            Assert.AreEqual("Undefinded", person.Country);
            Assert.AreEqual("Undefinded", person.City);
        }

        [TestMethod]
        public void ConstructorTest3()
        {
            Person person = new(Gender.MALE, "Вася");

            Assert.AreEqual(Gender.MALE, person.Gen);
            Assert.AreEqual("Вася", person.Name);
            Assert.AreEqual(20, person.Age);
            Assert.AreEqual(170, person.Height);
            Assert.AreEqual(65, person.Width);
            Assert.AreEqual("Undefinded", person.Country);
            Assert.AreEqual("Undefinded", person.City);
        }

        [TestMethod]
        public void ConstructorTest4()
        {
            Person person = new(Gender.MALE, "Вася", 180, 67.8, 20, "Россия", "Пенза");

            Assert.AreEqual(Gender.MALE, person.Gen);
            Assert.AreEqual("Вася", person.Name);
            Assert.AreEqual(20, person.Age);
            Assert.AreEqual(180, person.Height);
            Assert.AreEqual(67.8, person.Width);
            Assert.AreEqual("Россия", person.Country);
            Assert.AreEqual("Пенза", person.City);
        }

        [TestMethod]
        public void GetGenderToStringTest()
        {
            Person person = new();
            Assert.AreEqual(Gender.MALE, person.Gen);
        }

        [TestMethod]
        public void ToStringTest()
        {
            Person person = new(Gender.MALE, "Саша");
            string name = person.ToString();
            Assert.AreEqual(name, person.Name);
        }
    }
}
