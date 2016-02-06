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
    public partial class inventory : Form
    {
        public inventory()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            inventoryadd invadd = new inventoryadd();
            invadd.Show();
            this.WindowState = FormWindowState.Minimized;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {

                progressBar1.Value = 15;
                var mydbconnection = new dbconnection();
                progressBar1.Value = 30;
                string query = "SELECT * FROM inventory";
                MySqlCommand cmd = new MySqlCommand(query, mydbconnection.getconnect);
                progressBar1.Value = 50;
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmd;
                DataTable dataset = new DataTable();
                sda.Fill(dataset);
                progressBar1.Value = 80;
                //BindingSource bsource = new BindingSource();
                //bsource.DataSource = dataset;
                inventorygrid.DataSource = dataset;
                sda.Update(dataset);
                progressBar1.Value = 100;
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
            }
        }

        private void search_click(object sender, EventArgs e)
        {

            if (skutboxmain.Text.Length == 0)
            {
                MessageBox.Show("Please Enter The SKU in SKU box");
            }
            else
            {
                progressBar1.Value = 10;


                var mydbconnection = new dbconnection();//new code
                progressBar1.Value = 30;
                string query = "SELECT sku,productname,costprice,sellingprice,stockunit FROM inventory WHERE sku='" + skutboxmain.Text + "'";
                MySqlCommand cmd = new MySqlCommand(query, mydbconnection.getconnect);
                progressBar1.Value = 50;
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmd;
                DataTable dataset = new DataTable();
                sda.Fill(dataset);
                progressBar1.Value = 80;
                BindingSource bsource = new BindingSource();
                bsource.DataSource = dataset;
                inventorygrid.DataSource = dataset;
                sda.Update(dataset);


                progressBar1.Value = 100;


            }
        }

        private void inventory_Load(object sender, EventArgs e)
        {
            inventorygrid.ReadOnly = true;
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;

            ApplicationHome home = new ApplicationHome();
            home.WindowState = FormWindowState.Minimized;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (skutboxmain.Text.Length == 0)
            {
                MessageBox.Show("Please Enter The SKU in SKU box");
            }
            else
            {
                progressBar1.Value = 30;
                try
                {
                    var mydbconnection = new dbconnection();//new code
                    progressBar1.Value=70;
                    string query = "DELETE FROM inventory WHERE sku='" + skutboxmain.Text + "'";
                    MySqlCommand cmd = new MySqlCommand(query, mydbconnection.getconnect);
                    cmd.ExecuteNonQuery();
                    


                }
                catch (Exception e1)
                {
                    MessageBox.Show(e1.Message);
                }

                progressBar1.Value = 100;
                MessageBox.Show("Sucessfully Delete"+skutboxmain.Text);
                inventorygrid.Update();
                inventorygrid.Refresh();
            }
        }

        private void inventorygrid_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                if (e.RowIndex >= 0)
                {

                    DataGridViewRow row = this.inventorygrid.Rows[e.RowIndex];
                    skutboxmain.Text = row.Cells["sku"].Value.ToString();
                    productnametbox.Text = row.Cells["productname"].Value.ToString();



                }
                else
                    MessageBox.Show("No Row");
            }
            catch (Exception e1)
            {
                MessageBox.Show("Now Value");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 15;
            var mydbconnection = new dbconnection();
            progressBar1.Value = 30;
            string query = "SELECT * FROM inventory";
            MySqlCommand cmd = new MySqlCommand(query, mydbconnection.getconnect);
            progressBar1.Value = 50;
            MySqlDataAdapter sda = new MySqlDataAdapter();
            sda.SelectCommand = cmd;
            DataTable dataset = new DataTable();
            sda.Fill(dataset);
            progressBar1.Value = 80;
            BindingSource bsource = new BindingSource();
            bsource.DataSource = dataset;
            inventorygrid.DataSource = dataset;
            sda.Update(dataset);
            progressBar1.Value = 100;
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }
    }
}
