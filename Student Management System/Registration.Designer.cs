namespace Student_Management_System
{
    partial class Registration
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
            dataGridView1 = new DataGridView();
            next_button = new Button();
            clear_button = new Button();
            back_button = new Button();
            label8 = new Label();
            id_textBox = new TextBox();
            label2 = new Label();
            label1 = new Label();
            father_name_textBox = new TextBox();
            name_textBox = new TextBox();
            date_of_birth_dateTimePicker = new DateTimePicker();
            male_radioButton = new RadioButton();
            female_radioButton = new RadioButton();
            address_textBox = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            phone_textBox = new TextBox();
            label3 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 71, 140);
            panel1.Controls.Add(label7);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 54);
            panel1.TabIndex = 0;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.White;
            label7.Location = new Point(368, 23);
            label7.Name = "label7";
            label7.Size = new Size(86, 15);
            label7.TabIndex = 17;
            label7.Text = "REGISTRATION";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Top;
            dataGridView1.Location = new Point(0, 54);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(800, 211);
            dataGridView1.TabIndex = 12;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // next_button
            // 
            next_button.Location = new Point(711, 426);
            next_button.Name = "next_button";
            next_button.Size = new Size(75, 23);
            next_button.TabIndex = 9;
            next_button.Text = "NEXT";
            next_button.UseVisualStyleBackColor = true;
            next_button.Click += add_button_Click;
            // 
            // clear_button
            // 
            clear_button.Location = new Point(630, 426);
            clear_button.Name = "clear_button";
            clear_button.Size = new Size(75, 23);
            clear_button.TabIndex = 10;
            clear_button.Text = "CLEAR";
            clear_button.UseVisualStyleBackColor = true;
            clear_button.Click += clear_button_Click;
            // 
            // back_button
            // 
            back_button.Location = new Point(12, 426);
            back_button.Name = "back_button";
            back_button.Size = new Size(75, 23);
            back_button.TabIndex = 11;
            back_button.Text = "BACK";
            back_button.UseVisualStyleBackColor = true;
            back_button.Click += back_button_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(11, 291);
            label8.Name = "label8";
            label8.Size = new Size(18, 15);
            label8.TabIndex = 46;
            label8.Text = "ID";
            // 
            // id_textBox
            // 
            id_textBox.Location = new Point(35, 288);
            id_textBox.Name = "id_textBox";
            id_textBox.Size = new Size(100, 23);
            id_textBox.TabIndex = 0;
            id_textBox.KeyPress += id_textBox_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(303, 291);
            label2.Name = "label2";
            label2.Size = new Size(85, 15);
            label2.TabIndex = 43;
            label2.Text = "FATHER NAME";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(150, 291);
            label1.Name = "label1";
            label1.Size = new Size(41, 15);
            label1.TabIndex = 42;
            label1.Text = "NAME";
            // 
            // father_name_textBox
            // 
            father_name_textBox.Location = new Point(402, 288);
            father_name_textBox.Name = "father_name_textBox";
            father_name_textBox.Size = new Size(100, 23);
            father_name_textBox.TabIndex = 2;
            father_name_textBox.KeyPress += father_name_textBox_KeyPress;
            // 
            // name_textBox
            // 
            name_textBox.Location = new Point(197, 288);
            name_textBox.Name = "name_textBox";
            name_textBox.Size = new Size(100, 23);
            name_textBox.TabIndex = 1;
            name_textBox.KeyPress += name_textBox_KeyPress;
            // 
            // date_of_birth_dateTimePicker
            // 
            date_of_birth_dateTimePicker.Location = new Point(104, 335);
            date_of_birth_dateTimePicker.Name = "date_of_birth_dateTimePicker";
            date_of_birth_dateTimePicker.Size = new Size(200, 23);
            date_of_birth_dateTimePicker.TabIndex = 4;
            // 
            // male_radioButton
            // 
            male_radioButton.AutoSize = true;
            male_radioButton.Location = new Point(403, 335);
            male_radioButton.Name = "male_radioButton";
            male_radioButton.Size = new Size(51, 19);
            male_radioButton.TabIndex = 5;
            male_radioButton.TabStop = true;
            male_radioButton.Text = "Male";
            male_radioButton.UseVisualStyleBackColor = true;
            // 
            // female_radioButton
            // 
            female_radioButton.AutoSize = true;
            female_radioButton.Location = new Point(456, 335);
            female_radioButton.Name = "female_radioButton";
            female_radioButton.Size = new Size(63, 19);
            female_radioButton.TabIndex = 7;
            female_radioButton.TabStop = true;
            female_radioButton.Text = "Female";
            female_radioButton.UseVisualStyleBackColor = true;
            // 
            // address_textBox
            // 
            address_textBox.Location = new Point(76, 375);
            address_textBox.Multiline = true;
            address_textBox.Name = "address_textBox";
            address_textBox.Size = new Size(556, 31);
            address_textBox.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 339);
            label4.Name = "label4";
            label4.Size = new Size(88, 15);
            label4.TabIndex = 12;
            label4.Text = "DATE OF BIRTH";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(336, 337);
            label5.Name = "label5";
            label5.Size = new Size(51, 15);
            label5.TabIndex = 13;
            label5.Text = "GENDER";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 378);
            label6.Name = "label6";
            label6.Size = new Size(56, 15);
            label6.TabIndex = 14;
            label6.Text = "ADDRESS";
            // 
            // phone_textBox
            // 
            phone_textBox.Location = new Point(592, 288);
            phone_textBox.Name = "phone_textBox";
            phone_textBox.Size = new Size(100, 23);
            phone_textBox.TabIndex = 3;
            phone_textBox.KeyPress += phone_textBox_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(518, 291);
            label3.Name = "label3";
            label3.Size = new Size(68, 15);
            label3.TabIndex = 44;
            label3.Text = "PHONE NO";
            // 
            // Registration
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 461);
            Controls.Add(label8);
            Controls.Add(id_textBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(phone_textBox);
            Controls.Add(father_name_textBox);
            Controls.Add(name_textBox);
            Controls.Add(back_button);
            Controls.Add(clear_button);
            Controls.Add(next_button);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(address_textBox);
            Controls.Add(female_radioButton);
            Controls.Add(male_radioButton);
            Controls.Add(date_of_birth_dateTimePicker);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Name = "Registration";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registration";
            Load += Registration_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private DataGridView dataGridView1;
        private Button next_button;
        private Button clear_button;
        private Label label7;
        private Button back_button;
        private Label label8;
        private TextBox id_textBox;
        private Label label2;
        private Label label1;
        private TextBox father_name_textBox;
        private TextBox name_textBox;
        private DateTimePicker date_of_birth_dateTimePicker;
        private RadioButton male_radioButton;
        private RadioButton female_radioButton;
        private TextBox address_textBox;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox phone_textBox;
        private Label label3;
    }
}