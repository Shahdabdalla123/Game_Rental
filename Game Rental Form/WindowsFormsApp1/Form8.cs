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
namespace WindowsFormsApp1
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sqlconnection = new SqlConnection("Data Source=DESKTOP-JC2HFES;Initial Catalog=GameRental;Integrated Security=True");
            SqlCommand sqlcommand = new SqlCommand();
            sqlcommand.Connection = sqlconnection;
            sqlconnection.Open();
            sqlcommand.CommandText =" INSERT INTO RETURN VALUES('"+textBox1.Text+"','"+textBox2.Text+"','"+textBox3.Text+"') ";
            sqlcommand.ExecuteNonQuery();
            sqlconnection.Close();
            MessageBox.Show("Success");
            Form4 f4 = new Form4();
            f4.Show();
            this.Hide();
        }
    }
}
