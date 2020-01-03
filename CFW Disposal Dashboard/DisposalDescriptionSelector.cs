using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CFW_Disposal_Dashboard
{
    public class DisposalDescriptionSelector
    {
        /* For use as a module later to clean up code
         * 
        public int DipCost(int x)
        {
             
            try
            {
                //   textBox8.Text = "0";
                if (sqlconnect.State == ConnectionState.Closed)
                {
                    sqlconnect.Open();
                    SqlCommand sqlcmd = new SqlCommand("");
                }

                if (comboBox5.Text == "Passenger + Light Truck With Rim up to 17.5")
                {
                    textBox7.Text = "1";
                    string sqlSelectQuery = "SELECT * FROM DisposalId WHERE DisposalCost = 7.50" + (textBox8.Text);
                    SqlCommand Costcmd = new SqlCommand(sqlSelectQuery, sqlconnect);
                    SqlDataReader dr = Costcmd.ExecuteReader();
                    if (dr.Read())
                    {
                        textBox8.Text = (dr["DisposalCost"].ToString());
                        textBox6.ReadOnly = false;
                        MessageBox.Show("Now Enter Quantity and Save");
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("test failed");

            }
            return 0;
            */
    }
}

