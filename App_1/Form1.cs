using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtName.Text == "Test" && txtPWD.Text=="Test")
            {
                MessageBox.Show("User Available");
            }
            else
            {
                MessageBox.Show("User Not Available");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblPWD_Click(object sender, EventArgs e)
        {

        }
    }
}
