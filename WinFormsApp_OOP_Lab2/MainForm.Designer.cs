namespace WinFormsApp_OOP_Lab2
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
            WorkWithStackLabel = new Label();
            ContentLabel = new Label();
            AddButton = new Button();
            RemoveButton = new Button();
            MeasureListView = new ListView();
            ActivityLabel = new Label();
            CompareButton = new Button();
            CompareLabel = new Label();
            SuspendLayout();
            // 
            // WorkWithStackLabel
            // 
            WorkWithStackLabel.AutoSize = true;
            WorkWithStackLabel.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            WorkWithStackLabel.Location = new Point(319, 9);
            WorkWithStackLabel.Name = "WorkWithStackLabel";
            WorkWithStackLabel.Size = new Size(169, 25);
            WorkWithStackLabel.TabIndex = 0;
            WorkWithStackLabel.Text = "Работа со стэком:";
            // 
            // ContentLabel
            // 
            ContentLabel.Location = new Point(29, 65);
            ContentLabel.Name = "ContentLabel";
            ContentLabel.Size = new Size(810, 79);
            ContentLabel.TabIndex = 1;
            ContentLabel.Text = "Содержимое стэка:";
            // 
            // AddButton
            // 
            AddButton.Location = new Point(271, 147);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(94, 29);
            AddButton.TabIndex = 2;
            AddButton.Text = "Добавить";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // RemoveButton
            // 
            RemoveButton.Location = new Point(476, 147);
            RemoveButton.Name = "RemoveButton";
            RemoveButton.Size = new Size(94, 29);
            RemoveButton.TabIndex = 3;
            RemoveButton.Text = "Удалить";
            RemoveButton.UseVisualStyleBackColor = true;
            RemoveButton.Click += RemoveButton_Click;
            // 
            // MeasureListView
            // 
            MeasureListView.FullRowSelect = true;
            MeasureListView.GridLines = true;
            MeasureListView.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            MeasureListView.Location = new Point(68, 235);
            MeasureListView.Name = "MeasureListView";
            MeasureListView.Size = new Size(730, 197);
            MeasureListView.TabIndex = 4;
            MeasureListView.UseCompatibleStateImageBehavior = false;
            MeasureListView.View = View.Details;
            // 
            // ActivityLabel
            // 
            ActivityLabel.AutoSize = true;
            ActivityLabel.Location = new Point(494, 37);
            ActivityLabel.Name = "ActivityLabel";
            ActivityLabel.Size = new Size(155, 20);
            ActivityLabel.TabIndex = 5;
            ActivityLabel.Text = "Последнее действие:";
            // 
            // CompareButton
            // 
            CompareButton.Location = new Point(319, 438);
            CompareButton.Name = "CompareButton";
            CompareButton.Size = new Size(94, 29);
            CompareButton.TabIndex = 6;
            CompareButton.Text = "Сравнить";
            CompareButton.UseVisualStyleBackColor = true;
            CompareButton.Click += CompareButton_Click;
            // 
            // CompareLabel
            // 
            CompareLabel.AutoSize = true;
            CompareLabel.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            CompareLabel.Location = new Point(233, 207);
            CompareLabel.Name = "CompareLabel";
            CompareLabel.Size = new Size(416, 25);
            CompareLabel.TabIndex = 7;
            CompareLabel.Text = "Сравнение производительности Stack и Array";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(874, 479);
            Controls.Add(CompareLabel);
            Controls.Add(CompareButton);
            Controls.Add(ActivityLabel);
            Controls.Add(MeasureListView);
            Controls.Add(RemoveButton);
            Controls.Add(AddButton);
            Controls.Add(ContentLabel);
            Controls.Add(WorkWithStackLabel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Главная форма";
            Load += MainForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label WorkWithStackLabel;
        private Label ContentLabel;
        private Button AddButton;
        private Button RemoveButton;
        private ListView MeasureListView;
        private Label ActivityLabel;
        private Button CompareButton;
        private Label CompareLabel;
    }
}
