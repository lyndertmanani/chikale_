namespace Green_house_chikale.System_properties
{
    partial class Soil
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SearchBox = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.Search_btn = new System.Windows.Forms.Button();
            this.soilData = new System.Windows.Forms.Label();
            this.Soil_title = new System.Windows.Forms.Label();
            this.Errorx = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(383, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Solution";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(267, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(316, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Search of disease and soil Recommendation";
            // 
            // SearchBox
            // 
            this.SearchBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.SearchBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.AllSystemSources;
            this.SearchBox.Location = new System.Drawing.Point(205, 155);
            this.SearchBox.Margin = new System.Windows.Forms.Padding(2);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(440, 34);
            this.SearchBox.StateActive.Content.Font = new System.Drawing.Font("Century Gothic", 16F);
            this.SearchBox.TabIndex = 1;
            this.SearchBox.Text = " ";
            this.SearchBox.Enter += new System.EventHandler(this.SearchBox_Enter);
            // 
            // Search_btn
            // 
            this.Search_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Search_btn.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.Search_btn.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Search_btn.Location = new System.Drawing.Point(656, 155);
            this.Search_btn.Margin = new System.Windows.Forms.Padding(2);
            this.Search_btn.Name = "Search_btn";
            this.Search_btn.Size = new System.Drawing.Size(71, 34);
            this.Search_btn.TabIndex = 2;
            this.Search_btn.Text = "Search";
            this.Search_btn.UseVisualStyleBackColor = true;
            this.Search_btn.Click += new System.EventHandler(this.Search_btn_Click);
            // 
            // soilData
            // 
            this.soilData.BackColor = System.Drawing.SystemColors.Control;
            this.soilData.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.soilData.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.soilData.Location = new System.Drawing.Point(202, 303);
            this.soilData.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.soilData.Name = "soilData";
            this.soilData.Size = new System.Drawing.Size(525, 274);
            this.soilData.TabIndex = 3;
            this.soilData.Text = " search body will display here";
            // 
            // Soil_title
            // 
            this.Soil_title.Font = new System.Drawing.Font("Century Gothic", 12.2F, System.Drawing.FontStyle.Bold);
            this.Soil_title.Location = new System.Drawing.Point(202, 284);
            this.Soil_title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Soil_title.Name = "Soil_title";
            this.Soil_title.Size = new System.Drawing.Size(325, 29);
            this.Soil_title.TabIndex = 4;
            this.Soil_title.Text = " Titles will display hee";
            // 
            // Errorx
            // 
            this.Errorx.AutoSize = true;
            this.Errorx.ForeColor = System.Drawing.Color.Gray;
            this.Errorx.Location = new System.Drawing.Point(203, 191);
            this.Errorx.Name = "Errorx";
            this.Errorx.Size = new System.Drawing.Size(115, 16);
            this.Errorx.TabIndex = 5;
            this.Errorx.Text = "errors Display here";
            // 
            // Soil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.soilData);
            this.Controls.Add(this.Errorx);
            this.Controls.Add(this.Search_btn);
            this.Controls.Add(this.SearchBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Soil_title);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Soil";
            this.Size = new System.Drawing.Size(965, 678);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox SearchBox;
        private System.Windows.Forms.Button Search_btn;
        private System.Windows.Forms.Label soilData;
        private System.Windows.Forms.Label Soil_title;
        private System.Windows.Forms.Label Errorx;
    }
}
