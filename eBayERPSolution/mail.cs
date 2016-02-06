using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Gmail;


namespace eBayERPSolution
{
    public partial class Mail : Form
    {
        public Mail()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           if(templatelistbox.SelectedItem.ToString().Equals("Ready To Ship"))
            {
                string htmlcode_orderporcessing = System.IO.File.ReadAllText("order_processing.txt");
                
               // string m ="Dear Buyer,"; m += "<br>";
               // m += "Your order is Ready TO Ship.We are now waiting for pickup by eBay freight carrier. Once they picked up and update your order in their system, you will receive a SMS and email containing your tracking information from ebay.in";

               // m += "<br>"; m += "Tracking number generated for your recent order by eBay";

               // m += "<br>"; m += "Details:"; m += "<br>";
               // m += "<br>"; m += "------------------------------------"; m += "<br>";
               // m += "Courier name:	FEDEX"; m += "<br>";
               // m += "Airway bill number: 	552743591799"; m += "<br>";
               // m += "Remarks:	Shipped through preferred partner"; m += "<br>";
               // m += "Mode:	Priority Overnight"; m +="<br>";
               // m +="------------------------------------"; m +="<br>";
               // m+= "Regards,"; m +="<br>";
               // m+= "Shipping Department"; m +="<br>";
               // m+= "E-Shop @ Prostyle Pc "; m +="<br>";
               // m+= "Seller ID ehsop.prostylepc.in"; m +="<br>";
               // m+= "FAQ:" ; m +="<br>";
               // m+= "When will my order be dispatched?"; m +="<br>";
               // m+= "All orders through the FedEx, ARAMEX, Bluedart delivery service will be dispatched up until 2.30 pm (Monday – Saturday)."; m +="<br>";
               // m+= "If your order is placed outside of these hours it will be dispatched the next working day (Monday –Saturday).";m +="<br>";
               //string format="<html>";
               //format += "<body>"+m+"<body>";
               // format += "</html>";
                bodytbox.Text = htmlcode_orderporcessing;
               
            

                    
            }
        }

        
        

        private void button2_Click(object sender, EventArgs e)
        {
            GmailClient client = new GmailClient();
           
            string status = client.send(txt_gmailid.Text, txt_password.Text, txt_toemail.Text, txt_subject.Text,bodytbox.Text, txt_attachment.Text == "" ? null : txt_attachment.Text);
            MessageBox.Show(status);
        }

        
       
        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txt_attachment.Text = openFileDialog1.FileName;
            }
        }

        private void settingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setting obj = new setting();
            obj.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ApplicationHome home = new ApplicationHome();
            home.Show();
            this.WindowState = FormWindowState.Minimized;
            home.WindowState = FormWindowState.Maximized;
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bodytbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
