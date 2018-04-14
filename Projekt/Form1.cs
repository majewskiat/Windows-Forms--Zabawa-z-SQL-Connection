using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Projekt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=LAPTOP-4GS3Q03F\SQLEXPRESS;Initial Catalog=Wypozyczalnia;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            string select = "select marka from Marka";
            SqlCommand com = new SqlCommand(select, con);
            SqlDataReader reader;
            con.Open();

            reader = com.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("Marka");
            dt.Load(reader);
            comboBox1.ValueMember = "Marka";
            comboBox1.DataSource = dt;
            con.Close();
        }
         
    }
}
