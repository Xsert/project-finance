
namespace FamilyLifePlan
{
    partial class AddAgents
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.profile = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.picture = new System.Windows.Forms.Button();
            this.filePath = new System.Windows.Forms.TextBox();
            this.AgentName = new System.Windows.Forms.TextBox();
            this.Position = new System.Windows.Forms.TextBox();
            this.Address = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ContactNo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.AgentID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profile)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(416, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(335, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.AgentID);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.ContactNo);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Address);
            this.groupBox1.Controls.Add(this.Position);
            this.groupBox1.Controls.Add(this.AgentName);
            this.groupBox1.Controls.Add(this.filePath);
            this.groupBox1.Controls.Add(this.picture);
            this.groupBox1.Controls.Add(this.profile);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(13, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(478, 226);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // profile
            // 
            this.profile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.profile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.profile.Location = new System.Drawing.Point(6, 19);
            this.profile.Name = "profile";
            this.profile.Size = new System.Drawing.Size(168, 157);
            this.profile.TabIndex = 0;
            this.profile.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // picture
            // 
            this.picture.BackColor = System.Drawing.Color.Transparent;
            this.picture.Location = new System.Drawing.Point(148, 182);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(26, 22);
            this.picture.TabIndex = 3;
            this.picture.Text = "Upload";
            this.picture.UseVisualStyleBackColor = false;
            this.picture.Click += new System.EventHandler(this.picture_Click);
            // 
            // filePath
            // 
            this.filePath.BackColor = System.Drawing.Color.White;
            this.filePath.Location = new System.Drawing.Point(54, 182);
            this.filePath.Name = "filePath";
            this.filePath.Size = new System.Drawing.Size(88, 20);
            this.filePath.TabIndex = 4;
            // 
            // AgentName
            // 
            this.AgentName.Location = new System.Drawing.Point(275, 55);
            this.AgentName.Name = "AgentName";
            this.AgentName.Size = new System.Drawing.Size(194, 20);
            this.AgentName.TabIndex = 5;
            // 
            // Position
            // 
            this.Position.Location = new System.Drawing.Point(275, 88);
            this.Position.Name = "Position";
            this.Position.Size = new System.Drawing.Size(194, 20);
            this.Position.TabIndex = 6;
            // 
            // Address
            // 
            this.Address.Location = new System.Drawing.Point(275, 120);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(194, 20);
            this.Address.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(201, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(201, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Position";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(200, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(200, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Contact No.";
            // 
            // ContactNo
            // 
            this.ContactNo.Location = new System.Drawing.Point(275, 156);
            this.ContactNo.Name = "ContactNo";
            this.ContactNo.Size = new System.Drawing.Size(194, 20);
            this.ContactNo.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "File Path:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(201, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Agent ID";
            // 
            // AgentID
            // 
            this.AgentID.Location = new System.Drawing.Point(275, 26);
            this.AgentID.Name = "AgentID";
            this.AgentID.Size = new System.Drawing.Size(194, 20);
            this.AgentID.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(353, 262);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "label7";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AddAgents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 282);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "AddAgents";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Address;
        private System.Windows.Forms.TextBox Position;
        private System.Windows.Forms.TextBox AgentName;
        private System.Windows.Forms.TextBox filePath;
        private System.Windows.Forms.Button picture;
        private System.Windows.Forms.PictureBox profile;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox AgentID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ContactNo;
        private System.Windows.Forms.Label label7;
    }
}