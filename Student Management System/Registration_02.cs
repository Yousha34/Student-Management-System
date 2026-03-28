using Microsoft.Data.SqlClient;
using System.Data;

namespace Student_Management_System
{
    public partial class Registration_02 : Form
    {
        private string id, name, father_name, phone, date_of_birth, gender, address;
        string connection_string = "Data Source=DESKTOP-OHJMFVT\\SQLEXPRESS;Initial Catalog=Student_management_system;Integrated Security=True;Trust Server Certificate=True";

        public Registration_02(string temp_id, string temp_name, string temp_father_name, string temp_phone, string temp_date_of_birth, string temp_gender, string temp_address)
        {
            InitializeComponent();

            this.id = temp_id;
            this.name = temp_name;
            this.father_name = temp_father_name;
            this.phone = temp_phone;
            this.date_of_birth = temp_date_of_birth;
            this.gender = temp_gender;
            this.address = temp_address;
        }

        private void next_button_Click(object sender, EventArgs e)
        {
            if (semester_textBox.Text != "" && comboBox2.SelectedItem != null && comboBox1.SelectedItem != null)
            {
                SqlConnection conn = new SqlConnection(connection_string);

                string query_01 = "INSERT INTO student_personal_info(id, name, father_name, phone_no, gender, date_of_birth, address) " +
                               "VALUES (@id, @name, @father_name, @phone_no, @gender, @date_of_birth, @Address)";

                string query_02 = "INSERT INTO student_uni_info(Student_Id, Semester, Section, Program) " +
                               "VALUES (@id, @Semester, @Section, @Program)";

                conn.Open();

                SqlCommand command_01 = new SqlCommand(query_01, conn);
                SqlCommand command_02 = new SqlCommand(query_02, conn);

                command_01.Parameters.AddWithValue("@id", id);
                command_01.Parameters.AddWithValue("@name", name);
                command_01.Parameters.AddWithValue("@father_name", father_name);
                command_01.Parameters.AddWithValue("@phone_no", phone);
                command_01.Parameters.AddWithValue("@gender", gender);
                command_01.Parameters.AddWithValue("@date_of_birth", date_of_birth);
                command_01.Parameters.AddWithValue("@address", address);

                command_02.Parameters.AddWithValue("@id", id);
                command_02.Parameters.AddWithValue("@Semester", semester_textBox.Text);
                command_02.Parameters.AddWithValue("@Section", comboBox2.SelectedItem);
                command_02.Parameters.AddWithValue("@Program", comboBox1.SelectedItem);


                int temp_01 = command_01.ExecuteNonQuery();
                int temp_02 = command_02.ExecuteNonQuery();

                if (temp_01 > 0 && temp_02 > 0)
                {
                    MessageBox.Show("Register Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    grid_view();
                    clear_textbox();
                }
                else
                {
                    MessageBox.Show("Register Fail", "Failure", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }

                conn.Close();
            }
            else
            {
                MessageBox.Show("Please Fill All Fields", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Registration_02_Load(object sender, EventArgs e)
        {
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        void clear_textbox()
        {
            semester_textBox.Clear();
            comboBox2.SelectedItem = null;
            comboBox1.SelectedItem = null;
        }

        public void grid_view()
        {
            SqlConnection conn = new SqlConnection(connection_string);

            string query = @"SELECT spi.Id, spi.Name, spi.Father_Name,
                                        sui.Semester, sui.Section, sui.Program,
                                        spi.Phone_No, spi.Gender, spi.Date_of_Birth, spi.Address
                                 FROM student_personal_info spi 
                                 INNER JOIN student_uni_info sui ON spi.Id = sui.Student_Id";

            SqlDataAdapter obj_01 = new SqlDataAdapter(query, conn);
            DataTable obj_02 = new DataTable();

            obj_01.Fill(obj_02);
            dataGridView1.DataSource = obj_02;
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 obj = new Form1();
            obj.Show();
        }

        private void clear_button_Click(object sender, EventArgs e)
        {
            clear_textbox();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
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
            else if (ch > 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void semester_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            check_number(e);
        }

        private void section_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            check_letter(e);
        }
    }
}
