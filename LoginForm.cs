using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastFoodDemo
{
    public partial class LoginForm : Form
    {
        public static Panel pan1,pan2,pan3;
        public static int identifiant, num_compte;
        static double solde;
        public static String NP, e_mail, email, mail, num, r,adresse;

        String mdp, numero_compte, ID;

       SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\bank.mdf;Integrated Security=True");

        public LoginForm()
        {
            Thread trd = new Thread(new ThreadStart(formRun));
            trd.Start();
            InitializeComponent();
            Thread.Sleep(3000);
            //this.Show();
            trd.Abort();

        }

        private void formRun()
        {
            Application.Run(new Splash());
            
        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "Mot de passe")
            {
                textBox2.Text = "";
                textBox2.ForeColor = Color.White;
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuThinButton2_Click(object sender, EventArgs e)
        {
            RegisterPanel1.SendToBack();
            panel3.SendToBack();
            LoginPanel.Visible = true;
            LoginPanel.BringToFront();
        }

        private void bunifuThinButton1_Click(object sender, EventArgs e)
        {
            LoginPanel.SendToBack();
            LoginPanel.Visible = false;
            panel3.SendToBack();
            RegisterPanel1.BringToFront();
        }

        private void bunifuThinButton3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "N° de compte")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.White;
            }
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {
                textBox3.Text = "E-mail";
                textBox3.ForeColor = Color.LightBlue;
            }
        }

        private void textBox3_Enter(object sender, EventArgs e)
        {
            if (textBox3.Text == "E-mail")
            {
                textBox3.Text = "";
                textBox3.ForeColor = Color.White;
            }
        }

        private void button3_Click_2(object sender, EventArgs e)
        {

        }

        private void LoginPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int tmp;
            bool isNumeric = int.TryParse(textBox7.Text.Trim(), out tmp);
            if (textBox7.Text == "" || textBox6.Text == "")
            {
                Form3 f3 = new Form3();
                f3.Show();
                f3.label13.Hide();
                f3.label11.Hide();
                f3.label12.Hide();
                f3.label10.Hide();
                f3.label1.Visible = false;
                f3.label2.Visible = false;
                f3.label3.Visible = false;
                f3.label4.Visible = false;
                f3.label5.Visible = false;
                f3.label6.Visible = false;
                f3.label7.Visible = false;

            }
            else if (!isNumeric)
            {
                Form3 f3 = new Form3();
                f3.Show();
                f3.label13.Hide();
                f3.label11.Hide();
                f3.label12.Hide();
                f3.label10.Hide();
                f3.label1.Visible = false;
                f3.label2.Visible = false;
                f3.label3.Visible = false;
                f3.label4.Visible = false;
                f3.label5.Visible = false;
                f3.label6.Visible = false;
                f3.label7.Visible = false;
                f3.label8.Text = "Le mot de passe de compte doit être numérique";
            }
            else if (textBox7.Text.Length < 6)
            {
                Form3 f3 = new Form3();
                f3.Show();
                f3.label13.Hide();
                f3.label11.Hide();
                f3.label12.Hide();
                f3.label10.Hide();
                f3.label1.Visible = false;
                f3.label2.Visible = false;
                f3.label3.Visible = false;
                f3.label4.Visible = false;
                f3.label5.Visible = false;
                f3.label6.Visible = false;
                f3.label7.Visible = false;
                f3.label8.Text = "minimum 6 caractères";
            }
            else if (textBox7.Text.Equals(textBox7.Text))
            {
                connection.Open();
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "UPDATE compte SET mdp = '" + textBox7.Text + "' where compte_numero = '" + numero_compte + "'";
                cmd.ExecuteNonQuery();

                Form3 f3 = new Form3();
                f3.Show();
                f3.label13.Hide();
                f3.label11.Hide();
                f3.label12.Hide();
                f3.label10.Hide();
                f3.label1.Visible = false;
                f3.label2.Visible = false;
                f3.label3.Visible = false;
                f3.label4.Visible = false;
                f3.label5.Visible = false;
                f3.label6.Visible = false;
                f3.label7.Visible = false;
                f3.label8.Text = "Mot de passe modifié avec succès";
                connection.Close();
                register();

            }
            else
            {
                Form3 f3 = new Form3();
                f3.Show();
                f3.label13.Hide();
                f3.label11.Hide();
                f3.label12.Hide();
                f3.label10.Hide();
                f3.label1.Visible = false;
                f3.label2.Visible = false;
                f3.label3.Visible = false;
                f3.label4.Visible = false;
                f3.label5.Visible = false;
                f3.label6.Visible = false;
                f3.label7.Visible = false;
                f3.label8.Text = "Les champs ne sont pas identiques";
            }

        }

        private void textBox6_Enter(object sender, EventArgs e)
        {
            if (textBox6.Text == "************")
            {
                textBox6.Text = "";
                textBox6.ForeColor = Color.White;
            }
        }

        private void textBox7_Enter(object sender, EventArgs e)
        {
            if (textBox7.Text == "************")
            {
                textBox7.Text = "";
                textBox7.ForeColor = Color.White;
            }
        }

        private void textBox6_Leave(object sender, EventArgs e)
        {
            if (textBox6.Text == "************")
            {
                textBox6.Text = "";
                textBox6.ForeColor = Color.LightBlue;
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        public void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {

            LoginPanel.BringToFront();
        }

        private void textBox7_Leave(object sender, EventArgs e)
        {
            if (textBox7.Text == "************")
            {
                textBox7.Text = "";
                textBox7.ForeColor = Color.LightBlue;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (textBox4.Text == "" || textBox3.Text == "")
            {
                Form3 f3 = new Form3();
                f3.Show();
                f3.label13.Hide();
                f3.label11.Hide();
                f3.label12.Hide();
                f3.label10.Hide();
                f3.label1.Visible = false;
                f3.label2.Visible = false;
                f3.label3.Visible = false;
                f3.label4.Visible = false;
                f3.label5.Visible = false;
                f3.label6.Visible = false;
                f3.label7.Visible = false;

            }
            else
            {
                connection.Close();
                connection.Open();
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Select * from [compte] where compte_numero ='" + textBox4.Text + "'";
                SqlDataReader reader;
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    numero_compte = reader["compte_numero"].ToString();
                    ID = reader["client_id"].ToString();
                    mdp = reader["mdp"].ToString();
                }

                if (numero_compte == null )
                {
                    reader.Close();
                    connection.Close();
                    Form3 f3 = new Form3();
                    f3.Show();
                    f3.label1.Visible = false;
                    f3.label2.Visible = false;
                    f3.label3.Visible = false;
                    f3.label4.Visible = false;
                    f3.label5.Visible = false;
                    f3.label6.Visible = false;
                    f3.label7.Visible = false;
                    f3.label13.Hide();
                    f3.label11.Hide();
                    f3.label12.Hide();
                    f3.label10.Hide();
                    f3.label8.Text = "Aucun utilisateur correspondent";
                    textBox3.Text = "";
                    textBox4.Text = "";
                }
                else
                {
                    reader.Close();
                    connection.Close();
                    connection.Open();
                    SqlCommand cmd1 = connection.CreateCommand();
                    cmd1.CommandType = CommandType.Text;
                    cmd1.CommandText = "Select * from [client] where Id_client ='" + ID + "'";
                    SqlDataReader reader1;
                    reader1 = cmd1.ExecuteReader();

                    while (reader1.Read())
                    {
                        e_mail = reader1["client_email"].ToString();
                    }

                    if (e_mail != textBox3.Text)
                    {
                        reader1.Close();
                        connection.Close();
                        Form3 f3 = new Form3();
                        f3.Show();
                        f3.label1.Visible = false;
                        f3.label2.Visible = false;
                        f3.label3.Visible = false;
                        f3.label4.Visible = false;
                        f3.label5.Visible = false;
                        f3.label6.Visible = false;
                        f3.label7.Visible = false;
                        f3.label13.Hide();
                        f3.label11.Hide();
                        f3.label12.Hide();
                        f3.label10.Hide();
                        f3.label8.Text = "Auncune adresse mail correspondente";
                        textBox4.Text = "";
                        textBox3.Text = "";
                    }
                    else
                    {
                        reader1.Close();
                        connection.Close();
                        MailMessage mail = new MailMessage();
                        SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
                        mail.From = new MailAddress("MyOwnerbank2019@gmail.com");
                        mail.To.Add(e_mail);
                        Random generator = new Random();
                        r = generator.Next(0, 999999).ToString("D6");
                        mail.Subject = "Confirmez votre identité pour Activer votre compte MyBank App";
                        mail.Body = "Veuillez entrer ce code pour pouvoir activer votre compte MyBank. \n CODE: " + r;
                        SmtpServer.Port = 587;
                        SmtpServer.Credentials = new System.Net.NetworkCredential("MyOwnerbank2019@gmail.com", "Mybank1234");
                        SmtpServer.EnableSsl = true;
                        SmtpServer.Send(mail);
                        Form2 f = new Form2();
                        f.Show();
                        
                    }
                }
            }
        }

        private void textBox4_Enter(object sender, EventArgs e)
        {
            if (textBox4.Text == "N° de compte")
            {
                textBox4.Text = "";
                textBox4.ForeColor = Color.White;
            }
        }

        private void textBox4_Leave(object sender, EventArgs e)
        {
            int tempCNE;
            bool isNumeric = int.TryParse(textBox4.Text.Trim(), out tempCNE);
            if (!isNumeric && textBox4.Text != "")
            {
                Form3 f3 = new Form3();
                f3.Show();
                f3.label1.Visible = false;
                f3.label2.Visible = false;
                f3.label3.Visible = false;
                f3.label4.Visible = false;
                f3.label5.Visible = false;
                f3.label6.Visible = false;
                f3.label7.Visible = false;
                f3.label13.Hide();
                f3.label11.Hide();
                f3.label12.Hide();
                f3.label10.Hide();
                f3.label8.Text = "Le N° de compte doit être numérique"; textBox4.Clear();
                textBox4.Focus();
            }

            if (textBox4.Text == "")
            {
                textBox4.Text = "N° de compte";
                textBox4.ForeColor = Color.LightBlue;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox1.Text == "N° de compte" || textBox2.Text == "Mot de passe")
            {
                Form3 f3 = new Form3();
                f3.Show();
                f3.label1.Visible = false;
                f3.label2.Visible = false;
                f3.label3.Visible = false;
                f3.label4.Visible = false;
                f3.label5.Visible = false;
                f3.label6.Visible = false;
                f3.label7.Visible = false;
                f3.label9.Visible = false;
                f3.label13.Hide();
                f3.label11.Hide();
                f3.label12.Hide();
                f3.label10.Hide();
            }
            else
            {
                int choix;
                choix = login();
                if (choix == 1)
                {
                    connection.Open();
                    SqlCommand cmd = connection.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "Select * from [compte] where compte_numero ='" + textBox1.Text + "'AND mdp ='" + textBox2.Text + "'";
                    SqlDataReader reader;
                    reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        identifiant = Convert.ToInt32(reader["client_id"].ToString());
                        num_compte = Convert.ToInt32(reader["compte_numero"].ToString());
                        solde = double.Parse(reader["solde"].ToString());

                        //solde = Convert.ToInt32(reader["solde"].ToString());
                    }

                    SqlCommand cmd1 = connection.CreateCommand();
                    cmd1.CommandType = CommandType.Text;
                    cmd1.CommandText = "Select * from [client] where Id_client ='" + identifiant + "'";
                    reader.Close();
                    SqlDataReader reader1;
                    reader1 = cmd1.ExecuteReader();

                    while (reader1.Read())
                    {
                        NP = reader1["client_nom"].ToString() + " " + reader1["client_prenom"].ToString();
                        mail = reader1["client_email"].ToString();
                        adresse = reader1["client_adresse"].ToString();
                        num = reader1["client_numero"].ToString();

                    }

                    connection.Close();
                  
                    this.Hide();
                    Form1 Check = new Form1();
                    Check.label1.Text = NP + "\n" + mail + "\n" + num + "\n" + adresse;
                    Check.page1.label2.Text = NP + "\n" + num_compte + "\n" + adresse;
                    Check.page1.label4.Text = solde + " MAD";
                    Check.Show();

                }
            }


        }



        private void textBox1_Leave(object sender, EventArgs e)
        {
            int tempCNE;
            bool isNumeric = int.TryParse(textBox1.Text.Trim(), out tempCNE);
            if (!isNumeric && textBox1.Text != "")
            {
                Form3 f3 = new Form3();
                f3.Show();
                f3.label1.Visible = false;
                f3.label2.Visible = false;
                f3.label3.Visible = false;
                f3.label4.Visible = false;
                f3.label5.Visible = false;
                f3.label6.Visible = false;
                f3.label7.Visible = false;
                f3.label9.Visible = false;
                f3.label13.Hide();
                f3.label11.Hide();
                f3.label12.Hide();
                f3.label10.Hide();
                f3.label8.Text = "Le N° de compte doit être numérique";
                textBox1.Clear();
                textBox1.Focus();
            }

            if (textBox1.Text == "")
            {
                textBox1.Text = "N° de compte";
                textBox1.ForeColor = Color.LightBlue;
            }

        }



        private int login()
        {
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * from [compte] where compte_numero ='" + textBox1.Text + "'AND mdp ='" + textBox2.Text + "'";
            SqlDataReader reader;
            reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                numero_compte = reader["compte_numero"].ToString();
                mdp = reader["mdp"].ToString();

            }

            if (numero_compte == null || mdp == null)
            {
                reader.Close();
                connection.Close();
                Form3 f3 = new Form3();
                f3.Show();
                f3.label1.Visible = false;
                f3.label2.Visible = false;
                f3.label3.Visible = false;
                f3.label4.Visible = false;
                f3.label5.Visible = false;
                f3.label6.Visible = false;
                f3.label7.Visible = false;
                f3.label13.Hide();
                f3.label9.Hide();
                f3.label11.Hide();
                f3.label12.Hide();
                f3.label10.Hide();
                f3.label8.Text = "Veuillez entrer un numéro de compte existant ou activer votre compte";
                textBox1.Text = "";
                textBox2.Text = "";
                return 0;
            }
            else
            {
                connection.Close();
                return 1;

            }

        }

        private void register()
        {
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * from [compte] where compte_numero ='" + numero_compte + "'";
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                identifiant = Convert.ToInt32(reader["client_id"].ToString());
                num_compte = Convert.ToInt32(reader["compte_numero"].ToString());
                solde = Convert.ToInt32(reader["solde"].ToString());
            }

            SqlCommand cmd1 = connection.CreateCommand();
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "Select * from [client] where Id_client ='" + ID + "'";
            reader.Close();
            SqlDataReader reader1;
            reader1 = cmd1.ExecuteReader();

            while (reader1.Read())
            {
                NP = reader1["client_nom"].ToString() + " " + reader1["client_prenom"].ToString();
                email = reader1["client_email"].ToString();
                num = reader1["client_numero"].ToString();

            }

            connection.Close();
            Form1 Check = new Form1();
            Check.label1.Text = NP + "\n" + email + "\n" + num;
            Check.page1.label2.Text = NP + "\n" + num_compte;
            Check.page1.label4.Text = solde + " MAD";
            Check.Show();
        }


        private void LoginForm_Load(object sender, EventArgs e)
        {
            pan1 = LoginPanel;
            pan2 = RegisterPanel1;
            pan3 = panel3;
        }


    }
}
