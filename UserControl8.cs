using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FastFoodDemo
{
    public partial class UserControl8 : UserControl
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\bank.mdf;Integrated Security=True");
        public UserControl8()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
        private int recherer()
        {

            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select count(1) from [compte] where compte_numero='" + LoginForm.num_compte + "'AND mdp='" + textBox3.Text + "'";
            int cnt = (int)cmd.ExecuteScalar();
            if (cnt == 0)
            {
                connection.Close();
                return 0;
            }
            else
            {
                connection.Close();
                return 1;
            }
        }
        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            if (recherer() == 0)
            {
                MessageBox.Show("Mot de passe est incorrect");

            }
            else
            {
                if (radioButton1.Checked == true || radioButton2.Checked == true || radioButton3.Checked == true)
                {

                    Form3 f3 = new Form3();
                    f3.label2.Hide();
                    f3.label5.Hide();
                    f3.label3.Hide();
                    f3.label4.Hide();
                    f3.label6.Hide();
                    f3.label7.Hide();
                    f3.label8.Hide();
                    f3.label9.Hide();
                    f3.label13.Hide();
                    f3.label11.Hide();
                    f3.label12.Hide();
                    f3.label10.Hide();
                    f3.Show();
                    textBox3.Text = "";

                    //  MessageBox.Show("Votre chéquier sera envoyer à l'agence de souscription de votre contrat mobile");
                }
                else
                {
                    Form3 f3 = new Form3();
                    f3.label1.Hide();
                    f3.label5.Hide();
                    f3.label3.Hide();
                    f3.label4.Hide();
                    f3.label6.Hide();
                    f3.label7.Hide();
                    f3.label8.Hide();
                    f3.label13.Hide();
                    f3.label9.Hide();
                    f3.label11.Hide();
                    f3.label12.Hide();
                    f3.label10.Hide();
                    f3.Show();
                    textBox3.Text = "";

                }
            }
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            
        }
    }
}
