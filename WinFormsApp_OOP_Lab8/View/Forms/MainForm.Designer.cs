namespace WinFormsApp_OOP_Lab8
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
            MVPHeader = new Label();
            AddButton = new Button();
            PersonDataGridView = new DataGridView();
            IdColumn = new DataGridViewTextBoxColumn();
            GenderColumn = new DataGridViewTextBoxColumn();
            CountryColumn = new DataGridViewTextBoxColumn();
            CityColumn = new DataGridViewTextBoxColumn();
            EditColumn = new DataGridViewButtonColumn();
            DeleteColumn = new DataGridViewButtonColumn();
            ActivityPanel = new Panel();
            NameTextBox = new TextBox();
            CancellButton = new Button();
            IdLabel = new Label();
            CityTextBox = new TextBox();
            CityLabel = new Label();
            NameLabel = new Label();
            CountryLabel = new Label();
            CountryTextBox = new TextBox();
            SaveButton = new Button();
            ActivityLabel = new Label();
            ExitButton = new Button();
            ((System.ComponentModel.ISupportInitialize)PersonDataGridView).BeginInit();
            ActivityPanel.SuspendLayout();
            SuspendLayout();
            // 
            // MVPHeader
            // 
            MVPHeader.AutoSize = true;
            MVPHeader.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            MVPHeader.Location = new Point(288, 9);
            MVPHeader.Name = "MVPHeader";
            MVPHeader.Size = new Size(245, 25);
            MVPHeader.TabIndex = 6;
            MVPHeader.Text = "Реализация паттерна MVP";
            // 
            // AddButton
            // 
            AddButton.Location = new Point(632, 36);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(94, 29);
            AddButton.TabIndex = 5;
            AddButton.Text = "Добавить";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // PersonDataGridView
            // 
            PersonDataGridView.AllowUserToAddRows = false;
            PersonDataGridView.AllowUserToDeleteRows = false;
            PersonDataGridView.AllowUserToResizeColumns = false;
            PersonDataGridView.AllowUserToResizeRows = false;
            PersonDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PersonDataGridView.Columns.AddRange(new DataGridViewColumn[] { IdColumn, GenderColumn, CountryColumn, CityColumn, EditColumn, DeleteColumn });
            PersonDataGridView.Location = new Point(42, 71);
            PersonDataGridView.Name = "PersonDataGridView";
            PersonDataGridView.RowHeadersVisible = false;
            PersonDataGridView.RowHeadersWidth = 51;
            PersonDataGridView.Size = new Size(714, 188);
            PersonDataGridView.TabIndex = 4;
            PersonDataGridView.CellContentClick += PersonDataGridView_CellContentClick;
            // 
            // IdColumn
            // 
            IdColumn.HeaderText = "Id";
            IdColumn.MinimumWidth = 6;
            IdColumn.Name = "IdColumn";
            IdColumn.Width = 65;
            // 
            // GenderColumn
            // 
            GenderColumn.HeaderText = "Имя";
            GenderColumn.MinimumWidth = 6;
            GenderColumn.Name = "GenderColumn";
            GenderColumn.Width = 125;
            // 
            // CountryColumn
            // 
            CountryColumn.HeaderText = "Страна";
            CountryColumn.MinimumWidth = 6;
            CountryColumn.Name = "CountryColumn";
            CountryColumn.Width = 125;
            // 
            // CityColumn
            // 
            CityColumn.HeaderText = "Город";
            CityColumn.MinimumWidth = 6;
            CityColumn.Name = "CityColumn";
            CityColumn.Width = 125;
            // 
            // EditColumn
            // 
            EditColumn.HeaderText = "Изменить";
            EditColumn.MinimumWidth = 6;
            EditColumn.Name = "EditColumn";
            EditColumn.Width = 125;
            // 
            // DeleteColumn
            // 
            DeleteColumn.HeaderText = "Удалить";
            DeleteColumn.MinimumWidth = 6;
            DeleteColumn.Name = "DeleteColumn";
            DeleteColumn.Width = 125;
            // 
            // ActivityPanel
            // 
            ActivityPanel.BorderStyle = BorderStyle.FixedSingle;
            ActivityPanel.Controls.Add(NameTextBox);
            ActivityPanel.Controls.Add(CancellButton);
            ActivityPanel.Controls.Add(IdLabel);
            ActivityPanel.Controls.Add(CityTextBox);
            ActivityPanel.Controls.Add(CityLabel);
            ActivityPanel.Controls.Add(NameLabel);
            ActivityPanel.Controls.Add(CountryLabel);
            ActivityPanel.Controls.Add(CountryTextBox);
            ActivityPanel.Controls.Add(SaveButton);
            ActivityPanel.Controls.Add(ActivityLabel);
            ActivityPanel.Location = new Point(71, 265);
            ActivityPanel.Name = "ActivityPanel";
            ActivityPanel.Size = new Size(655, 159);
            ActivityPanel.TabIndex = 7;
            ActivityPanel.Visible = false;
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(58, 70);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(125, 27);
            NameTextBox.TabIndex = 81;
            // 
            // CancellButton
            // 
            CancellButton.Location = new Point(163, 115);
            CancellButton.Name = "CancellButton";
            CancellButton.Size = new Size(94, 29);
            CancellButton.TabIndex = 80;
            CancellButton.Text = "Отмена";
            CancellButton.UseVisualStyleBackColor = true;
            CancellButton.Click += CancellButton_Click;
            // 
            // IdLabel
            // 
            IdLabel.AutoSize = true;
            IdLabel.Location = new Point(15, 44);
            IdLabel.Name = "IdLabel";
            IdLabel.Size = new Size(29, 20);
            IdLabel.TabIndex = 79;
            IdLabel.Text = "Id: ";
            // 
            // CityTextBox
            // 
            CityTextBox.Location = new Point(512, 70);
            CityTextBox.Name = "CityTextBox";
            CityTextBox.Size = new Size(125, 27);
            CityTextBox.TabIndex = 78;
            // 
            // CityLabel
            // 
            CityLabel.AutoSize = true;
            CityLabel.Location = new Point(455, 73);
            CityLabel.Name = "CityLabel";
            CityLabel.Size = new Size(51, 20);
            CityLabel.TabIndex = 77;
            CityLabel.Text = "Город";
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Location = new Point(15, 73);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(39, 20);
            NameLabel.TabIndex = 75;
            NameLabel.Text = "Имя";
            // 
            // CountryLabel
            // 
            CountryLabel.AutoSize = true;
            CountryLabel.Location = new Point(216, 73);
            CountryLabel.Name = "CountryLabel";
            CountryLabel.Size = new Size(58, 20);
            CountryLabel.TabIndex = 74;
            CountryLabel.Text = "Страна";
            // 
            // CountryTextBox
            // 
            CountryTextBox.Location = new Point(275, 70);
            CountryTextBox.Name = "CountryTextBox";
            CountryTextBox.Size = new Size(125, 27);
            CountryTextBox.TabIndex = 73;
            // 
            // SaveButton
            // 
            SaveButton.Location = new Point(405, 115);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(94, 29);
            SaveButton.TabIndex = 72;
            SaveButton.Text = "Сохранить";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // ActivityLabel
            // 
            ActivityLabel.AutoSize = true;
            ActivityLabel.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            ActivityLabel.Location = new Point(163, 10);
            ActivityLabel.Name = "ActivityLabel";
            ActivityLabel.Size = new Size(336, 25);
            ActivityLabel.TabIndex = 71;
            ActivityLabel.Text = "Форма изменения данных человека";
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(12, 430);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(95, 30);
            ExitButton.TabIndex = 8;
            ExitButton.Text = "Выход";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(802, 463);
            Controls.Add(ExitButton);
            Controls.Add(ActivityPanel);
            Controls.Add(MVPHeader);
            Controls.Add(AddButton);
            Controls.Add(PersonDataGridView);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MainForm";
            Text = "Главная форма";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)PersonDataGridView).EndInit();
            ActivityPanel.ResumeLayout(false);
            ActivityPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label MVPHeader;
        private Button AddButton;
        private DataGridView PersonDataGridView;
        private Panel ActivityPanel;
        private Button CancellButton;
        private Label IdLabel;
        private TextBox CityTextBox;
        private Label CityLabel;
        private Label NameLabel;
        private Label CountryLabel;
        private TextBox CountryTextBox;
        private Button SaveButton;
        private Label ActivityLabel;
        private TextBox NameTextBox;
        private Button ExitButton;
        private DataGridViewTextBoxColumn IdColumn;
        private DataGridViewTextBoxColumn GenderColumn;
        private DataGridViewTextBoxColumn CountryColumn;
        private DataGridViewTextBoxColumn CityColumn;
        private DataGridViewButtonColumn EditColumn;
        private DataGridViewButtonColumn DeleteColumn;
    }
}
