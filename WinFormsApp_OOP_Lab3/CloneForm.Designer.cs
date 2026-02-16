namespace WinFormsApp_OOP_Lab3
{
    partial class CloneForm
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
            CloneObjectLabel = new Label();
            AgeLabel = new Label();
            CityLabel = new Label();
            CoutryLabel = new Label();
            WidthLabel = new Label();
            HeightLabel = new Label();
            NameLabel = new Label();
            GenLabel = new Label();
            AgeTextBox = new TextBox();
            CityTextBox = new TextBox();
            CountryTextBox = new TextBox();
            WidthTextBox = new TextBox();
            HeightTextBox = new TextBox();
            GenTextBox = new TextBox();
            NameTextBox = new TextBox();
            ChangeButton = new Button();
            HudeButton = new Button();
            SuspendLayout();
            // 
            // CloneObjectLabel
            // 
            CloneObjectLabel.AutoSize = true;
            CloneObjectLabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            CloneObjectLabel.Location = new Point(288, 74);
            CloneObjectLabel.Name = "CloneObjectLabel";
            CloneObjectLabel.Size = new Size(211, 23);
            CloneObjectLabel.TabIndex = 29;
            CloneObjectLabel.Text = "Клонированный объект";
            // 
            // AgeLabel
            // 
            AgeLabel.AutoSize = true;
            AgeLabel.Location = new Point(263, 250);
            AgeLabel.Name = "AgeLabel";
            AgeLabel.Size = new Size(64, 20);
            AgeLabel.TabIndex = 28;
            AgeLabel.Text = "Возраст";
            // 
            // CityLabel
            // 
            CityLabel.AutoSize = true;
            CityLabel.Location = new Point(490, 185);
            CityLabel.Name = "CityLabel";
            CityLabel.Size = new Size(51, 20);
            CityLabel.TabIndex = 27;
            CityLabel.Text = "Город";
            // 
            // CoutryLabel
            // 
            CoutryLabel.AutoSize = true;
            CoutryLabel.Location = new Point(490, 130);
            CoutryLabel.Name = "CoutryLabel";
            CoutryLabel.Size = new Size(58, 20);
            CoutryLabel.TabIndex = 26;
            CoutryLabel.Text = "Страна";
            // 
            // WidthLabel
            // 
            WidthLabel.AutoSize = true;
            WidthLabel.Location = new Point(288, 185);
            WidthLabel.Name = "WidthLabel";
            WidthLabel.Size = new Size(33, 20);
            WidthLabel.TabIndex = 25;
            WidthLabel.Text = "Вес";
            // 
            // HeightLabel
            // 
            HeightLabel.AutoSize = true;
            HeightLabel.Location = new Point(288, 130);
            HeightLabel.Name = "HeightLabel";
            HeightLabel.Size = new Size(39, 20);
            HeightLabel.TabIndex = 24;
            HeightLabel.Text = "Рост";
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Location = new Point(48, 180);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(39, 20);
            NameLabel.TabIndex = 23;
            NameLabel.Text = "Имя";
            // 
            // GenLabel
            // 
            GenLabel.AutoSize = true;
            GenLabel.Location = new Point(48, 126);
            GenLabel.Name = "GenLabel";
            GenLabel.Size = new Size(37, 20);
            GenLabel.TabIndex = 22;
            GenLabel.Text = "Пол";
            // 
            // AgeTextBox
            // 
            AgeTextBox.Location = new Point(333, 243);
            AgeTextBox.Name = "AgeTextBox";
            AgeTextBox.ReadOnly = true;
            AgeTextBox.Size = new Size(125, 27);
            AgeTextBox.TabIndex = 21;
            // 
            // CityTextBox
            // 
            CityTextBox.Location = new Point(554, 178);
            CityTextBox.Name = "CityTextBox";
            CityTextBox.ReadOnly = true;
            CityTextBox.Size = new Size(125, 27);
            CityTextBox.TabIndex = 20;
            // 
            // CountryTextBox
            // 
            CountryTextBox.Location = new Point(554, 126);
            CountryTextBox.Name = "CountryTextBox";
            CountryTextBox.ReadOnly = true;
            CountryTextBox.Size = new Size(125, 27);
            CountryTextBox.TabIndex = 19;
            // 
            // WidthTextBox
            // 
            WidthTextBox.Location = new Point(333, 182);
            WidthTextBox.Name = "WidthTextBox";
            WidthTextBox.ReadOnly = true;
            WidthTextBox.Size = new Size(125, 27);
            WidthTextBox.TabIndex = 18;
            // 
            // HeightTextBox
            // 
            HeightTextBox.Location = new Point(333, 123);
            HeightTextBox.Name = "HeightTextBox";
            HeightTextBox.ReadOnly = true;
            HeightTextBox.Size = new Size(125, 27);
            HeightTextBox.TabIndex = 17;
            // 
            // GenTextBox
            // 
            GenTextBox.Location = new Point(98, 123);
            GenTextBox.Name = "GenTextBox";
            GenTextBox.ReadOnly = true;
            GenTextBox.Size = new Size(125, 27);
            GenTextBox.TabIndex = 16;
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(98, 173);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.ReadOnly = true;
            NameTextBox.Size = new Size(125, 27);
            NameTextBox.TabIndex = 15;
            // 
            // ChangeButton
            // 
            ChangeButton.Location = new Point(333, 302);
            ChangeButton.Name = "ChangeButton";
            ChangeButton.Size = new Size(94, 29);
            ChangeButton.TabIndex = 30;
            ChangeButton.Text = "Изменить";
            ChangeButton.UseVisualStyleBackColor = true;
            ChangeButton.Click += ChangeButton_Click;
            // 
            // HudeButton
            // 
            HudeButton.Location = new Point(48, 409);
            HudeButton.Name = "HudeButton";
            HudeButton.Size = new Size(94, 29);
            HudeButton.TabIndex = 31;
            HudeButton.Text = "Спрятать";
            HudeButton.UseVisualStyleBackColor = true;
            HudeButton.Click += HudeButton_Click;
            // 
            // CloneForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(800, 450);
            Controls.Add(HudeButton);
            Controls.Add(ChangeButton);
            Controls.Add(CloneObjectLabel);
            Controls.Add(AgeLabel);
            Controls.Add(CityLabel);
            Controls.Add(CoutryLabel);
            Controls.Add(WidthLabel);
            Controls.Add(HeightLabel);
            Controls.Add(NameLabel);
            Controls.Add(GenLabel);
            Controls.Add(AgeTextBox);
            Controls.Add(CityTextBox);
            Controls.Add(CountryTextBox);
            Controls.Add(WidthTextBox);
            Controls.Add(HeightTextBox);
            Controls.Add(GenTextBox);
            Controls.Add(NameTextBox);
            Name = "CloneForm";
            Text = "CloneForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label CloneObjectLabel;
        private Label AgeLabel;
        private Label CityLabel;
        private Label CoutryLabel;
        private Label WidthLabel;
        private Label HeightLabel;
        private Label NameLabel;
        private Label GenLabel;
        private TextBox AgeTextBox;
        private TextBox CityTextBox;
        private TextBox CountryTextBox;
        private TextBox WidthTextBox;
        private TextBox HeightTextBox;
        private TextBox GenTextBox;
        private TextBox NameTextBox;
        private Button ChangeButton;
        private Button HudeButton;
    }
}