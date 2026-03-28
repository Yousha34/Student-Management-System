using System.Data;
using Microsoft.Data.SqlClient;

namespace Student_Management_System
{
    public partial class New_Course : Form
    {
        string connection_string = "Data Source=DESKTOP-OHJMFVT\\SQLEXPRESS;Initial Catalog=Student_management_system;Integrated Security=True;Trust Server Certificate=True";
        
        public New_Course()
        {
            InitializeComponent();
        }

        private void New_Course_Load(object sender, EventArgs e)
        {
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.ReadOnly = true;
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            if (code_textBox.Text != "" && name_textBox.Text != "" && comboBox1.SelectedItem != null)
            {
                SqlConnection conn = new SqlConnection(connection_string);

                string query = "INSERT INTO course(code, name, Program) " +
                               "VALUES (@code, @name, @program)";

                conn.Open();
                
                SqlCommand command = new SqlCommand(query, conn);

                command.Parameters.AddWithValue("@code", code_textBox.Text);
                command.Parameters.AddWithValue("@name", name_textBox.Text);
                command.Parameters.AddWithValue("@program", comboBox1.SelectedItem.ToString());

                int temp = command.ExecuteNonQuery();

                if (temp > 0)
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
            comboBox1.SelectedItem = null;
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

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
