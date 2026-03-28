using System.Data;
using Microsoft.Data.SqlClient;

namespace Student_Management_System
{
    public partial class Registration : Form
    {
        string connection_string = "Data Source=DESKTOP-OHJMFVT\\SQLEXPRESS;Initial Catalog=Student_management_system;Integrated Security=True;Trust Server Certificate=True";

        public Registration()
        {
            InitializeComponent();
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            if (name_textBox.Text != "" && father_name_textBox.Text != "" && phone_textBox.Text != "" && date_of_birth_dateTimePicker != null && (male_radioButton.Checked == true || female_radioButton.Checked == true) && address_textBox.Text != "")
            {
                string gender = "";

                if (male_radioButton.Checked)
                {
                    gender = "Male";
                }
                else if (female_radioButton.Checked)
                {
                    gender = "Female";
                }

                Registration_02 obj = new Registration_02(id_textBox.Text, name_textBox.Text, father_name_textBox.Text, phone_textBox.Text, date_of_birth_dateTimePicker.Value.ToString(), gender, address_textBox.Text);

                obj.Show();
                this.Hide();

                obj.grid_view();
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

        void clear_textbox()
        {
            name_textBox.Clear();
            father_name_textBox.Clear();
            phone_textBox.Clear();
            date_of_birth_dateTimePicker.Value = DateTime.Now;
            male_radioButton.Checked = false;
            female_radioButton.Checked = false;
            address_textBox.Clear();
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.ReadOnly = true;
        }

        private void phone_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            check_number(e);
        }

        private void id_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            check_number(e);
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

        private void Registration_Load(object sender, EventArgs e)
        {
            grid_view();
        }
    }
}
