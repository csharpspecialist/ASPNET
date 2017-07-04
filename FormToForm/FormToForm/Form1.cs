using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace FormToForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)


        {


            string words = textBox1.Text;

            string nice = textBox2.Text;


            SuccessForm su = new SuccessForm();

            su.Show(); //calls the second form!!!!


            label1.Text = words;

            label2.Text = nice;

        }
    }
}
