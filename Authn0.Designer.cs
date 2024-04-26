namespace Green_house_chikale
{
    partial class AuthnFrom
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Min_btn = new System.Windows.Forms.Button();
            this.Close_btn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.signin2 = new Green_house_chikale.Signin();
            this.signup2 = new Green_house_chikale.Signup();
            this.NoAcc_btn = new System.Windows.Forms.LinkLabel();
            this.ReadyAcc_btn = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Min_btn);
            this.panel1.Controls.Add(this.Close_btn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(820, 41);
            this.panel1.TabIndex = 0;
            // 
            // Min_btn
            // 
            this.Min_btn.FlatAppearance.BorderSize = 0;
            this.Min_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Min_btn.ForeColor = System.Drawing.Color.Ivory;
            this.Min_btn.Image = global::Green_house_chikale.Properties.Resources.icons8_horizontal_line_18px;
            this.Min_btn.Location = new System.Drawing.Point(695, -1);
            this.Min_btn.Name = "Min_btn";
            this.Min_btn.Size = new System.Drawing.Size(58, 42);
            this.Min_btn.TabIndex = 1;
            this.Min_btn.Text = " ";
            this.Min_btn.UseVisualStyleBackColor = true;
            this.Min_btn.Click += new System.EventHandler(this.Min_btn_Click);
            // 
            // Close_btn
            // 
            this.Close_btn.FlatAppearance.BorderSize = 0;
            this.Close_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close_btn.ForeColor = System.Drawing.Color.Ivory;
            this.Close_btn.Image = global::Green_house_chikale.Properties.Resources.icons8_Close_18px;
            this.Close_btn.Location = new System.Drawing.Point(759, 0);
            this.Close_btn.Name = "Close_btn";
            this.Close_btn.Size = new System.Drawing.Size(58, 42);
            this.Close_btn.TabIndex = 1;
            this.Close_btn.Text = " ";
            this.Close_btn.UseVisualStyleBackColor = true;
            this.Close_btn.Click += new System.EventHandler(this.Close_btn_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.signin2);
            this.panel2.Controls.Add(this.signup2);
            this.panel2.Location = new System.Drawing.Point(0, 41);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(820, 531);
            this.panel2.TabIndex = 1;
            // 
            // signin2
            // 
            this.signin2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.signin2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.signin2.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signin2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.signin2.Location = new System.Drawing.Point(0, 0);
            this.signin2.Name = "signin2";
            this.signin2.Size = new System.Drawing.Size(820, 531);
            this.signin2.TabIndex = 1;
            // 
            // signup2
            // 
            this.signup2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.signup2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.signup2.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signup2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.signup2.Location = new System.Drawing.Point(0, 0);
            this.signup2.Name = "signup2";
            this.signup2.Size = new System.Drawing.Size(820, 531);
            this.signup2.TabIndex = 0;
            // 
            // NoAcc_btn
            // 
            this.NoAcc_btn.AutoSize = true;
            this.NoAcc_btn.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.NoAcc_btn.LinkColor = System.Drawing.Color.Gray;
            this.NoAcc_btn.Location = new System.Drawing.Point(282, 579);
            this.NoAcc_btn.Name = "NoAcc_btn";
            this.NoAcc_btn.Size = new System.Drawing.Size(58, 17);
            this.NoAcc_btn.TabIndex = 2;
            this.NoAcc_btn.TabStop = true;
            this.NoAcc_btn.Text = "Register";
            this.NoAcc_btn.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.NoAcc_btn_LinkClicked);
            // 
            // ReadyAcc_btn
            // 
            this.ReadyAcc_btn.AutoSize = true;
            this.ReadyAcc_btn.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.ReadyAcc_btn.LinkColor = System.Drawing.Color.Gray;
            this.ReadyAcc_btn.Location = new System.Drawing.Point(485, 579);
            this.ReadyAcc_btn.Name = "ReadyAcc_btn";
            this.ReadyAcc_btn.Size = new System.Drawing.Size(49, 17);
            this.ReadyAcc_btn.TabIndex = 3;
            this.ReadyAcc_btn.TabStop = true;
            this.ReadyAcc_btn.Text = "Sign in";
            this.ReadyAcc_btn.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ReadyAcc_btn_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(337, 575);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "|";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(466, 575);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "|";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel1.LinkColor = System.Drawing.Color.Gray;
            this.linkLabel1.Location = new System.Drawing.Point(352, 578);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(123, 17);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Forgot Password?";
            // 
            // AuthnFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.ClientSize = new System.Drawing.Size(820, 621);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ReadyAcc_btn);
            this.Controls.Add(this.NoAcc_btn);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Ivory;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AuthnFrom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Authn";
            this.Load += new System.EventHandler(this.Authn_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Close_btn;
        private System.Windows.Forms.Button Min_btn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.LinkLabel NoAcc_btn;
        private System.Windows.Forms.LinkLabel ReadyAcc_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private Signin signin2;
        private Signup signup2;
    }

}
