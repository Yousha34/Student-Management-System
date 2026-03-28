namespace Student_Management_System
{
    partial class Assign_Course_02
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
            clear_button = new Button();
            back_button = new Button();
            label1 = new Label();
            label7 = new Label();
            add_course_button = new Button();
            dataGridView1 = new DataGridView();
            label3 = new Label();
            panel1 = new Panel();
            comboBox1 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 15.75F);
            label8.Location = new Point(12, 115);
            label8.Name = "label8";
            label8.Size = new Size(366, 25);
            label8.TabIndex = 82;
            label8.Text = "NUMBER OF COURSE HE/SHE HAS";
            // 
            // clear_button
            // 
            clear_button.Location = new Point(235, 267);
            clear_button.Name = "clear_button";
            clear_button.Size = new Size(75, 23);
            clear_button.TabIndex = 76;
            clear_button.Text = "CLEAR";
            clear_button.UseVisualStyleBackColor = true;
            clear_button.Click += clear_button_Click;
            // 
            // back_button
            // 
            back_button.Location = new Point(12, 267);
            back_button.Name = "back_button";
            back_button.Size = new Size(75, 23);
            back_button.TabIndex = 77;
            back_button.Text = "BACK";
            back_button.UseVisualStyleBackColor = true;
            back_button.Click += back_button_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 15.75F);
            label1.Location = new Point(12, 80);
            label1.Name = "label1";
            label1.Size = new Size(73, 25);
            label1.TabIndex = 80;
            label1.Text = "NAME";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.White;
            label7.Location = new Point(300, 23);
            label7.Name = "label7";
            label7.Size = new Size(78, 15);
            label7.TabIndex = 17;
            label7.Text = "ADD COURSE";
            // 
            // add_course_button
            // 
            add_course_button.Location = new Point(316, 267);
            add_course_button.Name = "add_course_button";
            add_course_button.Size = new Size(75, 23);
            add_course_button.TabIndex = 75;
            add_course_button.Text = "ADD";
            add_course_button.UseVisualStyleBackColor = true;
            add_course_button.Click += add_course_button_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(433, 70);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(244, 220);
            dataGridView1.TabIndex = 79;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 15.75F);
            label3.Location = new Point(12, 205);
            label3.Name = "label3";
            label3.Size = new Size(189, 25);
            label3.TabIndex = 81;
            label3.Text = "SELECT COURSE";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 71, 140);
            panel1.Controls.Add(label7);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(689, 60);
            panel1.TabIndex = 78;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(207, 201);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(184, 33);
            comboBox1.TabIndex = 83;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // Assign_Course_02
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(689, 303);
            Controls.Add(comboBox1);
            Controls.Add(label8);
            Controls.Add(clear_button);
            Controls.Add(back_button);
            Controls.Add(label1);
            Controls.Add(add_course_button);
            Controls.Add(dataGridView1);
            Controls.Add(label3);
            Controls.Add(panel1);
            Name = "Assign_Course_02";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Assign_Course_02";
            Load += Assign_Course_02_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label8;
        private Button clear_button;
        private Button back_button;
        private Label label1;
        private Label label7;
        private Button add_course_button;
        private DataGridView dataGridView1;
        private Label label3;
        private Panel panel1;
        private ComboBox comboBox1;
    }
}