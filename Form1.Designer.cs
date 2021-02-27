
namespace FamilyLifePlan
{
    partial class Form1
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
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblPrnt = new System.Windows.Forms.Label();
            this.textPass = new System.Windows.Forms.TextBox();
            this.textUser = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(181, 233);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(67, 23);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "LOGIN";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblPrnt
            // 
            this.lblPrnt.AutoSize = true;
            this.lblPrnt.Location = new System.Drawing.Point(178, 191);
            this.lblPrnt.Name = "lblPrnt";
            this.lblPrnt.Size = new System.Drawing.Size(70, 13);
            this.lblPrnt.TabIndex = 1;
            this.lblPrnt.Text = "PASSWORD";
            this.lblPrnt.Click += new System.EventHandler(this.lblPrnt_Click);
            // 
            // textPass
            // 
            this.textPass.Location = new System.Drawing.Point(116, 207);
            this.textPass.Name = "textPass";
            this.textPass.PasswordChar = '*';
            this.textPass.Size = new System.Drawing.Size(205, 20);
            this.textPass.TabIndex = 2;
            // 
            // textUser
            // 
            this.textUser.Location = new System.Drawing.Point(116, 159);
            this.textUser.Name = "textUser";
            this.textUser.Size = new System.Drawing.Size(205, 20);
            this.textUser.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(197, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "USER";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 300);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textUser);
            this.Controls.Add(this.textPass);
            this.Controls.Add(this.lblPrnt);
            this.Controls.Add(this.btnLogin);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblPrnt;
        private System.Windows.Forms.TextBox textPass;
        private System.Windows.Forms.TextBox textUser;
        private System.Windows.Forms.Label label1;
    }
}

