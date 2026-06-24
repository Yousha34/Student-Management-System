using System.Diagnostics;

namespace Student_Management_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            customized_sidepanel();
        }

        private void customized_sidepanel()
        {
            student_panel.Visible = false;
            course_panel.Visible = false;
        }

        private void show_submenu(Panel obj)
        {
            if (obj.Visible)
            {
                obj.Visible = false;
            }
            else
            {
                obj.Visible = true;
            }
        }

        private void student_button_Click(object sender, EventArgs e)
        {
            show_submenu(student_panel);
        }

        private void course_button_Click(object sender, EventArgs e)
        {
            show_submenu(course_panel);
        }

        private void registration_button_Click(object sender, EventArgs e)
        {
            Registration obj = new Registration();

            obj.Show();
            this.Hide();
        }

        private void manage_student_button_Click(object sender, EventArgs e)
        {
            Manage_Student obj = new Manage_Student();

            obj.Show();
            this.Hide();
        }

        private void new_course_button_Click(object sender, EventArgs e)
        {
            New_Course obj = new New_Course();

            obj.Show();
            this.Hide();

            obj.grid_view();
        }

        private void manage_course_button_Click(object sender, EventArgs e)
        {
            Manage_Course obj = new Manage_Course();

            obj.Show();
            this.Hide();

            obj.grid_view();
        }

        private void assign_course_button_Click(object sender, EventArgs e)
        {
            Assign_Course obj = new Assign_Course();

            obj.Show();
            this.Hide();

            obj.grid_view();
        }

        private void drop_course_button_Click(object sender, EventArgs e)
        {
            Drop_Course obj = new Drop_Course();

            obj.Show();
            this.Hide();

            obj.grid_view();
        }

        private void student_status_button_Click(object sender, EventArgs e)
        {
            Student_Status obj = new Student_Status();

            obj.Show();
            this.Hide();
        }

        private void course_status_button_Click(object sender, EventArgs e)
        {
            Course_Status obj = new Course_Status();

            obj.Show();
            this.Hide();
        }

        private void past_student_button_Click(object sender, EventArgs e)
        {
            Past_Students obj = new Past_Students();

            obj.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Process.Start("D:\\Visual Studio\\06 Projects\\Project 03\\Project 03\\bin\\Debug\\net8.0-windows\\Project 03");
            this.Hide();
        }
    }
}
