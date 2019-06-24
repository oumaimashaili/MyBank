using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastFoodDemo
{
    public partial class Splash : Form
    {
        System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();

        public Splash()
        {
            InitializeComponent();
 
        }

        private void Splash_Load(object sender, EventArgs e)
        {
            timerSplash.Start();
        }

        private void timerSplash_Tick(object sender, EventArgs e)
        {
            panelMoving.Left += 2;

            if(panelMoving.Left > 564)
            {
                panelMoving.Left = -130;
            }

        }

     
    }
}
