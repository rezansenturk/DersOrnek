using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DersÖrnek
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox5.Text != "" && textBox6.Text != "" && comboBox1 != "" && textBox7.Text != "")
            {
                SqlConnection baglan = new SqlConnection("Server=DESKTOP-R6345IK\\SQLEXPRESS;Database=MYUÖ;Trusted_Connection=True;Encrypt=False;");
                baglan.Open();
                SqlCommand cmd = new SqlCommand("insert into Personeller  values('" + textBox1.Text + "', '" + textBox2.Text + "', '" + textBox3.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox8.Text + "')", baglan);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Kayıt Başarılı.");
                this.Hide();
                baglan.Close();
            }
            else
            {
                MessageBox.Show("Zorunlu alanları doldurunuz.");
            }
        }
    }
}
