using Microsoft.Data.SqlClient;
using System.Data;

namespace Student_Management_System
{
    public partial class Drop_Course_02 : Form
    {
        string connection_string = "Data Source=DESKTOP-OHJMFVT\\SQLEXPRESS;Initial Catalog=Student_management_system;Integrated Security=True;Trust Server Certificate=True";
        private string selected_student;

        public Drop_Course_02(string temp_selected_student)
        {
            InitializeComponent();
            this.selected_student = temp_selected_student;
        }

        private void Drop_Course_02_Load(object sender, EventArgs e)
        {
            name_lable_text_change();
            number_of_course_lable_text_change();
            fill_datagrid();
        }

        public void name_lable_text_change()
        {
            SqlConnection conn = new SqlConnection(connection_string);
            conn.Open();

            string query = "SELECT Name FROM student_personal_info WHERE Id = @id";

            SqlCommand cmd1 = new SqlCommand(query, conn);
            cmd1.Parameters.AddWithValue("@id", selected_student);

            object result = cmd1.ExecuteScalar();

            if (result != null)
            {
                label1.Text = result.ToString().ToUpper();
            }
            else
            {
                label1.Text = "Student Not Found";
            }
        }

        public void number_of_course_lable_text_change()
        {
            SqlConnection conn = new SqlConnection(connection_string);
            conn.Open();

            string query = "SELECT COUNT(*) FROM assign_course WHERE Student_Id = @id";

            SqlCommand cmd2 = new SqlCommand(query, conn);
            cmd2.Parameters.AddWithValue("@id", selected_student);

            int course_count = (int)cmd2.ExecuteScalar();

            label8.Text = "ALREADY ENROLLED IN " + course_count.ToString() + " COURSES";
        }

        public void fill_datagrid()
        {
            SqlConnection conn = new SqlConnection(connection_string);
            conn.Open();

            string query = "SELECT c.Code, c.Name FROM assign_course ac JOIN course c ON ac.Course_Code = c.Code WHERE ac.Student_Id = @id";

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@id", selected_student);

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable obj = new DataTable();

            adapter.Fill(obj);
            dataGridView1.DataSource = obj;

            conn.Close();
        }

        private void drop_course_button_Click(object sender, EventArgs e)
        {
            string course_code_to_drop = textBox1.Text.Trim();

            if (string.IsNullOrEmpty(course_code_to_drop))
            {
                MessageBox.Show("Please enter a valid course name.");
                return;
            }

            SqlConnection conn = new SqlConnection(connection_string);
            conn.Open();

            // Step 1: Check if course exists
            string check_course_query = "SELECT COUNT(*) FROM course WHERE Code = @code";
            SqlCommand check_course_cmd = new SqlCommand(check_course_query, conn);
            check_course_cmd.Parameters.AddWithValue("@code", course_code_to_drop);

            int course_exists = (int)check_course_cmd.ExecuteScalar();
            if (course_exists == 0)
            {
                MessageBox.Show("Course code not found.");
                conn.Close();
                return;
            }

            // Step 2: Check if student is assigned this course
            string check_assign_query = "SELECT COUNT(*) FROM assign_course WHERE Student_Id = @id AND Course_Code = @code";
            SqlCommand check_assign_cmd = new SqlCommand(check_assign_query, conn);
            check_assign_cmd.Parameters.AddWithValue("@id", selected_student);
            check_assign_cmd.Parameters.AddWithValue("@code", course_code_to_drop);

            int assigned = (int)check_assign_cmd.ExecuteScalar();
            if (assigned == 0)
            {
                MessageBox.Show("This course is not assigned to the student.");
                conn.Close();
                return;
            }

            // Step 3: Delete course assignment
            string delete_query = "DELETE FROM assign_course WHERE Student_Id = @id AND Course_Code = @code";
            SqlCommand delete_cmd = new SqlCommand(delete_query, conn);
            delete_cmd.Parameters.AddWithValue("@id", selected_student);
            delete_cmd.Parameters.AddWithValue("@code", course_code_to_drop);

            int rows_deleted = delete_cmd.ExecuteNonQuery();

            if (rows_deleted > 0)
            {
                MessageBox.Show("Course successfully dropped!");
                fill_datagrid();
                number_of_course_lable_text_change();
                textBox1.Clear();
            }
            else
            {
                MessageBox.Show("Failed to drop course.");
            }

            conn.Close();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                textBox1.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            }
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 obj = new Form1();
            obj.Show();
        }
    }
}
