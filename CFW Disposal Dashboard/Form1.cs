using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CFW_Disposal_Dashboard
{
    public partial class Form1 : Form
    {
        // SQL Connection //
        SqlConnection sqlconnect = new SqlConnection(@"Data Source=38574LAP\SQLEXPRESS;Initial Catalog=DisposalDashboardDatabase;Integrated Security=True;Connect Timeout=30");

        public Form1()
        {
            InitializeComponent();
            
            tabControl1.TabPages.Clear();
            tabControl1.TabPages.Add(tabPage1);
            // ^^^ Tab removal and setup //
                       
        }

        //  TOP MENU //
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();            
        }
        
        // BUTTON 1 Create WorkOrder DashBoardPage//
        private void button1_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Remove(tabPage2);
            tabControl1.TabPages.Add(tabPage2);
            tabControl1.SelectedIndex = 1;
          //  button1.Visible = false; //
        }

        // BUTTON 2 Work Order Disposal Dashboard Page//
        private void button2_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Remove(tabPage3);
            tabControl1.TabPages.Add(tabPage3);
            tabControl1.SelectedIndex = 2;
        }
        // BUTTON 3 Invoice Dashboard Page //
        private void button3_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Remove(tabPage4);
            tabControl1.TabPages.Add(tabPage4);
            tabControl1.SelectedIndex = 3;
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'disposalDashboardDatabaseDataSet4.DisposalId' table. You can move, or remove it, as needed.
            this.disposalIdTableAdapter1.Fill(this.disposalDashboardDatabaseDataSet4.DisposalId);
            // TODO: This line of code loads data into the 'disposalDashboardDatabaseDataSet3.WorkOrder' table. You can move, or remove it, as needed.
            this.workOrderTableAdapter1.Fill(this.disposalDashboardDatabaseDataSet3.WorkOrder);
           // TODO: This line of code loads data into the 'disposalDashboardDatabaseDataSet2.Contractor' table. You can move, or remove it, as needed.
            this.contractorTableAdapter1.Fill(this.disposalDashboardDatabaseDataSet2.Contractor);
           // TODO: This line of code loads data into the 'disposalDashboardDatabaseDataSet1.Employees' table. You can move, or remove it, as needed.
            this.employeesTableAdapter.Fill(this.disposalDashboardDatabaseDataSet1.Employees);
         
            // TODO: This line of code loads data into the 'disposalDashboardDatabaseDataSet.DOS' table. You can move, or remove it, as needed.
            this.dOSTableAdapter.Fill(this.disposalDashboardDatabaseDataSet.DOS);
            // TODO: This line of code loads data into the 'disposalDashboardDatabaseDataSet.Contractor' table. You can move, or remove it, as needed.
            this.contractorTableAdapter.Fill(this.disposalDashboardDatabaseDataSet.Contractor);
            

        }
        // Tab 1 Work Order Back Button //
        private void button6_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
            button1.Visible = true;
            this.workOrderTableAdapter1.Fill(this.disposalDashboardDatabaseDataSet3.WorkOrder);

        }
        // Tab 1 Work Order Start Button // 
        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
                        
        }
        // Tab 1 Work Order Save Button //
        private void button5_Click(object sender, EventArgs e)
        {
            sqlconnect.Open();
            SqlCommand cmd = sqlconnect.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into [WorkOrder] (ManifestNumber,Contractor,DOS,PickUpDate,WorkOrderStatus,Notes,FullName) values ('" + textBox2.Text + "','" + comboBox1.Text + "','" + comboBox2.Text + "','" + dateTimePicker1.Value.ToString() + "','" + comboBox3.Text + "','" + comboBox4.Text + "','" + textBox3.Text + "')";
            cmd.ExecuteNonQuery();
            sqlconnect.Close();
            textBox1.Text = "";
            textBox2.Text = "";
            comboBox1.Text = "";
            comboBox2.Text = "";
            dateTimePicker1.Text = "";
            comboBox3.Text = "";
            comboBox4.Text = "";
            textBox3.Text = "";
            MessageBox.Show("Work Order Saved Successfully");
            sqlconnect.Close();
        }
        // Work order View Data Button //
        private void button7_Click(object sender, EventArgs e)
        {
            WorkOrderVerify woverify = new WorkOrderVerify();
            woverify.Show();
            
        }
        // Tab 2 Work Order Disposal START BUTTON //
        // When the user Clicks Start the program will select the correct disposal ID from the database based on the users disposal description selection //
        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
             
                if(sqlconnect.State == ConnectionState.Closed)
                {
                    sqlconnect.Open();
                    SqlCommand sqlcmd = new SqlCommand("");
                    
                }

                if(comboBox5.Text == "Passenger + Light Truck With Rim up to 17.5")
                {
                    textBox7.Text = "1";
                    string sqlSelectQuery = "SELECT * FROM DisposalId WHERE DisposalCost = 7.50" + (textBox8.Text);
                    SqlCommand Costcmd = new SqlCommand(sqlSelectQuery, sqlconnect);
                    SqlDataReader dr = Costcmd.ExecuteReader();
                    if (dr.Read())
                    {
                        textBox8.Text = (dr["DisposalCost"].ToString());
                                                
                        MessageBox.Show("Now Enter Quantity Click Total button");
                        
                    }
                }

                if (comboBox5.Text == "Medium Truck Sized Tire With Rim (17.6-24.5)")
                {
                    textBox7.Text = "2";
                    string sqlSelectQuery = "SELECT * FROM DisposalId WHERE DisposalCost = 25.00" + (textBox8.Text);
                    SqlCommand Costcmd = new SqlCommand(sqlSelectQuery, sqlconnect);
                    SqlDataReader dr = Costcmd.ExecuteReader();
                    if (dr.Read())
                    {
                        textBox8.Text = (dr["DisposalCost"].ToString());
                        textBox6.ReadOnly = false;
                        MessageBox.Show("Now Click Total and Save");
                    }
                }

                if (comboBox5.Text == "Passanger Light Truck w/o Rim")
                {
                    textBox7.Text = "3";
                    string sqlSelectQuery = "SELECT * FROM DisposalId WHERE DisposalCost = 2.50" + (textBox8.Text);
                    SqlCommand Costcmd = new SqlCommand(sqlSelectQuery, sqlconnect);
                    SqlDataReader dr = Costcmd.ExecuteReader();
                    if (dr.Read())
                    {
                        textBox8.Text = (dr["DisposalCost"].ToString());
                        textBox6.ReadOnly = false;
                        MessageBox.Show("Now Click Total and Save");
                    }
                }

                if (comboBox5.Text == "Medium Truck Sized Tires Without Rim (17.5-24.5)")
                {
                    textBox7.Text = "4";
                    string sqlSelectQuery = "SELECT * FROM DisposalId WHERE DisposalCost = 10.00" + (textBox8.Text);
                    SqlCommand Costcmd = new SqlCommand(sqlSelectQuery, sqlconnect);
                    SqlDataReader dr = Costcmd.ExecuteReader();
                    if (dr.Read())
                    {
                        textBox8.Text = (dr["DisposalCost"].ToString());
                        textBox6.ReadOnly = false;
                        MessageBox.Show("Now Click Total and Save");
                    }
                }

                if (comboBox5.Text == "Duplex 355/80R20/385/85R22.5")
                {
                    textBox7.Text = "5";
                    string sqlSelectQuery = "SELECT * FROM DisposalId WHERE DisposalCost = 10.00" + (textBox8.Text);
                    SqlCommand Costcmd = new SqlCommand(sqlSelectQuery, sqlconnect);
                    SqlDataReader dr = Costcmd.ExecuteReader();
                    if (dr.Read())
                    {
                        textBox8.Text = (dr["DisposalCost"].ToString());
                        textBox6.ReadOnly = false;
                        MessageBox.Show("Now Click Total and Save");
                    }
                }

                if (comboBox5.Text == "21L24")
                {
                    textBox7.Text = "6";
                    string sqlSelectQuery = "SELECT * FROM DisposalId WHERE DisposalCost = 30.00" + (textBox8.Text);
                    SqlCommand Costcmd = new SqlCommand(sqlSelectQuery, sqlconnect);
                    SqlDataReader dr = Costcmd.ExecuteReader();
                    if (dr.Read())
                    {
                        textBox8.Text = (dr["DisposalCost"].ToString());
                        textBox6.ReadOnly = false;
                        MessageBox.Show("Now Click Total and Save");
                    }
                }

                if (comboBox5.Text == "15.5 / 20.5-25")
                {
                    textBox7.Text = "7";
                    string sqlSelectQuery = "SELECT * FROM DisposalId WHERE DisposalCost = 30.00" + (textBox8.Text);
                    SqlCommand Costcmd = new SqlCommand(sqlSelectQuery, sqlconnect);
                    SqlDataReader dr = Costcmd.ExecuteReader();
                    if (dr.Read())
                    {
                        textBox8.Text = (dr["DisposalCost"].ToString());
                        textBox6.ReadOnly = false;
                        MessageBox.Show("Now Click Total and Save");
                    }
                }

                if (comboBox5.Text == "1400-24")
                {
                    textBox7.Text = "8";
                    string sqlSelectQuery = "SELECT * FROM DisposalId WHERE DisposalCost = 30.00" + (textBox8.Text);
                    SqlCommand Costcmd = new SqlCommand(sqlSelectQuery, sqlconnect);
                    SqlDataReader dr = Costcmd.ExecuteReader();
                    if (dr.Read())
                    {
                        textBox8.Text = (dr["DisposalCost"].ToString());
                        textBox6.ReadOnly = false;
                        MessageBox.Show("Now Click Total and Save");
                    }
                }

                if (comboBox5.Text == "Agricultural (18.4X28, 31-13.5X15, 16.9X30)")
                {
                    textBox7.Text = "9";
                    string sqlSelectQuery = "SELECT * FROM DisposalId WHERE DisposalCost = 35.00" + (textBox8.Text);
                    SqlCommand Costcmd = new SqlCommand(sqlSelectQuery, sqlconnect);
                    SqlDataReader dr = Costcmd.ExecuteReader();
                    if (dr.Read())
                    {
                        textBox8.Text = (dr["DisposalCost"].ToString());
                        textBox6.ReadOnly = false;
                        MessageBox.Show("Now Click Total and Save");
                    }
                }

                if (comboBox5.Text == "Tires per Ton Taken to All American Recycling Location")
                {
                    textBox7.Text = "10";
                    string sqlSelectQuery = "SELECT * FROM DisposalId WHERE DisposalCost = 125.00" + (textBox8.Text);
                    SqlCommand Costcmd = new SqlCommand(sqlSelectQuery, sqlconnect);
                    SqlDataReader dr = Costcmd.ExecuteReader();
                    if (dr.Read())
                    {
                        textBox8.Text = (dr["DisposalCost"].ToString());
                        textBox6.ReadOnly = false;
                        MessageBox.Show("Now Click Total and Save");
                    }
                }

                if (comboBox5.Text == "Mix Load  of Scrap Tires Picked up by All American Recycling")
                {
                    textBox7.Text = "11";
                    string sqlSelectQuery = "SELECT * FROM DisposalId WHERE DisposalCost = 127.00" + (textBox8.Text);
                    SqlCommand Costcmd = new SqlCommand(sqlSelectQuery, sqlconnect);
                    SqlDataReader dr = Costcmd.ExecuteReader();
                    if (dr.Read())
                    {
                        textBox8.Text = (dr["DisposalCost"].ToString());
                        textBox6.ReadOnly = false;
                        MessageBox.Show("Now Click Total and Save");
                    }
                }

                if (comboBox5.Text == "Mix Load of Scrap Tires Picked up by Liberty Tire Recycling")
                {
                    textBox7.Text = "12";
                    string sqlSelectQuery = "SELECT * FROM DisposalId WHERE DisposalCost = 325.00" + (textBox8.Text);
                    SqlCommand Costcmd = new SqlCommand(sqlSelectQuery, sqlconnect);
                    SqlDataReader dr = Costcmd.ExecuteReader();
                    if (dr.Read())
                    {
                        textBox8.Text = (dr["DisposalCost"].ToString());
                        textBox6.ReadOnly = false;
                        MessageBox.Show("Now Click Total and Save");
                    }
                }

                if (comboBox5.Text == "TV's/CRT's  Picked up by Goodwill")
                {
                    textBox7.Text = "13";
                    string sqlSelectQuery = "SELECT * FROM DisposalId WHERE DisposalCost = 13.25" + (textBox8.Text);
                    SqlCommand Costcmd = new SqlCommand(sqlSelectQuery, sqlconnect);
                    SqlDataReader dr = Costcmd.ExecuteReader();
                    if (dr.Read())
                    {
                        textBox8.Text = (dr["DisposalCost"].ToString());
                        textBox6.ReadOnly = false;
                        MessageBox.Show("Now Click Total and Save");
                    }
                }
                sqlconnect.Close();
            }
            catch (Exception ex) 
            {
                MessageBox.Show("test failed");
                
            }
                        
        }
        // Tab 2 Work Order Disposal SAVE BUTTON //
        // When users hit save the data will be saved to Database //

        private void button9_Click(object sender, EventArgs e)
        {
            
            sqlconnect.Open();
            SqlCommand cmd = sqlconnect.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into [WorkOrderDisposal] (WorkOrderId,DisposalID,Quantity) values ('"+ comboBox6.Text +"','" + textBox7.Text + "','"+ textBox6.Text +"')";
            cmd.ExecuteNonQuery();
            sqlconnect.Close();
            comboBox6.Text = "";
            textBox7.Text = "";
            textBox6.Text = "";
            MessageBox.Show("Work Order Disposal Saved Successfully");
        }
        // Tab 2 Back Button
        private void button10_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
            button1.Visible = true;
            this.workOrderTableAdapter1.Fill(this.disposalDashboardDatabaseDataSet3.WorkOrder);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            decimal quantity = Convert.ToDecimal(textBox6.Text);
            decimal disposalcost = Convert.ToDecimal(textBox8.Text);
            textBox9.Text = Convert.ToString(quantity * disposalcost);
        }

        private void label29_Click(object sender, EventArgs e)
        {

        }
    }
}
