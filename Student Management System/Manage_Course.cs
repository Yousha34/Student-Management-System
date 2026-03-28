using Microsoft.Data.SqlClient;
using System.Data;

namespace Student_Management_System
{
    public partial class Manage_Course : Form
    {
        string connection_string = "Data Source=DESKTOP-OHJMFVT\\SQLEXPRESS;Initial Catalog=Student_management_system;Integrated Security=True;Trust Server Certificate=True";

        public Manage_Course()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.ReadOnly = true;
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            if (name_textBox.Text != "" && code_textBox.Text != "" && program_textBox.Text != "")
            {
                SqlConnection conn = new SqlConnection(connection_string);

                string query = "delete from course where code = @code";

                conn.Open();

                SqlCommand command = new SqlCommand(query, conn);

                command.Parameters.AddWithValue("@code", code_textBox.Text);

                int temp = command.ExecuteNonQuery();

                if (temp > 0)
                {
                    MessageBox.Show("Delete Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    grid_view();
                    clear_textbox();
                }
                else
                {
                    MessageBox.Show("Deletion Fail", "Failure", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }

                conn.Close();
            }
            else
            {
                MessageBox.Show("Please Fill All Fields", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void grid_view()
        {
            SqlConnection conn = new SqlConnection(connection_string);
            string query = "select * from course";

            SqlDataAdapter obj_01 = new SqlDataAdapter(query, conn);
            DataTable obj_02 = new DataTable();

            obj_01.Fill(obj_02);
            dataGridView1.DataSource = obj_02;
        }

        void clear_textbox()
        {
            code_textBox.Clear();
            name_textBox.Clear();
            program_textBox.Clear();
            search_textBox.Clear();
        }

        private void clear_button_Click(object sender, EventArgs e)
        {
            clear_textbox();
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 obj = new Form1();
            obj.Show();
        }

        private void update_button_Click(object sender, EventArgs e)
        {
            if (name_textBox.Text != "" && code_textBox.Text != "" && program_textBox.Text != "")
            {
                SqlConnection conn = new SqlConnection(connection_string);

                string query = "update course set code = @code, name = @name, program = @program where code = @code";

                conn.Open();

                SqlCommand command = new SqlCommand(query, conn);

                command.Parameters.AddWithValue("@code", code_textBox.Text);
                command.Parameters.AddWithValue("@name", name_textBox.Text);
                command.Parameters.AddWithValue("@program", program_textBox.Text);

                int temp = command.ExecuteNonQuery();

                if (temp > 0)
                {
                    MessageBox.Show("Update Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    grid_view();
                    clear_textbox();
                }
                else
                {
                    MessageBox.Show("Updation Fail", "Failure", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }

                conn.Close();
            }
            else
            {
                MessageBox.Show("Please Fill All Fields", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            code_textBox.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            name_textBox.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            program_textBox.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void Manage_Course_Load(object sender, EventArgs e)
        {

        }

        private void search_textBox_TextChanged(object sender, EventArgs e)
        {
            string searchValue = search_textBox.Text.Trim();

            SqlConnection conn = new SqlConnection(connection_string);
            conn.Open();
                
            string query = "SELECT * FROM course WHERE name LIKE @name + '%'";

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
