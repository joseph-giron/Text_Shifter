namespace XOR_By
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.tbTextIn = new System.Windows.Forms.TextBox();
            this.btnShiftBy = new System.Windows.Forms.Button();
            this.tbShiftBy = new System.Windows.Forms.TextBox();
            this.tbTextOut = new System.Windows.Forms.TextBox();
            this.cbShifter = new System.Windows.Forms.ComboBox();
            this.cvt = new System.ComponentModel.BackgroundWorker();
            this.lblLength = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbTextIn
            // 
            this.tbTextIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTextIn.Location = new System.Drawing.Point(12, 12);
            this.tbTextIn.Multiline = true;
            this.tbTextIn.Name = "tbTextIn";
            this.tbTextIn.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbTextIn.Size = new System.Drawing.Size(330, 176);
            this.tbTextIn.TabIndex = 0;
            // 
            // btnShiftBy
            // 
            this.btnShiftBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShiftBy.Location = new System.Drawing.Point(237, 195);
            this.btnShiftBy.Name = "btnShiftBy";
            this.btnShiftBy.Size = new System.Drawing.Size(105, 23);
            this.btnShiftBy.TabIndex = 3;
            this.btnShiftBy.Text = "Shift By Value";
            this.btnShiftBy.UseVisualStyleBackColor = true;
            this.btnShiftBy.Click += new System.EventHandler(this.btnXorBy_Click);
            // 
            // tbShiftBy
            // 
            this.tbShiftBy.Location = new System.Drawing.Point(163, 196);
            this.tbShiftBy.Name = "tbShiftBy";
            this.tbShiftBy.Size = new System.Drawing.Size(68, 20);
            this.tbShiftBy.TabIndex = 2;
            // 
            // tbTextOut
            // 
            this.tbTextOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTextOut.Location = new System.Drawing.Point(12, 225);
            this.tbTextOut.Multiline = true;
            this.tbTextOut.Name = "tbTextOut";
            this.tbTextOut.ReadOnly = true;
            this.tbTextOut.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbTextOut.Size = new System.Drawing.Size(330, 176);
            this.tbTextOut.TabIndex = 4;
            // 
            // cbShifter
            // 
            this.cbShifter.FormattingEnabled = true;
            this.cbShifter.Items.AddRange(new object[] {
            "XOR",
            "OR",
            "AND",
            "Bitwise Compliment",
            "Left Shift",
            "Right Shift"});
            this.cbShifter.Location = new System.Drawing.Point(12, 196);
            this.cbShifter.Name = "cbShifter";
            this.cbShifter.Size = new System.Drawing.Size(145, 21);
            this.cbShifter.TabIndex = 1;
            // 
            // cvt
            // 
            this.cvt.DoWork += new System.ComponentModel.DoWorkEventHandler(this.cvt_DoWork);
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLength.Location = new System.Drawing.Point(12, 408);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(54, 13);
            this.lblLength.TabIndex = 5;
            this.lblLength.Text = "Length: ";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 430);
            this.Controls.Add(this.lblLength);
            this.Controls.Add(this.cbShifter);
            this.Controls.Add(this.tbShiftBy);
            this.Controls.Add(this.btnShiftBy);
            this.Controls.Add(this.tbTextOut);
            this.Controls.Add(this.tbTextIn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.Text = "Text Shifter By AverageJoe";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbTextIn;
        private System.Windows.Forms.Button btnShiftBy;
        private System.Windows.Forms.TextBox tbShiftBy;
        private System.Windows.Forms.TextBox tbTextOut;
        private System.Windows.Forms.ComboBox cbShifter;
        private System.ComponentModel.BackgroundWorker cvt;
        private System.Windows.Forms.Label lblLength;
    }
}

