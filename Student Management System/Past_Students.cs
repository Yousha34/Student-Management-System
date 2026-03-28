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
    public partial class Past_Students : Form
    {
        string connection_string = "Data Source=DESKTOP-OHJMFVT\\SQLEXPRESS;Initial Catalog=Student_management_system;Integrated Security=True;Trust Server Certificate=True";

        public Past_Students()
        {
            InitializeComponent();
        }

        public void grid_view()
        {
            SqlConnection conn = new SqlConnection(connection_string);

            string query = @"SELECT * FROM past_students ORDER BY Deleted_At DESC;";

            SqlDataAdapter obj_01 = new SqlDataAdapter(query, conn);
            DataTable obj_02 = new DataTable();

            obj_01.Fill(obj_02);
            dataGridView1.DataSource = obj_02;
        }

        private void back_button_Click_1(object sender, EventArgs e)
        {
            Form1 obj = new Form1();

            obj.Show();
            this.Hide();
        }

        private void Past_Students_Load(object sender, EventArgs e)
        {
            grid_view();
        }
    }
}
