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
    public partial class inventoryadd : Form
    {
        public inventoryadd()
        {
            InitializeComponent();
        }

        private void inventoryadd_Load(object sender, EventArgs e)
        {

            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;
        }


        private void button2_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 10;
            try
            {
                var mydbconnection = new dbconnection();//new code
                progressBar1.Value = 30;
                string query = "INSERT INTO inventory (sku,productname,costprice,sellingprice,stockunit) VALUES('" + skutbox.Text + "','" + productnametbox.Text + "','" + float.Parse(costpricetbox.Text) + "','" + float.Parse(sellingpricetbox.Text) + "','" + int.Parse(stockunittbox.Text) + "')";
                MySqlCommand cmd = new MySqlCommand(query, mydbconnection.getconnect);
                progressBar1.Value = 40;
                cmd.ExecuteNonQuery();
                progressBar1.Value = 60;
            }
            catch (Exception e3)
            {
                MessageBox.Show(e3.Message);

            }
            progressBar1.Value = 100;


        }

        

        private void button3_Click(object sender, EventArgs e)
        {
            inventory show = new inventory();
            show.WindowState = FormWindowState.Maximized;
            this.Close();

        }

        private void update_click(object sender, EventArgs e)
        {
            if (skutboxkey.Text.Length == 0)
            {
                MessageBox.Show("Please Enter the SKU In SKUKEY box");
            }
            else
            {
                progressBar1.Value = 10;
                try
                {
                    var mydbconnection = new dbconnection();//new code
                    progressBar1.Value = 20;
                    string query = "UPDATE inventory SET sku='" + skutbox.Text + "',productname='" + productnametbox.Text + "',costprice='" + int.Parse(costpricetbox.Text) + "',sellingprice='" + int.Parse(sellingpricetbox.Text) + "',stockunit='" + stockunittbox.Text + "' WHERE sku='" + skutboxkey.Text + "'";
                    MySqlCommand cmd = new MySqlCommand(query, mydbconnection.getconnect);
                    progressBar1.Value = 30;
                    cmd.ExecuteNonQuery();
                    progressBar1.Value = 40;
                }
                catch (Exception e1)
                {
                    MessageBox.Show(e1.Message);
                }
                progressBar1.Value = 50;
                try
                {

                    var mydbconnection = new dbconnection();//new code
                    
                    progressBar1.Value = 60;
                    string query = "SELECT sku,productname,costprice,sellingprice,stockunit FROM inventory WHERE sku='" + skutbox.Text + "'";
                    MySqlCommand cmd = new MySqlCommand(query, mydbconnection.getconnect);
                    MySqlDataAdapter sda = new MySqlDataAdapter();
                    progressBar1.Value = 70;
                    sda.SelectCommand = cmd;
                  
                    DataTable dataset = new DataTable();
                    sda.Fill(dataset);
                   //BindingSource bsource = new BindingSource();
                   // bsource.DataSource = dataset;
                    inventorylistgrid.DataSource = dataset;
                    sda.Update(dataset);

                }
                catch (Exception e1) { MessageBox.Show(e1.Message); }
                progressBar1.Value = 100;
            }
        }
        private void button6_Click(object sender, EventArgs e)
        {
            if (skutboxkey.Text.Length == 0)
            {
                MessageBox.Show("Please Enter the SKU In SKUKEY box");
            }
            else
            {
                progressBar1.Value = 10;
                try
                {

                    var mydbconnection = new dbconnection();//new code
                    progressBar1.Value = 20;
                    //MySqlDataReader dr;
                    string query = "SELECT sku,productname,costprice,sellingprice,stockunit FROM inventory WHERE sku='" + skutboxkey.Text + "'";
                    MySqlCommand cmd = new MySqlCommand(query, mydbconnection.getconnect);
                    progressBar1.Value = 30;
                    MySqlDataAdapter sda = new MySqlDataAdapter();
                    sda.SelectCommand = cmd;
                    //dr = cmd.ExecuteReader();
                    DataTable dataset = new DataTable();
                    progressBar1.Value = 40;
                    sda.Fill(dataset);
                    BindingSource bsource = new BindingSource();
                    bsource.DataSource = dataset;

                    inventorylistgrid.DataSource = dataset;
                    sda.Update(dataset);

                }
                catch (Exception e1) { MessageBox.Show(e1.Message); }
                progressBar1.Value = 50;
                try
                {
                    var mydbconnection = new dbconnection();//new code
                    progressBar1.Value = 60;
                    MySqlDataReader dr;
                    string query = "SELECT sku,productname,costprice,sellingprice,stockunit FROM inventory WHERE sku='" + skutboxkey.Text + "'";
                    MySqlCommand cmd = new MySqlCommand(query, mydbconnection.getconnect);
                    dr = cmd.ExecuteReader();
                    progressBar1.Value = 70;
                    while (dr.Read())
                    {
                        skutbox.Text = dr[0].ToString();
                        productnametbox.Text = dr[1].ToString();
                        costpricetbox.Text = dr[2].ToString();
                        sellingpricetbox.Text = dr[3].ToString();
                        stockunittbox.Text = dr[4].ToString();
                    }
                    progressBar1.Value = 80;
                    dr.Close();
                }
                catch (Exception e2)
                {
                    MessageBox.Show(e2.Message);
                }

                updatebutton.Enabled = true;
                progressBar1.Value = 100;


            }
        }

        private void inventorylistgrid_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {

                    DataGridViewRow row = this.inventorylistgrid.Rows[e.RowIndex];
                    skutbox.Text = row.Cells["sku"].Value.ToString();
                    productnametbox.Text = row.Cells["productname"].Value.ToString();
                    costpricetbox.Text = row.Cells["costprice"].Value.ToString();
                    sellingpricetbox.Text = row.Cells["sellingprice"].Value.ToString();
                    stockunittbox.Text = row.Cells["stockunit"].Value.ToString();
                }
            }
            catch (Exception e1)
            {
                MessageBox.Show("No Value");
            }
        }
    }
}
