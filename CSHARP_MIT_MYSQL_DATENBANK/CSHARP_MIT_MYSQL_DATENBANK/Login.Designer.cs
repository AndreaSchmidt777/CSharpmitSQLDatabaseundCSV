namespace CSHARP_MIT_MYSQL_DATENBANK
{
    partial class Login
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
            this.lblusername = new System.Windows.Forms.Label();
            this.lblpassword = new System.Windows.Forms.Label();
            this.cbUsername = new System.Windows.Forms.ComboBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnAnmelden = new System.Windows.Forms.Button();
            this.btnSchließen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblusername
            // 
            this.lblusername.AutoSize = true;
            this.lblusername.Location = new System.Drawing.Point(129, 67);
            this.lblusername.Name = "lblusername";
            this.lblusername.Size = new System.Drawing.Size(55, 13);
            this.lblusername.TabIndex = 0;
            this.lblusername.Text = "Username";
            // 
            // lblpassword
            // 
            this.lblpassword.AutoSize = true;
            this.lblpassword.Location = new System.Drawing.Point(129, 129);
            this.lblpassword.Name = "lblpassword";
            this.lblpassword.Size = new System.Drawing.Size(53, 13);
            this.lblpassword.TabIndex = 1;
            this.lblpassword.Text = "Password";
            // 
            // cbUsername
            // 
            this.cbUsername.FormattingEnabled = true;
            this.cbUsername.Items.AddRange(new object[] {
            "Administrator",
            "User"});
            this.cbUsername.Location = new System.Drawing.Point(218, 58);
            this.cbUsername.Name = "cbUsername";
            this.cbUsername.Size = new System.Drawing.Size(121, 21);
            this.cbUsername.TabIndex = 2;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(218, 121);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(121, 20);
            this.txtPassword.TabIndex = 3;
            // 
            // btnAnmelden
            // 
            this.btnAnmelden.Location = new System.Drawing.Point(209, 177);
            this.btnAnmelden.Name = "btnAnmelden";
            this.btnAnmelden.Size = new System.Drawing.Size(75, 23);
            this.btnAnmelden.TabIndex = 4;
            this.btnAnmelden.Text = "Anmelden";
            this.btnAnmelden.UseVisualStyleBackColor = true;
            this.btnAnmelden.Click += new System.EventHandler(this.btnAnmelden_Click);
            // 
            // btnSchließen
            // 
            this.btnSchließen.Location = new System.Drawing.Point(309, 177);
            this.btnSchließen.Name = "btnSchließen";
            this.btnSchließen.Size = new System.Drawing.Size(75, 23);
            this.btnSchließen.TabIndex = 5;
            this.btnSchließen.Text = "Schließen";
            this.btnSchließen.UseVisualStyleBackColor = true;
            this.btnSchließen.Click += new System.EventHandler(this.button2_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(503, 286);
            this.Controls.Add(this.btnSchließen);
            this.Controls.Add(this.btnAnmelden);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.cbUsername);
            this.Controls.Add(this.lblpassword);
            this.Controls.Add(this.lblusername);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblusername;
        private System.Windows.Forms.Label lblpassword;
        private System.Windows.Forms.ComboBox cbUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnAnmelden;
        private System.Windows.Forms.Button btnSchließen;
    }
}