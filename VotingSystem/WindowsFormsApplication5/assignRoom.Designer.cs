namespace WindowsFormsApplication5
{
    partial class assignRoom
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
            this.cmbRoom = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtTotalStudent = new System.Windows.Forms.TextBox();
            this.txtYearLevel = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtOther = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.txtmname = new System.Windows.Forms.TextBox();
            this.txtlname = new System.Windows.Forms.TextBox();
            this.txtfname = new System.Windows.Forms.TextBox();
            this.lblMiddlename = new System.Windows.Forms.Label();
            this.lblLastname = new System.Windows.Forms.Label();
            this.lbl2Firstname = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbRoom
            // 
            this.cmbRoom.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cmbRoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRoom.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbRoom.FormattingEnabled = true;
            this.cmbRoom.Location = new System.Drawing.Point(299, 562);
            this.cmbRoom.Margin = new System.Windows.Forms.Padding(4);
            this.cmbRoom.Name = "cmbRoom";
            this.cmbRoom.Size = new System.Drawing.Size(292, 29);
            this.cmbRoom.TabIndex = 38;
            this.cmbRoom.SelectedIndexChanged += new System.EventHandler(this.cmbRoom_SelectedIndexChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Maroon;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(695, 691);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(170, 38);
            this.btnAdd.TabIndex = 36;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtTotalStudent
            // 
            this.txtTotalStudent.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalStudent.Location = new System.Drawing.Point(299, 638);
            this.txtTotalStudent.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotalStudent.Name = "txtTotalStudent";
            this.txtTotalStudent.ReadOnly = true;
            this.txtTotalStudent.Size = new System.Drawing.Size(296, 30);
            this.txtTotalStudent.TabIndex = 35;
            // 
            // txtYearLevel
            // 
            this.txtYearLevel.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYearLevel.Location = new System.Drawing.Point(299, 494);
            this.txtYearLevel.Margin = new System.Windows.Forms.Padding(4);
            this.txtYearLevel.Name = "txtYearLevel";
            this.txtYearLevel.ReadOnly = true;
            this.txtYearLevel.Size = new System.Drawing.Size(291, 30);
            this.txtYearLevel.TabIndex = 34;
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(299, 257);
            this.txtId.Margin = new System.Windows.Forms.Padding(4);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(291, 30);
            this.txtId.TabIndex = 33;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Maroon;
            this.label6.Location = new System.Drawing.Point(109, 645);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 23);
            this.label6.TabIndex = 31;
            this.label6.Text = "Total Student";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Maroon;
            this.label5.Location = new System.Drawing.Point(109, 568);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 23);
            this.label5.TabIndex = 30;
            this.label5.Text = "Room";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(109, 501);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 23);
            this.label4.TabIndex = 29;
            this.label4.Text = "Year level";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(104, 258);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 23);
            this.label3.TabIndex = 28;
            this.label3.Text = "Student I.D";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(104, 127);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 23);
            this.label1.TabIndex = 25;
            this.label1.Text = "Search";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Maroon;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(873, 691);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 38);
            this.btnClear.TabIndex = 37;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            // 
            // txtOther
            // 
            this.txtOther.BackColor = System.Drawing.Color.Maroon;
            this.txtOther.FlatAppearance.BorderSize = 0;
            this.txtOther.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtOther.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOther.ForeColor = System.Drawing.Color.White;
            this.txtOther.Location = new System.Drawing.Point(610, 556);
            this.txtOther.Name = "txtOther";
            this.txtOther.Size = new System.Drawing.Size(86, 39);
            this.txtOther.TabIndex = 41;
            this.txtOther.Text = "other";
            this.txtOther.UseVisualStyleBackColor = false;
            this.txtOther.Click += new System.EventHandler(this.txtOther_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Maroon;
            this.label7.Location = new System.Drawing.Point(65, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(396, 56);
            this.label7.TabIndex = 42;
            this.label7.Text = "Room Assigning";
            this.label7.UseWaitCursor = true;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.White;
            this.pictureBox3.Image = global::WindowsFormsApplication5.Properties.Resources.Search_30px;
            this.pictureBox3.Location = new System.Drawing.Point(478, 131);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(24, 22);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 44;
            this.pictureBox3.TabStop = false;
            // 
            // txtSearch
            // 
            this.txtSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtSearch.BackColor = System.Drawing.Color.White;
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(207, 129);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(296, 24);
            this.txtSearch.TabIndex = 43;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // txtmname
            // 
            this.txtmname.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmname.Location = new System.Drawing.Point(299, 430);
            this.txtmname.Margin = new System.Windows.Forms.Padding(4);
            this.txtmname.Name = "txtmname";
            this.txtmname.ReadOnly = true;
            this.txtmname.Size = new System.Drawing.Size(291, 30);
            this.txtmname.TabIndex = 48;
            // 
            // txtlname
            // 
            this.txtlname.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlname.Location = new System.Drawing.Point(299, 377);
            this.txtlname.Margin = new System.Windows.Forms.Padding(4);
            this.txtlname.Name = "txtlname";
            this.txtlname.ReadOnly = true;
            this.txtlname.Size = new System.Drawing.Size(291, 30);
            this.txtlname.TabIndex = 50;
            // 
            // txtfname
            // 
            this.txtfname.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfname.Location = new System.Drawing.Point(299, 313);
            this.txtfname.Margin = new System.Windows.Forms.Padding(4);
            this.txtfname.Name = "txtfname";
            this.txtfname.ReadOnly = true;
            this.txtfname.Size = new System.Drawing.Size(291, 30);
            this.txtfname.TabIndex = 49;
            // 
            // lblMiddlename
            // 
            this.lblMiddlename.AutoSize = true;
            this.lblMiddlename.BackColor = System.Drawing.Color.Transparent;
            this.lblMiddlename.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMiddlename.ForeColor = System.Drawing.Color.Maroon;
            this.lblMiddlename.Location = new System.Drawing.Point(104, 431);
            this.lblMiddlename.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMiddlename.Name = "lblMiddlename";
            this.lblMiddlename.Size = new System.Drawing.Size(134, 23);
            this.lblMiddlename.TabIndex = 47;
            this.lblMiddlename.Text = "Middlename";
            // 
            // lblLastname
            // 
            this.lblLastname.AutoSize = true;
            this.lblLastname.BackColor = System.Drawing.Color.Transparent;
            this.lblLastname.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastname.ForeColor = System.Drawing.Color.Maroon;
            this.lblLastname.Location = new System.Drawing.Point(104, 377);
            this.lblLastname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLastname.Name = "lblLastname";
            this.lblLastname.Size = new System.Drawing.Size(106, 23);
            this.lblLastname.TabIndex = 46;
            this.lblLastname.Text = "Lastname";
            // 
            // lbl2Firstname
            // 
            this.lbl2Firstname.AutoSize = true;
            this.lbl2Firstname.BackColor = System.Drawing.Color.Transparent;
            this.lbl2Firstname.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2Firstname.ForeColor = System.Drawing.Color.Maroon;
            this.lbl2Firstname.Location = new System.Drawing.Point(104, 314);
            this.lbl2Firstname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl2Firstname.Name = "lbl2Firstname";
            this.lbl2Firstname.Size = new System.Drawing.Size(102, 23);
            this.lbl2Firstname.TabIndex = 45;
            this.lbl2Firstname.Text = "Firstname";
            // 
            // assignRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtmname);
            this.Controls.Add(this.txtlname);
            this.Controls.Add(this.txtfname);
            this.Controls.Add(this.lblMiddlename);
            this.Controls.Add(this.lblLastname);
            this.Controls.Add(this.lbl2Firstname);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtOther);
            this.Controls.Add(this.cmbRoom);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtTotalStudent);
            this.Controls.Add(this.txtYearLevel);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "assignRoom";
            this.Size = new System.Drawing.Size(1417, 756);
            this.Load += new System.EventHandler(this.assignRoom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbRoom;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtTotalStudent;
        private System.Windows.Forms.TextBox txtYearLevel;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button txtOther;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.TextBox txtmname;
        private System.Windows.Forms.TextBox txtlname;
        private System.Windows.Forms.TextBox txtfname;
        private System.Windows.Forms.Label lblMiddlename;
        private System.Windows.Forms.Label lblLastname;
        private System.Windows.Forms.Label lbl2Firstname;
    }
}
