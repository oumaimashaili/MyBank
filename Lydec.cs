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
    public partial class Lydec : UserControl
    {
        public Lydec()
        {
            InitializeComponent();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\bank.mdf;Integrated Security=True");

        double montant, solde;

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            connection.Close();
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select Montant from [Facture] where NumeroC = '" + textBox1.Text + "'";
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    montant = double.Parse(dr["Montant"].ToString());
                }
                connection.Close();
                if (montant == 0)
                {
                    Form3 f3 = new Form3();
                    f3.label2.Hide();
                    f3.label1.Hide();
                    f3.label3.Hide();
                    f3.label4.Hide();
                    f3.label5.Hide();
                    f3.label6.Hide();
                    f3.label7.Hide();
                    f3.label8.Hide();
                    f3.label9.Hide();
                    f3.label11.Hide();
                    f3.label12.Hide();
                    f3.label10.Hide();
                    f3.Show();

                }

               
           else {

                    connection.Open();
                    SqlCommand cmd1 = connection.CreateCommand();
                    cmd1.CommandType = CommandType.Text;
                    cmd1.CommandText = "select solde from [compte] where compte_numero = '" + LoginForm.num_compte + "'";
                    SqlDataReader dr1 = cmd1.ExecuteReader();
                    while (dr1.Read())
                    {
                        solde = double.Parse(dr1["solde"].ToString());
                    }

                    connection.Close();

                    if (solde >= montant)
                    {

                        solde = solde - montant;
                        connection.Open();
                        SqlCommand cmd2 = connection.CreateCommand();
                        cmd2.CommandType = CommandType.Text;
                        cmd2.CommandText = "update [compte] set solde = '" + solde + "'where compte_numero = '" + LoginForm.num_compte + "'";
                        cmd2.ExecuteNonQuery();
                        connection.Close();
                        updateAutreCompteLydec(montant);
                        updateFacture();

                        String n = "123LY";
                        virementLydec(montant, DateTime.Now, n, LoginForm.num_compte);
                        textBox1.Clear();
                        textBox2.Clear();
                        Form3 f3 = new Form3();
                        f3.label2.Hide();
                        f3.label1.Hide();
                        f3.label3.Hide();
                        f3.label4.Hide();
                        f3.label5.Hide();
                        f3.label6.Hide();
                        f3.label7.Hide();
                        f3.label8.Hide();
                        f3.label9.Hide();
                        f3.label11.Hide();
                        f3.label12.Hide();
                        f3.label13.Hide();
                        f3.Show();
                    }
                    else
                    {
                        Form3 f3 = new Form3();
                        f3.label2.Hide();
                        f3.label1.Hide();
                        f3.label3.Hide();
                        f3.label4.Hide();
                        f3.label6.Hide();
                        f3.label7.Hide();
                        f3.label8.Hide();
                        f3.label9.Hide();
                        f3.label10.Hide();
                        f3.label12.Hide();
                        f3.label5.Hide();
                        f3.label13.Hide();
                        f3.label11.Show();

                    }

                }
            }
            else
            {
                MessageBox.Show("le numéro de contrat n'existe pas !");
            }
           
            this.Hide();
           /* Form1 back = new Form1();
            back.Show();*/

        }
        private void updateFacture()
        {
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update [Facture] set Montant = '" + 0 + "'where NumeroC  = '" + textBox1.Text + "'";
            cmd.ExecuteNonQuery();
            connection.Close();

        }

       

        private void updateAutreCompteLydec(double solde)
        {

            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            String n = "123LY";
            cmd.CommandText = "update [compte] set solde += '" + solde + "' where compte_numero  = '" + n + "'";
            cmd.ExecuteNonQuery();
            connection.Close();

        }

        private void Lydec_Load(object sender, EventArgs e)
        {

        }

        private void virementLydec(double montant, DateTime date_operation, String numero_comptedest, int id_comptesource)
        {
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            string format = "yyyy-MM-dd HH:mm:ss";
            cmd.CommandText = "insert into [operation] (operation_montant,operation_date,operation_type,id_compte,numero_comptedest) values ('" + montant.ToString() + "','" + date_operation.ToString(format) + "','" + "virementLydec" + "','" + id_comptesource + "','" + numero_comptedest + "')";
            cmd.ExecuteNonQuery();
            connection.Close();

        }

    }
}
