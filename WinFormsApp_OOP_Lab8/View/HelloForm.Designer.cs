namespace WinFormsApp_OOP_Lab8.View
{
    partial class HelloForm
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
            ExitButton = new Button();
            FormButton = new Button();
            ConsoleButton = new Button();
            RepresentationLabel = new Label();
            OptionLabel = new Label();
            TeamLabel = new Label();
            Subtitle = new Label();
            Title = new Label();
            SuspendLayout();
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(9, 322);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(94, 29);
            ExitButton.TabIndex = 15;
            ExitButton.Text = "Выйти";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // FormButton
            // 
            FormButton.Location = new Point(343, 244);
            FormButton.Name = "FormButton";
            FormButton.Size = new Size(94, 29);
            FormButton.TabIndex = 14;
            FormButton.Text = "Форма";
            FormButton.UseVisualStyleBackColor = true;
            FormButton.Click += FormButton_Click;
            // 
            // ConsoleButton
            // 
            ConsoleButton.Location = new Point(128, 240);
            ConsoleButton.Name = "ConsoleButton";
            ConsoleButton.Size = new Size(95, 33);
            ConsoleButton.TabIndex = 13;
            ConsoleButton.Text = "Консоль";
            ConsoleButton.UseVisualStyleBackColor = true;
            ConsoleButton.Click += ConsoleButton_Click;
            // 
            // RepresentationLabel
            // 
            RepresentationLabel.AutoSize = true;
            RepresentationLabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            RepresentationLabel.Location = new Point(152, 174);
            RepresentationLabel.Name = "RepresentationLabel";
            RepresentationLabel.Size = new Size(285, 23);
            RepresentationLabel.TabIndex = 12;
            RepresentationLabel.Text = "Выберите форму представления";
            // 
            // OptionLabel
            // 
            OptionLabel.AutoSize = true;
            OptionLabel.Location = new Point(211, 118);
            OptionLabel.Name = "OptionLabel";
            OptionLabel.Size = new Size(152, 20);
            OptionLabel.TabIndex = 11;
            OptionLabel.Text = "Вариант 13: Человек";
            // 
            // TeamLabel
            // 
            TeamLabel.AutoSize = true;
            TeamLabel.Location = new Point(152, 86);
            TeamLabel.Name = "TeamLabel";
            TeamLabel.Size = new Size(302, 20);
            TeamLabel.TabIndex = 10;
            TeamLabel.Text = "Бриагада 13: Пономарев П., Толстоухов В.";
            // 
            // Subtitle
            // 
            Subtitle.AutoSize = true;
            Subtitle.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Subtitle.Location = new Point(185, 53);
            Subtitle.Name = "Subtitle";
            Subtitle.Size = new Size(222, 23);
            Subtitle.TabIndex = 9;
            Subtitle.Text = "Реализация паттерна MVP";
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Title.Location = new Point(175, 19);
            Title.Name = "Title";
            Title.Size = new Size(242, 25);
            Title.TabIndex = 8;
            Title.Text = "Лабораторная работа №8";
            // 
            // HelloForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(602, 358);
            Controls.Add(ExitButton);
            Controls.Add(FormButton);
            Controls.Add(ConsoleButton);
            Controls.Add(RepresentationLabel);
            Controls.Add(OptionLabel);
            Controls.Add(TeamLabel);
            Controls.Add(Subtitle);
            Controls.Add(Title);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "HelloForm";
            Text = "HelloForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ExitButton;
        private Button FormButton;
        private Button ConsoleButton;
        private Label RepresentationLabel;
        private Label OptionLabel;
        private Label TeamLabel;
        private Label Subtitle;
        private Label Title;
    }
}