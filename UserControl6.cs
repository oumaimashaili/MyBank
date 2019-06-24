using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastFoodDemo
{
    public partial class UserControl6 : UserControl
    {
        public UserControl6()
        {
            InitializeComponent();
            userControl71.Hide();
            userControl91.Hide();
            userControl81.Hide();

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            userControl91.Hide();
            userControl81.Hide();

            userControl71.Show();
        }

        private void userControl81_Load(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            userControl91.Hide();
            userControl71.Hide();
            userControl81.Show();
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
          

        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            userControl71.Hide();
            userControl81.Hide();
            userControl91.Show();
        }

        private void userControl71_Load(object sender, EventArgs e)
        {

        }

        private void userControl71_Load_1(object sender, EventArgs e)
        {

        }

        private void userControl91_Load(object sender, EventArgs e)
        {

        }

        private void UserControl6_Load(object sender, EventArgs e)
        {

        }

        private void userControl91_Load_1(object sender, EventArgs e)
        {

        }
    }
}
