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
    public partial class sales : Form
    {
        public static DataTable dataset = new DataTable();
        
        public static string awbno;
        public static string lsp;
        public static long pid;
        
        public sales()
        {
            InitializeComponent();
        }

       

    
        private void button3_Click(object sender, EventArgs e)
        {

            ApplicationHome home = new ApplicationHome();
            home.WindowState = FormWindowState.Minimized;
            this.Close();

        }

       

        private void button2_Click(object sender, EventArgs e)
        {

            salesentry salesadd = new salesentry();
            salesadd.Show();
            this.Close();

        }

        private void searchb_Click(object sender, EventArgs e)
        {
            try
            {
                sales.dataset.Clear();
                progressBar1.Value = 0;
                MySqlDataReader dr;
                var mydbconnection = new dbconnection();//new code
                progressBar1.Value = 40;
                string query = "SELECT invdate,invno,paisapayid,phonenumber,emailid,paymentrecdate,customername,buyerid,billingaddress,shippingaddress,shippingpatner,awbno,shippingdate,shippingfees,total,status FROM ebayerp_sales WHERE paisapayid='" + long.Parse(paisapayidtbox.Text) + "'";
                MySqlCommand cmd = new MySqlCommand(query, mydbconnection.getconnect);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    invdatetbox.Text = dr[0].ToString();
                    invnotbox.Text = dr[1].ToString();
                    paisapayidtbox.Text = dr[2].ToString();
                    phonenumbertbox.Text = dr[3].ToString();
                    emailidtbox.Text = dr[4].ToString();
                    paymentrecdatetbox.Text = dr[5].ToString();
                    customernametbox.Text = dr[6].ToString();
                    buyeridtbox.Text = dr[7].ToString();
                    billingaddresstbox.Text = dr[8].ToString();
                    shippingaddresstbox.Text = dr[9].ToString();
                    shippingpatnertbox.Text = dr[10].ToString();
                    awbnotbox.Text = dr[11].ToString();
                    shippingdatetbox.Text = dr[12].ToString();
                    shippingfeestbox.Text = dr[13].ToString();
                    totaltbox.Text = dr[14].ToString();
                    statustbox.Text = dr[15].ToString();

                }
                progressBar1.Value = 50;

            }
            catch (Exception e2)
            {
                MessageBox.Show(e2.Message);

            }

            try
            {
                progressBar1.Value = 55;
                var mydbconnection = new dbconnection();
                progressBar1.Value = 70;
                string query2 = "SELECT SKU,productname,price,qty,withouttaxtotal,itemtax,itemtotal FROM solditem WHERE paisapayidglobal='" + long.Parse(paisapayidtbox.Text) + "'";
                MySqlCommand cmd1 = new MySqlCommand(query2, mydbconnection.getconnect);
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmd1;
                //DataTable dataset = new DataTable();
                sda.Fill(dataset);
                BindingSource bsource = new BindingSource();
                bsource.DataSource = dataset;
                saleslistgrid.DataSource = dataset;
                sda.Update(dataset);
                progressBar1.Value = 100;

            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
            }


        }

        private void update_click(object sender, EventArgs e)
        {


            try
            {
                progressBar1.Value = 10;
                var mydbconnection = new dbconnection();//new code
                progressBar1.Value = 40;
                string query = "UPDATE ebayerp_sales SET invdate='" + invdatetbox.Text + "',invno='" + invnotbox.Text + "',paisapayid='" + long.Parse(paisapayidtbox.Text) + "',phonenumber='" + long.Parse(phonenumbertbox.Text) + "',emailid='" + emailidtbox.Text + "',paymentrecdate='" + paymentrecdatetbox.Text + "',customername='" + customernametbox.Text + "',buyerid='" + buyeridtbox.Text + "',billingaddress='" + billingaddresstbox.Text + "',shippingaddress='" + shippingaddresstbox.Text + "',shippingpatner='" + shippingpatnertbox.Text + "',awbno='" + awbnotbox.Text + "',shippingdate='" + shippingdatetbox.Text + "',shippingfees='" + int.Parse(shippingfeestbox.Text) + "',total='" + int.Parse(totaltbox.Text) + "',status='" + statustbox.Text + "' WHERE paisapayid='" + long.Parse(paisapayidtbox.Text) + "'";
                MySqlCommand cmd = new MySqlCommand(query, mydbconnection.getconnect);
                cmd.ExecuteNonQuery();

                progressBar1.Value = 50;
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
            }

            try
            {
                progressBar1.Value = 60;
                var mydbconnection = new dbconnection();
                string query, sku;
                string itemname;
                int itemqty;
                double itemprice, total, withouttax, itemtax;
                for (int i = 0; i < (saleslistgrid.Rows.Count - 1); i++)
                {
                    sku = Convert.ToString(saleslistgrid.Rows[i].Cells[0].Value);
                    itemname = Convert.ToString(saleslistgrid.Rows[i].Cells[0].Value);
                    itemprice = Convert.ToDouble(saleslistgrid.Rows[i].Cells[1].Value);
                    itemqty = Convert.ToInt32(saleslistgrid.Rows[i].Cells[2].Value);
                    withouttax = Convert.ToDouble(saleslistgrid.Rows[i].Cells[3].Value);
                    itemtax = Convert.ToDouble(saleslistgrid.Rows[i].Cells[4].Value);
                    total = Convert.ToDouble(saleslistgrid.Rows[i].Cells[5].Value);
                    query = "UPDATE solditem SET price='" + itemprice + "',qty='" + itemqty + "',productname='" + itemname + "',withouttaxtotal='" + withouttax + "',itemtax='" + itemtax + "',itemtotal='" + total + "' WHERE paisapayidglobal='" + sku + "'";
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

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {

                MessageBox.Show("You are going to delete this Transaction");
                progressBar1.Value = 30;
                var mydbconnection = new dbconnection();//new code
                string query = "DELETE FROM ebayerp_sales WHERE paisapayid='" + int.Parse(paisapayidtbox.Text) + "'";
                MySqlCommand cmd = new MySqlCommand(query, mydbconnection.getconnect);
                progressBar1.Value = 60;
                cmd.ExecuteNonQuery();
                String query2 = "DELETE FROM solditem WHERE paisapayidglobal='" + int.Parse(paisapayidtbox.Text) + "'";
                MySqlCommand cmd2 = new MySqlCommand(query2, mydbconnection.getconnect);
                progressBar1.Value = 80;
                cmd2.ExecuteNonQuery();
                progressBar1.Value = 100;

            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (skutbox.Text.Length == 0)
            {
                MessageBox.Show("Please Enter The SKU in SKU box");
            }
            else
            {
                progressBar1.Value = 30;
                try
                {
                    var mydbconnection = new dbconnection();//new code
                    progressBar1.Value = 70;
                    string query = "DELETE FROM solditem WHERE sku='" + skutbox.Text + "'and paisapayidglobal='" + long.Parse(paisapayidtbox.Text) + "'";
                    MySqlCommand cmd = new MySqlCommand(query, mydbconnection.getconnect);
                    cmd.ExecuteNonQuery();
                    progressBar1.Value = 100;


                }
                catch (Exception e1)
                {
                    MessageBox.Show(e1.Message);
                }
            }
        }

        private void sales_Load(object sender, EventArgs e)
        {
            paisapayidtbox.Text = salesentry.paisapayidsearch.ToString();
        }

        private void paisapayidtbox_TextChanged(object sender, EventArgs e)
        {
            try
            {

                pid = long.Parse(paisapayidtbox.Text);
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
            }
        }

        
        public static long paisapayidglobal;
        public static string name,saddress;
        public static int sfee, total;
        public static string date;
        public static string buyerid;
        public static string phone;
        public static string emailid;
       
      
        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                buyerid = buyeridtbox.Text;
                emailid = emailidtbox.Text;
                date = shippingdatetbox.Text;
                saddress = shippingaddresstbox.Text;
                sfee = int.Parse(shippingfeestbox.Text);
                total = int.Parse(totaltbox.Text);
                name = customernametbox.Text;
                paisapayidglobal = long.Parse(paisapayidtbox.Text);
                lsp = shippingpatnertbox.Text;
                awbno = awbnotbox.Text;
                sendmail open = new sendmail();
                open.Show();
            }
            catch (Exception e1)
            {
                MessageBox.Show("Missing Some Important Fields");
            }
        }

        private void shippingpatnertbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            lsp = shippingpatnertbox.Text;
        }

        private void awbnotbox_TextChanged(object sender, EventArgs e)
        {
            awbno = awbnotbox.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {    
                paisapayidglobal = long.Parse(paisapayidtbox.Text);
                lsp = shippingpatnertbox.Text;
                awbno = awbnotbox.Text;
                phone = phonenumbertbox.Text;
                sms open = new sms();
                open.Show();
            }
            catch (Exception e1)
            {
                MessageBox.Show("Missing Some Important Fields");
            }
            
           
        }

        private void button9_Click(object sender, EventArgs e)
        {
            totaltbox.Text = (int.Parse(subtotaltbox.Text) + int.Parse(shippingfeestbox.Text)).ToString();
        }

        

        
    }

    
}
