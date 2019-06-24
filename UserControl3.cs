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
using System.Net.Mail;

namespace FastFoodDemo
{
   
    public partial class UserControl3 : UserControl
    {
        public static String r;
        public static string nvmdp;
        public static String mdp;
        public static double soldeAct;
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\bank.mdf;Integrated Security=True");
        public UserControl3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void UserControl3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int tmp;
            bool isNumeric = int.TryParse(textBox2.Text.Trim(), out tmp);
            if (!isNumeric)
            {
                MessageBox.Show("mot de passe doit être numérique");
            }
            else if (textBox2.Text.Length < 6)
            {
                MessageBox.Show("minimum 6 caractères");
            }
            else if (textBox2.Text.Equals(textBox3.Text))
            {
                nvmdp = textBox2.Text;
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
                mail.From = new MailAddress("MyOwnerbank2019@gmail.com");
                MessageBox.Show(LoginForm.mail);
                mail.To.Add(LoginForm.mail);
                Random generator = new Random();
                r = generator.Next(0, 999999).ToString("D6");
                mail.Subject = "Confirmez votre identité pour modifier votre mot de passe  MaBanque";
                mail.Body = "Veuillez entrer ce code pour pouvoir changer votre mot de passe \n CODE: " + r;
                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential("MyOwnerbank2019@gmail.com", "Mybank1234");
                SmtpServer.EnableSsl = true;
                SmtpServer.Send(mail);
                Form2 f = new Form2();
                f.Show();


            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select mdp from [compte] where client_id ='" + LoginForm.identifiant + "'";
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                mdp = reader["mdp"].ToString();
            }
            connection.Close();

            if (!textBox1.Text.Equals(mdp))
            {
                MessageBox.Show("mot de passe inconnu");
            }
        }
    }
}
