using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void sumButton_Click(object sender, EventArgs e)
        {
            string val1 = textBox1.Text;
            string val2 = textBox2.Text;

            int num1 = Convert.ToInt32(val1);

            int num2 = Convert.ToInt32(val2);

            int total = num1 * num2;

            displayLabel.Text = total.ToString();
        }
    }
}
