namespace WinFormsApp_OOP_Lab4
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
            HeightLabel = new Label();
            HeightTextBox = new TextBox();
            GenderLabel = new Label();
            NameLabel = new Label();
            NameTextBox = new TextBox();
            EventsLabel = new Label();
            SuspendLayout();
            // 
            // GenderComboBox
            // 
            GenderComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            GenderComboBox.FormattingEnabled = true;
            GenderComboBox.Items.AddRange(new object[] { "Муж", "Жен" });
            GenderComboBox.Location = new Point(113, 167);
            GenderComboBox.Name = "GenderComboBox";
            GenderComboBox.Size = new Size(125, 28);
            GenderComboBox.TabIndex = 63;
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(231, 304);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(94, 29);
            ExitButton.TabIndex = 62;
            ExitButton.Text = "Назад";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += this.ExitButton_Click;
            // 
            // SaveButton
            // 
            SaveButton.Location = new Point(411, 304);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(94, 29);
            SaveButton.TabIndex = 61;
            SaveButton.Text = "Сохранить";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += this.SaveButton_Click;
            // 
            // HeaderLabel
            // 
            HeaderLabel.AutoSize = true;
            HeaderLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            HeaderLabel.Location = new Point(278, 73);
            HeaderLabel.Name = "HeaderLabel";
            HeaderLabel.Size = new Size(203, 20);
            HeaderLabel.TabIndex = 60;
            HeaderLabel.Text = "Форма изменения данных";
            // 
            // CityLabel
            // 
            CityLabel.AutoSize = true;
            CityLabel.Location = new Point(474, 173);
            CityLabel.Name = "CityLabel";
            CityLabel.Size = new Size(51, 20);
            CityLabel.TabIndex = 59;
            CityLabel.Text = "Город";
            // 
            // CityTextBox
            // 
            CityTextBox.Location = new Point(538, 170);
            CityTextBox.Name = "CityTextBox";
            CityTextBox.Size = new Size(125, 27);
            CityTextBox.TabIndex = 58;
            // 
            // CountryLabel
            // 
            CountryLabel.AutoSize = true;
            CountryLabel.Location = new Point(474, 129);
            CountryLabel.Name = "CountryLabel";
            CountryLabel.Size = new Size(58, 20);
            CountryLabel.TabIndex = 57;
            CountryLabel.Text = "Страна";
            // 
            // CountryTextBox
            // 
            CountryTextBox.Location = new Point(538, 122);
            CountryTextBox.Name = "CountryTextBox";
            CountryTextBox.Size = new Size(125, 27);
            CountryTextBox.TabIndex = 56;
            // 
            // AgeTextBox
            // 
            AgeTextBox.Location = new Point(317, 227);
            AgeTextBox.Name = "AgeTextBox";
            AgeTextBox.Size = new Size(125, 27);
            AgeTextBox.TabIndex = 55;
            // 
            // AgeLabel
            // 
            AgeLabel.AutoSize = true;
            AgeLabel.Location = new Point(247, 230);
            AgeLabel.Name = "AgeLabel";
            AgeLabel.Size = new Size(64, 20);
            AgeLabel.TabIndex = 54;
            AgeLabel.Text = "Возраст";
            // 
            // WidthLabel
            // 
            WidthLabel.AutoSize = true;
            WidthLabel.Location = new Point(278, 173);
            WidthLabel.Name = "WidthLabel";
            WidthLabel.Size = new Size(33, 20);
            WidthLabel.TabIndex = 53;
            WidthLabel.Text = "Вес";
            // 
            // WidthTextBox
            // 
            WidthTextBox.Location = new Point(317, 170);
            WidthTextBox.Name = "WidthTextBox";
            WidthTextBox.Size = new Size(125, 27);
            WidthTextBox.TabIndex = 52;
            // 
            // HeightLabel
            // 
            HeightLabel.AutoSize = true;
            HeightLabel.Location = new Point(272, 125);
            HeightLabel.Name = "HeightLabel";
            HeightLabel.Size = new Size(39, 20);
            HeightLabel.TabIndex = 51;
            HeightLabel.Text = "Рост";
            // 
            // HeightTextBox
            // 
            HeightTextBox.Location = new Point(317, 122);
            HeightTextBox.Name = "HeightTextBox";
            HeightTextBox.Size = new Size(125, 27);
            HeightTextBox.TabIndex = 50;
            // 
            // GenderLabel
            // 
            GenderLabel.AutoSize = true;
            GenderLabel.Location = new Point(70, 170);
            GenderLabel.Name = "GenderLabel";
            GenderLabel.Size = new Size(37, 20);
            GenderLabel.TabIndex = 49;
            GenderLabel.Text = "Пол";
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Location = new Point(68, 122);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(39, 20);
            NameLabel.TabIndex = 48;
            NameLabel.Text = "Имя";
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(113, 119);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(125, 27);
            NameTextBox.TabIndex = 47;
            // 
            // EventsLabel
            // 
            EventsLabel.AutoSize = true;
            EventsLabel.Location = new Point(44, 45);
            EventsLabel.Name = "EventsLabel";
            EventsLabel.Size = new Size(156, 20);
            EventsLabel.TabIndex = 64;
            EventsLabel.Text = "События PersonProxy:";
            // 
            // EditForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(EventsLabel);
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
            Controls.Add(HeightLabel);
            Controls.Add(HeightTextBox);
            Controls.Add(GenderLabel);
            Controls.Add(NameLabel);
            Controls.Add(NameTextBox);
            Name = "EditForm";
            Text = "EditForm";
            Load += this.EditForm_Load;
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
        private Label HeightLabel;
        private TextBox HeightTextBox;
        private Label GenderLabel;
        private Label NameLabel;
        private TextBox NameTextBox;
        private Label EventsLabel;
    }
}