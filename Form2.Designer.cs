
namespace FamilyLifePlan
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.collectionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientsDataSet1 = new FamilyLifePlan.ClientsDataSet1();
            this.button1 = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ag_no = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.btnPrntCol = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.btnRef = new System.Windows.Forms.Button();
            this.link = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.agentName = new System.Windows.Forms.ComboBox();
            this.agentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.agents = new FamilyLifePlan.Agents();
            this.agentsTableAdapter = new FamilyLifePlan.AgentsTableAdapters.AgentsTableAdapter();
            this.addAgent = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.collectionTableAdapter = new FamilyLifePlan.ClientsDataSet1TableAdapters.CollectionTableAdapter();
            this.autoNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dbPlanholder = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dbDue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dbQcom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dbQncom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dbInst = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dbAge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataBal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.collectionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agents)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.autoNum,
            this.dataGridViewTextBoxColumn1,
            this.dbPlanholder,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dbDue,
            this.dbQcom,
            this.dbQncom,
            this.dataGridViewTextBoxColumn10,
            this.dbInst,
            this.dbAge,
            this.dataBal,
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn17});
            this.dataGridView1.DataSource = this.collectionBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(11, 192);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 254);
            this.dataGridView1.TabIndex = 0;
            // 
            // collectionBindingSource
            // 
            this.collectionBindingSource.DataMember = "Collection";
            this.collectionBindingSource.DataSource = this.clientsDataSet1;
            // 
            // clientsDataSet1
            // 
            this.clientsDataSet1.DataSetName = "ClientsDataSet1";
            this.clientsDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(711, 148);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(31, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "SAVE";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnDel
            // 
            this.btnDel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDel.Location = new System.Drawing.Point(673, 148);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(32, 23);
            this.btnDel.TabIndex = 2;
            this.btnDel.Text = "DEL";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Location = new System.Drawing.Point(638, 148);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(29, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "ADD";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(14, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(187, 143);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(207, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "NAME:";
            // 
            // ag_no
            // 
            this.ag_no.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ag_no.AutoSize = true;
            this.ag_no.Location = new System.Drawing.Point(207, 28);
            this.ag_no.Name = "ag_no";
            this.ag_no.Size = new System.Drawing.Size(26, 13);
            this.ag_no.TabIndex = 7;
            this.ag_no.Text = "NO.";
            this.ag_no.Click += new System.EventHandler(this.ag_no_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(207, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "POSITION: ";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(207, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "ADDRESS:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(207, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(206, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "NO. OF CLIENTS";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(397, 151);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(194, 20);
            this.textBox1.TabIndex = 12;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(159, 133);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(41, 37);
            this.button4.TabIndex = 13;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // btnPrntCol
            // 
            this.btnPrntCol.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrntCol.Location = new System.Drawing.Point(748, 149);
            this.btnPrntCol.Name = "btnPrntCol";
            this.btnPrntCol.Size = new System.Drawing.Size(35, 23);
            this.btnPrntCol.TabIndex = 18;
            this.btnPrntCol.Text = "PRNT";
            this.btnPrntCol.UseVisualStyleBackColor = true;
            this.btnPrntCol.Click += new System.EventHandler(this.btnPrntCol_Click_1);
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.Black;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.Red;
            this.linkLabel1.Location = new System.Drawing.Point(206, 157);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(63, 13);
            this.linkLabel1.TabIndex = 19;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Print Report";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // btnRef
            // 
            this.btnRef.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRef.Location = new System.Drawing.Point(597, 148);
            this.btnRef.Name = "btnRef";
            this.btnRef.Size = new System.Drawing.Size(35, 23);
            this.btnRef.TabIndex = 20;
            this.btnRef.Text = "RF";
            this.btnRef.UseVisualStyleBackColor = true;
            this.btnRef.Click += new System.EventHandler(this.btnRef_Click_1);
            // 
            // link
            // 
            this.link.AutoSize = true;
            this.link.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.link.ForeColor = System.Drawing.Color.DodgerBlue;
            this.link.Location = new System.Drawing.Point(11, 176);
            this.link.Name = "link";
            this.link.Size = new System.Drawing.Size(47, 13);
            this.link.TabIndex = 21;
            this.link.Text = "Full list...";
            this.link.Click += new System.EventHandler(this.link_Click);
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Location = new System.Drawing.Point(308, 28);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(35, 13);
            this.ID.TabIndex = 22;
            this.ID.Text = "label6";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(308, 80);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "label8";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(308, 106);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "label9";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(308, 133);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 13);
            this.label10.TabIndex = 26;
            this.label10.Text = "label10";
            // 
            // agentName
            // 
            this.agentName.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.agentsBindingSource, "Agent Name", true));
            this.agentName.DataSource = this.agentsBindingSource;
            this.agentName.DisplayMember = "Agent Name";
            this.agentName.FormattingEnabled = true;
            this.agentName.Location = new System.Drawing.Point(311, 51);
            this.agentName.Name = "agentName";
            this.agentName.Size = new System.Drawing.Size(181, 21);
            this.agentName.TabIndex = 27;
            // 
            // agentsBindingSource
            // 
            this.agentsBindingSource.DataMember = "Agents";
            this.agentsBindingSource.DataSource = this.agents;
            // 
            // agents
            // 
            this.agents.DataSetName = "Agents";
            this.agents.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // agentsTableAdapter
            // 
            this.agentsTableAdapter.ClearBeforeFill = true;
            // 
            // addAgent
            // 
            this.addAgent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addAgent.Location = new System.Drawing.Point(673, 28);
            this.addAgent.Name = "addAgent";
            this.addAgent.Size = new System.Drawing.Size(110, 39);
            this.addAgent.TabIndex = 28;
            this.addAgent.Text = "ADD AGENTS";
            this.addAgent.UseVisualStyleBackColor = true;
            this.addAgent.Click += new System.EventHandler(this.addAgent_Click);
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button5.Location = new System.Drawing.Point(673, 73);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(110, 39);
            this.button5.TabIndex = 29;
            this.button5.Text = "LOGOUT";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // collectionTableAdapter
            // 
            this.collectionTableAdapter.ClearBeforeFill = true;
            // 
            // autoNum
            // 
            this.autoNum.DataPropertyName = "Contract Number";
            this.autoNum.HeaderText = "#";
            this.autoNum.Name = "autoNum";
            this.autoNum.Width = 39;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Contract Number";
            this.dataGridViewTextBoxColumn1.HeaderText = "Contract Number";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 103;
            // 
            // dbPlanholder
            // 
            this.dbPlanholder.DataPropertyName = "Planholder";
            this.dbPlanholder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dbPlanholder.HeaderText = "Planholder";
            this.dbPlanholder.MinimumWidth = 150;
            this.dbPlanholder.Name = "dbPlanholder";
            this.dbPlanholder.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dbPlanholder.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dbPlanholder.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "TIN ID";
            this.dataGridViewTextBoxColumn4.HeaderText = "TIN ID";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 50;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Plan";
            this.dataGridViewTextBoxColumn5.HeaderText = "Plan";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn5.Width = 53;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Effective Date";
            this.dataGridViewTextBoxColumn6.HeaderText = "Effective Date";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 92;
            // 
            // dbDue
            // 
            this.dbDue.DataPropertyName = "Due Date";
            this.dbDue.HeaderText = "Due Date";
            this.dbDue.Name = "dbDue";
            this.dbDue.Width = 72;
            // 
            // dbQcom
            // 
            this.dbQcom.DataPropertyName = "Quota Com";
            this.dbQcom.HeaderText = "Quota Com";
            this.dbQcom.Name = "dbQcom";
            this.dbQcom.Width = 78;
            // 
            // dbQncom
            // 
            this.dbQncom.DataPropertyName = "Quota nCom";
            this.dbQncom.HeaderText = "Quota nCom";
            this.dbQncom.Name = "dbQncom";
            this.dbQncom.Width = 84;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "CBI";
            this.dataGridViewTextBoxColumn10.HeaderText = "CBI";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Width = 49;
            // 
            // dbInst
            // 
            this.dbInst.DataPropertyName = "Installment Duration";
            this.dbInst.HeaderText = "Installment Duration";
            this.dbInst.Name = "dbInst";
            this.dbInst.Width = 114;
            // 
            // dbAge
            // 
            this.dbAge.DataPropertyName = "Aging";
            this.dbAge.HeaderText = "Aging";
            this.dbAge.Name = "dbAge";
            this.dbAge.Width = 59;
            // 
            // dataBal
            // 
            this.dataBal.DataPropertyName = "Balance";
            this.dataBal.HeaderText = "Balance";
            this.dataBal.Name = "dataBal";
            this.dataBal.Width = 71;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "Tax";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Tax";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.Width = 31;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "OR Number";
            this.dataGridViewTextBoxColumn14.HeaderText = "OR Number";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.Width = 81;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "OR Date";
            this.dataGridViewTextBoxColumn15.HeaderText = "OR Date";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.Width = 69;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "Collection Due";
            this.dataGridViewTextBoxColumn16.HeaderText = "Collection Due";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.Width = 93;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "Collection Advance";
            this.dataGridViewTextBoxColumn17.HeaderText = "Collection Advance";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.Width = 114;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(800, 458);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.addAgent);
            this.Controls.Add(this.agentName);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.link);
            this.Controls.Add(this.btnRef);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.btnPrntCol);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ag_no);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form2";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.collectionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ag_no;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button4;
 
        private System.Windows.Forms.DataGridViewTextBoxColumn contractNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn planHolderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tINIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn planDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn decriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn effectiveDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dueDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quotaComDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quotaNComDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cBIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn installmentDurationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn agingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn balanceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn taxDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oRNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oRDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn collectionDueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn collectionAdvanceDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnPrntCol;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Button btnRef;
        private System.Windows.Forms.Label link;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox agentName;
        private Agents agents;
        private System.Windows.Forms.BindingSource agentsBindingSource;
        private AgentsTableAdapters.AgentsTableAdapter agentsTableAdapter;
        private System.Windows.Forms.Button addAgent;
        private System.Windows.Forms.Button button5;
        private ClientsDataSet1 clientsDataSet1;
        private System.Windows.Forms.BindingSource collectionBindingSource;
        private ClientsDataSet1TableAdapters.CollectionTableAdapter collectionTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn autoNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewButtonColumn dbPlanholder;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dbDue;
        private System.Windows.Forms.DataGridViewTextBoxColumn dbQcom;
        private System.Windows.Forms.DataGridViewTextBoxColumn dbQncom;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dbInst;
        private System.Windows.Forms.DataGridViewTextBoxColumn dbAge;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataBal;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.Timer timer1;
    }
}