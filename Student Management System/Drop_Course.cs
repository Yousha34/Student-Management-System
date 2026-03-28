using Microsoft.Data.SqlClient;
using System.Data;


namespace Student_Management_System
{
    public partial class Drop_Course : Form
    {
        string connection_string = "Data Source=DESKTOP-OHJMFVT\\SQLEXPRESS;Initial Catalog=Student_management_system;Integrated Security=True;Trust Server Certificate=True";

        public Drop_Course()
        {
            InitializeComponent();
        }

        private void Drop_Course_Load(object sender, EventArgs e)
        {

        }

        private void next_button_Click(object sender, EventArgs e)
        {
            if (selected_student_textBox.Text != "")
            {
                Drop_Course_02 obj = new Drop_Course_02(selected_student_textBox.Text);

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

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            selected_student_textBox.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
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
