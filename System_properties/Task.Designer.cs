namespace Green_house_chikale.System_properties
{
    partial class Task
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Duties = new System.Windows.Forms.MonthCalendar();
            this.Members = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Members)).BeginInit();
            this.SuspendLayout();
            // 
            // Duties
            // 
            this.Duties.CalendarDimensions = new System.Drawing.Size(2, 3);
            this.Duties.Location = new System.Drawing.Point(31, 23);
            this.Duties.Name = "Duties";
            this.Duties.TabIndex = 1;
            // 
            // Members
            // 
            this.Members.BackgroundColor = System.Drawing.SystemColors.Control;
            this.Members.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Members.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 6.8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Members.DefaultCellStyle = dataGridViewCellStyle2;
            this.Members.GridColor = System.Drawing.SystemColors.Control;
            this.Members.Location = new System.Drawing.Point(501, 23);
            this.Members.Name = "Members";
            this.Members.RowHeadersWidth = 51;
            this.Members.RowTemplate.Height = 24;
            this.Members.Size = new System.Drawing.Size(344, 437);
            this.Members.TabIndex = 2;
            this.Members.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.Members_CellFormatting);
            // 
            // Task
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Members);
            this.Controls.Add(this.Duties);
            this.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Task";
            this.Size = new System.Drawing.Size(965, 678);
            this.Load += new System.EventHandler(this.Task_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Members)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MonthCalendar Duties;
        private System.Windows.Forms.DataGridView Members;
    }
}
