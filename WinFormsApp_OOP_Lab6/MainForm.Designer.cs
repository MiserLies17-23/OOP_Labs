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
            MinVectorPanel = new Panel();
            MinValueLabel = new Label();
            FoundButton = new Button();
            MinValueHader = new Label();
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
            VectorPanel.SuspendLayout();
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
            VectorPanel.BorderStyle = BorderStyle.FixedSingle;
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
            VectorPanel.Size = new Size(776, 235);
            VectorPanel.TabIndex = 2;
            // 
            // MinVectorPanel
            // 
            MinVectorPanel.Controls.Add(MinValueLabel);
            MinVectorPanel.Controls.Add(FoundButton);
            MinVectorPanel.Controls.Add(MinValueHader);
            MinVectorPanel.Enabled = false;
            MinVectorPanel.Location = new Point(16, 146);
            MinVectorPanel.Name = "MinVectorPanel";
            MinVectorPanel.Size = new Size(738, 67);
            MinVectorPanel.TabIndex = 3;
            // 
            // MinValueLabel
            // 
            MinValueLabel.AutoSize = true;
            MinValueLabel.Location = new Point(113, 27);
            MinValueLabel.Name = "MinValueLabel";
            MinValueLabel.Size = new Size(18, 20);
            MinValueLabel.TabIndex = 2;
            MinValueLabel.Text = "...";
            // 
            // FoundButton
            // 
            FoundButton.Location = new Point(324, 23);
            FoundButton.Name = "FoundButton";
            FoundButton.Size = new Size(94, 29);
            FoundButton.TabIndex = 1;
            FoundButton.Text = "Найти";
            FoundButton.UseVisualStyleBackColor = true;
            FoundButton.Click += FoundButton_Click;
            // 
            // MinValueHader
            // 
            MinValueHader.AutoSize = true;
            MinValueHader.Location = new Point(3, 27);
            MinValueHader.Name = "MinValueHader";
            MinValueHader.Size = new Size(113, 20);
            MinValueHader.TabIndex = 0;
            MinValueHader.Text = "Минимальное:";
            // 
            // EventLabel
            // 
            EventLabel.AutoSize = true;
            EventLabel.Location = new Point(173, 43);
            EventLabel.Name = "EventLabel";
            EventLabel.Size = new Size(18, 20);
            EventLabel.TabIndex = 9;
            EventLabel.Text = "...";
            // 
            // EventHeader
            // 
            EventHeader.AutoSize = true;
            EventHeader.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            EventHeader.Location = new Point(16, 43);
            EventHeader.Name = "EventHeader";
            EventHeader.Size = new Size(156, 20);
            EventHeader.TabIndex = 8;
            EventHeader.Text = "Последнее событие:";
            // 
            // CreateButton
            // 
            CreateButton.Location = new Point(660, 88);
            CreateButton.Name = "CreateButton";
            CreateButton.Size = new Size(94, 29);
            CreateButton.TabIndex = 7;
            CreateButton.Text = "Создать";
            CreateButton.UseVisualStyleBackColor = true;
            CreateButton.Click += CreateButton_Click;
            // 
            // MaxNumericUpDown
            // 
            MaxNumericUpDown.Location = new Point(544, 88);
            MaxNumericUpDown.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            MaxNumericUpDown.Name = "MaxNumericUpDown";
            MaxNumericUpDown.Size = new Size(100, 27);
            MaxNumericUpDown.TabIndex = 6;
            MaxNumericUpDown.Value = new decimal(new int[] { 1000, 0, 0, 0 });
            // 
            // MaxLabel
            // 
            MaxLabel.AutoSize = true;
            MaxLabel.Location = new Point(418, 90);
            MaxLabel.Name = "MaxLabel";
            MaxLabel.Size = new Size(120, 20);
            MaxLabel.TabIndex = 5;
            MaxLabel.Text = "Макс. значение:";
            // 
            // MinNumericUpDown
            // 
            MinNumericUpDown.Location = new Point(307, 88);
            MinNumericUpDown.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            MinNumericUpDown.Name = "MinNumericUpDown";
            MinNumericUpDown.Size = new Size(100, 27);
            MinNumericUpDown.TabIndex = 4;
            // 
            // MinLabel
            // 
            MinLabel.AutoSize = true;
            MinLabel.Location = new Point(185, 90);
            MinLabel.Name = "MinLabel";
            MinLabel.Size = new Size(116, 20);
            MinLabel.TabIndex = 3;
            MinLabel.Text = "Мин. значение:";
            // 
            // LengthLabel
            // 
            LengthLabel.AutoSize = true;
            LengthLabel.Location = new Point(16, 90);
            LengthLabel.Name = "LengthLabel";
            LengthLabel.Size = new Size(56, 20);
            LengthLabel.TabIndex = 2;
            LengthLabel.Text = "Длина:";
            // 
            // LengthNumericUpDown
            // 
            LengthNumericUpDown.Location = new Point(78, 88);
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
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(VectorPanel);
            Controls.Add(ExitButton);
            Controls.Add(TimeLabel);
            Name = "MainForm";
            Text = "Form1";
            Load += MainForm_Load;
            VectorPanel.ResumeLayout(false);
            VectorPanel.PerformLayout();
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
        private Label MinValueHader;
        private Button FoundButton;
        private Label MinValueLabel;
    }
}
