namespace Green_house_chikale
{
    partial class Signup
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Signup_btn = new System.Windows.Forms.Button();
            this.Password = new ComponentFactory.Krypton.Toolkit.KryptonMaskedTextBox();
            this.Email = new ComponentFactory.Krypton.Toolkit.KryptonMaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Firstname = new ComponentFactory.Krypton.Toolkit.KryptonMaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Surname = new ComponentFactory.Krypton.Toolkit.KryptonMaskedTextBox();
            this.SuspendLayout();
            // 
            // Signup_btn
            // 
            this.Signup_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Signup_btn.Font = new System.Drawing.Font("Century Gothic", 8.8F);
            this.Signup_btn.ForeColor = System.Drawing.Color.DarkGray;
            this.Signup_btn.Location = new System.Drawing.Point(321, 467);
            this.Signup_btn.Name = "Signup_btn";
            this.Signup_btn.Size = new System.Drawing.Size(175, 42);
            this.Signup_btn.TabIndex = 18;
            this.Signup_btn.Text = "Sign up";
            this.Signup_btn.UseVisualStyleBackColor = true;
            this.Signup_btn.Click += new System.EventHandler(this.Signup_btn_Click);
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(167, 390);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(491, 46);
            this.Password.StateActive.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.Password.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.Password.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Password.StateActive.Border.Rounding = 40;
            this.Password.StateActive.Content.Color1 = System.Drawing.Color.Gainsboro;
            this.Password.StateActive.Content.Padding = new System.Windows.Forms.Padding(15, -1, -1, -1);
            this.Password.TabIndex = 16;
            this.Password.Tag = "Password";
            // 
            // Email
            // 
            this.Email.Location = new System.Drawing.Point(167, 306);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(491, 46);
            this.Email.StateActive.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.Email.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.Email.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Email.StateActive.Border.Rounding = 40;
            this.Email.StateActive.Content.Color1 = System.Drawing.Color.Gainsboro;
            this.Email.StateActive.Content.Padding = new System.Windows.Forms.Padding(15, -1, -1, -1);
            this.Email.TabIndex = 17;
            this.Email.Tag = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(189, 367);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(189, 283);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(317, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "The Green House System";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 30F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(297, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 59);
            this.label1.TabIndex = 15;
            this.label1.Text = "Chikale ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(189, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Firstname";
            // 
            // Firstname
            // 
            this.Firstname.Location = new System.Drawing.Point(167, 222);
            this.Firstname.Name = "Firstname";
            this.Firstname.Size = new System.Drawing.Size(234, 46);
            this.Firstname.StateActive.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.Firstname.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.Firstname.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Firstname.StateActive.Border.Rounding = 40;
            this.Firstname.StateActive.Content.Color1 = System.Drawing.Color.Gainsboro;
            this.Firstname.StateActive.Content.Padding = new System.Windows.Forms.Padding(15, -1, -1, -1);
            this.Firstname.TabIndex = 17;
            this.Firstname.Tag = "Firstname";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(431, 199);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Surname";
            // 
            // Surname
            // 
            this.Surname.Location = new System.Drawing.Point(421, 222);
            this.Surname.Name = "Surname";
            this.Surname.Size = new System.Drawing.Size(237, 46);
            this.Surname.StateActive.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.Surname.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.Surname.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Surname.StateActive.Border.Rounding = 40;
            this.Surname.StateActive.Content.Color1 = System.Drawing.Color.Gainsboro;
            this.Surname.StateActive.Content.Padding = new System.Windows.Forms.Padding(15, -1, -1, -1);
            this.Surname.TabIndex = 17;
            this.Surname.Tag = "Surname";
            // 
            // Signup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.Controls.Add(this.Signup_btn);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Surname);
            this.Controls.Add(this.Firstname);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Name = "Signup";
            this.Size = new System.Drawing.Size(820, 531);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Signup_btn;
        private ComponentFactory.Krypton.Toolkit.KryptonMaskedTextBox Password;
        private ComponentFactory.Krypton.Toolkit.KryptonMaskedTextBox Email;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private ComponentFactory.Krypton.Toolkit.KryptonMaskedTextBox Firstname;
        private System.Windows.Forms.Label label6;
        private ComponentFactory.Krypton.Toolkit.KryptonMaskedTextBox Surname;
    }
}
