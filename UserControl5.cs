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
    public partial class UserControl5 : UserControl
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\bank.mdf;Integrated Security=True");
        public UserControl5()
        {
            InitializeComponent();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
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
        private double Solde()
        {
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * from [compte] where compte_numero ='" + LoginForm.num_compte + "'";
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            double soldeA = 0;
            while (reader.Read())
            {
                soldeA = double.Parse(reader["solde"].ToString());
            }
            connection.Close();
            return soldeA;
        }

        private void updateAutreCompte(double solde)
        {

            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update [compteexterne] set solde += '" + solde + "'where rip = '" + textBox1.Text + "'";
            cmd.ExecuteNonQuery();
            connection.Close();

        }
        private void virement(double montant, DateTime date_operation, String numero_comptedest, int id_comptesource)
        {
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            string format = "yyyy-MM-dd HH:mm:ss";
            cmd.CommandText = "insert into [operation] (operation_montant,operation_date,operation_type,numero_comptedest,id_compte) values ('" + montant.ToString() + "','" + date_operation.ToString(format) + "','" + "virement" + "','" + numero_comptedest + "','" + id_comptesource + "')";
            cmd.ExecuteNonQuery();
            connection.Close();

        }
        private int bankname(String compte)
        {
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * from [compteexterne] where rip ='" + textBox1.Text + "'";
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            int id_banque = 0;
            while (reader.Read())
            {
                id_banque = Int32.Parse(reader["id_banque"].ToString());
            }
            connection.Close();
            return id_banque;
        }
        private int verifierbank(int id_banque, String banquename)
        {

            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select count(1) from [banque] where Id_banque ='" + id_banque + "'  ";
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
        private void traitement(double versement)
        {

            if (recherer() == 0)
            {
                MessageBox.Show("Mot de passe est incorrect");

            }
            else
            {
                double soldeapres;
                double soldeA = Solde();
                if (soldeA > versement)
                {
                    soldeapres = soldeA - versement;
                    connection.Open();
                    SqlCommand cmd = connection.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "update [compte] set solde = '" + soldeapres + "'where compte_numero  = '" + LoginForm.num_compte + "'";
                    cmd.ExecuteNonQuery();
                    connection.Close();
                    updateAutreCompte(versement);
                    MessageBox.Show("operation est bien fait");
                    virement(versement, DateTime.Now, textBox1.Text, LoginForm.num_compte);
                }
                else
                {
                    MessageBox.Show("Votre solde est insuffisant pour cette operation");
                }
            }
        }
    
        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            double versement = double.Parse(textBox2.Text);

            if (comboBox1.Text=="ARAB BANK")
            {
                // MessageBox.Show(bankname(textBox1.Text).ToString()+"/////"+ radioButton1.Text+"///"+ verifierbank(bankname(textBox1.Text), radioButton1.Text).ToString());
                if (verifierbank(bankname(textBox1.Text), comboBox1.Text) == 1)
                {
                    traitement(versement);
                }
                else
                {
                    Form3 f3 = new Form3();
                    f3.label2.Hide();
                    f3.label5.Hide();
                    f3.label3.Hide();
                    f3.label4.Hide();
                    f3.label6.Hide();
                    f3.label1.Hide();
                    f3.label8.Hide();
                    f3.label9.Hide();
                    f3.label13.Hide();
                    f3.label11.Hide();
                    f3.label12.Hide();
                    f3.label10.Hide();
                    f3.Show();
                }
            }
            else if (comboBox1.Text == "ATTIJARIWAFA BANK")
            {
                if (verifierbank(bankname(textBox1.Text), comboBox1.Text) == 1)
                {
                    traitement(versement);
                }
                else
                {
                    Form3 f3 = new Form3();
                    f3.label2.Hide();
                    f3.label5.Hide();
                    f3.label3.Hide();
                    f3.label4.Hide();
                    f3.label6.Hide();
                    f3.label8.Hide();
                    f3.label9.Hide();
                    f3.label1.Hide();
                    f3.label13.Hide();
                    f3.label11.Hide();
                    f3.label12.Hide();
                    f3.label10.Hide();
                    f3.Show();
                }
            }
            else if (comboBox1.Text == "BANK AL MAGHREB")
            {
                if (verifierbank(bankname(textBox1.Text), comboBox1.Text) == 1)
                {
                    traitement(versement);
                }
                else
                {
                    Form3 f3 = new Form3();
                    f3.label2.Hide();
                    f3.label5.Hide();
                    f3.label3.Hide();
                    f3.label4.Hide();
                    f3.label6.Hide();
                    f3.label8.Hide();
                    f3.label1.Hide();
                    f3.label9.Hide();
                    f3.label13.Hide();
                    f3.label11.Hide();
                    f3.label12.Hide();
                    f3.label10.Hide();
                    f3.Show();
                }
            }
            else if (comboBox1.Text == "BCP")
            {
                if (verifierbank(bankname(textBox1.Text), comboBox1.Text) == 1)
                {
                    traitement(versement);
                }
                else
                {
                    Form3 f3 = new Form3();
                    f3.label2.Hide();
                    f3.label5.Hide();
                    f3.label3.Hide();
                    f3.label4.Hide();
                    f3.label8.Hide();
                    f3.label6.Hide();
                    f3.label1.Hide();
                    f3.label9.Hide();
                    f3.label13.Hide();
                    f3.label11.Hide();
                    f3.label12.Hide();
                    f3.label10.Hide();
                    f3.Show();
                }
            }
            else if (comboBox1.Text == "BMCI")
            {
                if (verifierbank(bankname(textBox1.Text), comboBox1.Text) == 1)
                {
                    traitement(versement);
                }
                else
                {
                    Form3 f3 = new Form3();
                    f3.label2.Hide();
                    f3.label5.Hide();
                    f3.label3.Hide();
                    f3.label4.Hide();
                    f3.label8.Hide();
                    f3.label6.Hide();
                    f3.label9.Hide();
                    f3.label1.Hide();
                    f3.label13.Hide();
                    f3.label11.Hide();
                    f3.label12.Hide();
                    f3.label10.Hide();
                    f3.Show();
                }
            }
        }
    }
}
