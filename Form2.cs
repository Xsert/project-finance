using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using FamilyLifePlan;
using System.Windows.Forms;

namespace FamilyLifePlan
{
    public partial class Form2 : Form
    {
        private const string conString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:/Clients.accdb";
        readonly OleDbConnection con = new OleDbConnection(conString);
        OleDbCommand cmd;
        OleDbDataAdapter adapter;
        readonly DataTable dt = new DataTable();
        public String agent;
        public int balance, cbi, quota, inst=1,age=0, orNo,colDue,colAdv, paid;
        public string date = DateTime.Now.ToShortDateString();
        public Byte by;
        BindingSource bs = new BindingSource();
        public int getPaid
        { 
            get 
            {
                return paid;
            }
        }
        public string getText
        {
            get
            {
                return agent;

            }
        }
        public Form2()
        {
            InitializeComponent();
      
            bs.DataSource = collectionBindingSource;
            dataGridView1.DataSource = bs;
            //SELECTION MODE
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
        }
        private void load()
        {
            foreach (DataRow row in dataGridView1.Rows)
            { 
                if (date.Equals(dbDue.ToString()))
                {
                    
                    if (inst >= 13)
                    {
              
                        
                    }

                }
            }
        }
        public void Reload(int a, int b,int c, string d)
        {            
            switch (a)
            {
                case 1:
                    if (b == 1)
                    {
                        cbi = 265;
                        quota = 350;
                        balance = c - quota;
                    }
                    else if (b == 2)
                    {
                        cbi = 795;
                        quota = 1050;
                        balance = c - quota;
                    }
                    else if (b == 3)
                    {
                        cbi = 1590;
                        quota = 2100;
                        balance = c - quota;
                    }
                    else if (b==4)
                    {
                        cbi = 4200;
                        quota = 4200;
                        balance = c - quota;
                    }
                    break;
                case 2:
                    if (b == 1)
                    {
                        cbi = 485;
                        quota = 550;
                        balance = c - quota;
                    }
                    else if (b == 2)
                    {
                        cbi = 1455;
                        quota = 1650;
                        balance = c - quota;
                    }
                    else if (b == 3)
                    {
                        cbi = 2910;
                        quota = 3300;
                        balance = c - quota;
                    }
                    else if (b==4)
                    {
                        cbi = 6600;
                        quota = 6600;
                        balance = c - quota;
                    }
                    break;
                case 3:
                    if (b == 1)
                    {
                        cbi = 570;
                        quota = 650;
                        balance = c - quota;
                    }
                    else if (b == 2)
                    {
                        cbi = 1710;
                        quota = 1950;
                        balance = c - quota;
                    }
                    else if (b == 3)
                    {
                        cbi = 3420;
                        quota = 3900;
                        balance = c - quota;
                    }
                    else if (b==4)
                    {
                        cbi = 7800;
                        quota = 7800;
                        balance = c - quota;
                    }
                    break;
            }
            string upd = " UPDATE Collection " +
                         " SET [Quota Com] = @QUOTA , [Quota nCom] = 0, CBI = @CBI , [Installment Duration] =@INS ," +
                         " Aging = @AGE, Balance =@BAL, Tax = true" +
                         " WHERE(Collection.[Contract Number] LIKE '"+ d +"')";
            cmd = new OleDbCommand(upd, con);
            cmd.Parameters.AddWithValue("@QUOTA",quota);
            cmd.Parameters.AddWithValue("@CBI", cbi);
            cmd.Parameters.AddWithValue("@INS", inst);
            cmd.Parameters.AddWithValue("@AGE", age);
            cmd.Parameters.AddWithValue("@BAL", balance);

            try 
            {
                con.Open();
                if (cmd.ExecuteNonQuery() > 0)
                    MessageBox.Show("Stupidly works!");
                con.Close();
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.StackTrace,ex.Message);
                con.Close();
            }
        }

        private void refreshData()
        {
            bs.ResetBindings(false);
        }
        public void retrieve()
        {
    

           /* dataGridView1.Rows.Clear();
            //SQL STATEMENT
            String sql = "SELECT * FROM Collection ";
            cmd = new OleDbCommand(sql, con);
            try
            {
                con.Open();
                adapter = new OleDbDataAdapter(cmd);
                adapter.Fill(dt);
                //LOOP THROUGH DATATABLE
                foreach (DataRow row in dt.Rows)
                {
                    populate(row[0].ToString(), row[1].ToString(), row[2].ToString());
                }

                con.Close();
                //CLEAR DATATABLE 
                dt.Rows.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }*/
        }


        private void populate(string contractNO, string planholder, string tin)
        {

            dataGridView1.Rows.Add(contractNO, planholder, tin);

        }

        /* public void delete(string contractNo)
         {
             //SQL STATEMENTT
             String sql = "DELETE FROM Collection WHERE [Agent ID] ='" + contractNo + "'";
             cmd = new OleDbCommand(sql, con);

             //'OPEN CONNECTION,EXECUTE DELETE,CLOSE CONNECTION
             try
             {
                 con.Open();
                 adapter = new OleDbDataAdapter(cmd);
                 adapter.DeleteCommand = con.CreateCommand();
                 adapter.DeleteCommand.CommandText = sql;

                 //PROMPT FOR CONFIRMATION BEFORE DELETING
                 if (MessageBox.Show(@"Are you sure to permanently delete this?", @"DELETE", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                 {
                     if (cmd.ExecuteNonQuery() > 0)
                     {
                         MessageBox.Show(@"Successfully deleted");
                     }
                 }
                 con.Close();
                 retrieve();
             }
             catch (Exception ex)
             {
                 MessageBox.Show(ex.Message);
                 con.Close();
             }
         }*/

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void ag_no_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 frw = new Form1();
            frw.Show();
            this.Close();
        }

        private void addAgent_Click(object sender, EventArgs e)
        {
            AddAgents frm = new AddAgents();
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'clientsDataSet1.Collection' table. You can move, or remove it, as needed.
            this.collectionTableAdapter.Fill(this.clientsDataSet1.Collection);
            // TODO: This line of code loads data into the 'agents._Agents' table. You can move, or remove it, as needed.
            this.agentsTableAdapter.Fill(this.agents._Agents);



        }

        private void btnRef_Click_1(object sender, EventArgs e)
        {
            refreshData();

        }



        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            prntFile form = new prntFile();
            form.Show();
        }

        private void btnPrntCol_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            prntFileCol prnt = new prntFileCol();
            prnt.Show();
        }

        private void link_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form list = new FullList();
            list.Show();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            try
            {
                collectionBindingSource.RemoveCurrent();
                collectionBindingSource.EndEdit();
                collectionTableAdapter.Adapter.Update(clientsDataSet1.Collection);
                clientsDataSet1.Collection.AcceptChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No Rows are deleted!", ex.Message);
            }
            /*int selectedIndex = dataGridView1.SelectedRows[0].Index;
            if (selectedIndex != -1)
            {
                String selected = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                string contractNo = selected;
                delete(contractNo);
            }*/
        }
    }
}
