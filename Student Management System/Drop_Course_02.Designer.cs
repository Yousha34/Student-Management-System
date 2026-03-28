namespace Student_Management_System
{
    partial class Drop_Course_02
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
            drop_course_button = new Button();
            dataGridView1 = new DataGridView();
            label3 = new Label();
            panel1 = new Panel();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 15.75F);
            label8.Location = new Point(12, 114);
            label8.Name = "label8";
            label8.Size = new Size(366, 25);
            label8.TabIndex = 91;
            label8.Text = "NUMBER OF COURSE HE/SHE HAS";
            // 
            // clear_button
            // 
            clear_button.Location = new Point(235, 266);
            clear_button.Name = "clear_button";
            clear_button.Size = new Size(75, 23);
            clear_button.TabIndex = 85;
            clear_button.Text = "CLEAR";
            clear_button.UseVisualStyleBackColor = true;
            // 
            // back_button
            // 
            back_button.Location = new Point(12, 266);
            back_button.Name = "back_button";
            back_button.Size = new Size(75, 23);
            back_button.TabIndex = 86;
            back_button.Text = "BACK";
            back_button.UseVisualStyleBackColor = true;
            back_button.Click += back_button_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 15.75F);
            label1.Location = new Point(12, 79);
            label1.Name = "label1";
            label1.Size = new Size(73, 25);
            label1.TabIndex = 89;
            label1.Text = "NAME";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.White;
            label7.Location = new Point(300, 23);
            label7.Name = "label7";
            label7.Size = new Size(85, 15);
            label7.TabIndex = 17;
            label7.Text = "DROP COURSE";
            // 
            // drop_course_button
            // 
            drop_course_button.Location = new Point(316, 266);
            drop_course_button.Name = "drop_course_button";
            drop_course_button.Size = new Size(75, 23);
            drop_course_button.TabIndex = 84;
            drop_course_button.Text = "DROP";
            drop_course_button.UseVisualStyleBackColor = true;
            drop_course_button.Click += drop_course_button_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(433, 69);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(244, 220);
            dataGridView1.TabIndex = 88;
            dataGridView1.DoubleClick += dataGridView1_DoubleClick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 15.75F);
            label3.Location = new Point(12, 204);
            label3.Name = "label3";
            label3.Size = new Size(189, 25);
            label3.TabIndex = 90;
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
            panel1.TabIndex = 87;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 14.25F);
            textBox1.Location = new Point(207, 200);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(184, 33);
            textBox1.TabIndex = 93;
            // 
            // Drop_Course_02
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(689, 303);
            Controls.Add(textBox1);
            Controls.Add(label8);
            Controls.Add(clear_button);
            Controls.Add(back_button);
            Controls.Add(label1);
            Controls.Add(drop_course_button);
            Controls.Add(dataGridView1);
            Controls.Add(label3);
            Controls.Add(panel1);
            Name = "Drop_Course_02";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Drop_Course_02";
            Load += Drop_Course_02_Load;
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
        private Button drop_course_button;
        private DataGridView dataGridView1;
        private Label label3;
        private Panel panel1;
        private TextBox textBox1;
    }
}