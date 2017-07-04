namespace FormToForm
{
    partial class SuccessForm
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
            this.FNamelabel = new System.Windows.Forms.Label();
            this.LNameLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Coral;
            this.label1.Location = new System.Drawing.Point(92, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Yess!!!";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // FNamelabel
            // 
            this.FNamelabel.AutoSize = true;
            this.FNamelabel.Location = new System.Drawing.Point(166, 213);
            this.FNamelabel.Name = "FNamelabel";
            this.FNamelabel.Size = new System.Drawing.Size(0, 13);
            this.FNamelabel.TabIndex = 1;
            // 
            // LNameLbl
            // 
            this.LNameLbl.AutoSize = true;
            this.LNameLbl.Location = new System.Drawing.Point(166, 256);
            this.LNameLbl.Name = "LNameLbl";
            this.LNameLbl.Size = new System.Drawing.Size(0, 13);
            this.LNameLbl.TabIndex = 2;
            // 
            // SuccessForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 345);
            this.Controls.Add(this.LNameLbl);
            this.Controls.Add(this.FNamelabel);
            this.Controls.Add(this.label1);
            this.Name = "SuccessForm";
            this.Text = "SuccessForm";
            this.Load += new System.EventHandler(this.SuccessForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label FNamelabel;
        private System.Windows.Forms.Label LNameLbl;
    }
}