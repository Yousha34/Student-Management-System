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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Student_Management_System
{
    public partial class Course_Status : Form
    {
        string connection_string = "Data Source=DESKTOP-OHJMFVT\\SQLEXPRESS;Initial Catalog=Student_management_system;Integrated Security=True;Trust Server Certificate=True";

        public Course_Status()
        {
            InitializeComponent();
        }

        private void Course_Status_Load(object sender, EventArgs e)
        {
            grid_view();
        }

        public void grid_view()
        {
            SqlConnection conn = new SqlConnection(connection_string);

            string query = @"SELECT 
                        c.Code AS [Course Code],
                        c.Name AS [Course Name],
                        c.Program,
                        COUNT(ac.Student_Id) AS [No. of Students Enrolled]
                    FROM 
                        course c
                    LEFT JOIN 
                        assign_course ac ON c.Code = ac.Course_Code
                    GROUP BY 
                        c.Code, c.Name, c.Program;";

            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();

            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
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
        }

        private void search_textBox_TextChanged(object sender, EventArgs e)
        {
            string searchText = search_textBox.Text.Trim();

            SqlConnection conn = new SqlConnection(connection_string);

            string query = @"SELECT 
                        c.Code AS [Course Code],
                        c.Name AS [Course Name],
                        c.Program,
                        COUNT(ac.Student_Id) AS [No. of Students Enrolled]
                    FROM 
                        course c
                    LEFT JOIN 
                        assign_course ac ON c.Code = ac.Course_Code
                    WHERE 
                        c.Name LIKE @search + '%'
                    GROUP BY 
                        c.Code, c.Name, c.Program;";

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@search", searchText);

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        public void filter_grid()
        {
            string searchText = search_textBox.Text.Trim();
            string selectedProgram = comboBox1.SelectedItem?.ToString();

            using (SqlConnection conn = new SqlConnection(connection_string))
            {
                StringBuilder query = new StringBuilder(@"SELECT 
                                                                c.Code AS [Course Code],
                                                                c.Name AS [Course Name],
                                                                c.Program,
                                                                COUNT(ac.Student_Id) AS [No. of Students Enrolled]
                                                            FROM 
                                                                course c
                                                            LEFT JOIN 
                                                                assign_course ac ON c.Code = ac.Course_Code
                                                            WHERE 
                                                                (@search IS NULL OR c.Name LIKE @search + '%')
                                                                AND (@program IS NULL OR c.Program = @program)
                                                            GROUP BY 
                                                                c.Code, c.Name, c.Program;
                                                            ");

                SqlCommand cmd = new SqlCommand(query.ToString(), conn);

                cmd.Parameters.AddWithValue("@search", string.IsNullOrEmpty(searchText) ? (object)DBNull.Value : searchText);
                cmd.Parameters.AddWithValue("@program", string.IsNullOrEmpty(selectedProgram) ? (object)DBNull.Value : selectedProgram);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            filter_grid();
        }

        private void search_textBox_Click(object sender, EventArgs e)
        {
            clear();
        }
    }
}
