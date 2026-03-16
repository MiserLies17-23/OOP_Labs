namespace WinFormsApp_OOP_Lab7.View
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
            Title = new Label();
            Subtitle = new Label();
            TeamLabel = new Label();
            OptionLabel = new Label();
            RepresentationLabel = new Label();
            ConsoleButton = new Button();
            FormButton = new Button();
            ExitButton = new Button();
            SuspendLayout();
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Title.Location = new Point(178, 14);
            Title.Name = "Title";
            Title.Size = new Size(242, 25);
            Title.TabIndex = 0;
            Title.Text = "Лабораторная работа №7";
            // 
            // Subtitle
            // 
            Subtitle.AutoSize = true;
            Subtitle.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Subtitle.Location = new Point(188, 48);
            Subtitle.Name = "Subtitle";
            Subtitle.Size = new Size(223, 23);
            Subtitle.TabIndex = 1;
            Subtitle.Text = "Реализация паттерна MVC";
            // 
            // TeamLabel
            // 
            TeamLabel.AutoSize = true;
            TeamLabel.Location = new Point(155, 81);
            TeamLabel.Name = "TeamLabel";
            TeamLabel.Size = new Size(302, 20);
            TeamLabel.TabIndex = 2;
            TeamLabel.Text = "Бриагада 13: Пономарев П., Толстоухов В.";
            // 
            // OptionLabel
            // 
            OptionLabel.AutoSize = true;
            OptionLabel.Location = new Point(214, 113);
            OptionLabel.Name = "OptionLabel";
            OptionLabel.Size = new Size(152, 20);
            OptionLabel.TabIndex = 3;
            OptionLabel.Text = "Вариант 13: Человек";
            // 
            // RepresentationLabel
            // 
            RepresentationLabel.AutoSize = true;
            RepresentationLabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            RepresentationLabel.Location = new Point(155, 194);
            RepresentationLabel.Name = "RepresentationLabel";
            RepresentationLabel.Size = new Size(285, 23);
            RepresentationLabel.TabIndex = 4;
            RepresentationLabel.Text = "Выберите форму представления";
            // 
            // ConsoleButton
            // 
            ConsoleButton.Location = new Point(131, 260);
            ConsoleButton.Name = "ConsoleButton";
            ConsoleButton.Size = new Size(95, 33);
            ConsoleButton.TabIndex = 5;
            ConsoleButton.Text = "Консоль";
            ConsoleButton.UseVisualStyleBackColor = true;
            ConsoleButton.Click += ConsoleButton_Click;
            // 
            // FormButton
            // 
            FormButton.Location = new Point(346, 264);
            FormButton.Name = "FormButton";
            FormButton.Size = new Size(94, 29);
            FormButton.TabIndex = 6;
            FormButton.Text = "Форма";
            FormButton.UseVisualStyleBackColor = true;
            FormButton.Click += FormButton_Click;
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(12, 317);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(94, 29);
            ExitButton.TabIndex = 7;
            ExitButton.Text = "Выйти";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
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
            Text = "Приветственная форма";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Title;
        private Label Subtitle;
        private Label TeamLabel;
        private Label OptionLabel;
        private Label RepresentationLabel;
        private Button ConsoleButton;
        private Button FormButton;
        private Button ExitButton;
    }
}