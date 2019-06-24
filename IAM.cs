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
using System.Text.RegularExpressions;

namespace FastFoodDemo
{
    public partial class IAM : UserControl
    {
        public IAM()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\bank.mdf;Integrated Security=True");
        //static double soldeAvant;
        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        //double soldeApres;
        private double Solde()
        {
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * from [compte] where Id_compte = '" + LoginForm.identifiant + "'";
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            double soldeA = 0;
            while (reader.Read())
            {
                soldeA = double.Parse(reader["solde"].ToString());
            }
           // MessageBox.Show("votre solde again est :" + soldeA);
            connection.Close();
            return soldeA;
        }
        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            double soldeapres;
            double soldeA = Solde();
           // Boolean test = false;
            // MessageBox.Show(soldeA.ToString());
            double versement = double.Parse(textBox2.Text);
            if (soldeA >= versement)
            {
                soldeapres = soldeA - versement;
                connection.Open();
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update [compte] set solde = '" + soldeapres + "'where compte_numero  = '" + LoginForm.num_compte + "'";
                cmd.ExecuteNonQuery();
                connection.Close();
                updateAutreCompteMT(versement);
                String n = "123MT";
                virement(versement, DateTime.Now, n, LoginForm.num_compte);
                textBox1.Clear();
                textBox2.Clear();
                Form3 f3 = new Form3();
                f3.label2.Hide();
                f3.label1.Hide();
                f3.label3.Hide();
                f3.label4.Hide();
                f3.label6.Hide();
                f3.label7.Hide();
                f3.label8.Hide();
                f3.label9.Hide();
                f3.label5.Hide();
                f3.label13.Hide();
                f3.label11.Hide();
                f3.label12.Hide();
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
                f3.label5.Hide();
                f3.label8.Hide();
                f3.label13.Hide();
                f3.label9.Hide();
                f3.label10.Hide();
                f3.label12.Hide();
                f3.Show();
               
            }
            this.Hide();
           /* Form1 back = new Form1();
            back.Show();*/
        }
        private void virement(double montant, DateTime date_operation, String numero_comptedest, int id_comptesource)
        {
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            string format = "yyyy-MM-dd HH:mm:ss";
            cmd.CommandText = "insert into [operation] (operation_montant,operation_date,operation_type,numero_comptedest,id_compte) values ('" + montant.ToString() + "','" + date_operation.ToString(format) + "','" + "virementIAM" + "','" + numero_comptedest + "','" + id_comptesource + "')";
            cmd.ExecuteNonQuery();
            connection.Close();

        }
        private void updateAutreCompteMT(double solde)
        {

            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            String n = "123MT";
            cmd.CommandText = "update [compte] set solde += '" + solde + "' where compte_numero  = '" + n + "'";
            cmd.ExecuteNonQuery();
            connection.Close();

        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (IsValidate())// Tester si Numeric
            {
                // Tester s'il correspond au pattern spécifié: nombre entre 0 et 9 et code (CNE) entre 8 et 10 Chiffres
                Regex pattern = new Regex("[0-9]{10}");
                if (pattern.IsMatch(textBox1.Text))
                {
                    //MessageBox.Show("OK");
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
                    f3.label13.Hide();
                    f3.label9.Hide();
                    f3.label10.Hide();
                    f3.label11.Hide();
                    f3.label5.Hide();
                    f3.Show();
                    
                    textBox1.Clear();
                    textBox1.Focus();
                    
                }
            }
        }
        private bool IsValidate()
        {

            int tempCNE;
            bool isNumeric = int.TryParse(textBox1.Text.Trim(), out tempCNE);

            if (!isNumeric)

            {
              
                textBox1.Clear();
                textBox1.Focus();

                return false;
            }
            return true;
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            int tempCNE;
            bool isNumeric = int.TryParse(textBox2.Text.Trim(), out tempCNE);

            if (!isNumeric)

            {
                // Necessite l'ajout de namespace "using MetroFramework;"
                
                textBox2.Clear();
                textBox2.Focus();

            }
        }

        private void IAM_Load(object sender, EventArgs e)
        {

        }
    }
}
