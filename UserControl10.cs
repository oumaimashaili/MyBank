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
    public partial class UserControl10 : UserControl
    {
        public UserControl10()
        {
            InitializeComponent();
            lydec1.Hide();
            iam1.Hide();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            iam1.Show();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            lydec1.Show();
        }

        private void lydec1_Load(object sender, EventArgs e)
        {

        }
    }
}
