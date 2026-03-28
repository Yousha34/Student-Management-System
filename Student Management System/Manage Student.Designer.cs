namespace Student_Management_System
{
    partial class Manage_Student
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
            back_button = new Button();
            update_button = new Button();
            delete_button = new Button();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            address_textBox = new TextBox();
            male_radioButton = new RadioButton();
            date_of_birth_dateTimePicker = new DateTimePicker();
            phone_textBox = new TextBox();
            father_name_textBox = new TextBox();
            name_textBox = new TextBox();
            dataGridView1 = new DataGridView();
            label7 = new Label();
            female_radioButton = new RadioButton();
            panel1 = new Panel();
            label9 = new Label();
            search_textBox = new TextBox();
            clear_button = new Button();
            label8 = new Label();
            id_textBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // back_button
            // 
            back_button.Location = new Point(12, 426);
            back_button.Name = "back_button";
            back_button.Size = new Size(75, 23);
            back_button.TabIndex = 35;
            back_button.Text = "BACK";
            back_button.UseVisualStyleBackColor = true;
            back_button.Click += back_button_Click;
            // 
            // update_button
            // 
            update_button.Location = new Point(630, 426);
            update_button.Name = "update_button";
            update_button.Size = new Size(75, 23);
            update_button.TabIndex = 34;
            update_button.Text = "UPDATE";
            update_button.UseVisualStyleBackColor = true;
            update_button.Click += update_button_Click;
            // 
            // delete_button
            // 
            delete_button.Location = new Point(711, 426);
            delete_button.Name = "delete_button";
            delete_button.Size = new Size(75, 23);
            delete_button.TabIndex = 33;
            delete_button.Text = "DELETE";
            delete_button.UseVisualStyleBackColor = true;
            delete_button.Click += delete_button_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 378);
            label6.Name = "label6";
            label6.Size = new Size(56, 15);
            label6.TabIndex = 32;
            label6.Text = "ADDRESS";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(336, 337);
            label5.Name = "label5";
            label5.Size = new Size(51, 15);
            label5.TabIndex = 31;
            label5.Text = "GENDER";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 339);
            label4.Name = "label4";
            label4.Size = new Size(88, 15);
            label4.TabIndex = 30;
            label4.Text = "DATE OF BIRTH";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(519, 292);
            label3.Name = "label3";
            label3.Size = new Size(68, 15);
            label3.TabIndex = 29;
            label3.Text = "PHONE NO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(304, 292);
            label2.Name = "label2";
            label2.Size = new Size(85, 15);
            label2.TabIndex = 28;
            label2.Text = "FATHER NAME";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(151, 292);
            label1.Name = "label1";
            label1.Size = new Size(41, 15);
            label1.TabIndex = 27;
            label1.Text = "NAME";
            // 
            // address_textBox
            // 
            address_textBox.Location = new Point(76, 375);
            address_textBox.Multiline = true;
            address_textBox.Name = "address_textBox";
            address_textBox.Size = new Size(556, 31);
            address_textBox.TabIndex = 26;
            // 
            // male_radioButton
            // 
            male_radioButton.AutoSize = true;
            male_radioButton.Location = new Point(403, 335);
            male_radioButton.Name = "male_radioButton";
            male_radioButton.Size = new Size(51, 19);
            male_radioButton.TabIndex = 24;
            male_radioButton.TabStop = true;
            male_radioButton.Text = "Male";
            male_radioButton.UseVisualStyleBackColor = true;
            // 
            // date_of_birth_dateTimePicker
            // 
            date_of_birth_dateTimePicker.Location = new Point(104, 335);
            date_of_birth_dateTimePicker.Name = "date_of_birth_dateTimePicker";
            date_of_birth_dateTimePicker.Size = new Size(200, 23);
            date_of_birth_dateTimePicker.TabIndex = 23;
            // 
            // phone_textBox
            // 
            phone_textBox.Location = new Point(593, 289);
            phone_textBox.Name = "phone_textBox";
            phone_textBox.Size = new Size(100, 23);
            phone_textBox.TabIndex = 22;
            phone_textBox.KeyPress += phone_textBox_KeyPress;
            // 
            // father_name_textBox
            // 
            father_name_textBox.Location = new Point(403, 289);
            father_name_textBox.Name = "father_name_textBox";
            father_name_textBox.Size = new Size(100, 23);
            father_name_textBox.TabIndex = 21;
            father_name_textBox.KeyPress += father_name_textBox_KeyPress;
            // 
            // name_textBox
            // 
            name_textBox.Location = new Point(198, 289);
            name_textBox.Name = "name_textBox";
            name_textBox.Size = new Size(100, 23);
            name_textBox.TabIndex = 20;
            name_textBox.KeyPress += name_textBox_KeyPress;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Top;
            dataGridView1.Location = new Point(0, 54);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(800, 211);
            dataGridView1.TabIndex = 19;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.MouseDoubleClick += dataGridView1_MouseDoubleClick;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.White;
            label7.Location = new Point(12, 21);
            label7.Name = "label7";
            label7.Size = new Size(111, 15);
            label7.TabIndex = 17;
            label7.Text = "MANAGE STUDENT";
            // 
            // female_radioButton
            // 
            female_radioButton.AutoSize = true;
            female_radioButton.Location = new Point(456, 335);
            female_radioButton.Name = "female_radioButton";
            female_radioButton.Size = new Size(63, 19);
            female_radioButton.TabIndex = 25;
            female_radioButton.TabStop = true;
            female_radioButton.Text = "Female";
            female_radioButton.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 71, 140);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(search_textBox);
            panel1.Controls.Add(label7);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 54);
            panel1.TabIndex = 18;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 14.25F);
            label9.ForeColor = Color.White;
            label9.Location = new Point(379, 16);
            label9.Name = "label9";
            label9.Size = new Size(165, 25);
            label9.TabIndex = 70;
            label9.Text = "SEARCH STUDENT";
            // 
            // search_textBox
            // 
            search_textBox.Font = new Font("Segoe UI", 14.25F);
            search_textBox.Location = new Point(550, 12);
            search_textBox.Name = "search_textBox";
            search_textBox.Size = new Size(238, 33);
            search_textBox.TabIndex = 69;
            search_textBox.TextChanged += search_textBox_TextChanged;
            // 
            // clear_button
            // 
            clear_button.Location = new Point(549, 426);
            clear_button.Name = "clear_button";
            clear_button.Size = new Size(75, 23);
            clear_button.TabIndex = 36;
            clear_button.Text = "CLEAR";
            clear_button.UseVisualStyleBackColor = true;
            clear_button.Click += clear_button_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 292);
            label8.Name = "label8";
            label8.Size = new Size(18, 15);
            label8.TabIndex = 38;
            label8.Text = "ID";
            // 
            // id_textBox
            // 
            id_textBox.Location = new Point(36, 289);
            id_textBox.Name = "id_textBox";
            id_textBox.Size = new Size(100, 23);
            id_textBox.TabIndex = 37;
            // 
            // Manage_Student
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 461);
            Controls.Add(label8);
            Controls.Add(id_textBox);
            Controls.Add(clear_button);
            Controls.Add(back_button);
            Controls.Add(update_button);
            Controls.Add(delete_button);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(address_textBox);
            Controls.Add(male_radioButton);
            Controls.Add(date_of_birth_dateTimePicker);
            Controls.Add(phone_textBox);
            Controls.Add(father_name_textBox);
            Controls.Add(name_textBox);
            Controls.Add(dataGridView1);
            Controls.Add(female_radioButton);
            Controls.Add(panel1);
            Name = "Manage_Student";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Manage_Student";
            Load += Manage_Student_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button back_button;
        private Button update_button;
        private Button delete_button;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox address_textBox;
        private RadioButton male_radioButton;
        private DateTimePicker date_of_birth_dateTimePicker;
        private TextBox phone_textBox;
        private TextBox father_name_textBox;
        private TextBox name_textBox;
        private DataGridView dataGridView1;
        private Label label7;
        private RadioButton female_radioButton;
        private Panel panel1;
        private Button clear_button;
        private Label label8;
        private TextBox id_textBox;
        private Label label9;
        private TextBox search_textBox;
    }
}