using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Management_System
{
    public partial class Student_Status : Form
    {
        string connection_string = "Data Source=DESKTOP-OHJMFVT\\SQLEXPRESS;Initial Catalog=Student_management_system;Integrated Security=True;Trust Server Certificate=True";

        public Student_Status()
        {
            InitializeComponent();
        }

        private void Student_Status_Load(object sender, EventArgs e)
        {
            grid_view();

            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox3.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox4.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        public void grid_view()
        {
            SqlConnection conn = new SqlConnection(connection_string);

            string query = @"
                SELECT 
                    spi.Id, 
                    spi.Name, 
                    spi.Father_Name,
                    sui.Semester, 
                    sui.Section, 
                    sui.Program,
                    COUNT(ac.Course_Code) AS [No. of Courses Enrolled],
                    spi.Phone_No, 
                    spi.Gender, 
                    spi.Date_of_Birth, 
                    spi.Address 
                FROM 
                    student_personal_info spi
                INNER JOIN 
                    student_uni_info sui ON spi.Id = sui.Student_Id
                LEFT JOIN 
                    assign_course ac ON spi.Id = ac.Student_Id
                GROUP BY 
                    spi.Id, spi.Name, spi.Father_Name, 
                    sui.Semester, sui.Section, sui.Program,
                    spi.Phone_No, spi.Gender, spi.Date_of_Birth, spi.Address";

            SqlDataAdapter obj_01 = new SqlDataAdapter(query, conn);
            DataTable obj_02 = new DataTable();

            obj_01.Fill(obj_02);
            dataGridView1.DataSource = obj_02;
        }

        public void filter_grid()
        {
            string program = comboBox1.Text;
            string semester = comboBox4.Text;
            string section = comboBox3.Text;
            string gender = comboBox2.Text;

            using (SqlConnection conn = new SqlConnection(connection_string))
            {
                SqlCommand cmd = new SqlCommand("sp_FilterStudents", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                // NULL pass karein agar value select nahi ki gayi
                cmd.Parameters.AddWithValue("@Program", string.IsNullOrEmpty(program) ? (object)DBNull.Value : program);
                cmd.Parameters.AddWithValue("@Semester", string.IsNullOrEmpty(semester) ? (object)DBNull.Value : semester);
                cmd.Parameters.AddWithValue("@Section", string.IsNullOrEmpty(section) ? (object)DBNull.Value : section);
                cmd.Parameters.AddWithValue("@Gender", string.IsNullOrEmpty(gender) ? (object)DBNull.Value : gender);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            Form1 obj = new Form1();

            obj.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            clear();
        }

        void clear()
        {
            search_textBox.Clear();
            comboBox1.SelectedItem = null;
            comboBox2.SelectedItem = null;
            comboBox3.SelectedItem = null;
            comboBox4.SelectedItem = null;
        }

        private void search_textBox_TextChanged(object sender, EventArgs e)
        {
            string studentName = search_textBox.Text.Trim();
            SqlConnection conn = new SqlConnection(connection_string);

            string query = @"
                SELECT 
                    spi.Id, 
                    spi.Name, 
                    spi.Father_Name,
                    sui.Semester, 
                    sui.Section, 
                    sui.Program,
                    COUNT(ac.Course_Code) AS [No. of Courses Enrolled],
                    spi.Phone_No, 
                    spi.Gender, 
                    spi.Date_of_Birth, 
                    spi.Address 
                FROM 
                    student_personal_info spi
                INNER JOIN 
                    student_uni_info sui ON spi.Id = sui.Student_Id
                LEFT JOIN 
                    assign_course ac ON spi.Id = ac.Student_Id
                GROUP BY 
                    spi.Id, spi.Name, spi.Father_Name, 
                    sui.Semester, sui.Section, sui.Program,
                    spi.Phone_No, spi.Gender, spi.Date_of_Birth, spi.Address
                HAVING 
                    spi.Name LIKE @Name + '%'";

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@Name", studentName);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView1.DataSource = dt;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            filter_grid();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            filter_grid();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            filter_grid();
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            filter_grid();
        }

        private void search_textBox_Click(object sender, EventArgs e)
        {
            clear();
        }
    }
}
