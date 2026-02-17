namespace WinFormsApp_OOP_Lab4
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
            EventLabel = new Label();
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
            ProxyHeaderLabel = new Label();
            ExitButton = new Button();
            ChangeButton = new Button();
            SuspendLayout();
            // 
            // EventLabel
            // 
            EventLabel.AutoSize = true;
            EventLabel.Location = new Point(35, 66);
            EventLabel.Name = "EventLabel";
            EventLabel.Size = new Size(168, 20);
            EventLabel.TabIndex = 0;
            EventLabel.Text = "События в PersonProxy:";
            // 
            // AgeLabel
            // 
            AgeLabel.AutoSize = true;
            AgeLabel.Location = new Point(250, 271);
            AgeLabel.Name = "AgeLabel";
            AgeLabel.Size = new Size(64, 20);
            AgeLabel.TabIndex = 27;
            AgeLabel.Text = "Возраст";
            // 
            // CityLabel
            // 
            CityLabel.AutoSize = true;
            CityLabel.Location = new Point(510, 206);
            CityLabel.Name = "CityLabel";
            CityLabel.Size = new Size(51, 20);
            CityLabel.TabIndex = 26;
            CityLabel.Text = "Город";
            // 
            // CoutryLabel
            // 
            CoutryLabel.AutoSize = true;
            CoutryLabel.Location = new Point(510, 151);
            CoutryLabel.Name = "CoutryLabel";
            CoutryLabel.Size = new Size(58, 20);
            CoutryLabel.TabIndex = 25;
            CoutryLabel.Text = "Страна";
            // 
            // WidthLabel
            // 
            WidthLabel.AutoSize = true;
            WidthLabel.Location = new Point(275, 206);
            WidthLabel.Name = "WidthLabel";
            WidthLabel.Size = new Size(33, 20);
            WidthLabel.TabIndex = 24;
            WidthLabel.Text = "Вес";
            // 
            // HeightLabel
            // 
            HeightLabel.AutoSize = true;
            HeightLabel.Location = new Point(275, 151);
            HeightLabel.Name = "HeightLabel";
            HeightLabel.Size = new Size(39, 20);
            HeightLabel.TabIndex = 23;
            HeightLabel.Text = "Рост";
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Location = new Point(35, 201);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(39, 20);
            NameLabel.TabIndex = 22;
            NameLabel.Text = "Имя";
            // 
            // GenLabel
            // 
            GenLabel.AutoSize = true;
            GenLabel.Location = new Point(35, 147);
            GenLabel.Name = "GenLabel";
            GenLabel.Size = new Size(37, 20);
            GenLabel.TabIndex = 21;
            GenLabel.Text = "Пол";
            // 
            // AgeTextBox
            // 
            AgeTextBox.Location = new Point(320, 264);
            AgeTextBox.Name = "AgeTextBox";
            AgeTextBox.ReadOnly = true;
            AgeTextBox.Size = new Size(125, 27);
            AgeTextBox.TabIndex = 20;
            // 
            // CityTextBox
            // 
            CityTextBox.Location = new Point(574, 199);
            CityTextBox.Name = "CityTextBox";
            CityTextBox.ReadOnly = true;
            CityTextBox.Size = new Size(125, 27);
            CityTextBox.TabIndex = 19;
            // 
            // CountryTextBox
            // 
            CountryTextBox.Location = new Point(574, 147);
            CountryTextBox.Name = "CountryTextBox";
            CountryTextBox.ReadOnly = true;
            CountryTextBox.Size = new Size(125, 27);
            CountryTextBox.TabIndex = 18;
            // 
            // WidthTextBox
            // 
            WidthTextBox.Location = new Point(320, 203);
            WidthTextBox.Name = "WidthTextBox";
            WidthTextBox.ReadOnly = true;
            WidthTextBox.Size = new Size(125, 27);
            WidthTextBox.TabIndex = 17;
            // 
            // HeightTextBox
            // 
            HeightTextBox.Location = new Point(320, 144);
            HeightTextBox.Name = "HeightTextBox";
            HeightTextBox.ReadOnly = true;
            HeightTextBox.Size = new Size(125, 27);
            HeightTextBox.TabIndex = 16;
            // 
            // GenTextBox
            // 
            GenTextBox.Location = new Point(85, 144);
            GenTextBox.Name = "GenTextBox";
            GenTextBox.ReadOnly = true;
            GenTextBox.Size = new Size(125, 27);
            GenTextBox.TabIndex = 15;
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(85, 194);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.ReadOnly = true;
            NameTextBox.Size = new Size(125, 27);
            NameTextBox.TabIndex = 14;
            // 
            // ProxyHeaderLabel
            // 
            ProxyHeaderLabel.AutoSize = true;
            ProxyHeaderLabel.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            ProxyHeaderLabel.Location = new Point(221, 26);
            ProxyHeaderLabel.Name = "ProxyHeaderLabel";
            ProxyHeaderLabel.Size = new Size(376, 25);
            ProxyHeaderLabel.TabIndex = 28;
            ProxyHeaderLabel.Text = "Реализация структурного паттерна Proxy";
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(35, 354);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(94, 29);
            ExitButton.TabIndex = 29;
            ExitButton.Text = "Выход";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // ChangeButton
            // 
            ChangeButton.Location = new Point(320, 316);
            ChangeButton.Name = "ChangeButton";
            ChangeButton.Size = new Size(94, 29);
            ChangeButton.TabIndex = 30;
            ChangeButton.Text = "Изменить";
            ChangeButton.UseVisualStyleBackColor = true;
            ChangeButton.Click += this.ChangeButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ChangeButton);
            Controls.Add(ExitButton);
            Controls.Add(ProxyHeaderLabel);
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
            Controls.Add(EventLabel);
            Name = "MainForm";
            Text = "Form1";
            Load += MainForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label EventLabel;
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
        private Label ProxyHeaderLabel;
        private Button ExitButton;
        private Button ChangeButton;
    }
}
