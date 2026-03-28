namespace Student_Management_System
{
    partial class Registration_02
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
            label9 = new Label();
            label8 = new Label();
            semester_textBox = new TextBox();
            label2 = new Label();
            label1 = new Label();
            back_button = new Button();
            clear_button = new Button();
            add_button = new Button();
            dataGridView1 = new DataGridView();
            label7 = new Label();
            panel1 = new Panel();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = Color.White;
            label9.Location = new Point(310, 20);
            label9.Name = "label9";
            label9.Size = new Size(202, 15);
            label9.TabIndex = 18;
            label9.Text = "STUDENT PERSONAL INFORMATION";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14.25F);
            label8.Location = new Point(12, 297);
            label8.Name = "label8";
            label8.Size = new Size(100, 25);
            label8.TabIndex = 66;
            label8.Text = "SEMESTER";
            // 
            // semester_textBox
            // 
            semester_textBox.Font = new Font("Segoe UI", 14.25F);
            semester_textBox.Location = new Point(115, 289);
            semester_textBox.Name = "semester_textBox";
            semester_textBox.Size = new Size(160, 33);
            semester_textBox.TabIndex = 48;
            semester_textBox.KeyPress += semester_textBox_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F);
            label2.Location = new Point(529, 293);
            label2.Name = "label2";
            label2.Size = new Size(101, 25);
            label2.TabIndex = 64;
            label2.Text = "PROGRAM";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F);
            label1.Location = new Point(277, 293);
            label1.Name = "label1";
            label1.Size = new Size(87, 25);
            label1.TabIndex = 63;
            label1.Text = "SECTION";
            // 
            // back_button
            // 
            back_button.Location = new Point(12, 346);
            back_button.Name = "back_button";
            back_button.Size = new Size(75, 23);
            back_button.TabIndex = 58;
            back_button.Text = "BACK";
            back_button.UseVisualStyleBackColor = true;
            back_button.Click += back_button_Click;
            // 
            // clear_button
            // 
            clear_button.Location = new Point(632, 346);
            clear_button.Name = "clear_button";
            clear_button.Size = new Size(75, 23);
            clear_button.TabIndex = 57;
            clear_button.Text = "CLEAR";
            clear_button.UseVisualStyleBackColor = true;
            clear_button.Click += clear_button_Click;
            // 
            // add_button
            // 
            add_button.Location = new Point(713, 346);
            add_button.Name = "add_button";
            add_button.Size = new Size(75, 23);
            add_button.TabIndex = 56;
            add_button.Text = "ADD";
            add_button.UseVisualStyleBackColor = true;
            add_button.Click += next_button_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Top;
            dataGridView1.Location = new Point(0, 54);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(800, 211);
            dataGridView1.TabIndex = 60;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.White;
            label7.Location = new Point(11, 20);
            label7.Name = "label7";
            label7.Size = new Size(86, 15);
            label7.TabIndex = 17;
            label7.Text = "REGISTRATION";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 71, 140);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label7);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 54);
            panel1.TabIndex = 47;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 14.25F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "BSCS", "BSEE", "BSIT", "MEDICAL", "BSSE" });
            comboBox1.Location = new Point(628, 290);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(160, 33);
            comboBox1.TabIndex = 67;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // comboBox2
            // 
            comboBox2.Font = new Font("Segoe UI", 14.25F);
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "A", "B", "C" });
            comboBox2.Location = new Point(363, 289);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(160, 33);
            comboBox2.TabIndex = 68;
            // 
            // Registration_02
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 381);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(label8);
            Controls.Add(semester_textBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(back_button);
            Controls.Add(clear_button);
            Controls.Add(add_button);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Name = "Registration_02";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registration_02";
            Load += Registration_02_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label9;
        private Label label8;
        private TextBox semester_textBox;
        private Label label2;
        private Label label1;
        private Button back_button;
        private Button clear_button;
        private Button add_button;
        private DataGridView dataGridView1;
        private Label label7;
        private Panel panel1;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
    }
}