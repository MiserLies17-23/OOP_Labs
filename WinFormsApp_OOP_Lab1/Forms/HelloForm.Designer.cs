namespace WinFormsApp_OOP_Lab1
{
    partial class HelloForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HelloForm));
            HeaderLabel = new Label();
            VariantLabel = new Label();
            label1 = new Label();
            TaskLabel = new Label();
            pictureBox1 = new PictureBox();
            OkButton = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // HeaderLabel
            // 
            HeaderLabel.Anchor = AnchorStyles.None;
            HeaderLabel.AutoSize = true;
            HeaderLabel.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            HeaderLabel.Location = new Point(264, 0);
            HeaderLabel.Name = "HeaderLabel";
            HeaderLabel.Size = new Size(257, 25);
            HeaderLabel.TabIndex = 1;
            HeaderLabel.Text = "Лабораторная работа №1";
            // 
            // VariantLabel
            // 
            VariantLabel.Anchor = AnchorStyles.None;
            VariantLabel.AutoSize = true;
            VariantLabel.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            VariantLabel.Location = new Point(295, 25);
            VariantLabel.Name = "VariantLabel";
            VariantLabel.Size = new Size(195, 25);
            VariantLabel.TabIndex = 2;
            VariantLabel.Text = "Вариант 13: Человек";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(178, 50);
            label1.Name = "label1";
            label1.Size = new Size(428, 23);
            label1.TabIndex = 3;
            label1.Text = "Бригада 13: Пономарев Павел, Толстоухов Вадим";
            // 
            // TaskLabel
            // 
            TaskLabel.Anchor = AnchorStyles.None;
            TaskLabel.AutoSize = true;
            TaskLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            TaskLabel.Location = new Point(343, 73);
            TaskLabel.Name = "TaskLabel";
            TaskLabel.Size = new Size(98, 28);
            TaskLabel.TabIndex = 4;
            TaskLabel.Text = "Задание:";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(11, 104);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(762, 431);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // OkButton
            // 
            OkButton.Anchor = AnchorStyles.None;
            OkButton.Location = new Point(364, 569);
            OkButton.Name = "OkButton";
            OkButton.Size = new Size(56, 36);
            OkButton.TabIndex = 6;
            OkButton.Text = "Ок";
            OkButton.UseVisualStyleBackColor = true;
            OkButton.Click += OkButton_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.Controls.Add(OkButton, 0, 5);
            tableLayoutPanel1.Controls.Add(VariantLabel, 0, 1);
            tableLayoutPanel1.Controls.Add(label1, 0, 2);
            tableLayoutPanel1.Controls.Add(pictureBox1, 0, 4);
            tableLayoutPanel1.Controls.Add(TaskLabel, 0, 3);
            tableLayoutPanel1.Controls.Add(HeaderLabel, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(785, 636);
            tableLayoutPanel1.TabIndex = 7;
            // 
            // HelloForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(785, 636);
            Controls.Add(tableLayoutPanel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "HelloForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Приветствие";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label HeaderLabel;
        private Label VariantLabel;
        private Label label1;
        private Label TaskLabel;
        private PictureBox pictureBox1;
        private Button OkButton;
        private TableLayoutPanel tableLayoutPanel1;
    }
}