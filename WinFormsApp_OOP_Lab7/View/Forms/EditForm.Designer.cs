namespace WinFormsApp_OOP_Lab7.Forms
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
            Header = new Label();
            EditButton = new Button();
            ExitButton = new Button();
            GenderComboBox = new ComboBox();
            GenderLabel = new Label();
            NameLabel = new Label();
            NameTextBox = new TextBox();
            AgeTextBox = new TextBox();
            AgeLabel = new Label();
            IdLabel = new Label();
            SuspendLayout();
            // 
            // Header
            // 
            Header.AutoSize = true;
            Header.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Header.Location = new Point(180, 21);
            Header.Name = "Header";
            Header.Size = new Size(336, 25);
            Header.TabIndex = 0;
            Header.Text = "Форма изменения данных человека";
            // 
            // EditButton
            // 
            EditButton.Location = new Point(317, 180);
            EditButton.Name = "EditButton";
            EditButton.Size = new Size(94, 29);
            EditButton.TabIndex = 1;
            EditButton.Text = "Сохранить";
            EditButton.UseVisualStyleBackColor = true;
            EditButton.Click += EditButton_Click;
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(43, 228);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(94, 29);
            ExitButton.TabIndex = 2;
            ExitButton.Text = "Назад";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // GenderComboBox
            // 
            GenderComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            GenderComboBox.FormattingEnabled = true;
            GenderComboBox.Items.AddRange(new object[] { "Муж", "Жен" });
            GenderComboBox.Location = new Point(86, 102);
            GenderComboBox.Name = "GenderComboBox";
            GenderComboBox.Size = new Size(125, 28);
            GenderComboBox.TabIndex = 67;
            // 
            // GenderLabel
            // 
            GenderLabel.AutoSize = true;
            GenderLabel.Location = new Point(43, 105);
            GenderLabel.Name = "GenderLabel";
            GenderLabel.Size = new Size(37, 20);
            GenderLabel.TabIndex = 66;
            GenderLabel.Text = "Пол";
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Location = new Point(258, 105);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(39, 20);
            NameLabel.TabIndex = 65;
            NameLabel.Text = "Имя";
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(303, 102);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(125, 27);
            NameTextBox.TabIndex = 64;
            // 
            // AgeTextBox
            // 
            AgeTextBox.Location = new Point(553, 102);
            AgeTextBox.Name = "AgeTextBox";
            AgeTextBox.Size = new Size(125, 27);
            AgeTextBox.TabIndex = 69;
            // 
            // AgeLabel
            // 
            AgeLabel.AutoSize = true;
            AgeLabel.Location = new Point(483, 105);
            AgeLabel.Name = "AgeLabel";
            AgeLabel.Size = new Size(64, 20);
            AgeLabel.TabIndex = 68;
            AgeLabel.Text = "Возраст";
            // 
            // IdLabel
            // 
            IdLabel.AutoSize = true;
            IdLabel.Location = new Point(43, 59);
            IdLabel.Name = "IdLabel";
            IdLabel.Size = new Size(29, 20);
            IdLabel.TabIndex = 70;
            IdLabel.Text = "Id: ";
            // 
            // EditForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(754, 306);
            Controls.Add(IdLabel);
            Controls.Add(AgeTextBox);
            Controls.Add(AgeLabel);
            Controls.Add(GenderComboBox);
            Controls.Add(GenderLabel);
            Controls.Add(NameLabel);
            Controls.Add(NameTextBox);
            Controls.Add(ExitButton);
            Controls.Add(EditButton);
            Controls.Add(Header);
            Name = "EditForm";
            Text = "Форма изменения";
            Load += EditForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Header;
        private Button EditButton;
        private Button ExitButton;
        private ComboBox GenderComboBox;
        private Label GenderLabel;
        private Label NameLabel;
        private TextBox NameTextBox;
        private TextBox AgeTextBox;
        private Label AgeLabel;
        private Label IdLabel;
    }
}