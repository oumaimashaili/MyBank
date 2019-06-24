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

namespace FastFoodDemo
{
    public partial class Form2 : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\bank.mdf;Integrated Security=True");

        public Form2()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm.pan1.Visible = true;
            LoginForm.pan2.Visible = true;
            LoginForm.pan3.Visible = true;
            LoginForm.pan1.BringToFront();
            LoginForm.pan2.SendToBack();
            LoginForm.pan3.SendToBack();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals(UserControl3.r))
            {
                connection.Open();
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "UPDATE compte SET mdp = '" + UserControl3.nvmdp + "' where compte_numero = '" + LoginForm.num_compte + "'";
                cmd.ExecuteNonQuery();

                MessageBox.Show("Mot de passe modifié avec succès");
                this.Close();
            }

            if (textBox1.Text.Equals(LoginForm.r))
            {
                this.Close();
                LoginForm.pan2.Visible = false;
                LoginForm.pan1.Visible = false;
                LoginForm.pan3.BringToFront();
            }
            else
            {
                label2.Visible = true;
                textBox1.Text = "";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
