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
    public partial class sendmail : Form
    {
        public sendmail()
        {
            InitializeComponent();
        }
        
        private void sendmail_Load(object sender, EventArgs e)
        {
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;
            txt_toemail.Text = sales.emailid;

        }

        private void templatelistbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (templatelistbox.SelectedItem.ToString().Equals("Ready To Ship QTY 1"))
            {
                txt_subject.Text = "Order Confirmation - Your Order with eBay.in ["+sales.paisapayidglobal+"] has been successfully received to We Are Reseller.";
                string htmlcode_orderporcessing = System.IO.File.ReadAllText("order_processingqty1.txt");
                string news = htmlcode_orderporcessing.Replace("$name", sales.name);
                string news1 = news.Replace("$product1", sales.dataset.Rows[0][1].ToString());
               
                string news2 = news1.Replace("$qty1", sales.dataset.Rows[0][3].ToString());
               
                string news3 = news2.Replace("$iprice1", sales.dataset.Rows[0][6].ToString());
               
                string news4 = news3.Replace("$paisapayid", sales.paisapayidglobal.ToString());
                string news5 = news4.Replace("$sfees", sales.sfee.ToString());
                string news6 = news5.Replace("$total", sales.total.ToString());
                string news7 = news6.Replace("$saddress", sales.saddress.ToString());
                bodytbox.Text = news7;

            }
            else if (templatelistbox.SelectedItem.ToString().Equals("Ready To Ship QTY 2"))
            {
                txt_subject.Text = "Order Confirmation - Your Order with eBay.in [" + sales.paisapayidglobal + "] has been successfully received to We Are Reseller.";
                string htmlcode_orderporcessing = System.IO.File.ReadAllText("order_processing.txt");
                string news = htmlcode_orderporcessing.Replace("$name", sales.name);
                string news1 = news.Replace("$product1", sales.dataset.Rows[0][1].ToString());
                string news2 = news1.Replace("$product2", sales.dataset.Rows[1][1].ToString());
                string news3 = news2.Replace("$qty1", sales.dataset.Rows[0][3].ToString());
                string news4 = news3.Replace("$qty2", sales.dataset.Rows[1][3].ToString());
                string news5 = news4.Replace("$iprice1", sales.dataset.Rows[0][6].ToString());
                string news6 = news5.Replace("$iprice2", sales.dataset.Rows[1][6].ToString());
                string news7 = news6.Replace("$paisapayid", sales.paisapayidglobal.ToString());
                string news8 = news7.Replace("$sfees",sales.sfee.ToString());
                string news9 = news8.Replace("$total", sales.total.ToString());
                string news10= news9.Replace("$saddress", sales.saddress.ToString());
                bodytbox.Text= news10;

            }
            else if(templatelistbox.SelectedItem.ToString().Equals("Packed And Ready TO Ship QTY 1"))
            {
                txt_subject.Text = "Ready TO Ship! - Your Order[" + sales.paisapayidglobal + "] has packed and ready to ship.";
                string htmlcode_orderporcessing = System.IO.File.ReadAllText("packed_readytoship.txt");
                string news = htmlcode_orderporcessing.Replace("$name", sales.name);
                string news1 = news.Replace("$product1", sales.dataset.Rows[0][1].ToString());

                string news2 = news1.Replace("$qty1", sales.dataset.Rows[0][3].ToString());

                string news3 = news2.Replace("$iprice1", sales.dataset.Rows[0][6].ToString());

                string news4 = news3.Replace("$paisapayid", sales.paisapayidglobal.ToString());
                string news5 = news4.Replace("$sfees", sales.sfee.ToString());
                string news6 = news5.Replace("$total", sales.total.ToString());
                string news7 = news6.Replace("$saddress", sales.saddress.ToString());
                string news8 = news7.Replace("$lsp", sales.lsp.ToString());
                string news9=  news8.Replace("$awbno",sales.awbno.ToString());
                string news10 = news9.Replace("$sdate", sales.date.ToString());
                bodytbox.Text = news10;

            }

            else if (templatelistbox.SelectedItem.ToString().Equals("Packed And Ready TO Ship QTY 2"))
            {
                txt_subject.Text = "Ready TO Ship! - Your Order[" + sales.paisapayidglobal + "] has packed and ready to ship.";
                string htmlcode_orderporcessing = System.IO.File.ReadAllText("packed_readytoshipqty2.txt");
                string news = htmlcode_orderporcessing.Replace("$name", sales.name);
                string news1 = news.Replace("$product1", sales.dataset.Rows[0][1].ToString());
                string news2 = news1.Replace("$product2", sales.dataset.Rows[1][1].ToString());
                string news3 = news2.Replace("$qty1", sales.dataset.Rows[0][3].ToString());
                string news4 = news3.Replace("$qty2", sales.dataset.Rows[1][3].ToString());
                string news5 = news4.Replace("$iprice1", sales.dataset.Rows[0][6].ToString());
                string news6 = news5.Replace("$iprice2", sales.dataset.Rows[1][6].ToString());

                string news7 = news6.Replace("$paisapayid", sales.paisapayidglobal.ToString());
                string news8 = news7.Replace("$sfees", sales.sfee.ToString());
                string news9 = news8.Replace("$total", sales.total.ToString());
                string news10 = news9.Replace("$saddress", sales.saddress.ToString());
                string news11 = news10.Replace("$lsp", sales.lsp.ToString());
                string news12 = news11.Replace("$awbno", sales.awbno.ToString());
                string news13 = news12.Replace("$sdate", sales.date.ToString());
                bodytbox.Text = news13;
 
            }
            else if (templatelistbox.SelectedItem.ToString().Equals("Shipped QTY 1"))
            {
                txt_subject.Text = "Shipment of items in order " + sales.paisapayidglobal + " has shipped by We Are Reseller.";
                string htmlcode_orderporcessing = System.IO.File.ReadAllText("shipment_doneqty1.txt");
                string news = htmlcode_orderporcessing.Replace("$name", sales.name);
                string news1 = news.Replace("$product1", sales.dataset.Rows[0][1].ToString());

                string news2 = news1.Replace("$qty1", sales.dataset.Rows[0][3].ToString());

                string news3 = news2.Replace("$iprice1", sales.dataset.Rows[0][6].ToString());

                string news4 = news3.Replace("$paisapayid", sales.paisapayidglobal.ToString());
                string news5 = news4.Replace("$sfees", sales.sfee.ToString());
                string news6 = news5.Replace("$total", sales.total.ToString());
                string news7 = news6.Replace("$saddress", sales.saddress.ToString());
                string news8 = news7.Replace("$lsp", sales.lsp.ToString());
                string news9 = news8.Replace("$awbno", sales.awbno.ToString());
                string news10 = news9.Replace("$sdate", sales.date.ToString());
                bodytbox.Text = news10;
 
            }

            else if (templatelistbox.SelectedItem.ToString().Equals("Shipped QTY 2"))
            {
                txt_subject.Text = "Shipment of items in order " + sales.paisapayidglobal + " has shipped by We Are Reseller.";
                string htmlcode_orderporcessing = System.IO.File.ReadAllText("shipment_doneqty2l.txt");
                string news = htmlcode_orderporcessing.Replace("$name", sales.name);
                string news1 = news.Replace("$product1", sales.dataset.Rows[0][1].ToString());
                string news2 = news1.Replace("$product2", sales.dataset.Rows[1][1].ToString());
                string news3 = news2.Replace("$qty1", sales.dataset.Rows[0][3].ToString());
                string news4 = news3.Replace("$qty2", sales.dataset.Rows[1][3].ToString());
                string news5 = news4.Replace("$iprice1", sales.dataset.Rows[0][6].ToString());
                string news6 = news5.Replace("$iprice2", sales.dataset.Rows[1][6].ToString());

                string news7 = news6.Replace("$paisapayid", sales.paisapayidglobal.ToString());
                string news8 = news7.Replace("$sfees", sales.sfee.ToString());
                string news9 = news8.Replace("$total", sales.total.ToString());
                string news10 = news9.Replace("$saddress", sales.saddress.ToString());
                string news11 = news10.Replace("$lsp", sales.lsp.ToString());
                string news12 = news11.Replace("$awbno", sales.awbno.ToString());
                string news13 = news12.Replace("$sdate", sales.date.ToString());
                bodytbox.Text = news13;

            }


            else if (templatelistbox.SelectedItem.ToString().Equals("Delivered QTY 1"))
            {
                txt_subject.Text = "Delivery confirmation of We Are Reseller order " + sales.paisapayidglobal + ".Please Leave Feedback on ebay.in.";
                string htmlcode_orderporcessing = System.IO.File.ReadAllText("deliveredqty1.txt");
                string news = htmlcode_orderporcessing.Replace("$name", sales.name);
                string news1 = news.Replace("$paisapayid", sales.paisapayidglobal.ToString());
                string news2 = news1.Replace("$awbno", sales.awbno.ToString());
                string news3 = news2.Replace("$qty1", sales.dataset.Rows[0][3].ToString());
                string news4 = news3.Replace("$product1", sales.dataset.Rows[0][1].ToString());
                string news5 = news4.Replace("$buyerid", sales.buyerid.ToString());
                string news6 = news5.Replace("$total", sales.total.ToString());
                bodytbox.Text = news6;

 
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txt_attachment.Text = openFileDialog1.FileName;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            progressBar1.Value = 10;
            GmailClient client = new GmailClient();
            progressBar1.Value = 50;
            string status = client.send(Properties.Settings.Default.guser, Properties.Settings.Default.gpassword, txt_toemail.Text, txt_subject.Text, bodytbox.Text, txt_attachment.Text == "" ? null : txt_attachment.Text);
            progressBar1.Value = 100;
            MessageBox.Show(status);
        }
    }
}
