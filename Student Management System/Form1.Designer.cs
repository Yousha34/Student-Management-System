namespace Student_Management_System
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel_slide = new Panel();
            button2 = new Button();
            course_panel = new Panel();
            button1 = new Button();
            course_status_button = new Button();
            drop_course_button = new Button();
            assign_course_button = new Button();
            manage_course_button = new Button();
            new_course_button = new Button();
            course_button = new Button();
            student_panel = new Panel();
            past_student_button = new Button();
            student_status_button = new Button();
            manage_student_button = new Button();
            registration_button = new Button();
            student_button = new Button();
            panel5 = new Panel();
            label1 = new Label();
            panel1 = new Panel();
            panel3 = new Panel();
            pictureBox1 = new PictureBox();
            panel4 = new Panel();
            pictureBox2 = new PictureBox();
            panel_slide.SuspendLayout();
            course_panel.SuspendLayout();
            student_panel.SuspendLayout();
            panel5.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel_slide
            // 
            panel_slide.AutoScroll = true;
            panel_slide.BackColor = Color.FromArgb(0, 71, 140);
            panel_slide.Controls.Add(button2);
            panel_slide.Controls.Add(course_panel);
            panel_slide.Controls.Add(course_button);
            panel_slide.Controls.Add(student_panel);
            panel_slide.Controls.Add(student_button);
            panel_slide.Controls.Add(panel5);
            panel_slide.Dock = DockStyle.Left;
            panel_slide.Location = new Point(0, 0);
            panel_slide.Margin = new Padding(3, 4, 3, 4);
            panel_slide.Name = "panel_slide";
            panel_slide.Size = new Size(211, 564);
            panel_slide.TabIndex = 0;
            // 
            // button2
            // 
            button2.Dock = DockStyle.Bottom;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            button2.ForeColor = Color.White;
            button2.Location = new Point(0, 663);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Padding = new Padding(11, 0, 0, 0);
            button2.Size = new Size(190, 48);
            button2.TabIndex = 8;
            button2.Text = "LOGOUT";
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // course_panel
            // 
            course_panel.BackColor = Color.FromArgb(0, 71, 180);
            course_panel.Controls.Add(button1);
            course_panel.Controls.Add(course_status_button);
            course_panel.Controls.Add(drop_course_button);
            course_panel.Controls.Add(assign_course_button);
            course_panel.Controls.Add(manage_course_button);
            course_panel.Controls.Add(new_course_button);
            course_panel.Dock = DockStyle.Top;
            course_panel.Location = new Point(0, 420);
            course_panel.Margin = new Padding(3, 4, 3, 4);
            course_panel.Name = "course_panel";
            course_panel.Size = new Size(190, 243);
            course_panel.TabIndex = 4;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Top;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(0, 240);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Padding = new Padding(34, 0, 0, 0);
            button1.Size = new Size(190, 48);
            button1.TabIndex = 9;
            button1.Text = "STATUS";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = true;
            // 
            // course_status_button
            // 
            course_status_button.Dock = DockStyle.Top;
            course_status_button.FlatAppearance.BorderSize = 0;
            course_status_button.FlatStyle = FlatStyle.Flat;
            course_status_button.ForeColor = Color.White;
            course_status_button.Location = new Point(0, 192);
            course_status_button.Margin = new Padding(3, 4, 3, 4);
            course_status_button.Name = "course_status_button";
            course_status_button.Padding = new Padding(34, 0, 0, 0);
            course_status_button.Size = new Size(190, 48);
            course_status_button.TabIndex = 8;
            course_status_button.Text = "STATUS";
            course_status_button.TextAlign = ContentAlignment.MiddleLeft;
            course_status_button.UseVisualStyleBackColor = true;
            course_status_button.Click += course_status_button_Click;
            // 
            // drop_course_button
            // 
            drop_course_button.Dock = DockStyle.Top;
            drop_course_button.FlatAppearance.BorderSize = 0;
            drop_course_button.FlatStyle = FlatStyle.Flat;
            drop_course_button.ForeColor = Color.White;
            drop_course_button.Location = new Point(0, 144);
            drop_course_button.Margin = new Padding(3, 4, 3, 4);
            drop_course_button.Name = "drop_course_button";
            drop_course_button.Padding = new Padding(34, 0, 0, 0);
            drop_course_button.Size = new Size(190, 48);
            drop_course_button.TabIndex = 7;
            drop_course_button.Text = "DROP COURSE";
            drop_course_button.TextAlign = ContentAlignment.MiddleLeft;
            drop_course_button.UseVisualStyleBackColor = true;
            drop_course_button.Click += drop_course_button_Click;
            // 
            // assign_course_button
            // 
            assign_course_button.Dock = DockStyle.Top;
            assign_course_button.FlatAppearance.BorderSize = 0;
            assign_course_button.FlatStyle = FlatStyle.Flat;
            assign_course_button.ForeColor = Color.White;
            assign_course_button.Location = new Point(0, 96);
            assign_course_button.Margin = new Padding(3, 4, 3, 4);
            assign_course_button.Name = "assign_course_button";
            assign_course_button.Padding = new Padding(34, 0, 0, 0);
            assign_course_button.Size = new Size(190, 48);
            assign_course_button.TabIndex = 6;
            assign_course_button.Text = "ASSIGN COURSE";
            assign_course_button.TextAlign = ContentAlignment.MiddleLeft;
            assign_course_button.UseVisualStyleBackColor = true;
            assign_course_button.Click += assign_course_button_Click;
            // 
            // manage_course_button
            // 
            manage_course_button.Dock = DockStyle.Top;
            manage_course_button.FlatAppearance.BorderSize = 0;
            manage_course_button.FlatStyle = FlatStyle.Flat;
            manage_course_button.ForeColor = Color.White;
            manage_course_button.Location = new Point(0, 48);
            manage_course_button.Margin = new Padding(3, 4, 3, 4);
            manage_course_button.Name = "manage_course_button";
            manage_course_button.Padding = new Padding(34, 0, 0, 0);
            manage_course_button.Size = new Size(190, 48);
            manage_course_button.TabIndex = 4;
            manage_course_button.Text = "MANAGE COURSE";
            manage_course_button.TextAlign = ContentAlignment.MiddleLeft;
            manage_course_button.UseVisualStyleBackColor = true;
            manage_course_button.Click += manage_course_button_Click;
            // 
            // new_course_button
            // 
            new_course_button.Dock = DockStyle.Top;
            new_course_button.FlatAppearance.BorderSize = 0;
            new_course_button.FlatStyle = FlatStyle.Flat;
            new_course_button.ForeColor = Color.White;
            new_course_button.Location = new Point(0, 0);
            new_course_button.Margin = new Padding(3, 4, 3, 4);
            new_course_button.Name = "new_course_button";
            new_course_button.Padding = new Padding(34, 0, 0, 0);
            new_course_button.Size = new Size(190, 48);
            new_course_button.TabIndex = 1;
            new_course_button.Text = "NEW COURSE";
            new_course_button.TextAlign = ContentAlignment.MiddleLeft;
            new_course_button.UseVisualStyleBackColor = true;
            new_course_button.Click += new_course_button_Click;
            // 
            // course_button
            // 
            course_button.Dock = DockStyle.Top;
            course_button.FlatAppearance.BorderSize = 0;
            course_button.FlatStyle = FlatStyle.Flat;
            course_button.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            course_button.ForeColor = Color.White;
            course_button.Location = new Point(0, 372);
            course_button.Margin = new Padding(3, 4, 3, 4);
            course_button.Name = "course_button";
            course_button.Padding = new Padding(11, 0, 0, 0);
            course_button.Size = new Size(190, 48);
            course_button.TabIndex = 3;
            course_button.Text = "COURSE";
            course_button.TextAlign = ContentAlignment.MiddleLeft;
            course_button.UseVisualStyleBackColor = true;
            course_button.Click += course_button_Click;
            // 
            // student_panel
            // 
            student_panel.BackColor = Color.FromArgb(0, 71, 180);
            student_panel.Controls.Add(past_student_button);
            student_panel.Controls.Add(student_status_button);
            student_panel.Controls.Add(manage_student_button);
            student_panel.Controls.Add(registration_button);
            student_panel.Dock = DockStyle.Top;
            student_panel.Location = new Point(0, 181);
            student_panel.Margin = new Padding(3, 4, 3, 4);
            student_panel.Name = "student_panel";
            student_panel.Size = new Size(190, 191);
            student_panel.TabIndex = 2;
            // 
            // past_student_button
            // 
            past_student_button.Dock = DockStyle.Top;
            past_student_button.FlatAppearance.BorderSize = 0;
            past_student_button.FlatStyle = FlatStyle.Flat;
            past_student_button.ForeColor = Color.White;
            past_student_button.Location = new Point(0, 144);
            past_student_button.Margin = new Padding(3, 4, 3, 4);
            past_student_button.Name = "past_student_button";
            past_student_button.Padding = new Padding(34, 0, 0, 0);
            past_student_button.Size = new Size(190, 48);
            past_student_button.TabIndex = 3;
            past_student_button.Text = "PAST STUDENTS";
            past_student_button.TextAlign = ContentAlignment.MiddleLeft;
            past_student_button.UseVisualStyleBackColor = true;
            past_student_button.Click += past_student_button_Click;
            // 
            // student_status_button
            // 
            student_status_button.Dock = DockStyle.Top;
            student_status_button.FlatAppearance.BorderSize = 0;
            student_status_button.FlatStyle = FlatStyle.Flat;
            student_status_button.ForeColor = Color.White;
            student_status_button.Location = new Point(0, 96);
            student_status_button.Margin = new Padding(3, 4, 3, 4);
            student_status_button.Name = "student_status_button";
            student_status_button.Padding = new Padding(34, 0, 0, 0);
            student_status_button.Size = new Size(190, 48);
            student_status_button.TabIndex = 2;
            student_status_button.Text = "STATUS";
            student_status_button.TextAlign = ContentAlignment.MiddleLeft;
            student_status_button.UseVisualStyleBackColor = true;
            student_status_button.Click += student_status_button_Click;
            // 
            // manage_student_button
            // 
            manage_student_button.Dock = DockStyle.Top;
            manage_student_button.FlatAppearance.BorderSize = 0;
            manage_student_button.FlatStyle = FlatStyle.Flat;
            manage_student_button.ForeColor = Color.White;
            manage_student_button.Location = new Point(0, 48);
            manage_student_button.Margin = new Padding(3, 4, 3, 4);
            manage_student_button.Name = "manage_student_button";
            manage_student_button.Padding = new Padding(34, 0, 0, 0);
            manage_student_button.Size = new Size(190, 48);
            manage_student_button.TabIndex = 1;
            manage_student_button.Text = "MANAGE STUDENT";
            manage_student_button.TextAlign = ContentAlignment.MiddleLeft;
            manage_student_button.UseVisualStyleBackColor = true;
            manage_student_button.Click += manage_student_button_Click;
            // 
            // registration_button
            // 
            registration_button.Dock = DockStyle.Top;
            registration_button.FlatAppearance.BorderSize = 0;
            registration_button.FlatStyle = FlatStyle.Flat;
            registration_button.ForeColor = Color.White;
            registration_button.Location = new Point(0, 0);
            registration_button.Margin = new Padding(3, 4, 3, 4);
            registration_button.Name = "registration_button";
            registration_button.Padding = new Padding(34, 0, 0, 0);
            registration_button.Size = new Size(190, 48);
            registration_button.TabIndex = 0;
            registration_button.Text = "REGISTRATION";
            registration_button.TextAlign = ContentAlignment.MiddleLeft;
            registration_button.UseVisualStyleBackColor = true;
            registration_button.Click += registration_button_Click;
            // 
            // student_button
            // 
            student_button.Dock = DockStyle.Top;
            student_button.FlatAppearance.BorderSize = 0;
            student_button.FlatStyle = FlatStyle.Flat;
            student_button.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            student_button.ForeColor = Color.White;
            student_button.Location = new Point(0, 133);
            student_button.Margin = new Padding(3, 4, 3, 4);
            student_button.Name = "student_button";
            student_button.Padding = new Padding(11, 0, 0, 0);
            student_button.Size = new Size(190, 48);
            student_button.TabIndex = 1;
            student_button.Text = "STUDENT";
            student_button.TextAlign = ContentAlignment.MiddleLeft;
            student_button.UseVisualStyleBackColor = true;
            student_button.Click += student_button_Click;
            // 
            // panel5
            // 
            panel5.Controls.Add(label1);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 0);
            panel5.Margin = new Padding(3, 4, 3, 4);
            panel5.Name = "panel5";
            panel5.Size = new Size(190, 133);
            panel5.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(11, 49);
            label1.Name = "label1";
            label1.Size = new Size(192, 37);
            label1.TabIndex = 0;
            label1.Text = "DASHBOARD";
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(168, 94);
            panel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(0, 71, 140);
            panel3.Controls.Add(pictureBox1);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(211, 0);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(602, 80);
            panel3.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(513, -4);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(90, 80);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(0, 71, 140);
            panel4.Location = new Point(211, 468);
            panel4.Margin = new Padding(3, 4, 3, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(603, 97);
            panel4.TabIndex = 3;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(211, 72);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(603, 396);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(813, 564);
            Controls.Add(pictureBox2);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel_slide);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            panel_slide.ResumeLayout(false);
            course_panel.ResumeLayout(false);
            student_panel.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_slide;
        private Panel panel1;
        private Panel student_panel;
        private Button student_button;
        private Button student_status_button;
        private Button manage_student_button;
        private Button registration_button;
        private Button course_button;
        private Panel course_panel;
        private Button assign_course_button;
        private Button manage_course_button;
        private Button new_course_button;
        private Panel panel3;
        private Panel panel4;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button drop_course_button;
        private Button course_status_button;
        private Panel panel5;
        private Label label1;
        private Button button1;
        private Button past_student_button;
        private Button button2;
    }
}
