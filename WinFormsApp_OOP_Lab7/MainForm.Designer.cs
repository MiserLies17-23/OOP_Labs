namespace WinFormsApp_OOP_Lab7
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
            ExitButton = new Button();
            PersonDataGridView = new DataGridView();
            IdColumn = new DataGridViewTextBoxColumn();
            GenderColumn = new DataGridViewTextBoxColumn();
            NameColumn = new DataGridViewTextBoxColumn();
            AgeColumn = new DataGridViewTextBoxColumn();
            EditColumn = new DataGridViewButtonColumn();
            DeleteColumn = new DataGridViewButtonColumn();
            AddButton = new Button();
            MVCHeader = new Label();
            ((System.ComponentModel.ISupportInitialize)PersonDataGridView).BeginInit();
            SuspendLayout();
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(33, 364);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(94, 29);
            ExitButton.TabIndex = 0;
            ExitButton.Text = "Выйти";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // PersonDataGridView
            // 
            PersonDataGridView.AllowUserToAddRows = false;
            PersonDataGridView.AllowUserToDeleteRows = false;
            PersonDataGridView.AllowUserToResizeColumns = false;
            PersonDataGridView.AllowUserToResizeRows = false;
            PersonDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PersonDataGridView.Columns.AddRange(new DataGridViewColumn[] { IdColumn, GenderColumn, NameColumn, AgeColumn, EditColumn, DeleteColumn });
            PersonDataGridView.Location = new Point(60, 104);
            PersonDataGridView.Name = "PersonDataGridView";
            PersonDataGridView.RowHeadersVisible = false;
            PersonDataGridView.RowHeadersWidth = 51;
            PersonDataGridView.Size = new Size(655, 188);
            PersonDataGridView.TabIndex = 1;
            PersonDataGridView.CellClick += PersonDataGridView_CellContentClick;
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
            GenderColumn.HeaderText = "Пол";
            GenderColumn.MinimumWidth = 6;
            GenderColumn.Name = "GenderColumn";
            GenderColumn.Width = 65;
            // 
            // NameColumn
            // 
            NameColumn.HeaderText = "Имя";
            NameColumn.MinimumWidth = 6;
            NameColumn.Name = "NameColumn";
            NameColumn.Width = 125;
            // 
            // AgeColumn
            // 
            AgeColumn.HeaderText = "Возраст";
            AgeColumn.MinimumWidth = 6;
            AgeColumn.Name = "AgeColumn";
            AgeColumn.Width = 125;
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
            // AddButton
            // 
            AddButton.Location = new Point(344, 310);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(94, 29);
            AddButton.TabIndex = 2;
            AddButton.Text = "Добавить";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // MVCHeader
            // 
            MVCHeader.AutoSize = true;
            MVCHeader.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            MVCHeader.Location = new Point(277, 47);
            MVCHeader.Name = "MVCHeader";
            MVCHeader.Size = new Size(245, 25);
            MVCHeader.TabIndex = 3;
            MVCHeader.Text = "Реализация паттерна MVC";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 413);
            Controls.Add(MVCHeader);
            Controls.Add(AddButton);
            Controls.Add(PersonDataGridView);
            Controls.Add(ExitButton);
            Name = "MainForm";
            Text = "Главная форма";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)PersonDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ExitButton;
        private DataGridView PersonDataGridView;
        private Button AddButton;
        private Label MVCHeader;
        private DataGridViewTextBoxColumn IdColumn;
        private DataGridViewTextBoxColumn GenderColumn;
        private DataGridViewTextBoxColumn NameColumn;
        private DataGridViewTextBoxColumn AgeColumn;
        private DataGridViewButtonColumn EditColumn;
        private DataGridViewButtonColumn DeleteColumn;
    }
}
