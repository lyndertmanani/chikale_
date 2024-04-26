namespace Green_house_chikale.Authn
{
    partial class Dashboard
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
            this.Close_btn = new System.Windows.Forms.Button();
            this.Min_btn = new System.Windows.Forms.Button();
            this.ControlsPanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.soil1 = new Green_house_chikale.System_properties.Soil();
            this.overview1 = new Green_house_chikale.System_properties.Overview();
            this.task1 = new Green_house_chikale.System_properties.Task();
            this.ControlsPanel.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // Close_btn
            // 
            this.Close_btn.FlatAppearance.BorderSize = 0;
            this.Close_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close_btn.Image = global::Green_house_chikale.Properties.Resources.icons8_Close_18px_1;
            this.Close_btn.Location = new System.Drawing.Point(882, 1);
            this.Close_btn.Name = "Close_btn";
            this.Close_btn.Size = new System.Drawing.Size(85, 40);
            this.Close_btn.TabIndex = 1;
            this.Close_btn.Text = " ";
            this.Close_btn.UseVisualStyleBackColor = true;
            this.Close_btn.Click += new System.EventHandler(this.Close_btn_Click);
            // 
            // Min_btn
            // 
            this.Min_btn.FlatAppearance.BorderSize = 0;
            this.Min_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Min_btn.Image = global::Green_house_chikale.Properties.Resources.icons8_horizontal_line_18px_1;
            this.Min_btn.Location = new System.Drawing.Point(791, 0);
            this.Min_btn.Name = "Min_btn";
            this.Min_btn.Size = new System.Drawing.Size(85, 40);
            this.Min_btn.TabIndex = 1;
            this.Min_btn.Text = " ";
            this.Min_btn.UseVisualStyleBackColor = true;
            // 
            // ControlsPanel
            // 
            this.ControlsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.ControlsPanel.Controls.Add(this.panel2);
            this.ControlsPanel.Controls.Add(this.panel1);
            this.ControlsPanel.Controls.Add(this.label3);
            this.ControlsPanel.Controls.Add(this.button5);
            this.ControlsPanel.Controls.Add(this.label2);
            this.ControlsPanel.Controls.Add(this.label1);
            this.ControlsPanel.Controls.Add(this.button6);
            this.ControlsPanel.Controls.Add(this.button2);
            this.ControlsPanel.Controls.Add(this.button3);
            this.ControlsPanel.Controls.Add(this.button1);
            this.ControlsPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.ControlsPanel.Location = new System.Drawing.Point(0, 0);
            this.ControlsPanel.Name = "ControlsPanel";
            this.ControlsPanel.Size = new System.Drawing.Size(255, 716);
            this.ControlsPanel.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Location = new System.Drawing.Point(12, 373);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(150, 1);
            this.panel2.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Location = new System.Drawing.Point(20, 164);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(150, 1);
            this.panel1.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.label3.Font = new System.Drawing.Font("Century Gothic", 8.2F);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label3.Location = new System.Drawing.Point(14, 348);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "Settings";
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.button5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button5.Image = global::Green_house_chikale.Properties.Resources.icons8_logout_25px;
            this.button5.Location = new System.Drawing.Point(-32, 435);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(265, 43);
            this.button5.TabIndex = 0;
            this.button5.Text = "Log out";
            this.button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8.2F);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label2.Location = new System.Drawing.Point(22, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Menu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(24, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Green house";
            // 
            // button6
            // 
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.button6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button6.Image = global::Green_house_chikale.Properties.Resources.icons8_settings_25px;
            this.button6.Location = new System.Drawing.Point(-32, 386);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(265, 43);
            this.button6.TabIndex = 0;
            this.button6.Text = "Settings";
            this.button6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Image = global::Green_house_chikale.Properties.Resources.icons8_ground_25px;
            this.button2.Location = new System.Drawing.Point(-22, 289);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(265, 43);
            this.button2.TabIndex = 0;
            this.button2.Text = "Soil research";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Image = global::Green_house_chikale.Properties.Resources.icons8_clipboard_list_25px_1;
            this.button3.Location = new System.Drawing.Point(-17, 240);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(250, 43);
            this.button3.TabIndex = 0;
            this.button3.Text = "Available task";
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Image = global::Green_house_chikale.Properties.Resources.icons8_home_25px;
            this.button1.Location = new System.Drawing.Point(-22, 188);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(265, 43);
            this.button1.TabIndex = 0;
            this.button1.Text = "Overview";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.Close_btn);
            this.panel3.Controls.Add(this.Min_btn);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(255, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(965, 42);
            this.panel3.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.task1);
            this.panel4.Controls.Add(this.soil1);
            this.panel4.Controls.Add(this.overview1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(255, 42);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(965, 674);
            this.panel4.TabIndex = 4;
            // 
            // soil1
            // 
            this.soil1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soil1.Location = new System.Drawing.Point(0, 0);
            this.soil1.Margin = new System.Windows.Forms.Padding(6);
            this.soil1.Name = "soil1";
            this.soil1.Size = new System.Drawing.Size(965, 678);
            this.soil1.TabIndex = 1;
            // 
            // overview1
            // 
            this.overview1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.overview1.Location = new System.Drawing.Point(2, 0);
            this.overview1.Margin = new System.Windows.Forms.Padding(4);
            this.overview1.Name = "overview1";
            this.overview1.Size = new System.Drawing.Size(965, 674);
            this.overview1.TabIndex = 0;
            // 
            // task1
            // 
            this.task1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.task1.Location = new System.Drawing.Point(-5, 0);
            this.task1.Margin = new System.Windows.Forms.Padding(4);
            this.task1.Name = "task1";
            this.task1.Size = new System.Drawing.Size(3681, 2588);
            this.task1.TabIndex = 2;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1220, 716);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.ControlsPanel);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.ControlsPanel.ResumeLayout(false);
            this.ControlsPanel.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Close_btn;
        private System.Windows.Forms.Button Min_btn;
        private System.Windows.Forms.Panel ControlsPanel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System_properties.Overview overview1;
        private System_properties.Soil soil1;
        private System_properties.Task task1;
    }
}