namespace Student_Management_System
{
    partial class Past_Students
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
            button2 = new Button();
            back_button = new Button();
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
            panel1.TabIndex = 78;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.White;
            label7.Location = new Point(390, 22);
            label7.Name = "label7";
            label7.Size = new Size(47, 15);
            label7.TabIndex = 17;
            label7.Text = "STATUS";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Top;
            dataGridView1.Location = new Point(0, 54);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(800, 324);
            dataGridView1.TabIndex = 79;
            // 
            // button2
            // 
            button2.Location = new Point(713, 384);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 82;
            button2.Text = "CLEAR";
            button2.UseVisualStyleBackColor = true;
            // 
            // back_button
            // 
            back_button.Location = new Point(12, 384);
            back_button.Name = "back_button";
            back_button.Size = new Size(75, 23);
            back_button.TabIndex = 80;
            back_button.Text = "BACK";
            back_button.UseVisualStyleBackColor = true;
            back_button.Click += back_button_Click_1;
            // 
            // Past_Students
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 419);
            Controls.Add(dataGridView1);
            Controls.Add(button2);
            Controls.Add(back_button);
            Controls.Add(panel1);
            Name = "Past_Students";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Show_Past_Students";
            Load += Past_Students_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label7;
        private DataGridView dataGridView1;
        private Button button2;
        private Button back_button;
    }
}