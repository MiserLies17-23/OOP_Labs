using WinFormsApp_OOP_Lab5.Interpreter.NonTerminalExpression;
using WinFormsApp_OOP_Lab5.Model;

namespace WinFormsApp_OOP_Lab5.Utils
{
    public class ComboBoxComponent
    {
        private readonly ComboBox _genderComboBox;
        private readonly ComboBox _nonTermComboBox1;
        private readonly ComboBox _nonTermComboBox2;
        private readonly ComboBox _professionComboBox;

        public ComboBoxComponent(ComboBox genderComboBox, ComboBox nonTermComboBox1, 
            ComboBox nonTermComboBox2, ComboBox professionComboBox)
        {
            _genderComboBox = genderComboBox;
            _nonTermComboBox1 = nonTermComboBox1;
            _nonTermComboBox2 = nonTermComboBox2;
            _professionComboBox = professionComboBox;

            Load_All();
        }

        private void GenderCombobox_Load()
        {
            var displayValues = new Dictionary<Gender, string>
            {
                { Gender.MALE, "Муж" },
                { Gender.FEMALE, "Жен" }
            };
            _genderComboBox.DataSource = new BindingSource(displayValues, null);
            _genderComboBox.DisplayMember = "Value";
            _genderComboBox.ValueMember = "Key";
        }

        private void NonTermComboBox_Load()
        {
            var displayValues = new Dictionary<Operation, string>
            {
                { Operation.AND, "И"},
                { Operation.OR, "ИЛИ"}
            };
            _nonTermComboBox1.DataSource = new BindingSource(displayValues, null);
            _nonTermComboBox1.DisplayMember = "Value";
            _nonTermComboBox1.ValueMember = "Key";

            _nonTermComboBox2.DataSource = new BindingSource(displayValues, null);
            _nonTermComboBox2.DisplayMember = "Value";
            _nonTermComboBox2.ValueMember = "Key";
        }

        private void ProfessionComboBox_Load()
        {
            var displayValues = new Dictionary<Profession, string>
            {
                { Profession.PROGRAMMER, "Программист"},
                { Profession.BUILDER, "Строитель"},
                { Profession.TEACHER, "Учитель"},
                { Profession.COOK, "Повар"},
                { Profession.ACCOUNTANT, "Бухгалтер"},
                { Profession.HAIRDRESSER, "Парикмахер"}
            };
            _professionComboBox.DataSource = new BindingSource(displayValues, null);
            _professionComboBox.DisplayMember = "Value";
            _professionComboBox.ValueMember = "Key";
        }

        private void Load_All()
        {
            GenderCombobox_Load();
            NonTermComboBox_Load();
            ProfessionComboBox_Load();
        }
    }
}
