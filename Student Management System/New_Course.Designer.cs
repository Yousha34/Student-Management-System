namespace Student_Management_System
{
    partial class New_Course
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
            label8 = new Label();
            code_textBox = new TextBox();
            clear_button = new Button();
            back_button = new Button();
            add_button = new Button();
            label1 = new Label();
            label7 = new Label();
            name_textBox = new TextBox();
            dataGridView1 = new DataGridView();
            panel1 = new Panel();
            label3 = new Label();
            comboBox1 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 15.75F);
            label8.Location = new Point(16, 136);
            label8.Name = "label8";
            label8.Size = new Size(72, 25);
            label8.TabIndex = 59;
            label8.Text = "CODE";
            // 
            // code_textBox
            // 
            code_textBox.Font = new Font("Microsoft Sans Serif", 15.75F);
            code_textBox.Location = new Point(155, 134);
            code_textBox.Name = "code_textBox";
            code_textBox.Size = new Size(185, 31);
            code_textBox.TabIndex = 58;
            // 
            // clear_button
            // 
            clear_button.Location = new Point(184, 361);
            clear_button.Name = "clear_button";
            clear_button.Size = new Size(75, 23);
            clear_button.TabIndex = 57;
            clear_button.Text = "CLEAR";
            clear_button.UseVisualStyleBackColor = true;
            clear_button.Click += clear_button_Click;
            // 
            // back_button
            // 
            back_button.Location = new Point(16, 360);
            back_button.Name = "back_button";
            back_button.Size = new Size(75, 23);
            back_button.TabIndex = 56;
            back_button.Text = "BACK";
            back_button.UseVisualStyleBackColor = true;
            back_button.Click += back_button_Click;
            // 
            // add_button
            // 
            add_button.Location = new Point(265, 361);
            add_button.Name = "add_button";
            add_button.Size = new Size(75, 23);
            add_button.TabIndex = 54;
            add_button.Text = "ADD";
            add_button.UseVisualStyleBackColor = true;
            add_button.Click += add_button_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 15.75F);
            label1.Location = new Point(16, 193);
            label1.Name = "label1";
            label1.Size = new Size(73, 25);
            label1.TabIndex = 48;
            label1.Text = "NAME";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.White;
            label7.Location = new Point(334, 24);
            label7.Name = "label7";
            label7.Size = new Size(80, 15);
            label7.TabIndex = 17;
            label7.Text = "NEW COURSE";
            // 
            // name_textBox
            // 
            name_textBox.Font = new Font("Microsoft Sans Serif", 15.75F);
            name_textBox.Location = new Point(155, 191);
            name_textBox.Name = "name_textBox";
            name_textBox.Size = new Size(185, 31);
            name_textBox.TabIndex = 41;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(370, 66);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(344, 320);
            dataGridView1.TabIndex = 40;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 71, 140);
            panel1.Controls.Add(label7);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(723, 60);
            panel1.TabIndex = 39;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 15.75F);
            label3.Location = new Point(16, 255);
            label3.Name = "label3";
            label3.Size = new Size(120, 25);
            label3.TabIndex = 50;
            label3.Text = "PROGRAM";
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Microsoft Sans Serif", 15.75F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "BSCS", "BSEE", "BSIT", "MEDICAL", "BSSE" });
            comboBox1.Location = new Point(155, 252);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(185, 33);
            comboBox1.TabIndex = 61;
            // 
            // New_Course
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(723, 395);
            Controls.Add(comboBox1);
            Controls.Add(dataGridView1);
            Controls.Add(label8);
            Controls.Add(code_textBox);
            Controls.Add(clear_button);
            Controls.Add(back_button);
            Controls.Add(add_button);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(name_textBox);
            Controls.Add(panel1);
            Name = "New_Course";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "New_Course";
            Load += New_Course_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label8;
        private TextBox code_textBox;
        private Button clear_button;
        private Button back_button;
        private Button add_button;
        private Label label1;
        private Label label7;
        private TextBox name_textBox;
        private DataGridView dataGridView1;
        private Panel panel1;
        private Label label3;
        private ComboBox comboBox1;
    }
}