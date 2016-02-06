using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace eBayERPSolution
{
    public partial class setting : Form
    {
        public setting()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.guser = gusertbox.Text;
            Properties.Settings.Default.gpassword=ptbox.Text;
            Properties.Settings.Default.tax = int.Parse(taxtbox.Text);
            Properties.Settings.Default.Save();
            this.Close();
        }
    }
}
