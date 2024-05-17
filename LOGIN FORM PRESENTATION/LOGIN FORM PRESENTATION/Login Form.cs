using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LOGIN_FORM_PRESENTATION
{
    public partial class Login_Form : Form
    {
        public Login_Form()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_Form_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string conn = " datasource=localhost;database=login;port=3306;username=root;password =; ";
                string query = "select * from login where username = '" + textBox1.Text + "' && password = '" + textBox2.Text + "'  ";
                MySqlConnection myConn = new MySqlConnection(conn);
                MySqlCommand cmd = new MySqlCommand(query, myConn);
                MySqlDataReader reader;
                myConn.Open();
                reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    CalculatorForm calc = new CalculatorForm();
                    calc.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Username and Password are incorrect");
                }
                myConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
