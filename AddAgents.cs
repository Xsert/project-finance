using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FamilyLifePlan
{
    public partial class AddAgents : Form
    {
        private const string conString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:/Clients.accdb";
        readonly OleDbConnection con = new OleDbConnection(conString);
        OleDbCommand cmd;
        OleDbDataAdapter adapter;

        FileStream fs;
        BinaryReader br;
        byte[] ImageData;
       
        public AddAgents()
        {
            InitializeComponent();
            label7.Text = DateTime.Now.ToString();
           
        }

        private void picture_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image files (*.jpg,*.png,*.bitmap,*.jpeg,*.img)|*.jpg;*.png;*.bitmap;*.jpeg;*.img";
            openFileDialog1.FilterIndex = 6;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filePath.Text = openFileDialog1.FileName;
                profile.SizeMode = PictureBoxSizeMode.StretchImage;
                profile.Image = new Bitmap(openFileDialog1.FileName);
                fs = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read);
                br = new BinaryReader(fs);
                ImageData = br.ReadBytes((int)fs.Length);
                br.Close();
                fs.Close();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            DateTime d = DateTime.Now;
            string date = d.ToShortDateString();
            string an = AgentName.Text;
            string pos = Position.Text;
            string conta = ContactNo.Text;
            string add = Address.Text;
            string sql =  " INSERT INTO Agents ([Agent Name], [Position],[Contact Number],Address," +
                          " [Date Employed], Picture)" +
                          " VALUES(@AN, @POS,@CON,@ADD,@DATE, @PIC)";
            cmd = new OleDbCommand(sql,con);

            cmd.Parameters.AddWithValue("@AN", an);
            cmd.Parameters.AddWithValue("@POS", pos);
            cmd.Parameters.AddWithValue("@CON", conta);
            cmd.Parameters.AddWithValue("@ADD", add);
            cmd.Parameters.AddWithValue("@DATE", date);
            cmd.Parameters.AddWithValue("@PIC", ImageData);

            try
            {
                con.Open();
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("AGENT ADDED");
                    this.Close();
                }
                con.Close();
            }
            catch (Exception ex)
            { 
                MessageBox.Show(ex.StackTrace,ex.Message);
                con.Close();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
