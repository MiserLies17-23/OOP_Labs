namespace WinFormsApp_OOP_Lab3
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
            NameTextBox = new TextBox();
            GenTextBox = new TextBox();
            HeightTextBox = new TextBox();
            WidthTextBox = new TextBox();
            CountryTextBox = new TextBox();
            CityTextBox = new TextBox();
            AgeTextBox = new TextBox();
            GenLabel = new Label();
            NameLabel = new Label();
            HeightLabel = new Label();
            WidthLabel = new Label();
            CoutryLabel = new Label();
            CityLabel = new Label();
            AgeLabel = new Label();
            MainObjectLabel = new Label();
            ChangeButton = new Button();
            DeepCloneButton = new Button();
            ExitButton = new Button();
            ShallowCloneButton = new Button();
            ClonesDataGridView = new DataGridView();
            IdColumn = new DataGridViewTextBoxColumn();
            NameColumn = new DataGridViewTextBoxColumn();
            CloneTypeColumn = new DataGridViewTextBoxColumn();
            ActionColumn = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)ClonesDataGridView).BeginInit();
            SuspendLayout();
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(68, 119);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.ReadOnly = true;
            NameTextBox.Size = new Size(125, 27);
            NameTextBox.TabIndex = 0;
            // 
            // GenTextBox
            // 
            GenTextBox.Location = new Point(68, 69);
            GenTextBox.Name = "GenTextBox";
            GenTextBox.ReadOnly = true;
            GenTextBox.Size = new Size(125, 27);
            GenTextBox.TabIndex = 1;
            // 
            // HeightTextBox
            // 
            HeightTextBox.Location = new Point(303, 69);
            HeightTextBox.Name = "HeightTextBox";
            HeightTextBox.ReadOnly = true;
            HeightTextBox.Size = new Size(125, 27);
            HeightTextBox.TabIndex = 2;
            // 
            // WidthTextBox
            // 
            WidthTextBox.Location = new Point(303, 128);
            WidthTextBox.Name = "WidthTextBox";
            WidthTextBox.ReadOnly = true;
            WidthTextBox.Size = new Size(125, 27);
            WidthTextBox.TabIndex = 3;
            // 
            // CountryTextBox
            // 
            CountryTextBox.Location = new Point(557, 72);
            CountryTextBox.Name = "CountryTextBox";
            CountryTextBox.ReadOnly = true;
            CountryTextBox.Size = new Size(125, 27);
            CountryTextBox.TabIndex = 4;
            // 
            // CityTextBox
            // 
            CityTextBox.Location = new Point(557, 124);
            CityTextBox.Name = "CityTextBox";
            CityTextBox.ReadOnly = true;
            CityTextBox.Size = new Size(125, 27);
            CityTextBox.TabIndex = 5;
            // 
            // AgeTextBox
            // 
            AgeTextBox.Location = new Point(303, 189);
            AgeTextBox.Name = "AgeTextBox";
            AgeTextBox.ReadOnly = true;
            AgeTextBox.Size = new Size(125, 27);
            AgeTextBox.TabIndex = 6;
            // 
            // GenLabel
            // 
            GenLabel.AutoSize = true;
            GenLabel.Location = new Point(18, 72);
            GenLabel.Name = "GenLabel";
            GenLabel.Size = new Size(37, 20);
            GenLabel.TabIndex = 7;
            GenLabel.Text = "Пол";
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Location = new Point(18, 126);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(39, 20);
            NameLabel.TabIndex = 8;
            NameLabel.Text = "Имя";
            // 
            // HeightLabel
            // 
            HeightLabel.AutoSize = true;
            HeightLabel.Location = new Point(258, 76);
            HeightLabel.Name = "HeightLabel";
            HeightLabel.Size = new Size(39, 20);
            HeightLabel.TabIndex = 9;
            HeightLabel.Text = "Рост";
            // 
            // WidthLabel
            // 
            WidthLabel.AutoSize = true;
            WidthLabel.Location = new Point(258, 131);
            WidthLabel.Name = "WidthLabel";
            WidthLabel.Size = new Size(33, 20);
            WidthLabel.TabIndex = 10;
            WidthLabel.Text = "Вес";
            // 
            // CoutryLabel
            // 
            CoutryLabel.AutoSize = true;
            CoutryLabel.Location = new Point(493, 76);
            CoutryLabel.Name = "CoutryLabel";
            CoutryLabel.Size = new Size(58, 20);
            CoutryLabel.TabIndex = 11;
            CoutryLabel.Text = "Страна";
            // 
            // CityLabel
            // 
            CityLabel.AutoSize = true;
            CityLabel.Location = new Point(493, 131);
            CityLabel.Name = "CityLabel";
            CityLabel.Size = new Size(51, 20);
            CityLabel.TabIndex = 12;
            CityLabel.Text = "Город";
            // 
            // AgeLabel
            // 
            AgeLabel.AutoSize = true;
            AgeLabel.Location = new Point(233, 196);
            AgeLabel.Name = "AgeLabel";
            AgeLabel.Size = new Size(64, 20);
            AgeLabel.TabIndex = 13;
            AgeLabel.Text = "Возраст";
            // 
            // MainObjectLabel
            // 
            MainObjectLabel.AutoSize = true;
            MainObjectLabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            MainObjectLabel.Location = new Point(289, 27);
            MainObjectLabel.Name = "MainObjectLabel";
            MainObjectLabel.Size = new Size(155, 23);
            MainObjectLabel.TabIndex = 14;
            MainObjectLabel.Text = "Основной объект";
            // 
            // ChangeButton
            // 
            ChangeButton.Location = new Point(191, 262);
            ChangeButton.Name = "ChangeButton";
            ChangeButton.Size = new Size(94, 32);
            ChangeButton.TabIndex = 15;
            ChangeButton.Text = "Изменить";
            ChangeButton.UseVisualStyleBackColor = true;
            ChangeButton.Click += ChangeButton_Click;
            // 
            // DeepCloneButton
            // 
            DeepCloneButton.Location = new Point(332, 250);
            DeepCloneButton.Name = "DeepCloneButton";
            DeepCloneButton.Size = new Size(123, 56);
            DeepCloneButton.TabIndex = 16;
            DeepCloneButton.Text = "Глуб. клонирование";
            DeepCloneButton.UseVisualStyleBackColor = true;
            DeepCloneButton.Click += CloneButton_Click;
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(31, 487);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(94, 29);
            ExitButton.TabIndex = 17;
            ExitButton.Text = "Выход";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // ShallowCloneButton
            // 
            ShallowCloneButton.Location = new Point(477, 250);
            ShallowCloneButton.Name = "ShallowCloneButton";
            ShallowCloneButton.Size = new Size(123, 56);
            ShallowCloneButton.TabIndex = 18;
            ShallowCloneButton.Text = "неглуб. клонирование";
            ShallowCloneButton.UseVisualStyleBackColor = true;
            ShallowCloneButton.Click += ShallowCloneButton_Click;
            // 
            // ClonesDataGridView
            // 
            ClonesDataGridView.AllowUserToAddRows = false;
            ClonesDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ClonesDataGridView.Columns.AddRange(new DataGridViewColumn[] { IdColumn, NameColumn, CloneTypeColumn, ActionColumn });
            ClonesDataGridView.Location = new Point(117, 312);
            ClonesDataGridView.Name = "ClonesDataGridView";
            ClonesDataGridView.RowHeadersVisible = false;
            ClonesDataGridView.RowHeadersWidth = 51;
            ClonesDataGridView.Size = new Size(553, 168);
            ClonesDataGridView.TabIndex = 19;
            ClonesDataGridView.CellContentClick += ClonesDataGridView_CellContentClick;
            // 
            // IdColumn
            // 
            IdColumn.HeaderText = "Id";
            IdColumn.MinimumWidth = 6;
            IdColumn.Name = "IdColumn";
            IdColumn.Width = 125;
            // 
            // NameColumn
            // 
            NameColumn.HeaderText = "Объект";
            NameColumn.MinimumWidth = 6;
            NameColumn.Name = "NameColumn";
            NameColumn.Width = 125;
            // 
            // CloneTypeColumn
            // 
            CloneTypeColumn.HeaderText = "Тип клонирования";
            CloneTypeColumn.MinimumWidth = 6;
            CloneTypeColumn.Name = "CloneTypeColumn";
            CloneTypeColumn.Width = 175;
            // 
            // ActionColumn
            // 
            ActionColumn.HeaderText = "Действие";
            ActionColumn.MinimumWidth = 6;
            ActionColumn.Name = "ActionColumn";
            ActionColumn.Resizable = DataGridViewTriState.True;
            ActionColumn.SortMode = DataGridViewColumnSortMode.Automatic;
            ActionColumn.Width = 125;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 528);
            Controls.Add(ClonesDataGridView);
            Controls.Add(ShallowCloneButton);
            Controls.Add(ExitButton);
            Controls.Add(DeepCloneButton);
            Controls.Add(ChangeButton);
            Controls.Add(MainObjectLabel);
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
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "MainForm";
            Text = "Главная форма";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)ClonesDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox NameTextBox;
        private TextBox GenTextBox;
        private TextBox HeightTextBox;
        private TextBox WidthTextBox;
        private TextBox CountryTextBox;
        private TextBox CityTextBox;
        private TextBox AgeTextBox;
        private Label GenLabel;
        private Label NameLabel;
        private Label HeightLabel;
        private Label WidthLabel;
        private Label CoutryLabel;
        private Label CityLabel;
        private Label AgeLabel;
        private Label MainObjectLabel;
        private Button ChangeButton;
        private Button DeepCloneButton;
        private Button ExitButton;
        private Button ShallowCloneButton;
        private DataGridView ClonesDataGridView;
        private DataGridViewTextBoxColumn IdColumn;
        private DataGridViewTextBoxColumn NameColumn;
        private DataGridViewTextBoxColumn CloneTypeColumn;
        private DataGridViewButtonColumn ActionColumn;
    }
}
