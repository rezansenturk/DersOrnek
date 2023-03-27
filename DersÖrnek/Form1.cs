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

namespace DersÖrnek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection("Server=DESKTOP-R6345IK\\SQLEXPRESS;Database=MYUÖ;Trusted_Connection=True;Encrypt=False;");
        private void button1_Click(object sender, EventArgs e)
        {
            baglan.Open();
            string query = "select * from Personeller where Email='" + textBox1.Text + "' and Sifre='" + textBox2.Text + "'";
            SqlCommand cmd = new SqlCommand(query, baglan);
            SqlDataReader reading = cmd.ExecuteReader();
            

            if (reading.Read())
            {
                this.Hide();
                Form1 obj1 = new Form1();
                obj1.Show();
            }
            else
            {
                MessageBox.Show("Hatalı giriş");
                textBox1.Text = null;
                textBox2.Text = null;
            }
            baglan.Close();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
    
        }
    }
    
}
