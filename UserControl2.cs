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
    public partial class page1 : UserControl
    {
        public page1()
        {
            InitializeComponent();
            
             userControl41.Hide();
             userControl51.Hide();

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            //this.Hide();
            userControl41.Show();


        }
        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            //   page3.BringToFront();
           // this.Hide();
          userControl51.Show();

        }

        private void page3_Load(object sender, EventArgs e)
        {
         //   page2.BringToFront();
        }

      

        private void userControl51_Load(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton2_Click_1(object sender, EventArgs e)
        {
            userControl51.Show();
        }

        private void userControl41_Load(object sender, EventArgs e)
        {

        }

        private void userControl51_Load_1(object sender, EventArgs e)
        {

        }

        private void userControl51_Load_2(object sender, EventArgs e)
        {

        }
    }
}
