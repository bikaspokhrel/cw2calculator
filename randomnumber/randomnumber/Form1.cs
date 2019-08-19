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
            int min = 1;
            int max = 10;
            int result = randomnumber(min, max);
            MessageBox.Show(Convert.ToString(result));
        }
        
        private int randomnumber(int min, int max)
        {
            Random rdm = new Random(); // the random function is used here
            return rdm.Next(1, 10); //the random values between 1 to 100 is generated randomly here

        }


        private void PictureBox1_Click(object sender, EventArgs e)
        {
        }
    }
}
