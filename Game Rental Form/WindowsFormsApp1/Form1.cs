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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

   

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection sqlconnection = new SqlConnection("Data Source=DESKTOP-JC2HFES;Initial Catalog=GameRental;Integrated Security=True");
            SqlCommand sqlcommand = new SqlCommand();
            sqlcommand.Connection = sqlconnection;
            sqlconnection.Open();
            sqlcommand.CommandText =" INSERT INTO [USER] VALUES('"+textBox1.Text+"','"+textBox2.Text+"','"+textBox3.Text+"','"+textBox4.Text+"','"+textBox5.Text+"','"+textBox6.Text+"') ";
            sqlcommand.ExecuteNonQuery();
            sqlconnection.Close();
            MessageBox.Show("Data Inserted AS USER and your ID is "+textBox6.Text);
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sqlconnection = new SqlConnection("Data Source=DESKTOP-JC2HFES;Initial Catalog=GameRental;Integrated Security=True");
            SqlCommand sqlcommand = new SqlCommand();
            sqlcommand.Connection = sqlconnection;
            sqlconnection.Open();
            sqlcommand.CommandText =" UPDATE [USER] SET ID = '"+textBox6.Text+"' WHERE EMAIL = '"+textBox1.Text+"' and PASSWORD = '"+textBox2.Text+"' ";
            sqlcommand.ExecuteNonQuery();
            sqlconnection.Close();
            MessageBox.Show("Data Updated");
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }
    }
}
