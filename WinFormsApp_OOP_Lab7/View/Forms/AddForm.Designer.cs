namespace WinFormsApp_OOP_Lab7.Forms
{
    partial class AddForm
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
            AgeTextBox = new TextBox();
            AgeLabel = new Label();
            GenderComboBox = new ComboBox();
            GenderLabel = new Label();
            NameLabel = new Label();
            NameTextBox = new TextBox();
            ExitButton = new Button();
            AddButton = new Button();
            SuspendLayout();
            // 
            // Header
            // 
            Header.AutoSize = true;
            Header.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Header.Location = new Point(195, 25);
            Header.Name = "Header";
            Header.Size = new Size(275, 25);
            Header.TabIndex = 0;
            Header.Text = "Добавление нового человека";
            // 
            // AgeTextBox
            // 
            AgeTextBox.Location = new Point(528, 100);
            AgeTextBox.Name = "AgeTextBox";
            AgeTextBox.Size = new Size(125, 27);
            AgeTextBox.TabIndex = 77;
            // 
            // AgeLabel
            // 
            AgeLabel.AutoSize = true;
            AgeLabel.Location = new Point(458, 103);
            AgeLabel.Name = "AgeLabel";
            AgeLabel.Size = new Size(64, 20);
            AgeLabel.TabIndex = 76;
            AgeLabel.Text = "Возраст";
            // 
            // GenderComboBox
            // 
            GenderComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            GenderComboBox.FormattingEnabled = true;
            GenderComboBox.Items.AddRange(new object[] { "Муж", "Жен" });
            GenderComboBox.Location = new Point(61, 100);
            GenderComboBox.Name = "GenderComboBox";
            GenderComboBox.Size = new Size(125, 28);
            GenderComboBox.TabIndex = 75;
            // 
            // GenderLabel
            // 
            GenderLabel.AutoSize = true;
            GenderLabel.Location = new Point(18, 103);
            GenderLabel.Name = "GenderLabel";
            GenderLabel.Size = new Size(37, 20);
            GenderLabel.TabIndex = 74;
            GenderLabel.Text = "Пол";
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Location = new Point(233, 103);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(39, 20);
            NameLabel.TabIndex = 73;
            NameLabel.Text = "Имя";
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(278, 100);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(125, 27);
            NameTextBox.TabIndex = 72;
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(18, 226);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(94, 29);
            ExitButton.TabIndex = 71;
            ExitButton.Text = "Назад";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // AddButton
            // 
            AddButton.Location = new Point(291, 173);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(94, 29);
            AddButton.TabIndex = 70;
            AddButton.Text = "Создать";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // AddForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(673, 301);
            Controls.Add(AgeTextBox);
            Controls.Add(AgeLabel);
            Controls.Add(GenderComboBox);
            Controls.Add(GenderLabel);
            Controls.Add(NameLabel);
            Controls.Add(NameTextBox);
            Controls.Add(ExitButton);
            Controls.Add(AddButton);
            Controls.Add(Header);
            Name = "AddForm";
            Text = "Форма добавления";
            Load += AddForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Header;
        private TextBox AgeTextBox;
        private Label AgeLabel;
        private ComboBox GenderComboBox;
        private Label GenderLabel;
        private Label NameLabel;
        private TextBox NameTextBox;
        private Button ExitButton;
        private Button AddButton;
    }
}