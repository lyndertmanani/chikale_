﻿namespace Green_house_chikale
{
    partial class Startup
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Errorsx = new System.Windows.Forms.Label();
            this.Reconnect_btn = new System.Windows.Forms.LinkLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.ForestGreen;
            this.label1.Location = new System.Drawing.Point(146, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Green";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(275, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 50);
            this.label2.TabIndex = 0;
            this.label2.Text = "House";
            // 
            // Errorsx
            // 
            this.Errorsx.AutoSize = true;
            this.Errorsx.Font = new System.Drawing.Font("Arial", 10.2F);
            this.Errorsx.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Errorsx.Location = new System.Drawing.Point(228, 193);
            this.Errorsx.Name = "Errorsx";
            this.Errorsx.Size = new System.Drawing.Size(14, 19);
            this.Errorsx.TabIndex = 1;
            this.Errorsx.Text = " ";
            // 
            // Reconnect_btn
            // 
            this.Reconnect_btn.AutoSize = true;
            this.Reconnect_btn.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reconnect_btn.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.Reconnect_btn.LinkColor = System.Drawing.Color.SeaGreen;
            this.Reconnect_btn.Location = new System.Drawing.Point(187, 144);
            this.Reconnect_btn.Name = "Reconnect_btn";
            this.Reconnect_btn.Size = new System.Drawing.Size(156, 19);
            this.Reconnect_btn.TabIndex = 2;
            this.Reconnect_btn.TabStop = true;
            this.Reconnect_btn.Text = "Click to Reconnect..";
            this.Reconnect_btn.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Reconnect_btn_LinkClicked);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::Green_house_chikale.Properties.Resources.icons8_Close_18px_1;
            this.button1.Location = new System.Drawing.Point(507, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(69, 33);
            this.button1.TabIndex = 3;
            this.button1.Text = " ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = global::Green_house_chikale.Properties.Resources.icons8_horizontal_line_18px_1;
            this.button2.Location = new System.Drawing.Point(434, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(69, 33);
            this.button2.TabIndex = 3;
            this.button2.Text = " ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Startup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 265);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Reconnect_btn);
            this.Controls.Add(this.Errorsx);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Startup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Startup";
            this.Load += new System.EventHandler(this.Startup_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Errorsx;
        private System.Windows.Forms.LinkLabel Reconnect_btn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}