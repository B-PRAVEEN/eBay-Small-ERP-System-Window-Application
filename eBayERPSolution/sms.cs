using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Net;

namespace eBayERPSolution
{
    public partial class sms : Form
    {
        public sms()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HttpWebRequest request;
            HttpWebResponse response;
            string url ;
            string username = "prostylepc";
            string pass = "nokian73";
            string host = "http://login.mysmsindia.com/messageapi.asp?";

            progressBar1.Value = 25;

            url= host +"username="+username+"&password="+pass+"&sender=prostylepc&mobile="+customernumbertbox.Text+"&message="+smsmessagetbox.Text;

            request = (HttpWebRequest)WebRequest.Create(url);

            progressBar1.Value = 50;

            try
            {
                response = (HttpWebResponse)request.GetResponse();

                StreamReader sr = new StreamReader(response.GetResponseStream());


                string result = sr.ReadToEnd();

                progressBar1.Value = 100;   

                MessageBox.Show(result);            

            }

            catch (Exception e1)
            
            {
                MessageBox.Show(e1.Message);
            }

        }

        private void sms_Load(object sender, EventArgs e)
        {
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;
            customernumbertbox.Text = sales.phone;
        }

        private void smstemplatecbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (smstemplatecbox.SelectedItem.ToString().Equals("Shipped"))
            {
                string smsread = System.IO.File.ReadAllText("shipped.txt");
                string s1 = smsread.Replace("$pid", sales.paisapayidglobal.ToString());
                string s2 = s1.Replace("$lsp", sales.lsp);
                string s3 = s2.Replace("$awb", sales.awbno);
                smsmessagetbox.Text = s3;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sms a = new sms();
            this.Close();
        }

        
        
    }
}
