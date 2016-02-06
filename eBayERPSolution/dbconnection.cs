using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace eBayERPSolution
{
 
    
    public class dbconnection
    {

        MySqlConnection connection;  // Object Name

        public MySqlConnection getconnect 
        {
            get { return this.connection; } 
        }

       
        public dbconnection()
        {


            this.connection  = new MySqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["mysqlconnect"].ConnectionString);
            



            try
            {
                this.connection.Open();
                


            }

            catch (Exception e)
            {
                
                MessageBox.Show(e.Message );
                

            }



           
        }



    }
}
