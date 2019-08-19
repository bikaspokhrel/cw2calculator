using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace randomnumber
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnRandom_Click(object sender, EventArgs e)
        {
            randomnumber();
        }
        
        private void randomnumber()
        {
            Random rdm = new Random(); // the random function is used here
            MessageBox.Show(rdm.Next(1, 10).ToString()); //the random values between 1 to 100 is generated randomly here

        }


        private void PictureBox1_Click(object sender, EventArgs e)
        {
        }
    }
}
