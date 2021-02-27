using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FamilyLifePlan
{
    public partial class prntFileCol : Form
    {
        public prntFileCol()
        {
            InitializeComponent();
            Form2 getName = new Form2();
            string get = getName.getText;
            agentName.Text = get;
            DateTime getDate = DateTime.Now;
            string currentMonth = DateTime.Now.Month.ToString();
            string currentYear = DateTime.Now.Year.ToString();
            switch (currentMonth)
            {
                case "1": currentMonth = "January"; break;
                case "2": currentMonth = "February"; break;
                case "3": currentMonth = "March"; break;
                case "4": currentMonth = "April"; break;
                case "5": currentMonth = "May"; break;
                case "6": currentMonth = "June"; break;
                case "7": currentMonth = "July"; break;
                case "8": currentMonth = "August"; break;
                case "9": currentMonth = "September"; break;
                case "10": currentMonth = "October"; break;
                case "11": currentMonth = "November"; break;
                case "12": currentMonth = "December"; break;
            }

            datePrinted.Text = getDate.ToString();
            getMonth.Text = currentMonth + " " + currentYear;
        }


        private void prntFileCol_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'clientsDataSet1.Collection' table. You can move, or remove it, as needed.
            this.collectionTableAdapter.Fill(this.clientsDataSet1.Collection);


        }

        private void prntPrev_Click(object sender, EventArgs e)
        {
            PrintDialog prntPrv = new PrintDialog();
            prntPrv.ShowDialog();
        }
    }
}
