namespace WinFormsApp_OOP_Lab1
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            HeaderLabel = new Label();
            VariantLabel = new Label();
            DataLabel = new Label();
            NameTextBox = new TextBox();
            CountryTextBox = new TextBox();
            CityTextBox = new TextBox();
            GenderLabel = new Label();
            NameLabel = new Label();
            WidthLabel = new Label();
            HeightLabel = new Label();
            CountryLabel = new Label();
            CityLabel = new Label();
            AgeLabel = new Label();
            ChangeButton = new Button();
            HeightTextBox = new TextBox();
            WidthTextBox = new TextBox();
            AgeTextBox = new TextBox();
            GenderTextBox = new TextBox();
            ExitButton = new Button();
            CountLabel = new Label();
            CurrentLabel = new Label();
            SuspendLayout();
            // 
            // HeaderLabel
            // 
            HeaderLabel.AutoSize = true;
            HeaderLabel.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            HeaderLabel.Location = new Point(273, 9);
            HeaderLabel.Name = "HeaderLabel";
            HeaderLabel.Size = new Size(257, 25);
            HeaderLabel.TabIndex = 0;
            HeaderLabel.Text = "Лабораторная работа №1";
            // 
            // VariantLabel
            // 
            VariantLabel.AutoSize = true;
            VariantLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            VariantLabel.Location = new Point(315, 45);
            VariantLabel.Name = "VariantLabel";
            VariantLabel.Size = new Size(161, 20);
            VariantLabel.TabIndex = 1;
            VariantLabel.Text = "Вариант 13: Человек";
            // 
            // DataLabel
            // 
            DataLabel.AutoSize = true;
            DataLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            DataLabel.Location = new Point(354, 92);
            DataLabel.Name = "DataLabel";
            DataLabel.Size = new Size(119, 20);
            DataLabel.TabIndex = 2;
            DataLabel.Text = "Общие данные";
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(260, 166);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.ReadOnly = true;
            NameTextBox.Size = new Size(125, 27);
            NameTextBox.TabIndex = 4;
            // 
            // CountryTextBox
            // 
            CountryTextBox.Location = new Point(436, 166);
            CountryTextBox.Name = "CountryTextBox";
            CountryTextBox.ReadOnly = true;
            CountryTextBox.Size = new Size(125, 27);
            CountryTextBox.TabIndex = 8;
            // 
            // CityTextBox
            // 
            CityTextBox.Location = new Point(609, 165);
            CityTextBox.Name = "CityTextBox";
            CityTextBox.ReadOnly = true;
            CityTextBox.Size = new Size(125, 27);
            CityTextBox.TabIndex = 9;
            // 
            // GenderLabel
            // 
            GenderLabel.AutoSize = true;
            GenderLabel.Location = new Point(122, 133);
            GenderLabel.Name = "GenderLabel";
            GenderLabel.Size = new Size(37, 20);
            GenderLabel.TabIndex = 10;
            GenderLabel.Text = "Пол";
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Location = new Point(304, 133);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(39, 20);
            NameLabel.TabIndex = 11;
            NameLabel.Text = "Имя";
            // 
            // WidthLabel
            // 
            WidthLabel.AutoSize = true;
            WidthLabel.Location = new Point(379, 221);
            WidthLabel.Name = "WidthLabel";
            WidthLabel.Size = new Size(60, 20);
            WidthLabel.TabIndex = 12;
            WidthLabel.Text = "Вес (кг)";
            // 
            // HeightLabel
            // 
            HeightLabel.AutoSize = true;
            HeightLabel.Location = new Point(201, 221);
            HeightLabel.Name = "HeightLabel";
            HeightLabel.Size = new Size(71, 20);
            HeightLabel.TabIndex = 13;
            HeightLabel.Text = "Рост (см)";
            // 
            // CountryLabel
            // 
            CountryLabel.AutoSize = true;
            CountryLabel.Location = new Point(472, 133);
            CountryLabel.Name = "CountryLabel";
            CountryLabel.Size = new Size(58, 20);
            CountryLabel.TabIndex = 14;
            CountryLabel.Text = "Страна";
            // 
            // CityLabel
            // 
            CityLabel.AutoSize = true;
            CityLabel.Location = new Point(600, 133);
            CityLabel.Name = "CityLabel";
            CityLabel.Size = new Size(144, 20);
            CityLabel.TabIndex = 15;
            CityLabel.Text = "Город проживания";
            // 
            // AgeLabel
            // 
            AgeLabel.AutoSize = true;
            AgeLabel.Location = new Point(545, 221);
            AgeLabel.Name = "AgeLabel";
            AgeLabel.Size = new Size(64, 20);
            AgeLabel.TabIndex = 16;
            AgeLabel.Text = "Возраст";
            // 
            // ChangeButton
            // 
            ChangeButton.Location = new Point(354, 316);
            ChangeButton.Name = "ChangeButton";
            ChangeButton.Size = new Size(94, 29);
            ChangeButton.TabIndex = 17;
            ChangeButton.Text = "Изменить";
            ChangeButton.UseVisualStyleBackColor = true;
            ChangeButton.Click += CreateButton_Click;
            // 
            // HeightTextBox
            // 
            HeightTextBox.Location = new Point(170, 244);
            HeightTextBox.Name = "HeightTextBox";
            HeightTextBox.ReadOnly = true;
            HeightTextBox.Size = new Size(125, 27);
            HeightTextBox.TabIndex = 22;
            // 
            // WidthTextBox
            // 
            WidthTextBox.Location = new Point(354, 244);
            WidthTextBox.Name = "WidthTextBox";
            WidthTextBox.ReadOnly = true;
            WidthTextBox.Size = new Size(125, 27);
            WidthTextBox.TabIndex = 23;
            // 
            // AgeTextBox
            // 
            AgeTextBox.Location = new Point(528, 244);
            AgeTextBox.Name = "AgeTextBox";
            AgeTextBox.ReadOnly = true;
            AgeTextBox.Size = new Size(125, 27);
            AgeTextBox.TabIndex = 24;
            // 
            // GenderTextBox
            // 
            GenderTextBox.Location = new Point(85, 165);
            GenderTextBox.Name = "GenderTextBox";
            GenderTextBox.ReadOnly = true;
            GenderTextBox.Size = new Size(125, 27);
            GenderTextBox.TabIndex = 25;
            // 
            // ExitButton
            // 
            ExitButton.BackgroundImage = Properties.Resources.button_exit_icon;
            ExitButton.BackgroundImageLayout = ImageLayout.Stretch;
            ExitButton.Location = new Point(34, 327);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(125, 97);
            ExitButton.TabIndex = 26;
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // CountLabel
            // 
            CountLabel.AutoSize = true;
            CountLabel.Location = new Point(34, 92);
            CountLabel.Name = "CountLabel";
            CountLabel.Size = new Size(120, 20);
            CountLabel.TabIndex = 27;
            CountLabel.Text = "Всего объектов:";
            // 
            // CurrentLabel
            // 
            CurrentLabel.AutoSize = true;
            CurrentLabel.Location = new Point(662, 92);
            CurrentLabel.Name = "CurrentLabel";
            CurrentLabel.Size = new Size(129, 20);
            CurrentLabel.TabIndex = 28;
            CurrentLabel.Text = "Индекс текущего:";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(833, 450);
            Controls.Add(CurrentLabel);
            Controls.Add(CountLabel);
            Controls.Add(ExitButton);
            Controls.Add(GenderTextBox);
            Controls.Add(AgeTextBox);
            Controls.Add(WidthTextBox);
            Controls.Add(HeightTextBox);
            Controls.Add(ChangeButton);
            Controls.Add(AgeLabel);
            Controls.Add(CityLabel);
            Controls.Add(CountryLabel);
            Controls.Add(HeightLabel);
            Controls.Add(WidthLabel);
            Controls.Add(NameLabel);
            Controls.Add(GenderLabel);
            Controls.Add(CityTextBox);
            Controls.Add(CountryTextBox);
            Controls.Add(NameTextBox);
            Controls.Add(DataLabel);
            Controls.Add(VariantLabel);
            Controls.Add(HeaderLabel);
            Name = "MainForm";
            Text = "Данные человека";
            Load += CreateForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label HeaderLabel;
        private Label VariantLabel;
        private Label DataLabel;
        private TextBox NameTextBox;
        private TextBox CountryTextBox;
        private TextBox CityTextBox;
        private Label GenderLabel;
        private Label NameLabel;
        private Label WidthLabel;
        private Label HeightLabel;
        private Label CountryLabel;
        private Label CityLabel;
        private Label AgeLabel;
        private Button ChangeButton;
        private TextBox HeightTextBox;
        private TextBox WidthTextBox;
        private TextBox AgeTextBox;
        private TextBox GenderTextBox;
        private Button ExitButton;
        private Label CountLabel;
        private Label CurrentLabel;
    }
}
