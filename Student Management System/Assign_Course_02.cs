using Microsoft.Data.SqlClient;
using System.Data;

namespace Student_Management_System
{
    public partial class Assign_Course_02 : Form
    {
        string connection_string = "Data Source=DESKTOP-OHJMFVT\\SQLEXPRESS;Initial Catalog=Student_management_system;Integrated Security=True;Trust Server Certificate=True";
        private string selected_student;

        public Assign_Course_02(string temp_selected_student)
        {
            InitializeComponent();
            this.selected_student = temp_selected_student;
        }

        private void Assign_Course_02_Load(object sender, EventArgs e)
        {
            name_lable_text_change();
            number_of_course_lable_text_change();
            fill_combobox();
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

        public void fill_combobox()
        {
            SqlConnection conn = new SqlConnection(connection_string);
            conn.Open();

            string student_program = "";
            string program_query = "SELECT Program FROM student_uni_info WHERE Student_Id = @id";

            SqlCommand cmd = new SqlCommand(program_query, conn);
            cmd.Parameters.AddWithValue("@id", selected_student);

            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                student_program = reader["Program"].ToString();
            }

            reader.Close();
            comboBox1.Items.Clear();

            if (!string.IsNullOrEmpty(student_program))
            {
                string course_query = "SELECT Name FROM course WHERE Program = @program";

                SqlCommand course_cmd = new SqlCommand(course_query, conn);
                course_cmd.Parameters.AddWithValue("@program", student_program);

                SqlDataReader course_reader = course_cmd.ExecuteReader();

                while (course_reader.Read())
                {
                    comboBox1.Items.Add(course_reader["Name"].ToString());
                }

                course_reader.Close();

                if (comboBox1.Items.Count > 0)
                {
                    comboBox1.SelectedIndex = 0;
                }
                else
                {
                    comboBox1.Items.Add("No courses found");
                }
            }
            else
            {
                comboBox1.Items.Add("Program not found!");
            }

            conn.Close();
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void add_course_button_Click(object sender, EventArgs e)
        {
            string selected_course_name = comboBox1.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(selected_course_name) || selected_course_name == "No courses found" || selected_course_name == "Program not found!")
            {
                MessageBox.Show("Please select a valid course.");
                return;
            }

            SqlConnection conn = new SqlConnection(connection_string);
            conn.Open();

            string course_code = "";
            string get_code_query = "SELECT Code FROM course WHERE Name = @name";

            SqlCommand cmd1 = new SqlCommand(get_code_query, conn);
            cmd1.Parameters.AddWithValue("@name", selected_course_name);

            object code_result = cmd1.ExecuteScalar();

            if (code_result != null)
            {
                course_code = code_result.ToString();
            }
            else
            {
                MessageBox.Show("Course code not found for selected course.");
                conn.Close();

                return;
            }

            string check_query = "SELECT COUNT(*) FROM assign_course WHERE Student_Id = @id AND Course_Code = @code";

            SqlCommand check_cmd = new SqlCommand(check_query, conn);

            check_cmd.Parameters.AddWithValue("@id", selected_student);
            check_cmd.Parameters.AddWithValue("@code", course_code);

            int exists = (int)check_cmd.ExecuteScalar();

            if (exists > 0)
            {
                MessageBox.Show("This course is already assigned to the student.");
                conn.Close();
                return;
            }

            string count_query = "SELECT COUNT(*) FROM assign_course WHERE Student_Id = @id";

            SqlCommand count_cmd = new SqlCommand(count_query, conn);
            count_cmd.Parameters.AddWithValue("@id", selected_student);

            int course_count = (int)count_cmd.ExecuteScalar();

            if (course_count >= 5)
            {
                MessageBox.Show("Cannot assign more than 5 courses to a student.");
                conn.Close();
                return;
            }

            string insert_query = "INSERT INTO assign_course (Student_Id, Course_Code) VALUES (@id, @code)";

            SqlCommand insert_cmd = new SqlCommand(insert_query, conn);

            insert_cmd.Parameters.AddWithValue("@id", selected_student);
            insert_cmd.Parameters.AddWithValue("@code", course_code);

            int rows_affected = insert_cmd.ExecuteNonQuery();

            if (rows_affected > 0)
            {
                MessageBox.Show("Course successfully assigned!");

                fill_datagrid();
                number_of_course_lable_text_change();
            }
            else
            {
                MessageBox.Show("Failed to assign course.");
            }

            conn.Close();
        }

        private void clear_button_Click(object sender, EventArgs e)
        {
            comboBox1.SelectedItem = null;
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 obj = new Form1();
            obj.Show();
        }
    }
}

















//public void FillComboBoxWithCourses()
//{
//    SqlConnection conn = new SqlConnection(connection_string);
//    conn.Open();

//    string student_program = "";
//    string program_query = "SELECT Program FROM student_uni_info WHERE Student_Id = @id";

//    SqlCommand cmd = new SqlCommand(program_query, conn);
//    cmd.Parameters.AddWithValue("@id", selected_student);

//    SqlDataReader reader = cmd.ExecuteReader();

//    if (reader.Read())
//    {
//        student_program = reader["Program"].ToString();
//    }

//    reader.Close();
//    comboBox1.Items.Clear();

//    if (!string.IsNullOrEmpty(student_program))
//    {
//        // Only select courses for the student's program that the student is NOT already assigned to
//        string course_query = @"
//            SELECT Name 
//            FROM course 
//            WHERE Program = @program
//            AND Code NOT IN (
//                SELECT Course_Code 
//                FROM assign_course 
//                WHERE Student_Id = @id
//            )";

//        SqlCommand course_cmd = new SqlCommand(course_query, conn);
//        course_cmd.Parameters.AddWithValue("@program", student_program);
//        course_cmd.Parameters.AddWithValue("@id", selected_student); // reuse selected_student

//        SqlDataReader course_reader = course_cmd.ExecuteReader();

//        while (course_reader.Read())
//        {
//            comboBox1.Items.Add(course_reader["Name"].ToString());
//        }

//        course_reader.Close();

//        if (comboBox1.Items.Count > 0)
//        {
//            comboBox1.SelectedIndex = 0;
//        }
//        else
//        {
//            comboBox1.Items.Add("No available courses found");
//        }
//    }
//    else
//    {
//        comboBox1.Items.Add("Program not found!");
//    }

//    conn.Close();
//}
