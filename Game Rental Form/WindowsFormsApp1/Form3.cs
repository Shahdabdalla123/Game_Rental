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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void gAMEBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.gAMEBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gameRentalDataSet);

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gameRentalDataSet.BROWSING' table. You can move, or remove it, as needed.
            this.bROWSINGTableAdapter.Fill(this.gameRentalDataSet.BROWSING);
            // TODO: This line of code loads data into the 'gameRentalDataSet.GAME' table. You can move, or remove it, as needed.
            this.gAMETableAdapter.Fill(this.gameRentalDataSet.GAME);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sqlconnection = new SqlConnection("Data Source=DESKTOP-JC2HFES;Initial Catalog=GameRental;Integrated Security=True");
            SqlCommand sqlcommand = new SqlCommand();
            sqlcommand.Connection = sqlconnection;
            sqlconnection.Open();
            sqlcommand.CommandText =" INSERT INTO GAME VALUES('"+textBox1.Text+"','"+textBox2.Text+"','"+textBox3.Text+"','"+textBox4.Text+"','"+textBox5.Text+"','"+textBox6.Text+"','"+textBox7.Text+"') ";

            sqlcommand.ExecuteNonQuery();
            sqlconnection.Close();
            MessageBox.Show("Game Added");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection sqlconnection = new SqlConnection("Data Source=DESKTOP-JC2HFES;Initial Catalog=GameRental;Integrated Security=True");
            SqlCommand sqlcommand = new SqlCommand();
            sqlcommand.Connection = sqlconnection;
            sqlconnection.Open();
            sqlcommand.CommandText =" UPDATE GAME SET GAMENAME = '"+textBox4.Text+"' WHERE GAMEID = '"+textBox5.Text+"'";
            sqlcommand.ExecuteNonQuery();
            sqlconnection.Close();
            MessageBox.Show("Game Updated");
        }
    }
}
