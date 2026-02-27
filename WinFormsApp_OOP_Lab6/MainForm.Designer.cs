namespace WinFormsApp_OOP_Lab6
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
            TimeLabel = new Label();
            ExitButton = new Button();
            VectorPanel = new Panel();
            SortingPanel = new Panel();
            SortingHeader = new Label();
            StatusValueLabel = new Label();
            SortButton = new Button();
            StatusLabel = new Label();
            MinVectorPanel = new Panel();
            MinValueHeader = new Label();
            MinValueLabel = new Label();
            FoundButton = new Button();
            MinimiumLabel = new Label();
            EventLabel = new Label();
            EventHeader = new Label();
            CreateButton = new Button();
            MaxNumericUpDown = new NumericUpDown();
            MaxLabel = new Label();
            MinNumericUpDown = new NumericUpDown();
            MinLabel = new Label();
            LengthLabel = new Label();
            LengthNumericUpDown = new NumericUpDown();
            VectorLabel = new Label();
            HeaderLabel = new Label();
            VectorPanel.SuspendLayout();
            SortingPanel.SuspendLayout();
            MinVectorPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MaxNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MinNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)LengthNumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // TimeLabel
            // 
            TimeLabel.AutoSize = true;
            TimeLabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            TimeLabel.Location = new Point(16, 67);
            TimeLabel.Name = "TimeLabel";
            TimeLabel.Size = new Size(69, 23);
            TimeLabel.TabIndex = 0;
            TimeLabel.Text = "Время: ";
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(12, 409);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(94, 29);
            ExitButton.TabIndex = 1;
            ExitButton.Text = "Выход";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // VectorPanel
            // 
            VectorPanel.BorderStyle = BorderStyle.Fixed3D;
            VectorPanel.Controls.Add(SortingPanel);
            VectorPanel.Controls.Add(MinVectorPanel);
            VectorPanel.Controls.Add(EventLabel);
            VectorPanel.Controls.Add(EventHeader);
            VectorPanel.Controls.Add(CreateButton);
            VectorPanel.Controls.Add(MaxNumericUpDown);
            VectorPanel.Controls.Add(MaxLabel);
            VectorPanel.Controls.Add(MinNumericUpDown);
            VectorPanel.Controls.Add(MinLabel);
            VectorPanel.Controls.Add(LengthLabel);
            VectorPanel.Controls.Add(LengthNumericUpDown);
            VectorPanel.Controls.Add(VectorLabel);
            VectorPanel.Location = new Point(12, 102);
            VectorPanel.Name = "VectorPanel";
            VectorPanel.Size = new Size(776, 301);
            VectorPanel.TabIndex = 2;
            // 
            // SortingPanel
            // 
            SortingPanel.BorderStyle = BorderStyle.FixedSingle;
            SortingPanel.Controls.Add(SortingHeader);
            SortingPanel.Controls.Add(StatusValueLabel);
            SortingPanel.Controls.Add(SortButton);
            SortingPanel.Controls.Add(StatusLabel);
            SortingPanel.Enabled = false;
            SortingPanel.Location = new Point(16, 120);
            SortingPanel.Name = "SortingPanel";
            SortingPanel.Size = new Size(738, 85);
            SortingPanel.TabIndex = 10;
            // 
            // SortingHeader
            // 
            SortingHeader.AutoSize = true;
            SortingHeader.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            SortingHeader.Location = new Point(308, 5);
            SortingHeader.Name = "SortingHeader";
            SortingHeader.Size = new Size(111, 23);
            SortingHeader.TabIndex = 3;
            SortingHeader.Text = "Сортировка";
            // 
            // StatusValueLabel
            // 
            StatusValueLabel.AutoSize = true;
            StatusValueLabel.Location = new Point(59, 36);
            StatusValueLabel.Name = "StatusValueLabel";
            StatusValueLabel.Size = new Size(18, 20);
            StatusValueLabel.TabIndex = 2;
            StatusValueLabel.Text = "...";
            // 
            // SortButton
            // 
            SortButton.Location = new Point(308, 53);
            SortButton.Name = "SortButton";
            SortButton.Size = new Size(110, 29);
            SortButton.TabIndex = 1;
            SortButton.Text = "Сортировать";
            SortButton.UseVisualStyleBackColor = true;
            SortButton.Click += SortButton_Click;
            // 
            // StatusLabel
            // 
            StatusLabel.AutoSize = true;
            StatusLabel.Location = new Point(3, 36);
            StatusLabel.Name = "StatusLabel";
            StatusLabel.Size = new Size(55, 20);
            StatusLabel.TabIndex = 0;
            StatusLabel.Text = "Статус:";
            // 
            // MinVectorPanel
            // 
            MinVectorPanel.BorderStyle = BorderStyle.FixedSingle;
            MinVectorPanel.Controls.Add(MinValueHeader);
            MinVectorPanel.Controls.Add(MinValueLabel);
            MinVectorPanel.Controls.Add(FoundButton);
            MinVectorPanel.Controls.Add(MinimiumLabel);
            MinVectorPanel.Enabled = false;
            MinVectorPanel.Location = new Point(16, 211);
            MinVectorPanel.Name = "MinVectorPanel";
            MinVectorPanel.Size = new Size(738, 85);
            MinVectorPanel.TabIndex = 3;
            // 
            // MinValueHeader
            // 
            MinValueHeader.AutoSize = true;
            MinValueHeader.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            MinValueHeader.Location = new Point(265, 5);
            MinValueHeader.Name = "MinValueHeader";
            MinValueHeader.Size = new Size(191, 23);
            MinValueHeader.TabIndex = 3;
            MinValueHeader.Text = "Поиск минимального";
            // 
            // MinValueLabel
            // 
            MinValueLabel.AutoSize = true;
            MinValueLabel.Location = new Point(113, 36);
            MinValueLabel.Name = "MinValueLabel";
            MinValueLabel.Size = new Size(18, 20);
            MinValueLabel.TabIndex = 2;
            MinValueLabel.Text = "...";
            // 
            // FoundButton
            // 
            FoundButton.Location = new Point(317, 52);
            FoundButton.Name = "FoundButton";
            FoundButton.Size = new Size(94, 29);
            FoundButton.TabIndex = 1;
            FoundButton.Text = "Найти";
            FoundButton.UseVisualStyleBackColor = true;
            FoundButton.Click += FoundButton_Click;
            // 
            // MinimiumLabel
            // 
            MinimiumLabel.AutoSize = true;
            MinimiumLabel.Location = new Point(3, 36);
            MinimiumLabel.Name = "MinimiumLabel";
            MinimiumLabel.Size = new Size(113, 20);
            MinimiumLabel.TabIndex = 0;
            MinimiumLabel.Text = "Минимальное:";
            // 
            // EventLabel
            // 
            EventLabel.AutoSize = true;
            EventLabel.Location = new Point(160, 44);
            EventLabel.Name = "EventLabel";
            EventLabel.Size = new Size(18, 20);
            EventLabel.TabIndex = 9;
            EventLabel.Text = "...";
            // 
            // EventHeader
            // 
            EventHeader.AutoSize = true;
            EventHeader.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            EventHeader.Location = new Point(3, 44);
            EventHeader.Name = "EventHeader";
            EventHeader.Size = new Size(156, 20);
            EventHeader.TabIndex = 8;
            EventHeader.Text = "Последнее событие:";
            // 
            // CreateButton
            // 
            CreateButton.Location = new Point(660, 77);
            CreateButton.Name = "CreateButton";
            CreateButton.Size = new Size(94, 29);
            CreateButton.TabIndex = 7;
            CreateButton.Text = "Создать";
            CreateButton.UseVisualStyleBackColor = true;
            CreateButton.Click += CreateButton_Click;
            // 
            // MaxNumericUpDown
            // 
            MaxNumericUpDown.Location = new Point(543, 79);
            MaxNumericUpDown.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            MaxNumericUpDown.Name = "MaxNumericUpDown";
            MaxNumericUpDown.Size = new Size(100, 27);
            MaxNumericUpDown.TabIndex = 6;
            MaxNumericUpDown.Value = new decimal(new int[] { 1000, 0, 0, 0 });
            // 
            // MaxLabel
            // 
            MaxLabel.AutoSize = true;
            MaxLabel.Location = new Point(417, 81);
            MaxLabel.Name = "MaxLabel";
            MaxLabel.Size = new Size(120, 20);
            MaxLabel.TabIndex = 5;
            MaxLabel.Text = "Макс. значение:";
            // 
            // MinNumericUpDown
            // 
            MinNumericUpDown.Location = new Point(306, 79);
            MinNumericUpDown.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            MinNumericUpDown.Name = "MinNumericUpDown";
            MinNumericUpDown.Size = new Size(100, 27);
            MinNumericUpDown.TabIndex = 4;
            // 
            // MinLabel
            // 
            MinLabel.AutoSize = true;
            MinLabel.Location = new Point(184, 81);
            MinLabel.Name = "MinLabel";
            MinLabel.Size = new Size(116, 20);
            MinLabel.TabIndex = 3;
            MinLabel.Text = "Мин. значение:";
            // 
            // LengthLabel
            // 
            LengthLabel.AutoSize = true;
            LengthLabel.Location = new Point(15, 81);
            LengthLabel.Name = "LengthLabel";
            LengthLabel.Size = new Size(56, 20);
            LengthLabel.TabIndex = 2;
            LengthLabel.Text = "Длина:";
            // 
            // LengthNumericUpDown
            // 
            LengthNumericUpDown.Location = new Point(77, 79);
            LengthNumericUpDown.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            LengthNumericUpDown.Name = "LengthNumericUpDown";
            LengthNumericUpDown.Size = new Size(100, 27);
            LengthNumericUpDown.TabIndex = 1;
            LengthNumericUpDown.Value = new decimal(new int[] { 1000, 0, 0, 0 });
            // 
            // VectorLabel
            // 
            VectorLabel.AutoSize = true;
            VectorLabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            VectorLabel.Location = new Point(308, 11);
            VectorLabel.Name = "VectorLabel";
            VectorLabel.Size = new Size(165, 23);
            VectorLabel.TabIndex = 0;
            VectorLabel.Text = "Работа с вектором";
            // 
            // HeaderLabel
            // 
            HeaderLabel.AutoSize = true;
            HeaderLabel.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            HeaderLabel.Location = new Point(171, 23);
            HeaderLabel.Name = "HeaderLabel";
            HeaderLabel.Size = new Size(486, 25);
            HeaderLabel.TabIndex = 3;
            HeaderLabel.Text = "Многопоточность и асинхронное программирование";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(HeaderLabel);
            Controls.Add(VectorPanel);
            Controls.Add(ExitButton);
            Controls.Add(TimeLabel);
            Name = "MainForm";
            Text = "Главная форма";
            Load += MainForm_Load;
            VectorPanel.ResumeLayout(false);
            VectorPanel.PerformLayout();
            SortingPanel.ResumeLayout(false);
            SortingPanel.PerformLayout();
            MinVectorPanel.ResumeLayout(false);
            MinVectorPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)MaxNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)MinNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)LengthNumericUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label TimeLabel;
        private Button ExitButton;
        private Panel VectorPanel;
        private Label MinLabel;
        private Label LengthLabel;
        private NumericUpDown LengthNumericUpDown;
        private Label VectorLabel;
        private NumericUpDown MaxNumericUpDown;
        private Label MaxLabel;
        private NumericUpDown MinNumericUpDown;
        private Label EventLabel;
        private Label EventHeader;
        private Button CreateButton;
        private Panel MinVectorPanel;
        private Label MinimiumLabel;
        private Button FoundButton;
        private Label MinValueLabel;
        private Label HeaderLabel;
        private Label MinValueHeader;
        private Panel SortingPanel;
        private Label SortingHeader;
        private Label StatusValueLabel;
        private Button SortButton;
        private Label StatusLabel;
    }
}
