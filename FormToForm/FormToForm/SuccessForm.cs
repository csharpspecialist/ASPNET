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
    public partial class SuccessForm : Form
    {
  
        
        public SuccessForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Whatever!!!");
        }

        private void SuccessForm_Load(object sender, EventArgs e)
        {
           
        }
    }
}
