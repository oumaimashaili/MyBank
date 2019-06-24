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
using System.Net;

namespace FastFoodDemo
{
    public partial class UserControl9 : UserControl
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\bank.mdf;Integrated Security=True");
        public String rip = "";
        public UserControl9()
        {
            InitializeComponent();
            connection.Close();
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * from [compte] where compte_numero ='" + LoginForm.num_compte + "'";
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
          
            if (reader.Read())
            {
                //  soldeAct = double.Parse(reader["solde"].ToString());
                rip = "3537" + reader["compte_numero"].ToString() + "005";
            }
            connection.Close();
            label1.Text = rip;

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void UserControl9_Load(object sender, EventArgs e)
        {
          

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton1_Click_1(object sender, EventArgs e)
        {
            if (LoginForm.mail != null)
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
                mail.From = new MailAddress("MyOwnerbank2019@gmail.com");
                MessageBox.Show(LoginForm.mail);
                mail.To.Add(LoginForm.mail);
                Random generator = new Random();
                mail.Subject = "Demande de RIP";
                mail.Body = "Votre Rip est : " + rip;
                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential("MyOwnerbank2019@gmail.com", "Mybank1234");
                SmtpServer.EnableSsl = true;
                SmtpServer.Send(mail);
            }
            else
            {
                MessageBox.Show("Vous n'avez pas d'email");
            }


        }
    }
}
