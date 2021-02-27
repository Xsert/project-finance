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
using System.Drawing.Printing;

namespace FamilyLifePlan
{
    public partial class prntFile : Form
    {
        public int month = (int)System.DateTime.Now.Month;
        public int day = (int)System.DateTime.Now.DayOfWeek;
        Form2 frm = new Form2();
        public prntFile()
        {
            InitializeComponent();
            populate();
            if (day >= 15 && day <= 21)
            {
                prntPrev.Enabled = true;
                MessageBox.Show("PRINT ENABLED");
            }

        }

        private void dbPlanholder_Click(object sender, EventArgs e)
        { 
            
        }

        private void prntFile_Load(object sender, EventArgs e)
        {

        }

        private void prntPrev_Click(object sender, EventArgs e)
        {
            PrintDialog printPrv = new PrintDialog();
            printPrv.ShowDialog();
        }

        //method to populate labels
        private void populate()
        {
            DateTime getDate = DateTime.Now;
         
            datePrinted.Text = getDate.ToString();
            agentName.Text = frm.getText;
            switch (month)
            {
                case 1: dateEncode.Text = "JAN"; break;
                case 2: dateEncode.Text = "FEB"; break;
                case 3: dateEncode.Text = "MAR"; break;
                case 4: dateEncode.Text = "APR"; break;
                case 5: dateEncode.Text = "MAY"; break;
                case 6: dateEncode.Text = "JUN"; break;
                case 7: dateEncode.Text = "JUL"; break;
                case 8: dateEncode.Text = "AUG"; break;
                case 9: dateEncode.Text = "SEPT"; break;
                case 10: dateEncode.Text = "OCT"; break;
                case 11: dateEncode.Text = "NOV"; break;
                case 12: dateEncode.Text = "DEC"; break;
            }
          
        }

 
    }
}
