using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Extract;
using FamilyLifePlan;
using System.Windows.Forms;

namespace FamilyLifePlan
{
  

    public partial class Form3 : Form
    {
        Form2 frm = new Form2();
        //CONNECTION STRING COMMAND FOR OLEDB
        private const string conString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:/Clients.accdb";
        readonly OleDbConnection con = new OleDbConnection(conString);
        OleDbCommand cmd;
        OleDbDataAdapter adapter;
        readonly DataTable dt = new DataTable();
        //END CONNECTION STRING COMMAND
        //PUBLIC VAR
        public string plan, gender, resident, status,modP;
        public int planType, count, gcount, ind,daysDue;
        public bool i;
        //END OF PUBLIC VAR

        //CHOOSING PLAN TYPE PAYMENT
        //MONTHLY
        private void checkMon_CheckedChanged(object sender, EventArgs e)
        {
            planType = 1;
            modP = "MONTHLY";
            daysDue = 60;
            textBox5.Text = "5";
            switch (count)
            {
                case 1:
                    totalPay.Text = "350";
                    break;

                case 2:
                    totalPay.Text = "550";
                    break;

                case 3:
                    totalPay.Text = "650";
                    break;
            }
            spotCash.Checked = false;
            checkAnn.Checked = false;
            checkSemi.Checked = false;
            checkQuar.Checked = false;
        }
        //QUARTERLY
        private void checkQuar_CheckedChanged(object sender, EventArgs e)
        {
            planType = 2;
            daysDue= 120;
            modP = "QUARTERLY";
            textBox5.Text = "5";
            switch (count)
            {
                case 1:
                    totalPay.Text = "1050";
                    break;

                case 2:
                    totalPay.Text = "1650";
                    break;

                case 3:
                    totalPay.Text = "1950";
                    break;
            }
            spotCash.Checked = false;
            checkAnn.Checked = false;
            checkSemi.Checked = false;
            checkMon.Checked = false;
        }
        //SEMI ANNUAL
        private void checkSemi_CheckedChanged(object sender, EventArgs e)
        {
            planType = 3;
            daysDue = 180;
            modP = "SEMI-ANNUAL";
            textBox5.Text = "5";
            switch (count)
            {
                case 1:
                    totalPay.Text = "2100";
                    break;

                case 2:
                    totalPay.Text = "3300";
                    break;

                case 3:
                    totalPay.Text = "3900";
                    break;
            }
            spotCash.Checked = false;
            checkAnn.Checked = false;
            checkMon.Checked = false;
            checkQuar.Checked = false;
        }
        //ANNUAL
        private void checkAnn_CheckedChanged(object sender, EventArgs e)
        {
            textBox5.Text = "5";
            daysDue = 365;
            modP = "ANNUAL";
            planType = 4;
            switch (count)
            {
                case 1:
                    totalPay.Text = "4200";
                    break;

                case 2:
                    totalPay.Text = "6600";
                    break;

                case 3:
                    totalPay.Text = "7800";
                    break;
            }
            spotCash.Checked = false;
            checkMon.Checked = false;
            checkSemi.Checked = false;
            checkQuar.Checked = false;


        }
        //SPOTCASH
        private void spotCash_CheckedChanged(object sender, EventArgs e)
        {
            textBox5.Clear();
            modP = "ON_CASH";
            switch (count)
            {
                case 1: totalPay.Text = "21000"; break;
                case 2: totalPay.Text = "33000"; break;
                case 3: totalPay.Text = "39000"; break;
                default: totalPay.Clear(); break;
            }
            checkMon.Checked = false;
            checkSemi.Checked = false;
            checkQuar.Checked = false;
            checkAnn.Checked = false;
        }
        // END OF CHOOSING PLAN TYPE PAYMENT

        //CHOOSING GENDER
        private void Male(object sender, EventArgs e)
            {
            gender = "M";
            gcount = 1;
            checkFemale.CheckState = CheckState.Unchecked;
        }
        private void Female(object sender, EventArgs e)
        {
            gender = "F";
            gcount = 2;
            checkMale.CheckState = CheckState.Unchecked;
        }
        //END CHOOSING GENDER


        //CHOOSING STATUS
        //RESIDENT STATUS
        private void res_Click(object sender, EventArgs e)
        {
            resident = "RESIDENT";
        }
        private void nres_Click(object sender, EventArgs e)
        {
            resident = "NON-RESIDENT";
        }
     
        //END OF RESIDENT STATUS
        //CIVIL STATUS
        private void single_Click(object sender, EventArgs e)
        {
            status = "SINGLE";
        }
        private void married_Click(object sender, EventArgs e)
        {
            status = "MARRIED";
        }
        private void divann_Click(object sender, EventArgs e)
        {
            status = "DIVORCED/ANNULLED";
        }
        private void wid_Click(object sender, EventArgs e)
        {
            if(gcount == 2)
                status = "WIDOW";
            if(gcount == 1)
                status = "WIDOWER";
        }
        //END OF CIVIL STATUS
        //END OF CHOOSING STATUS
        public Form3()
        {
            InitializeComponent();
            checkMon.Enabled = false;
            checkAnn.Enabled = false;
            checkSemi.Enabled = false;
            checkQuar.Enabled = false;
        }
        private void Form3_Load(object sender, EventArgs e)
        {
           
        }

        private void checkBox10_Click(object sender, EventArgs e) 
        {
                i = true;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        //START DB QUERY
        private void button1_Click(object sender, EventArgs e)
        {
            //ASSIGNED VALUES FOR QUERY
            String agent = agent_name.Text;
            String contractNO = contract_no.Text;
            String last = lname.Text;
            String first = fname.Text;
            String mid = mname.Text;
            String nationality = natTxt.Text;
            String cont = contactNo.Text;
            String email = emailTxt.Text;
            int years = Int32.Parse(ageYTxt.Text);
            String plc = plcBirth.Text;
            String months = ageMTxt.Text;
            String days = ageDTxt.Text;
            int height = Int32.Parse(heightTxt.Text);
            int weight = Int32.Parse(weightTxt.Text);
            String occu = occupTxt.Text;
            String empl = emplrName.Text;
            String stat = statTxt.Text;
            String planholder = last + " " + first + " " + mid;
            int tin = Int32.Parse(tinID.Text);
            String card = cardTxt.Text;
            String src = altSrc.Text;
            String bfname = bfName.Text;
            String bsname = bsName.Text;
            String btname = btName.Text;
            String bfage = bfAge.Text;
            String bsage = bsAge.Text;
            String btage = btAge.Text;
            String bfrel = bfRel.Text;
            String bsrel = bsRel.Text;
            String btrel = btRel.Text;
            //String birth = birthDate.Value.ToShortDateString();
            //String nat = naturalization.Value.ToShortDateString();
            String st = streetTxt.Text;
            String br = barangayTxt.Text;
            String ct = cityTxt.Text;
            String pr = provinceTxt.Text;
            String zp = zipTxt.Text;
            String add = zp + " " + st + " " + br + ", " + ct + ", " + pr;
            String beni = bfname + ", " + bsname + "," + btname;
            string price = contPrice.Text;
            string pay = totalPay.Text;
            bool ins = i;
            int contract = Int32.Parse(contPrice.Text);
            int total = Int32.Parse(totalPay.Text);
            DateTime signed = DateTime.Now;
            DateTime due = signed.AddDays(daysDue);
            string dateS = signed.ToShortDateString();
            string dueTime = due.ToShortDateString();
            string nat = naturalization.Value.ToShortDateString();
            string birth = birthDate.Value.ToShortDateString();





            //CONNECTION STRING 
            string sql = " INSERT INTO [Client Information] ([Contract Number], Plan, [Contract Price], TotPayable, [Mode of Payment], Insurable, [Installment Due],[First Name],[Middle Name],[Last Name],Address, " +
                         " Nationality,[Date of Naturalization], [Contact Number], Email, [Date of Birth], [Place of Birth], Age, Sex, Height, Weight, [Civil Status], Occupation, [Employer Name], [Status of employment]," +
                         " [TIN ID],[GSIS SSS], [Source Fund], [Agent Name], Beneficiaries, [Date Signed:]) " +
                         " VALUES(@CONTRACTNO,@PLAN, @CONP, @TP, @MP,@IS, @DUE, @FNAME,@MNAME,@LNAME,@ADD,@NATIONALITY,@NATURAL, @CONTACT, @EMAIL,@BIRTH, @PLACE,@AGE,@SEX," +
                         " @HEIGHT,@WEIGHT, @CSTATUS,@OCCUP,@EMPLY,@STATUS,@TIN,@CARD,@SRCF, @AGENT, @BEN, @SIGNED)";

            cmd = new OleDbCommand(sql, con);
            //ADD PARAMS
            cmd.Parameters.AddWithValue("@CONTRACTNO", contractNO); 
            cmd.Parameters.AddWithValue("@PLAN", plan);
            cmd.Parameters.AddWithValue("@CONP", contract);
            cmd.Parameters.AddWithValue("@TP", total);
            cmd.Parameters.AddWithValue("@MP", modP);
            cmd.Parameters.AddWithValue("@INS", ins);
            cmd.Parameters.AddWithValue("@DUE", dueTime);
            cmd.Parameters.AddWithValue("@LNAME", last);
            cmd.Parameters.AddWithValue("@FNAME", first);
            cmd.Parameters.AddWithValue("@MNAME", mid);
            cmd.Parameters.AddWithValue("@ADD", add);
            cmd.Parameters.AddWithValue("@NATIONALITY", nationality);
            cmd.Parameters.AddWithValue("@NATURAL", nat);
            cmd.Parameters.AddWithValue("@CONTACT", cont);
            cmd.Parameters.AddWithValue("@EMAIL", email);
            cmd.Parameters.AddWithValue("@BIRTH", birth);
            cmd.Parameters.AddWithValue("@PLACE", plc);
            cmd.Parameters.AddWithValue("@AGE", years);
            cmd.Parameters.AddWithValue("@SEX", gender);
            cmd.Parameters.AddWithValue("@HEIGHT", height);
            cmd.Parameters.AddWithValue("@WEIGHT", weight);
            cmd.Parameters.AddWithValue("@CSTATUS", status);
            cmd.Parameters.AddWithValue("@OCCUP", occu);
            cmd.Parameters.AddWithValue("@EMPLY", empl);
            cmd.Parameters.AddWithValue("@STATUS", stat);
            cmd.Parameters.AddWithValue("@TIN", tin);
            cmd.Parameters.AddWithValue("@CARD", card);
            cmd.Parameters.AddWithValue("@SRCF", src);
            cmd.Parameters.AddWithValue("@AGENT", agent);
            cmd.Parameters.AddWithValue("@BEN", beni);
            cmd.Parameters.AddWithValue("@SIGNED",dateS );
            //OPEN CON AND EXEC INSERT
            try
            {
                con.Open();
                if (cmd.ExecuteNonQuery() > 0)
                {
                    ind += 1;
                    //clearTxts();
                    //INDICATOR FOR SUCCESSFUL QUERY 
                    cmd.Parameters.Clear();
                    address(st, br, ct, pr, zp, contractNO);
                    queryCollection(agent,contractNO,planholder, tin, plan, dueTime, dateS);
                    switch (ind)
                    {
                        case 2: MessageBox.Show("Insert Failed on Collection!"); ; break;
                        case 3: MessageBox.Show("DATA SUCCESSFULLY INSERTED!"); ; break;
                    }
                    
                    frm.Reload(count,planType,contract);
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            } //END FOR CLIENT QUERY
        } //END FOR CLIENT INFO QUERY METHOD 

        //METHOD ADDRESS QUERY
        public void address(String st, String br, String ct, String pr, String zp, String cont)
        {
            //ASSIGNED VALUES
            String lot = lotNo.Text;
            st = streetTxt.Text;
            String sub = subdivision.Text;
            br = barangayTxt.Text;
            ct = cityTxt.Text;
            String dis = districtTxt.Text;
            pr = provinceTxt.Text;
            zp = zipTxt.Text;
            String off = officeTxt.Text;
            String offadd = offAdd.Text;



            //STRING CONNECTION
            string sql1 = " INSERT INTO Address ([Contract Number], [Lot #], Street, Subdivision, Barangay," +
                          " City, District, Province, [Zip code], Office, [Office Address]) " +
                          " VALUES (@CON,@LOT, @STREET, @SUB, @BAR, @CITY, @DIS,@PROV,@ZIP, @OFF,OFFADD)";
            cmd = new OleDbCommand(sql1, con);

            //ADD PARAM
            cmd.Parameters.AddWithValue("@CON", cont);
            cmd.Parameters.AddWithValue("@LOT", lot);
            cmd.Parameters.AddWithValue("@STREET", st);
            cmd.Parameters.AddWithValue("@SUB", sub);
            cmd.Parameters.AddWithValue("@BAR", br);
            cmd.Parameters.AddWithValue("@CITY", ct);
            cmd.Parameters.AddWithValue("@DIS", dis);
            cmd.Parameters.AddWithValue("@PROV", pr);
            cmd.Parameters.AddWithValue("@ZIP", zp);
            cmd.Parameters.AddWithValue("@OFF", off);
            cmd.Parameters.AddWithValue("@OFFADD", offadd);
            ind += 1;
            cmd.ExecuteNonQuery();
            //END FOR QUERYING ADDRESS
        }//END FOR METHOD FOR QUERYING ADDRESS
        //METHOD ADDRESS COLLECTION
        public void queryCollection(string an,string cn, string ph, int tin, string plan, string date, string efdate)
            {
            cmd.Parameters.Clear();
            string sql2 = " INSERT INTO Collection ([Agent Name],[Contract Number],Planholder," +
                          " [TIN ID],Plan, [Due Date], [Effective Date]) " +
                          " VALUES(@AG, @CON,@PH,@TIN,@PLAN,@DUE, @DATE)";
            cmd = new OleDbCommand(sql2, con);

            cmd.Parameters.AddWithValue("@AG", an);
            cmd.Parameters.AddWithValue("@CON",cn);
            cmd.Parameters.AddWithValue("@PH", ph);
            cmd.Parameters.AddWithValue("@TIN", tin);
            cmd.Parameters.AddWithValue("@PLAN", plan);
            cmd.Parameters.AddWithValue("@DUE", date);
            cmd.Parameters.AddWithValue("@DATE", efdate);
            ind += 1;
            cmd.ExecuteNonQuery();
        }//END OF COLLECTION QUERY 

        //Future references for multiple entry to add
        private void clearTxts()
        {

        }

        //Cancel button
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Value button for fast testing
        // QUICK FILL
        private void testBtn_Click(object sender, EventArgs e)
        {
            const int A = 1000;
            const int B = 99999;
            Random rnd = new Random();
            int v = rnd.Next(A, B);
            //Fill client data plan
            plan = "LUKE";
            planLuk.Checked = true;
            modP = "ANNUALLY";
            checkAnn.Checked = true; 
            totalPay.Text = "7800";
            contPrice.Text = "39000";
            i = true;
            checkBox10.Checked = true;
            //End client data plan
            //Fill client info
            agent_name.Text = "Delro";
            contract_no.Text = v.ToString();
            lname.Text = "SANTOSIDAD";
            fname.Text = "RAYMUND  ";
            mname.Text = "BOLASO";
            //address section
            lotNo.Text="35";
            streetTxt.Text="Sayre Highway";
            subdivision.Text="N/A";
            barangayTxt.Text="Lumbo";
            cityTxt.Text="VALENCIA";
            districtTxt.Text="4";
            provinceTxt.Text="Bukidnon";
            zipTxt.Text="8709";
            officeTxt.Text="N/A";
            offAdd.Text="N/A";
            //end of address section
            //additional info
            natTxt.Text = "FILIPINO";
            contactNo.Text = "09966722929";
            gender = "M";
            checkMale.Checked = true;
            resident = "RESIDENT";
            checkRes.Checked = true;
            status = "SINGLE";
            checkSingle.Checked = true;
            emailTxt.Text = "raymundsantosidad@yahoo.com";
            ageYTxt.Text = "20";
            plcBirth.Text = "BATANGAN";
            ageMTxt.Text = "10";
            ageDTxt.Text = "24";
            heightTxt.Text = "168";
            weightTxt.Text = "51";
            occupTxt.Text = "STUDENT";
            emplrName.Text = "N/A";
            statTxt.Text="N/A";
            //String planholder = last + " " + first + " " + mid;
            tinID.Text = "654321";
            cardTxt.Text = "1234";
            altSrc.Text = "ALLOWANCE";
            bfName.Text ="HA LEEHA";
            bsName.Text ="KAZUMA SATOROU";
            btName.Text ="HAN XIAO";
            bfAge.Text ="26";
            bsAge.Text ="16";
            btAge.Text ="26";
            bfRel.Text ="TUTOR";
            bsRel.Text ="TEAM MEMBER";
            btRel.Text = "COMMANDER";
            //end of addtional info
            //end of fill client info
        }//END OF QUICK FILL
         
        // CHOOSING PLAN TYPE
        //PLAN MATTHEW
        private void planMat_CheckedChanged_1(object sender, EventArgs e)
        {
            contPrice.Text = "21000";
            plan = "MATTHEW";
            count = 1;
            checkMon.Checked = false;
            checkSemi.Checked = false;
            checkQuar.Checked = false;
            checkAnn.Checked = false;
            totalPay.Clear();
            checkMon.Enabled = true;
            checkAnn.Enabled = true;
            checkSemi.Enabled = true;
            checkQuar.Enabled = true;
        }

        //PLAN LUKE
        private void planLuk_CheckedChanged(object sender, EventArgs e)
        {
            contPrice.Text = "39000";
            plan = "LUKE";
            count = 3;
            checkMon.Checked = false;
            checkSemi.Checked = false;
            checkQuar.Checked = false;
            checkAnn.Checked = false;
            totalPay.Clear();
            checkMon.Enabled = true;
            checkAnn.Enabled = true;
            checkSemi.Enabled = true;
            checkQuar.Enabled = true;
        }
        //PLAN MARK
        private void planMar_CheckedChanged(object sender, EventArgs e)
        {
            contPrice.Text = "33000";
            plan = "MARK";
            count = 2;
            checkMon.Checked = false;
            checkSemi.Checked = false;
            checkQuar.Checked = false;
            checkAnn.Checked = false;
            totalPay.Clear();
            checkMon.Enabled = true;
            checkAnn.Enabled = true;
            checkSemi.Enabled = true;
            checkQuar.Enabled = true;
        } //END OF CHOOSING PLAN TYPE

    } // END OF CLASS FORM
} //END OF PROGRAM

