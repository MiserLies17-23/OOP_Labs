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
            ExpressionLabel = new Label();
            GenderLabel = new Label();
            GenderComboBox = new ComboBox();
            NonTermComboBox1 = new ComboBox();
            ExpressionPanel = new Panel();
            AgeLabel2 = new Label();
            AgeTopNumericUpDown = new NumericUpDown();
            ProfessionComboBox = new ComboBox();
            ProfessionLabel = new Label();
            NonTermComboBox2 = new ComboBox();
            AgeDownNumericUpDown = new NumericUpDown();
            AgeLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)AllPersonsDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SuitPersonsDataGridView).BeginInit();
            ExpressionPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)AgeTopNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AgeDownNumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // AllPersonLabel
            // 
            AllPersonLabel.AutoSize = true;
            AllPersonLabel.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            AllPersonLabel.Location = new Point(287, 9);
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
            AllPersonsDataGridView.Location = new Point(88, 48);
            AllPersonsDataGridView.Name = "AllPersonsDataGridView";
            AllPersonsDataGridView.ReadOnly = true;
            AllPersonsDataGridView.RowHeadersVisible = false;
            AllPersonsDataGridView.RowHeadersWidth = 51;
            AllPersonsDataGridView.ScrollBars = ScrollBars.Vertical;
            AllPersonsDataGridView.Size = new Size(626, 188);
            AllPersonsDataGridView.TabIndex = 1;
            AllPersonsDataGridView.CellContentClick += DataGridWiew_CellContentClick;
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
            ExitButton.Location = new Point(12, 550);
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
            SuitPersonsDataGridView.Location = new Point(88, 388);
            SuitPersonsDataGridView.Name = "SuitPersonsDataGridView";
            SuitPersonsDataGridView.ReadOnly = true;
            SuitPersonsDataGridView.RowHeadersVisible = false;
            SuitPersonsDataGridView.RowHeadersWidth = 51;
            SuitPersonsDataGridView.ScrollBars = ScrollBars.Vertical;
            SuitPersonsDataGridView.Size = new Size(626, 156);
            SuitPersonsDataGridView.TabIndex = 3;
            SuitPersonsDataGridView.CellContentClick += DataGridWiew_CellContentClick;
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
            FindButton.Location = new Point(320, 107);
            FindButton.Name = "FindButton";
            FindButton.Size = new Size(108, 28);
            FindButton.TabIndex = 4;
            FindButton.Text = "Найти";
            FindButton.UseVisualStyleBackColor = true;
            FindButton.Click += FindButton_Click;
            // 
            // ExpressionLabel
            // 
            ExpressionLabel.AutoSize = true;
            ExpressionLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            ExpressionLabel.Location = new Point(329, 13);
            ExpressionLabel.Name = "ExpressionLabel";
            ExpressionLabel.Size = new Size(95, 20);
            ExpressionLabel.TabIndex = 5;
            ExpressionLabel.Text = "Выражение";
            // 
            // GenderLabel
            // 
            GenderLabel.AutoSize = true;
            GenderLabel.Location = new Point(11, 57);
            GenderLabel.Name = "GenderLabel";
            GenderLabel.Size = new Size(51, 20);
            GenderLabel.TabIndex = 6;
            GenderLabel.Text = "Пол =";
            // 
            // GenderComboBox
            // 
            GenderComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            GenderComboBox.FormattingEnabled = true;
            GenderComboBox.Location = new Point(57, 54);
            GenderComboBox.Name = "GenderComboBox";
            GenderComboBox.Size = new Size(77, 28);
            GenderComboBox.TabIndex = 7;
            // 
            // NonTermComboBox1
            // 
            NonTermComboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            NonTermComboBox1.FormattingEnabled = true;
            NonTermComboBox1.Location = new Point(140, 54);
            NonTermComboBox1.Name = "NonTermComboBox1";
            NonTermComboBox1.Size = new Size(60, 28);
            NonTermComboBox1.TabIndex = 8;
            // 
            // ExpressionPanel
            // 
            ExpressionPanel.BorderStyle = BorderStyle.FixedSingle;
            ExpressionPanel.Controls.Add(AgeLabel2);
            ExpressionPanel.Controls.Add(AgeTopNumericUpDown);
            ExpressionPanel.Controls.Add(ProfessionComboBox);
            ExpressionPanel.Controls.Add(ProfessionLabel);
            ExpressionPanel.Controls.Add(NonTermComboBox2);
            ExpressionPanel.Controls.Add(AgeDownNumericUpDown);
            ExpressionPanel.Controls.Add(AgeLabel);
            ExpressionPanel.Controls.Add(NonTermComboBox1);
            ExpressionPanel.Controls.Add(FindButton);
            ExpressionPanel.Controls.Add(ExpressionLabel);
            ExpressionPanel.Controls.Add(GenderComboBox);
            ExpressionPanel.Controls.Add(GenderLabel);
            ExpressionPanel.Location = new Point(12, 242);
            ExpressionPanel.Name = "ExpressionPanel";
            ExpressionPanel.Size = new Size(761, 140);
            ExpressionPanel.TabIndex = 9;
            // 
            // AgeLabel2
            // 
            AgeLabel2.AutoSize = true;
            AgeLabel2.Location = new Point(445, 57);
            AgeLabel2.Name = "AgeLabel2";
            AgeLabel2.Size = new Size(14, 20);
            AgeLabel2.TabIndex = 15;
            AgeLabel2.Text = "]";
            // 
            // AgeTopNumericUpDown
            // 
            AgeTopNumericUpDown.Location = new Point(370, 53);
            AgeTopNumericUpDown.Name = "AgeTopNumericUpDown";
            AgeTopNumericUpDown.Size = new Size(69, 27);
            AgeTopNumericUpDown.TabIndex = 14;
            AgeTopNumericUpDown.Value = new decimal(new int[] { 40, 0, 0, 0 });
            // 
            // ProfessionComboBox
            // 
            ProfessionComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            ProfessionComboBox.FormattingEnabled = true;
            ProfessionComboBox.Location = new Point(628, 54);
            ProfessionComboBox.Name = "ProfessionComboBox";
            ProfessionComboBox.Size = new Size(128, 28);
            ProfessionComboBox.TabIndex = 13;
            // 
            // ProfessionLabel
            // 
            ProfessionLabel.AutoSize = true;
            ProfessionLabel.Location = new Point(531, 58);
            ProfessionLabel.Name = "ProfessionLabel";
            ProfessionLabel.Size = new Size(101, 20);
            ProfessionLabel.TabIndex = 12;
            ProfessionLabel.Text = "Профессия =";
            // 
            // NonTermComboBox2
            // 
            NonTermComboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            NonTermComboBox2.FormattingEnabled = true;
            NonTermComboBox2.Location = new Point(465, 53);
            NonTermComboBox2.Name = "NonTermComboBox2";
            NonTermComboBox2.Size = new Size(60, 28);
            NonTermComboBox2.TabIndex = 11;
            // 
            // AgeDownNumericUpDown
            // 
            AgeDownNumericUpDown.Location = new Point(288, 53);
            AgeDownNumericUpDown.Name = "AgeDownNumericUpDown";
            AgeDownNumericUpDown.Size = new Size(69, 27);
            AgeDownNumericUpDown.TabIndex = 10;
            AgeDownNumericUpDown.Value = new decimal(new int[] { 20, 0, 0, 0 });
            // 
            // AgeLabel
            // 
            AgeLabel.AutoSize = true;
            AgeLabel.Location = new Point(204, 57);
            AgeLabel.Name = "AgeLabel";
            AgeLabel.Size = new Size(87, 20);
            AgeLabel.TabIndex = 9;
            AgeLabel.Text = "Возраст = [";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(786, 591);
            Controls.Add(ExpressionPanel);
            Controls.Add(SuitPersonsDataGridView);
            Controls.Add(ExitButton);
            Controls.Add(AllPersonsDataGridView);
            Controls.Add(AllPersonLabel);
            Name = "MainForm";
            Text = "Главная форма";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)AllPersonsDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)SuitPersonsDataGridView).EndInit();
            ExpressionPanel.ResumeLayout(false);
            ExpressionPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)AgeTopNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)AgeDownNumericUpDown).EndInit();
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
        private Label ExpressionLabel;
        private Label GenderLabel;
        private ComboBox GenderComboBox;
        private ComboBox NonTermComboBox1;
        private Panel ExpressionPanel;
        private ComboBox NonTermComboBox2;
        private NumericUpDown AgeDownNumericUpDown;
        private Label AgeLabel;
        private ComboBox ProfessionComboBox;
        private Label ProfessionLabel;
        private NumericUpDown AgeTopNumericUpDown;
        private Label AgeLabel2;
    }
}
