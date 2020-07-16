namespace StudentVoting
{
    partial class Candidate
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
            this.lblName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblName.Location = new System.Drawing.Point(1, 12);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(65, 22);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "label1";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(21)))), ((int)(((byte)(3)))));
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Location = new System.Drawing.Point(-1, 312);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(347, 48);
            this.panel1.TabIndex = 2;
            // 
            // Candidate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.panel1);
            this.Name = "Candidate";
            this.Size = new System.Drawing.Size(337, 366);
            this.Load += new System.EventHandler(this.Candidate_Load);
            this.Click += new System.EventHandler(this.Candidate_Click);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Candidate_MouseClick);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Panel panel1;
    }
}
