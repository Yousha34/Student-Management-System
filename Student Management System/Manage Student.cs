using Microsoft.Data.SqlClient;
using System.Data;

namespace Student_Management_System
{
    public partial class Manage_Student : Form
    {
        string connection_string = "Data Source=DESKTOP-OHJMFVT\\SQLEXPRESS;Initial Catalog=Student_management_system;Integrated Security=True;Trust Server Certificate=True";

        public Manage_Student()
        {
            InitializeComponent();
        }

        public void grid_view()
        {
            SqlConnection conn = new SqlConnection(connection_string);
            string query = @"SELECT * from student_personal_info";

            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();

            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        void clear_textbox()
        {
            search_textBox.Clear();
            id_textBox.Clear();
            name_textBox.Clear();
            father_name_textBox.Clear();
            phone_textBox.Clear();
            date_of_birth_dateTimePicker.Value = DateTime.Now;
            male_radioButton.Checked = false;
            female_radioButton.Checked = false;
            address_textBox.Clear();
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            id_textBox.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            name_textBox.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            father_name_textBox.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            phone_textBox.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();

            string gender = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();

            if (gender == "Male")
            {
                male_radioButton.Checked = true;
            }
            else if (gender == "Female")
            {
                female_radioButton.Checked = true;
            }

            date_of_birth_dateTimePicker.Value = Convert.ToDateTime(dataGridView1.SelectedRows[0].Cells["date_of_birth"].Value);
            address_textBox.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 obj = new Form1();
            obj.Show();
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            if (name_textBox.Text != "" && father_name_textBox.Text != "" && phone_textBox.Text != "" && date_of_birth_dateTimePicker != null && (male_radioButton.Checked == true || female_radioButton.Checked == true) && address_textBox.Text != "")
            {
                SqlConnection conn = new SqlConnection(connection_string);
                conn.Open();

                SqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    SqlCommand cmd = new SqlCommand("DELETE FROM student_personal_info WHERE Id = @id", conn, transaction);
                    cmd.Parameters.AddWithValue("@id", id_textBox.Text);
                    int temp = cmd.ExecuteNonQuery();

                    transaction.Commit();
                    conn.Close();

                    if (temp > 0)
                    {
                        MessageBox.Show("Delete Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        grid_view();
                        clear_textbox();
                    }
                    else
                    {
                        MessageBox.Show("Deletion Failed", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    conn.Close();
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please Fill All Fields", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void update_button_Click(object sender, EventArgs e)
        {
            if (name_textBox.Text != "" && father_name_textBox.Text != "" && phone_textBox.Text != "" && date_of_birth_dateTimePicker != null && (male_radioButton.Checked == true || female_radioButton.Checked == true) && address_textBox.Text != "")
            {
                SqlConnection conn = new SqlConnection(connection_string);

                string query = "update student_personal_info set name = @name, father_name = @father_name, phone_no = @phone_no, gender = @gender, date_of_birth = @date_of_birth, address = @address where id = @id";

                conn.Open();

                SqlCommand command = new SqlCommand(query, conn);

                command.Parameters.AddWithValue("@id", id_textBox.Text);
                command.Parameters.AddWithValue("@name", name_textBox.Text);
                command.Parameters.AddWithValue("@father_name", father_name_textBox.Text);
                command.Parameters.AddWithValue("@phone_no", phone_textBox.Text);

                string gender = "";

                if (male_radioButton.Checked)
                {
                    gender = "Male";
                }
                else if (female_radioButton.Checked)
                {
                    gender = "Female";
                }

                command.Parameters.AddWithValue("@gender", gender);
                command.Parameters.AddWithValue("@date_of_birth", date_of_birth_dateTimePicker.Value.Date);
                command.Parameters.AddWithValue("@address", address_textBox.Text);

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

        private void clear_button_Click(object sender, EventArgs e)
        {
            clear_textbox();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.ReadOnly = true;
        }

        public void check_number(KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (char.IsNumber(ch))
            {
                e.Handled = false;
            }
            else if (ch == 8)
            {
                e.Handled = false;
            }
            else if (ch == 32)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        public void check_letter(KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (char.IsLetter(ch))
            {
                e.Handled = false;
            }
            else if (ch == 8)
            {
                e.Handled = false;
            }
            else if (ch == 32)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void name_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            check_letter(e);
        }

        private void father_name_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            check_letter(e);
        }

        private void phone_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            check_number(e);
        }

        private void Manage_Student_Load(object sender, EventArgs e)
        {
            grid_view();
        }

        private void search_textBox_TextChanged(object sender, EventArgs e)
        {
            string searchValue = search_textBox.Text.Trim();

            SqlConnection conn = new SqlConnection(connection_string);
            conn.Open();

            string query = "SELECT * FROM student_personal_info WHERE name LIKE @name + '%'";

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
