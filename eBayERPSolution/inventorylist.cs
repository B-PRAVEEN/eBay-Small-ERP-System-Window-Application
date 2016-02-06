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
    public partial class inventorylist : Form
    {
        public static DataTable saleslist = new DataTable();
        public inventorylist()
        {
            InitializeComponent();
        }
                       
        private void label1_Click(object sender, EventArgs e)
        {

        }
   

        private void inventorylist_Load(object sender, EventArgs e)
        {            
            paisapayidprimarykeytbox.Text = salesentry.paisapayid2.ToString();
            var mydbconnection = new dbconnection();
            
            string query = "SELECT * FROM inventory";
            MySqlCommand cmd = new MySqlCommand(query, mydbconnection.getconnect);

            MySqlDataAdapter sda = new MySqlDataAdapter();
            sda.SelectCommand = cmd;
            DataTable dataset = new DataTable();
            sda.Fill(dataset);
            BindingSource bsource = new BindingSource();
            bsource.DataSource = dataset;
            dataGridView1.DataSource = dataset;
            sda.Update(dataset);
            /////////////////////////////////////////////////////////////////////////////
            DataColumn Item_SKU = new DataColumn("SKU", Type.GetType("System.String"));
            DataColumn Item_Name = new DataColumn("Item Name", Type.GetType("System.String"));
            DataColumn Item_Price = new DataColumn("Item_Price", Type.GetType("System.Decimal"));
            DataColumn Item_Qty = new DataColumn("Item_Qty", Type.GetType("System.Decimal"));
            DataColumn Item_totalwt = new DataColumn("With Out Tax", Type.GetType("System.Decimal"));
            DataColumn Item_Tax = new DataColumn("Item_tax", Type.GetType("System.Decimal"));
            // "Item_Tax" column is calculated (10% Tax)
            Item_Tax.Expression = "(Item_Price * Item_Qty)" + "/100" + "*" + Properties.Settings.Default.tax;

            Item_totalwt.Expression = "Item_Price * Item_Qty";

            DataColumn Item_Total = new DataColumn("Item_Total",
            Type.GetType("System.Decimal"));
            // "Item_Total" column is calculated as (Price * Qty + Tax)
            Item_Total.Expression = "Item_Price * Item_Qty + Item_Tax";

            saleslist.Columns.Add(Item_SKU);      //
            saleslist.Columns.Add(Item_Name);    // Add 4
            saleslist.Columns.Add(Item_Price);   // Columns
            saleslist.Columns.Add(Item_Qty);     // to
            saleslist.Columns.Add(Item_totalwt);
            saleslist.Columns.Add(Item_Tax);     // the
            saleslist.Columns.Add(Item_Total);   // Datatable

           
        }

      

       
        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                skutbox.Text = row.Cells["sku"].Value.ToString();
                productnametbox.Text = row.Cells["productname"].Value.ToString();
                pricetbox.Text = row.Cells["sellingprice"].Value.ToString();
                              
                
            }
        }

       

        
       

        private void add_click(object sender, EventArgs e)
        {
            if (qtytbox.Text.Length == 00)
            {
                MessageBox.Show("Enter QTY");
            }

            else
            {
                saleslist.Rows.Add(skutbox.Text, productnametbox.Text, int.Parse(pricetbox.Text), int.Parse(qtytbox.Text));
                saleslistgrid.DataSource = saleslist;
               

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        
    }
}
