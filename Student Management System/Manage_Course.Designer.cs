namespace Student_Management_System
{
    partial class Manage_Course
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
            label1 = new Label();
            label7 = new Label();
            dataGridView1 = new DataGridView();
            label3 = new Label();
            program_textBox = new TextBox();
            name_textBox = new TextBox();
            panel1 = new Panel();
            label9 = new Label();
            search_textBox = new TextBox();
            update_button = new Button();
            delete_button = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 15.75F);
            label8.Location = new Point(16, 135);
            label8.Name = "label8";
            label8.Size = new Size(72, 25);
            label8.TabIndex = 70;
            label8.Text = "CODE";
            // 
            // code_textBox
            // 
            code_textBox.Font = new Font("Microsoft Sans Serif", 15.75F);
            code_textBox.Location = new Point(140, 131);
            code_textBox.Name = "code_textBox";
            code_textBox.Size = new Size(209, 31);
            code_textBox.TabIndex = 0;
            // 
            // clear_button
            // 
            clear_button.Location = new Point(93, 360);
            clear_button.Name = "clear_button";
            clear_button.Size = new Size(75, 23);
            clear_button.TabIndex = 6;
            clear_button.Text = "CLEAR";
            clear_button.UseVisualStyleBackColor = true;
            clear_button.Click += clear_button_Click;
            // 
            // back_button
            // 
            back_button.Location = new Point(12, 360);
            back_button.Name = "back_button";
            back_button.Size = new Size(75, 23);
            back_button.TabIndex = 7;
            back_button.Text = "BACK";
            back_button.UseVisualStyleBackColor = true;
            back_button.Click += back_button_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 15.75F);
            label1.Location = new Point(16, 192);
            label1.Name = "label1";
            label1.Size = new Size(73, 25);
            label1.TabIndex = 64;
            label1.Text = "NAME";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.White;
            label7.Location = new Point(12, 23);
            label7.Name = "label7";
            label7.Size = new Size(104, 15);
            label7.TabIndex = 17;
            label7.Text = "MANAGE COURSE";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(370, 67);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(344, 320);
            dataGridView1.TabIndex = 61;
            dataGridView1.DoubleClick += dataGridView1_DoubleClick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 15.75F);
            label3.Location = new Point(16, 254);
            label3.Name = "label3";
            label3.Size = new Size(120, 25);
            label3.TabIndex = 65;
            label3.Text = "PROGRAM";
            // 
            // program_textBox
            // 
            program_textBox.Font = new Font("Microsoft Sans Serif", 15.75F);
            program_textBox.Location = new Point(140, 250);
            program_textBox.Name = "program_textBox";
            program_textBox.Size = new Size(209, 31);
            program_textBox.TabIndex = 3;
            // 
            // name_textBox
            // 
            name_textBox.Font = new Font("Microsoft Sans Serif", 15.75F);
            name_textBox.Location = new Point(140, 188);
            name_textBox.Name = "name_textBox";
            name_textBox.Size = new Size(209, 31);
            name_textBox.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 71, 140);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(search_textBox);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(723, 59);
            panel1.TabIndex = 60;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 14.25F);
            label9.ForeColor = Color.White;
            label9.Location = new Point(313, 17);
            label9.Name = "label9";
            label9.Size = new Size(154, 25);
            label9.TabIndex = 72;
            label9.Text = "SEARCH COURSE";
            // 
            // search_textBox
            // 
            search_textBox.Font = new Font("Segoe UI", 14.25F);
            search_textBox.Location = new Point(473, 14);
            search_textBox.Name = "search_textBox";
            search_textBox.Size = new Size(238, 33);
            search_textBox.TabIndex = 71;
            search_textBox.TextChanged += search_textBox_TextChanged;
            // 
            // update_button
            // 
            update_button.Location = new Point(193, 360);
            update_button.Name = "update_button";
            update_button.Size = new Size(75, 23);
            update_button.TabIndex = 4;
            update_button.Text = "UPDATE";
            update_button.UseVisualStyleBackColor = true;
            update_button.Click += update_button_Click;
            // 
            // delete_button
            // 
            delete_button.Location = new Point(274, 360);
            delete_button.Name = "delete_button";
            delete_button.Size = new Size(75, 23);
            delete_button.TabIndex = 5;
            delete_button.Text = "DELETE";
            delete_button.UseVisualStyleBackColor = true;
            delete_button.Click += delete_button_Click;
            // 
            // Manage_Course
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(723, 395);
            Controls.Add(update_button);
            Controls.Add(delete_button);
            Controls.Add(label8);
            Controls.Add(code_textBox);
            Controls.Add(clear_button);
            Controls.Add(back_button);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(label3);
            Controls.Add(program_textBox);
            Controls.Add(name_textBox);
            Controls.Add(panel1);
            Name = "Manage_Course";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Manage_Course";
            Load += Manage_Course_Load;
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
        private Label label1;
        private Label label7;
        private DataGridView dataGridView1;
        private Label label3;
        private TextBox program_textBox;
        private TextBox name_textBox;
        private Panel panel1;
        private Button update_button;
        private Button delete_button;
        private Label label9;
        private TextBox search_textBox;
    }
}