namespace WinFormsApp_OOP_Lab5.Forms
{
    partial class ShowPersonForm
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
            PersonLabel = new Label();
            AgeLabel = new Label();
            ProfessionLabel = new Label();
            CoutryLabel = new Label();
            WidthLabel = new Label();
            HeightLabel = new Label();
            NameLabel = new Label();
            GenLabel = new Label();
            AgeTextBox = new TextBox();
            ProfessionTextBox = new TextBox();
            CountryTextBox = new TextBox();
            WidthTextBox = new TextBox();
            HeightTextBox = new TextBox();
            GenTextBox = new TextBox();
            NameTextBox = new TextBox();
            IdLabel = new Label();
            ExitButton = new Button();
            SuspendLayout();
            // 
            // PersonLabel
            // 
            PersonLabel.AutoSize = true;
            PersonLabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            PersonLabel.Location = new Point(307, 28);
            PersonLabel.Name = "PersonLabel";
            PersonLabel.Size = new Size(157, 23);
            PersonLabel.TabIndex = 29;
            PersonLabel.Text = "Данные человека";
            // 
            // AgeLabel
            // 
            AgeLabel.AutoSize = true;
            AgeLabel.Location = new Point(251, 197);
            AgeLabel.Name = "AgeLabel";
            AgeLabel.Size = new Size(64, 20);
            AgeLabel.TabIndex = 28;
            AgeLabel.Text = "Возраст";
            // 
            // ProfessionLabel
            // 
            ProfessionLabel.AutoSize = true;
            ProfessionLabel.Location = new Point(511, 132);
            ProfessionLabel.Name = "ProfessionLabel";
            ProfessionLabel.Size = new Size(87, 20);
            ProfessionLabel.TabIndex = 27;
            ProfessionLabel.Text = "Профессия";
            // 
            // CoutryLabel
            // 
            CoutryLabel.AutoSize = true;
            CoutryLabel.Location = new Point(511, 77);
            CoutryLabel.Name = "CoutryLabel";
            CoutryLabel.Size = new Size(58, 20);
            CoutryLabel.TabIndex = 26;
            CoutryLabel.Text = "Страна";
            // 
            // WidthLabel
            // 
            WidthLabel.AutoSize = true;
            WidthLabel.Location = new Point(276, 132);
            WidthLabel.Name = "WidthLabel";
            WidthLabel.Size = new Size(33, 20);
            WidthLabel.TabIndex = 25;
            WidthLabel.Text = "Вес";
            // 
            // HeightLabel
            // 
            HeightLabel.AutoSize = true;
            HeightLabel.Location = new Point(276, 77);
            HeightLabel.Name = "HeightLabel";
            HeightLabel.Size = new Size(39, 20);
            HeightLabel.TabIndex = 24;
            HeightLabel.Text = "Рост";
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Location = new Point(36, 127);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(39, 20);
            NameLabel.TabIndex = 23;
            NameLabel.Text = "Имя";
            // 
            // GenLabel
            // 
            GenLabel.AutoSize = true;
            GenLabel.Location = new Point(36, 73);
            GenLabel.Name = "GenLabel";
            GenLabel.Size = new Size(37, 20);
            GenLabel.TabIndex = 22;
            GenLabel.Text = "Пол";
            // 
            // AgeTextBox
            // 
            AgeTextBox.Location = new Point(321, 190);
            AgeTextBox.Name = "AgeTextBox";
            AgeTextBox.ReadOnly = true;
            AgeTextBox.Size = new Size(125, 27);
            AgeTextBox.TabIndex = 21;
            // 
            // ProfessionTextBox
            // 
            ProfessionTextBox.Location = new Point(604, 129);
            ProfessionTextBox.Name = "ProfessionTextBox";
            ProfessionTextBox.ReadOnly = true;
            ProfessionTextBox.Size = new Size(125, 27);
            ProfessionTextBox.TabIndex = 20;
            // 
            // CountryTextBox
            // 
            CountryTextBox.Location = new Point(604, 77);
            CountryTextBox.Name = "CountryTextBox";
            CountryTextBox.ReadOnly = true;
            CountryTextBox.Size = new Size(125, 27);
            CountryTextBox.TabIndex = 19;
            // 
            // WidthTextBox
            // 
            WidthTextBox.Location = new Point(321, 129);
            WidthTextBox.Name = "WidthTextBox";
            WidthTextBox.ReadOnly = true;
            WidthTextBox.Size = new Size(125, 27);
            WidthTextBox.TabIndex = 18;
            // 
            // HeightTextBox
            // 
            HeightTextBox.Location = new Point(321, 70);
            HeightTextBox.Name = "HeightTextBox";
            HeightTextBox.ReadOnly = true;
            HeightTextBox.Size = new Size(125, 27);
            HeightTextBox.TabIndex = 17;
            // 
            // GenTextBox
            // 
            GenTextBox.Location = new Point(86, 70);
            GenTextBox.Name = "GenTextBox";
            GenTextBox.ReadOnly = true;
            GenTextBox.Size = new Size(125, 27);
            GenTextBox.TabIndex = 16;
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(86, 120);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.ReadOnly = true;
            NameTextBox.Size = new Size(125, 27);
            NameTextBox.TabIndex = 15;
            // 
            // IdLabel
            // 
            IdLabel.AutoSize = true;
            IdLabel.Location = new Point(36, 31);
            IdLabel.Name = "IdLabel";
            IdLabel.Size = new Size(29, 20);
            IdLabel.TabIndex = 30;
            IdLabel.Text = "Id: ";
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(36, 251);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(94, 29);
            ExitButton.TabIndex = 31;
            ExitButton.Text = "Назад";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // ShowPersonForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(746, 305);
            Controls.Add(ExitButton);
            Controls.Add(IdLabel);
            Controls.Add(PersonLabel);
            Controls.Add(AgeLabel);
            Controls.Add(ProfessionLabel);
            Controls.Add(CoutryLabel);
            Controls.Add(WidthLabel);
            Controls.Add(HeightLabel);
            Controls.Add(NameLabel);
            Controls.Add(GenLabel);
            Controls.Add(AgeTextBox);
            Controls.Add(ProfessionTextBox);
            Controls.Add(CountryTextBox);
            Controls.Add(WidthTextBox);
            Controls.Add(HeightTextBox);
            Controls.Add(GenTextBox);
            Controls.Add(NameTextBox);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ShowPersonForm";
            Text = "Данные человека";
            Load += ShowPersonForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label PersonLabel;
        private Label AgeLabel;
        private Label ProfessionLabel;
        private Label CoutryLabel;
        private Label WidthLabel;
        private Label HeightLabel;
        private Label NameLabel;
        private Label GenLabel;
        private TextBox AgeTextBox;
        private TextBox ProfessionTextBox;
        private TextBox CountryTextBox;
        private TextBox WidthTextBox;
        private TextBox HeightTextBox;
        private TextBox GenTextBox;
        private TextBox NameTextBox;
        private Label IdLabel;
        private Button ExitButton;
    }
}