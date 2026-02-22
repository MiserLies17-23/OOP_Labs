namespace WinFormsApp_OOP_Lab5
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
            AllPersonLabel = new Label();
            AllPersonsDataGridView = new DataGridView();
            IdColumn = new DataGridViewTextBoxColumn();
            GenderColumn = new DataGridViewTextBoxColumn();
            NameColumn = new DataGridViewTextBoxColumn();
            AgeColumn = new DataGridViewTextBoxColumn();
            ProfessionColumn = new DataGridViewTextBoxColumn();
            ActionColumn = new DataGridViewButtonColumn();
            ExitButton = new Button();
            SuitPersonsDataGridView = new DataGridView();
            CuitIdColumn = new DataGridViewTextBoxColumn();
            CuitGenderColumn = new DataGridViewTextBoxColumn();
            CuitNameColumn = new DataGridViewTextBoxColumn();
            CuitAgeColumn = new DataGridViewTextBoxColumn();
            CuitProfColumn = new DataGridViewTextBoxColumn();
            CuitActionColumn = new DataGridViewButtonColumn();
            FindButton = new Button();
            ((System.ComponentModel.ISupportInitialize)AllPersonsDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SuitPersonsDataGridView).BeginInit();
            SuspendLayout();
            // 
            // AllPersonLabel
            // 
            AllPersonLabel.AutoSize = true;
            AllPersonLabel.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            AllPersonLabel.Location = new Point(277, 30);
            AllPersonLabel.Name = "AllPersonLabel";
            AllPersonLabel.Size = new Size(207, 25);
            AllPersonLabel.TabIndex = 0;
            AllPersonLabel.Text = "Список всех объектов";
            // 
            // AllPersonsDataGridView
            // 
            AllPersonsDataGridView.AllowUserToAddRows = false;
            AllPersonsDataGridView.AllowUserToResizeColumns = false;
            AllPersonsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            AllPersonsDataGridView.Columns.AddRange(new DataGridViewColumn[] { IdColumn, GenderColumn, NameColumn, AgeColumn, ProfessionColumn, ActionColumn });
            AllPersonsDataGridView.Location = new Point(88, 71);
            AllPersonsDataGridView.Name = "AllPersonsDataGridView";
            AllPersonsDataGridView.ReadOnly = true;
            AllPersonsDataGridView.RowHeadersVisible = false;
            AllPersonsDataGridView.RowHeadersWidth = 51;
            AllPersonsDataGridView.ScrollBars = ScrollBars.Vertical;
            AllPersonsDataGridView.Size = new Size(626, 188);
            AllPersonsDataGridView.TabIndex = 1;
            AllPersonsDataGridView.CellContentClick += AllPersonsDataSridWiew_CellContentClick;
            // 
            // IdColumn
            // 
            IdColumn.HeaderText = "Id";
            IdColumn.MinimumWidth = 6;
            IdColumn.Name = "IdColumn";
            IdColumn.ReadOnly = true;
            IdColumn.Width = 40;
            // 
            // GenderColumn
            // 
            GenderColumn.HeaderText = "Пол";
            GenderColumn.MinimumWidth = 6;
            GenderColumn.Name = "GenderColumn";
            GenderColumn.ReadOnly = true;
            GenderColumn.Width = 60;
            // 
            // NameColumn
            // 
            NameColumn.HeaderText = "Имя";
            NameColumn.MinimumWidth = 6;
            NameColumn.Name = "NameColumn";
            NameColumn.ReadOnly = true;
            NameColumn.Width = 125;
            // 
            // AgeColumn
            // 
            AgeColumn.HeaderText = "Возраст";
            AgeColumn.MinimumWidth = 6;
            AgeColumn.Name = "AgeColumn";
            AgeColumn.ReadOnly = true;
            AgeColumn.Width = 125;
            // 
            // ProfessionColumn
            // 
            ProfessionColumn.HeaderText = "Профессия";
            ProfessionColumn.MinimumWidth = 6;
            ProfessionColumn.Name = "ProfessionColumn";
            ProfessionColumn.ReadOnly = true;
            ProfessionColumn.Width = 125;
            // 
            // ActionColumn
            // 
            ActionColumn.HeaderText = "Действие";
            ActionColumn.MinimumWidth = 6;
            ActionColumn.Name = "ActionColumn";
            ActionColumn.ReadOnly = true;
            ActionColumn.Resizable = DataGridViewTriState.True;
            ActionColumn.SortMode = DataGridViewColumnSortMode.Automatic;
            ActionColumn.Width = 125;
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(12, 516);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(94, 29);
            ExitButton.TabIndex = 2;
            ExitButton.Text = "Выйти";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // SuitPersonsDataGridView
            // 
            SuitPersonsDataGridView.AllowUserToAddRows = false;
            SuitPersonsDataGridView.AllowUserToDeleteRows = false;
            SuitPersonsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            SuitPersonsDataGridView.Columns.AddRange(new DataGridViewColumn[] { CuitIdColumn, CuitGenderColumn, CuitNameColumn, CuitAgeColumn, CuitProfColumn, CuitActionColumn });
            SuitPersonsDataGridView.Location = new Point(88, 323);
            SuitPersonsDataGridView.Name = "SuitPersonsDataGridView";
            SuitPersonsDataGridView.ReadOnly = true;
            SuitPersonsDataGridView.RowHeadersVisible = false;
            SuitPersonsDataGridView.RowHeadersWidth = 51;
            SuitPersonsDataGridView.ScrollBars = ScrollBars.Vertical;
            SuitPersonsDataGridView.Size = new Size(626, 156);
            SuitPersonsDataGridView.TabIndex = 3;
            // 
            // CuitIdColumn
            // 
            CuitIdColumn.HeaderText = "Id";
            CuitIdColumn.MinimumWidth = 6;
            CuitIdColumn.Name = "CuitIdColumn";
            CuitIdColumn.ReadOnly = true;
            CuitIdColumn.Width = 40;
            // 
            // CuitGenderColumn
            // 
            CuitGenderColumn.HeaderText = "Пол";
            CuitGenderColumn.MinimumWidth = 6;
            CuitGenderColumn.Name = "CuitGenderColumn";
            CuitGenderColumn.ReadOnly = true;
            CuitGenderColumn.Width = 60;
            // 
            // CuitNameColumn
            // 
            CuitNameColumn.HeaderText = "Имя";
            CuitNameColumn.MinimumWidth = 6;
            CuitNameColumn.Name = "CuitNameColumn";
            CuitNameColumn.ReadOnly = true;
            CuitNameColumn.Width = 125;
            // 
            // CuitAgeColumn
            // 
            CuitAgeColumn.HeaderText = "Возраст";
            CuitAgeColumn.MinimumWidth = 6;
            CuitAgeColumn.Name = "CuitAgeColumn";
            CuitAgeColumn.ReadOnly = true;
            CuitAgeColumn.Width = 125;
            // 
            // CuitProfColumn
            // 
            CuitProfColumn.HeaderText = "Профессия";
            CuitProfColumn.MinimumWidth = 6;
            CuitProfColumn.Name = "CuitProfColumn";
            CuitProfColumn.ReadOnly = true;
            CuitProfColumn.Width = 125;
            // 
            // CuitActionColumn
            // 
            CuitActionColumn.HeaderText = "Действие";
            CuitActionColumn.MinimumWidth = 6;
            CuitActionColumn.Name = "CuitActionColumn";
            CuitActionColumn.ReadOnly = true;
            CuitActionColumn.Width = 125;
            // 
            // FindButton
            // 
            FindButton.Location = new Point(564, 277);
            FindButton.Name = "FindButton";
            FindButton.Size = new Size(108, 28);
            FindButton.TabIndex = 4;
            FindButton.Text = "Найти";
            FindButton.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 557);
            Controls.Add(FindButton);
            Controls.Add(SuitPersonsDataGridView);
            Controls.Add(ExitButton);
            Controls.Add(AllPersonsDataGridView);
            Controls.Add(AllPersonLabel);
            Name = "MainForm";
            Text = "Главная форма";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)AllPersonsDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)SuitPersonsDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label AllPersonLabel;
        private DataGridView AllPersonsDataGridView;
        private Button ExitButton;
        private DataGridView SuitPersonsDataGridView;
        private DataGridViewTextBoxColumn IdColumn;
        private DataGridViewTextBoxColumn GenderColumn;
        private DataGridViewTextBoxColumn NameColumn;
        private DataGridViewTextBoxColumn AgeColumn;
        private DataGridViewTextBoxColumn ProfessionColumn;
        private DataGridViewButtonColumn ActionColumn;
        private DataGridViewTextBoxColumn CuitIdColumn;
        private DataGridViewTextBoxColumn CuitGenderColumn;
        private DataGridViewTextBoxColumn CuitNameColumn;
        private DataGridViewTextBoxColumn CuitAgeColumn;
        private DataGridViewTextBoxColumn CuitProfColumn;
        private DataGridViewButtonColumn CuitActionColumn;
        private Button FindButton;
    }
}
