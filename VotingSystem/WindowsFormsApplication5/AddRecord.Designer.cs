namespace WindowsFormsApplication5
{
    partial class AddRecord
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
            this.gbStudentInfo = new System.Windows.Forms.GroupBox();
            this.txtmname = new System.Windows.Forms.TextBox();
            this.txtlname = new System.Windows.Forms.TextBox();
            this.txtfname = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblMiddlename = new System.Windows.Forms.Label();
            this.lblLastname = new System.Windows.Forms.Label();
            this.lbl2Firstname = new System.Windows.Forms.Label();
            this.lblStudenID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtViolation = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.gbStudentInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbStudentInfo
            // 
            this.gbStudentInfo.BackColor = System.Drawing.Color.Transparent;
            this.gbStudentInfo.Controls.Add(this.txtmname);
            this.gbStudentInfo.Controls.Add(this.txtlname);
            this.gbStudentInfo.Controls.Add(this.txtfname);
            this.gbStudentInfo.Controls.Add(this.txtID);
            this.gbStudentInfo.Controls.Add(this.lblMiddlename);
            this.gbStudentInfo.Controls.Add(this.lblLastname);
            this.gbStudentInfo.Controls.Add(this.lbl2Firstname);
            this.gbStudentInfo.Controls.Add(this.lblStudenID);
            this.gbStudentInfo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbStudentInfo.ForeColor = System.Drawing.Color.Maroon;
            this.gbStudentInfo.Location = new System.Drawing.Point(80, 164);
            this.gbStudentInfo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbStudentInfo.Name = "gbStudentInfo";
            this.gbStudentInfo.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbStudentInfo.Size = new System.Drawing.Size(621, 249);
            this.gbStudentInfo.TabIndex = 11;
            this.gbStudentInfo.TabStop = false;
            this.gbStudentInfo.Text = "Student Information ";
            // 
            // txtmname
            // 
            this.txtmname.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmname.Location = new System.Drawing.Point(204, 172);
            this.txtmname.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtmname.Name = "txtmname";
            this.txtmname.Size = new System.Drawing.Size(291, 32);
            this.txtmname.TabIndex = 7;
            // 
            // txtlname
            // 
            this.txtlname.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlname.Location = new System.Drawing.Point(204, 134);
            this.txtlname.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtlname.Name = "txtlname";
            this.txtlname.Size = new System.Drawing.Size(291, 32);
            this.txtlname.TabIndex = 8;
            // 
            // txtfname
            // 
            this.txtfname.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfname.Location = new System.Drawing.Point(204, 95);
            this.txtfname.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtfname.Name = "txtfname";
            this.txtfname.Size = new System.Drawing.Size(291, 32);
            this.txtfname.TabIndex = 7;
            // 
            // txtID
            // 
            this.txtID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtID.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(204, 54);
            this.txtID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(291, 32);
            this.txtID.TabIndex = 6;
            this.txtID.TextChanged += new System.EventHandler(this.txtID_TextChanged);
            this.txtID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtID_KeyPress);
            // 
            // lblMiddlename
            // 
            this.lblMiddlename.AutoSize = true;
            this.lblMiddlename.BackColor = System.Drawing.Color.Transparent;
            this.lblMiddlename.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMiddlename.ForeColor = System.Drawing.Color.Maroon;
            this.lblMiddlename.Location = new System.Drawing.Point(47, 172);
            this.lblMiddlename.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMiddlename.Name = "lblMiddlename";
            this.lblMiddlename.Size = new System.Drawing.Size(134, 23);
            this.lblMiddlename.TabIndex = 3;
            this.lblMiddlename.Text = "Middlename";
            // 
            // lblLastname
            // 
            this.lblLastname.AutoSize = true;
            this.lblLastname.BackColor = System.Drawing.Color.Transparent;
            this.lblLastname.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastname.ForeColor = System.Drawing.Color.Maroon;
            this.lblLastname.Location = new System.Drawing.Point(48, 134);
            this.lblLastname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLastname.Name = "lblLastname";
            this.lblLastname.Size = new System.Drawing.Size(106, 23);
            this.lblLastname.TabIndex = 2;
            this.lblLastname.Text = "Lastname";
            // 
            // lbl2Firstname
            // 
            this.lbl2Firstname.AutoSize = true;
            this.lbl2Firstname.BackColor = System.Drawing.Color.Transparent;
            this.lbl2Firstname.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2Firstname.ForeColor = System.Drawing.Color.Maroon;
            this.lbl2Firstname.Location = new System.Drawing.Point(47, 100);
            this.lbl2Firstname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl2Firstname.Name = "lbl2Firstname";
            this.lbl2Firstname.Size = new System.Drawing.Size(102, 23);
            this.lbl2Firstname.TabIndex = 1;
            this.lbl2Firstname.Text = "Firstname";
            // 
            // lblStudenID
            // 
            this.lblStudenID.AutoSize = true;
            this.lblStudenID.BackColor = System.Drawing.Color.Transparent;
            this.lblStudenID.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudenID.ForeColor = System.Drawing.Color.Maroon;
            this.lblStudenID.Location = new System.Drawing.Point(47, 59);
            this.lblStudenID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStudenID.Name = "lblStudenID";
            this.lblStudenID.Size = new System.Drawing.Size(116, 23);
            this.lblStudenID.TabIndex = 0;
            this.lblStudenID.Text = "Student I.D";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(65, 18);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(302, 57);
            this.label2.TabIndex = 12;
            this.label2.Text = "Add Record";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(69, 432);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 57);
            this.label1.TabIndex = 13;
            this.label1.Text = "VIOLATION";
            // 
            // txtViolation
            // 
            this.txtViolation.Location = new System.Drawing.Point(80, 505);
            this.txtViolation.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtViolation.Multiline = true;
            this.txtViolation.Name = "txtViolation";
            this.txtViolation.Size = new System.Drawing.Size(1025, 175);
            this.txtViolation.TabIndex = 14;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Maroon;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCancel.Location = new System.Drawing.Point(969, 688);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(137, 50);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Maroon;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAdd.Location = new System.Drawing.Point(793, 688);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(168, 50);
            this.btnAdd.TabIndex = 15;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Location = new System.Drawing.Point(793, 178);
            this.panelLogo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(313, 234);
            this.panelLogo.TabIndex = 17;
            // 
            // AddRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelLogo);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtViolation);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gbStudentInfo);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AddRecord";
            this.Size = new System.Drawing.Size(1417, 756);
            this.Load += new System.EventHandler(this.AddRecord_Load);
            this.gbStudentInfo.ResumeLayout(false);
            this.gbStudentInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbStudentInfo;
        private System.Windows.Forms.TextBox txtmname;
        private System.Windows.Forms.TextBox txtlname;
        private System.Windows.Forms.TextBox txtfname;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblMiddlename;
        private System.Windows.Forms.Label lblLastname;
        private System.Windows.Forms.Label lbl2Firstname;
        private System.Windows.Forms.Label lblStudenID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtViolation;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel panelLogo;
    }
}
