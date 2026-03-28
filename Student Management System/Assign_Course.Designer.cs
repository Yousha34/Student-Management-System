namespace Student_Management_System
{
    partial class Assign_Course
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
            selected_student_textBox = new TextBox();
            clear_button = new Button();
            label8 = new Label();
            back_button = new Button();
            next_button = new Button();
            dataGridView1 = new DataGridView();
            panel1 = new Panel();
            search_textBox = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // selected_student_textBox
            // 
            selected_student_textBox.Location = new Point(132, 290);
            selected_student_textBox.Name = "selected_student_textBox";
            selected_student_textBox.ReadOnly = true;
            selected_student_textBox.Size = new Size(100, 23);
            selected_student_textBox.TabIndex = 58;
            // 
            // clear_button
            // 
            clear_button.Location = new Point(380, 326);
            clear_button.Name = "clear_button";
            clear_button.Size = new Size(75, 23);
            clear_button.TabIndex = 57;
            clear_button.Text = "CLEAR";
            clear_button.UseVisualStyleBackColor = true;
            clear_button.Click += clear_button_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 294);
            label8.Name = "label8";
            label8.Size = new Size(114, 15);
            label8.TabIndex = 59;
            label8.Text = "SELECTED STUDENT";
            // 
            // back_button
            // 
            back_button.Location = new Point(14, 326);
            back_button.Name = "back_button";
            back_button.Size = new Size(75, 23);
            back_button.TabIndex = 56;
            back_button.Text = "BACK";
            back_button.UseVisualStyleBackColor = true;
            back_button.Click += back_button_Click;
            // 
            // next_button
            // 
            next_button.Location = new Point(461, 326);
            next_button.Name = "next_button";
            next_button.Size = new Size(75, 23);
            next_button.TabIndex = 54;
            next_button.Text = "NEXT";
            next_button.UseVisualStyleBackColor = true;
            next_button.Click += next_button_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Top;
            dataGridView1.Location = new Point(0, 57);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(548, 211);
            dataGridView1.TabIndex = 40;
            dataGridView1.DoubleClick += dataGridView1_DoubleClick;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 71, 140);
            panel1.Controls.Add(search_textBox);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(548, 57);
            panel1.TabIndex = 39;
            // 
            // search_textBox
            // 
            search_textBox.Font = new Font("Segoe UI", 14.25F);
            search_textBox.Location = new Point(298, 12);
            search_textBox.Name = "search_textBox";
            search_textBox.Size = new Size(238, 33);
            search_textBox.TabIndex = 69;
            search_textBox.TextChanged += search_textBox_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(127, 16);
            label1.Name = "label1";
            label1.Size = new Size(165, 25);
            label1.TabIndex = 70;
            label1.Text = "SEARCH STUDENT";
            // 
            // Assign_Course
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(548, 361);
            Controls.Add(selected_student_textBox);
            Controls.Add(clear_button);
            Controls.Add(label8);
            Controls.Add(back_button);
            Controls.Add(next_button);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Name = "Assign_Course";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Assign_Course";
            Load += Assign_Course_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox selected_student_textBox;
        private Button clear_button;
        private Label label8;
        private Button back_button;
        private Button next_button;
        private DataGridView dataGridView1;
        private Panel panel1;
        private TextBox search_textBox;
        private Label label1;
    }
}