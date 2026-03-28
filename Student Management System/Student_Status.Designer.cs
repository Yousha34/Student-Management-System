namespace Student_Management_System
{
    partial class Student_Status
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
            back_button = new Button();
            button2 = new Button();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            comboBox3 = new ComboBox();
            comboBox4 = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
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
            panel1.Size = new Size(800, 54);
            panel1.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.White;
            label7.Location = new Point(12, 20);
            label7.Name = "label7";
            label7.Size = new Size(47, 15);
            label7.TabIndex = 17;
            label7.Text = "STATUS";
            // 
            // search_textBox
            // 
            search_textBox.Font = new Font("Segoe UI", 14.25F);
            search_textBox.Location = new Point(550, 11);
            search_textBox.Name = "search_textBox";
            search_textBox.Size = new Size(238, 33);
            search_textBox.TabIndex = 67;
            search_textBox.Click += search_textBox_Click;
            search_textBox.TextChanged += search_textBox_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14.25F);
            label8.ForeColor = Color.White;
            label8.Location = new Point(379, 15);
            label8.Name = "label8";
            label8.Size = new Size(165, 25);
            label8.TabIndex = 68;
            label8.Text = "SEARCH STUDENT";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Top;
            dataGridView1.Location = new Point(0, 54);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(800, 324);
            dataGridView1.TabIndex = 2;
            // 
            // back_button
            // 
            back_button.Location = new Point(12, 516);
            back_button.Name = "back_button";
            back_button.Size = new Size(75, 23);
            back_button.TabIndex = 59;
            back_button.Text = "BACK";
            back_button.UseVisualStyleBackColor = true;
            back_button.Click += back_button_Click;
            // 
            // button2
            // 
            button2.Location = new Point(713, 516);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 70;
            button2.Text = "CLEAR";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 14.25F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "BSCS", "BSEE", "BSIT", "MEDICAL", "BSSE" });
            comboBox1.Location = new Point(207, 401);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(160, 33);
            comboBox1.TabIndex = 71;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // comboBox2
            // 
            comboBox2.Font = new Font("Segoe UI", 14.25F);
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Male", "Female" });
            comboBox2.Location = new Point(539, 467);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(160, 33);
            comboBox2.TabIndex = 72;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // comboBox3
            // 
            comboBox3.Font = new Font("Segoe UI", 14.25F);
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "A", "B", "C" });
            comboBox3.Location = new Point(207, 467);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(160, 33);
            comboBox3.TabIndex = 73;
            comboBox3.SelectedIndexChanged += comboBox3_SelectedIndexChanged;
            // 
            // comboBox4
            // 
            comboBox4.Font = new Font("Segoe UI", 14.25F);
            comboBox4.FormattingEnabled = true;
            comboBox4.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8" });
            comboBox4.Location = new Point(539, 401);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(160, 33);
            comboBox4.TabIndex = 74;
            comboBox4.SelectedIndexChanged += comboBox4_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(437, 471);
            label2.Name = "label2";
            label2.Size = new Size(83, 25);
            label2.TabIndex = 75;
            label2.Text = "GENDER";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(437, 405);
            label3.Name = "label3";
            label3.Size = new Size(100, 25);
            label3.TabIndex = 76;
            label3.Text = "SEMESTER";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(104, 471);
            label4.Name = "label4";
            label4.Size = new Size(87, 25);
            label4.TabIndex = 77;
            label4.Text = "SECTION";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(104, 405);
            label1.Name = "label1";
            label1.Size = new Size(101, 25);
            label1.TabIndex = 69;
            label1.Text = "PROGRAM";
            // 
            // Student_Status
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 551);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBox4);
            Controls.Add(comboBox3);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(dataGridView1);
            Controls.Add(button2);
            Controls.Add(back_button);
            Controls.Add(panel1);
            Name = "Student_Status";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Student_Status";
            Load += Student_Status_Load;
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
        private Button back_button;
        private Label label8;
        private TextBox search_textBox;
        private Button button2;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
        private ComboBox comboBox4;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label1;
    }
}