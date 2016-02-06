using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace eBayERPSolution
{
  
    public partial class salesentry : Form
    {
        static public long paisapayidglobal;
        public salesentry()
        {
            InitializeComponent();
            
          

        }

       

        public  void button1_Click(object sender, EventArgs e)
        {
           DialogResult ans = MessageBox.Show("Payment Received Date :-----"+paymentrecdatetbox.Text+"\n"+"Shipping Date :------"+shippingdatetbox.Text,"Is it Correct ?",MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button1);
           if (ans == DialogResult.Yes)
           {
               try
               {
                   progressBar1.Value = 10;
                   var mydbconnection = new dbconnection();//new code
                   string query = "INSERT INTO ebayerp_sales (invdate,invno,paisapayid,phonenumber,emailid,paymentrecdate,customername,buyerid,billingaddress,shippingaddress,shippingpatner,awbno,shippingdate,shippingfees,total,status) VALUES('" + invdate.Text + "','" + int.Parse(invnotbox.Text) + "','" + long.Parse(paisapayidtbox.Text) + "','" + long.Parse(phonenumbertbox.Text) + "','" + emailidtbox.Text + "','" + paymentrecdatetbox.Text + "','" + customernametbox.Text + "','" + buyeridtbox.Text + "','" + billingaddresstbox.Text + "','" + shippingaddresstbox.Text + "','" + shippingpatnertbox.Text + "','" + awbnotbox.Text + "','" + shippingdatetbox.Text + "','" + double.Parse(shippingfeestbox.Text) + "','" + double.Parse(totaltbox.Text) + "','" + statustbox.Text + "')";
                   MySqlCommand cmd = new MySqlCommand(query, mydbconnection.getconnect);
                   progressBar1.Value = 40;
                   cmd.ExecuteNonQuery();

                   progressBar1.Value = 50;
               }
               catch (Exception e1)
               {
                   MessageBox.Show(e1.Message);

               }

               try
               {
                   progressBar1.Value = 55;
                   var mydbconnection = new dbconnection();
                   string query, sku;
                   string itemname;
                   int itemqty;
                   double itemprice, total, withouttax, itemtax;
                   for (int i = 0; i < inventorylist.saleslist.Rows.Count; i++)
                   {
                       sku = Convert.ToString(inventorylist.saleslist.Rows[i][0].ToString());
                       itemname = Convert.ToString(inventorylist.saleslist.Rows[i][1].ToString());
                       itemprice = Convert.ToDouble(inventorylist.saleslist.Rows[i][2].ToString());
                       itemqty = Convert.ToInt32(inventorylist.saleslist.Rows[i][3].ToString());
                       withouttax = Convert.ToDouble(inventorylist.saleslist.Rows[i][4].ToString());
                       itemtax = Convert.ToDouble(inventorylist.saleslist.Rows[i][5].ToString());
                       total = Convert.ToDouble(inventorylist.saleslist.Rows[i][6].ToString());
                       query = "INSERT INTO solditem(SKU,productname,price,qty,withouttaxtotal,itemtax,itemtotal,paisapayidglobal) VALUES('" + sku + "','" + itemname + "','" + itemprice + "','" + itemqty + "','" + withouttax + "','" + itemtax + "','" + total + "'," + paisapayid2 + ")";
                       MySqlCommand cmd = new MySqlCommand(query, mydbconnection.getconnect);
                       progressBar1.Value = 80;
                       cmd.ExecuteNonQuery();

                   }
                   progressBar1.Value = 100;

               }
               catch (Exception e1)
               {
                   MessageBox.Show(e1.Message);
               }
           }
           

        }



                private void salesentry_Load(object sender, EventArgs e)
                {
                    subtotaltbox.Text ="0";
                    invnotbox.Text="0";
                    shippingfeestbox.Text = "0";

                    progressBar1.Minimum = 0;
                    progressBar1.Maximum = 100;
                }

                public void saleslistfun()
                {
                    itemlistgrid.DataSource = inventorylist.saleslist;
                }

                private void button2_Click(object sender, EventArgs e)
                {
                    double total = 0;
                    itemlistgrid.DataSource = inventorylist.saleslist;
                    for (int i = 0; i < inventorylist.saleslist.Rows.Count; i++)
                    {
                        total += Convert.ToDouble(inventorylist.saleslist.Rows[i][4].ToString());
                    }
                   subtotaltbox.Text = total.ToString();

                }

               
                public static long paisapayid2=0;
                private void button3_Click(object sender, EventArgs e)
                {
                    
                    try
                    {
                        if (paisapayidtbox.Text.Length == 0)
                        {

                            MessageBox.Show("Missing PaisaPay ID");
                        }
                        else
                        {
                            paisapayid2 = long.Parse(paisapayidtbox.Text);
                            inventorylist.saleslist.Clear();
                            inventorylist open = new inventorylist();
                            open.Show();
                        }
                    }

                    catch (Exception e1)
                    {
                        MessageBox.Show(e1.Message);
                    }
                }

                public void paisapayidtbox_TextChanged(object sender, EventArgs e)
                {

                }

               

                private void itemlistgrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
                {

                }
                public static string emailid;
                private void button4_Click(object sender, EventArgs e)
                {
                    sendmail obj = new sendmail();
                    obj.Show();
                    
                }

                public static long paisapayidsearch;
                private void button6_Click(object sender, EventArgs e)
                {
                   paisapayidsearch= long.Parse(paisapayidtbox.Text);
                    sales s = new sales();
                    s.Show();
                    this.Close();

                    

                }

                private void salesToolStripMenuItem_Click(object sender, EventArgs e)
                {

                }

                private void button7_Click(object sender, EventArgs e)
                {
                    this.Close();
                }

                private void shippingfeestbox_TextChanged(object sender, EventArgs e)
                {
                    if (shippingfeestbox.Text.Trim().Length==0)
                    {
                        shippingfeestbox.Text = "0";
                    }
                    
                }

                private void button5_Click(object sender, EventArgs e)
                {
                    totaltbox.Text = (int.Parse(subtotaltbox.Text) + int.Parse(shippingfeestbox.Text)).ToString();

                }

                private void button4_Click_1(object sender, EventArgs e)
                {
                    ApplicationHome a = new ApplicationHome();
                    a.BringToFront();
                    this.Close();
                }

               
    }
}
