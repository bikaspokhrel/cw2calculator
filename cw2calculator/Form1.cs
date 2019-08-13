using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cw2calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int Num1 = Convert.ToInt16(txtInput1.Text);
            int Num2 = Convert.ToInt16(txtInput2.Text);
            int Multiplication = Num1 * Num2;
            lblOutput.Text = Convert.ToString(Multiplication);
        }
    }
}
