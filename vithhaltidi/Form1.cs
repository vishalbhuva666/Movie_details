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

namespace vithhaltidi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\mulesoft\vithhaltidi\vithhaltidi\vithaltiddi.mdf;Integrated Security=True");
            con.Open();
            string q = "insert into vithhal3(m_name,m_actor,m_acteress,m_derector,m_relesedate) values ('" + textBox1.Text+ "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "')";
            SqlCommand cmd = new SqlCommand(q,con);
            cmd.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("Data Send Properly");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\mulesoft\vithhaltidi\vithhaltidi\vithaltiddi.mdf;Integrated Security=True");
            con.Open();
            string q = "select * from vithhal3 ";
            SqlDataAdapter dapt = new SqlDataAdapter(q, con);
            DataTable dt = new DataTable();
            dapt.Fill(dt);
            dataGridView1.DataSource= dt;

            con.Close();
           
        }
    }
}
