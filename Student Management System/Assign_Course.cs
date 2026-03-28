using Microsoft.Data.SqlClient;
using System.Data;

namespace Student_Management_System
{
    public partial class Assign_Course : Form
    {
        string connection_string = "Data Source=DESKTOP-OHJMFVT\\SQLEXPRESS;Initial Catalog=Student_management_system;Integrated Security=True;Trust Server Certificate=True";

        public Assign_Course()
        {
            InitializeComponent();
        }

        private void Assign_Course_Load(object sender, EventArgs e)
        {

        }

        private void next_button_Click(object sender, EventArgs e)
        {
            if (selected_student_textBox.Text != "")
            {
                Assign_Course_02 obj = new Assign_Course_02(selected_student_textBox.Text);

                obj.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please Fill The Field", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void clear_button_Click(object sender, EventArgs e)
        {
            selected_student_textBox.Clear();
            search_textBox.Clear();
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 obj = new Form1();
            obj.Show();
        }

        public void grid_view()
        {
            SqlConnection conn = new SqlConnection(connection_string);
            string query = @"SELECT spi.Id, spi.Name,
                                        sui.Semester, sui.Section, sui.Program 
                                 FROM student_personal_info spi 
                                 INNER JOIN student_uni_info sui ON spi.Id = sui.Student_Id";

            SqlDataAdapter obj_01 = new SqlDataAdapter(query, conn);
            DataTable obj_02 = new DataTable();

            obj_01.Fill(obj_02);
            dataGridView1.DataSource = obj_02;
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                selected_student_textBox.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while selecting student.\n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void search_textBox_TextChanged(object sender, EventArgs e)
        {
            string searchValue = search_textBox.Text.Trim();

            SqlConnection conn = new SqlConnection(connection_string);
            conn.Open();

            string query = @"SELECT spi.Id, spi.Name,
                                        sui.Semester, sui.Section, sui.Program 
                                 FROM student_personal_info spi 
                                 INNER JOIN student_uni_info sui ON spi.Id = sui.Student_Id
                                 WHERE name LIKE @name + '%'";

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@name", searchValue);

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            dataGridView1.DataSource = dt;

            conn.Close();
        }
    }
}
