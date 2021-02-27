using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FamilyLifePlan
{
    public partial class FullList : Form
    {
        
        public FullList()
        {
            InitializeComponent();
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'clientsDataSet3.Client_Information' table. You can move, or remove it, as needed.
            this.client_InformationTableAdapter.Fill(this.clientInfo.Client_Information);




        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Update();
            dataGridView1.Refresh();
        }

    }
}
