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
    public partial class ApplicationHome : Form
    {
        public ApplicationHome()
        {
            InitializeComponent();
        }

        private void oPENToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aboutUsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void ApplicationHome_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            feesandprofit fp = new feesandprofit();
            fp.Show();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            sales a = new sales();
            a.Show();
            this.WindowState = FormWindowState.Minimized;




            

                











        }

        private void button5_Click(object sender, EventArgs e)
        {
            inventory inv = new inventory();
            inv.Show();
            this.WindowState = FormWindowState.Minimized;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            salesentry abj = new salesentry();
            abj.Show();
            this.WindowState = FormWindowState.Minimized;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            
            sales open = new sales();
            open.Show();
            this.WindowState = FormWindowState.Minimized;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            sales open = new sales();
            open.Show();
            this.WindowState = FormWindowState.Minimized;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            inventoryadd open = new inventoryadd();
            open.Show();
            this.WindowState = FormWindowState.Minimized;
            
        }

        private void button10_Click(object sender, EventArgs e)
        {
            inventory open = new inventory();
            open.Show();
            this.WindowState = FormWindowState.Minimized;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            inventoryadd open = new inventoryadd();
            open.Show();
            this.WindowState = FormWindowState.Minimized;

        }

        private void button12_Click(object sender, EventArgs e)
        {
            Mail open = new Mail();
            open.Show();
            this.WindowState = FormWindowState.Minimized;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            setting open = new setting();
            open.Show();
            
            this.WindowState = FormWindowState.Minimized;
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            setting open = new setting();
            open.Show();

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("DEVELOPED BY Prostyle Pc Applications");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            sales open = new sales();
            open.Show();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            inventory open = new inventory();
            open.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Mail m = new Mail();
            m.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            sms s = new sms();
            s.Show();
        }
        
    }
}
