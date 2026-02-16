namespace WinFormsApp_OOP_Lab3
{
    partial class EditForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            GenderComboBox = new ComboBox();
            ExitButton = new Button();
            SaveButton = new Button();
            HeaderLabel = new Label();
            CityLabel = new Label();
            CityTextBox = new TextBox();
            CountryLabel = new Label();
            CountryTextBox = new TextBox();
            AgeTextBox = new TextBox();
            AgeLabel = new Label();
            WidthLabel = new Label();
            WidthTextBox = new TextBox();
            label1 = new Label();
            HeightTextBox = new TextBox();
            GenderLabel = new Label();
            NameLabel = new Label();
            NameTextBox = new TextBox();
            SuspendLayout();
            // 
            // GenderComboBox
            // 
            GenderComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            GenderComboBox.FormattingEnabled = true;
            GenderComboBox.Items.AddRange(new object[] { "Муж", "Жен" });
            GenderComboBox.Location = new Point(116, 138);
            GenderComboBox.Name = "GenderComboBox";
            GenderComboBox.Size = new Size(125, 28);
            GenderComboBox.TabIndex = 46;
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(234, 275);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(94, 29);
            ExitButton.TabIndex = 45;
            ExitButton.Text = "Назад";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // SaveButton
            // 
            SaveButton.Location = new Point(414, 275);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(94, 29);
            SaveButton.TabIndex = 44;
            SaveButton.Text = "Сохранить";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // HeaderLabel
            // 
            HeaderLabel.AutoSize = true;
            HeaderLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            HeaderLabel.Location = new Point(281, 44);
            HeaderLabel.Name = "HeaderLabel";
            HeaderLabel.Size = new Size(203, 20);
            HeaderLabel.TabIndex = 43;
            HeaderLabel.Text = "Форма изменения данных";
            // 
            // CityLabel
            // 
            CityLabel.AutoSize = true;
            CityLabel.Location = new Point(477, 144);
            CityLabel.Name = "CityLabel";
            CityLabel.Size = new Size(51, 20);
            CityLabel.TabIndex = 42;
            CityLabel.Text = "Город";
            // 
            // CityTextBox
            // 
            CityTextBox.Location = new Point(541, 141);
            CityTextBox.Name = "CityTextBox";
            CityTextBox.Size = new Size(125, 27);
            CityTextBox.TabIndex = 41;
            // 
            // CountryLabel
            // 
            CountryLabel.AutoSize = true;
            CountryLabel.Location = new Point(477, 100);
            CountryLabel.Name = "CountryLabel";
            CountryLabel.Size = new Size(58, 20);
            CountryLabel.TabIndex = 40;
            CountryLabel.Text = "Страна";
            // 
            // CountryTextBox
            // 
            CountryTextBox.Location = new Point(541, 93);
            CountryTextBox.Name = "CountryTextBox";
            CountryTextBox.Size = new Size(125, 27);
            CountryTextBox.TabIndex = 39;
            // 
            // AgeTextBox
            // 
            AgeTextBox.Location = new Point(320, 198);
            AgeTextBox.Name = "AgeTextBox";
            AgeTextBox.Size = new Size(125, 27);
            AgeTextBox.TabIndex = 38;
            // 
            // AgeLabel
            // 
            AgeLabel.AutoSize = true;
            AgeLabel.Location = new Point(250, 201);
            AgeLabel.Name = "AgeLabel";
            AgeLabel.Size = new Size(64, 20);
            AgeLabel.TabIndex = 37;
            AgeLabel.Text = "Возраст";
            // 
            // WidthLabel
            // 
            WidthLabel.AutoSize = true;
            WidthLabel.Location = new Point(281, 144);
            WidthLabel.Name = "WidthLabel";
            WidthLabel.Size = new Size(33, 20);
            WidthLabel.TabIndex = 36;
            WidthLabel.Text = "Вес";
            // 
            // WidthTextBox
            // 
            WidthTextBox.Location = new Point(320, 141);
            WidthTextBox.Name = "WidthTextBox";
            WidthTextBox.Size = new Size(125, 27);
            WidthTextBox.TabIndex = 35;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(275, 96);
            label1.Name = "label1";
            label1.Size = new Size(39, 20);
            label1.TabIndex = 34;
            label1.Text = "Рост";
            // 
            // HeightTextBox
            // 
            HeightTextBox.Location = new Point(320, 93);
            HeightTextBox.Name = "HeightTextBox";
            HeightTextBox.Size = new Size(125, 27);
            HeightTextBox.TabIndex = 33;
            // 
            // GenderLabel
            // 
            GenderLabel.AutoSize = true;
            GenderLabel.Location = new Point(73, 141);
            GenderLabel.Name = "GenderLabel";
            GenderLabel.Size = new Size(37, 20);
            GenderLabel.TabIndex = 32;
            GenderLabel.Text = "Пол";
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Location = new Point(71, 93);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(39, 20);
            NameLabel.TabIndex = 31;
            NameLabel.Text = "Имя";
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(116, 90);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(125, 27);
            NameTextBox.TabIndex = 30;
            // 
            // EditForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(800, 450);
            Controls.Add(GenderComboBox);
            Controls.Add(ExitButton);
            Controls.Add(SaveButton);
            Controls.Add(HeaderLabel);
            Controls.Add(CityLabel);
            Controls.Add(CityTextBox);
            Controls.Add(CountryLabel);
            Controls.Add(CountryTextBox);
            Controls.Add(AgeTextBox);
            Controls.Add(AgeLabel);
            Controls.Add(WidthLabel);
            Controls.Add(WidthTextBox);
            Controls.Add(label1);
            Controls.Add(HeightTextBox);
            Controls.Add(GenderLabel);
            Controls.Add(NameLabel);
            Controls.Add(NameTextBox);
            Name = "EditForm";
            Text = "EditForm";
            Load += EditForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox GenderComboBox;
        private Button ExitButton;
        private Button SaveButton;
        private Label HeaderLabel;
        private Label CityLabel;
        private TextBox CityTextBox;
        private Label CountryLabel;
        private TextBox CountryTextBox;
        private TextBox AgeTextBox;
        private Label AgeLabel;
        private Label WidthLabel;
        private TextBox WidthTextBox;
        private Label label1;
        private TextBox HeightTextBox;
        private Label GenderLabel;
        private Label NameLabel;
        private TextBox NameTextBox;
    }
}