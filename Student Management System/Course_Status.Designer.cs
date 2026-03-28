namespace Student_Management_System
{
    partial class Course_Status
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
            panel1 = new Panel();
            label7 = new Label();
            search_textBox = new TextBox();
            label8 = new Label();
            dataGridView1 = new DataGridView();
            button2 = new Button();
            back_button = new Button();
            comboBox1 = new ComboBox();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 71, 140);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(search_textBox);
            panel1.Controls.Add(label8);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(456, 54);
            panel1.TabIndex = 71;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.White;
            label7.Location = new Point(12, 21);
            label7.Name = "label7";
            label7.Size = new Size(47, 15);
            label7.TabIndex = 17;
            label7.Text = "STATUS";
            // 
            // search_textBox
            // 
            search_textBox.Font = new Font("Segoe UI", 14.25F);
            search_textBox.Location = new Point(266, 12);
            search_textBox.Name = "search_textBox";
            search_textBox.Size = new Size(178, 33);
            search_textBox.TabIndex = 74;
            search_textBox.Click += search_textBox_Click;
            search_textBox.TextChanged += search_textBox_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14.25F);
            label8.ForeColor = Color.White;
            label8.Location = new Point(182, 16);
            label8.Name = "label8";
            label8.Size = new Size(81, 25);
            label8.TabIndex = 75;
            label8.Text = "COURSE";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Top;
            dataGridView1.Location = new Point(0, 54);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(456, 324);
            dataGridView1.TabIndex = 72;
            // 
            // button2
            // 
            button2.Location = new Point(369, 402);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 77;
            button2.Text = "CLEAR";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // back_button
            // 
            back_button.Location = new Point(12, 402);
            back_button.Name = "back_button";
            back_button.Size = new Size(75, 23);
            back_button.TabIndex = 73;
            back_button.Text = "BACK";
            back_button.UseVisualStyleBackColor = true;
            back_button.Click += back_button_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "BSCS", "BSEE", "BSIT", "MEDICAL", "BSSE" });
            comboBox1.Location = new Point(191, 396);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(146, 23);
            comboBox1.TabIndex = 78;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Black;
            label1.Location = new Point(119, 400);
            label1.Name = "label1";
            label1.Size = new Size(70, 15);
            label1.TabIndex = 76;
            label1.Text = "PROGRAMS";
            // 
            // Course_Status
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(456, 437);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Controls.Add(button2);
            Controls.Add(back_button);
            Name = "Course_Status";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Course_Status";
            Load += Course_Status_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label7;
        private DataGridView dataGridView1;
        private Button button2;
        private Label label8;
        private TextBox search_textBox;
        private Button back_button;
        private ComboBox comboBox1;
        private Label label1;
    }
}