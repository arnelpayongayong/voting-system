namespace WindowsFormsApplication5
{
    partial class addStudent
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
            this.gbAddress = new System.Windows.Forms.GroupBox();
            this.txtpostal = new System.Windows.Forms.TextBox();
            this.txtcity = new System.Windows.Forms.TextBox();
            this.txtstname = new System.Windows.Forms.TextBox();
            this.txtBuilding = new System.Windows.Forms.TextBox();
            this.lblZipPostal = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblStreetName = new System.Windows.Forms.Label();
            this.lblBuilding = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnImport = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblStudenID = new System.Windows.Forms.Label();
            this.lbl2Firstname = new System.Windows.Forms.Label();
            this.lblLastname = new System.Windows.Forms.Label();
            this.lblMiddlename = new System.Windows.Forms.Label();
            this.lblYearLevel = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtfname = new System.Windows.Forms.TextBox();
            this.txtlname = new System.Windows.Forms.TextBox();
            this.txtmname = new System.Windows.Forms.TextBox();
            this.gbStudentInfo = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.cmbYearLevel = new System.Windows.Forms.ComboBox();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.gbAddress.SuspendLayout();
            this.gbStudentInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbAddress
            // 
            this.gbAddress.BackColor = System.Drawing.Color.Transparent;
            this.gbAddress.Controls.Add(this.txtpostal);
            this.gbAddress.Controls.Add(this.txtcity);
            this.gbAddress.Controls.Add(this.txtstname);
            this.gbAddress.Controls.Add(this.txtBuilding);
            this.gbAddress.Controls.Add(this.lblZipPostal);
            this.gbAddress.Controls.Add(this.lblCity);
            this.gbAddress.Controls.Add(this.lblStreetName);
            this.gbAddress.Controls.Add(this.lblBuilding);
            this.gbAddress.Controls.Add(this.label1);
            this.gbAddress.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAddress.ForeColor = System.Drawing.Color.Maroon;
            this.gbAddress.Location = new System.Drawing.Point(610, 116);
            this.gbAddress.Margin = new System.Windows.Forms.Padding(4);
            this.gbAddress.Name = "gbAddress";
            this.gbAddress.Padding = new System.Windows.Forms.Padding(4);
            this.gbAddress.Size = new System.Drawing.Size(483, 302);
            this.gbAddress.TabIndex = 2;
            this.gbAddress.TabStop = false;
            this.gbAddress.Text = "Address";
            // 
            // txtpostal
            // 
            this.txtpostal.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpostal.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtpostal.Location = new System.Drawing.Point(188, 222);
            this.txtpostal.Margin = new System.Windows.Forms.Padding(4);
            this.txtpostal.Name = "txtpostal";
            this.txtpostal.Size = new System.Drawing.Size(272, 26);
            this.txtpostal.TabIndex = 3;
            this.txtpostal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtpostal_KeyPress);
            // 
            // txtcity
            // 
            this.txtcity.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcity.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtcity.Location = new System.Drawing.Point(188, 172);
            this.txtcity.Margin = new System.Windows.Forms.Padding(4);
            this.txtcity.Name = "txtcity";
            this.txtcity.Size = new System.Drawing.Size(272, 26);
            this.txtcity.TabIndex = 2;
            // 
            // txtstname
            // 
            this.txtstname.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtstname.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtstname.Location = new System.Drawing.Point(188, 106);
            this.txtstname.Margin = new System.Windows.Forms.Padding(4);
            this.txtstname.Name = "txtstname";
            this.txtstname.Size = new System.Drawing.Size(272, 26);
            this.txtstname.TabIndex = 1;
            // 
            // txtBuilding
            // 
            this.txtBuilding.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuilding.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtBuilding.Location = new System.Drawing.Point(188, 51);
            this.txtBuilding.Margin = new System.Windows.Forms.Padding(4);
            this.txtBuilding.Name = "txtBuilding";
            this.txtBuilding.Size = new System.Drawing.Size(272, 26);
            this.txtBuilding.TabIndex = 0;
            // 
            // lblZipPostal
            // 
            this.lblZipPostal.AutoSize = true;
            this.lblZipPostal.BackColor = System.Drawing.Color.Transparent;
            this.lblZipPostal.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZipPostal.ForeColor = System.Drawing.Color.Maroon;
            this.lblZipPostal.Location = new System.Drawing.Point(21, 229);
            this.lblZipPostal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblZipPostal.Name = "lblZipPostal";
            this.lblZipPostal.Size = new System.Drawing.Size(159, 19);
            this.lblZipPostal.TabIndex = 7;
            this.lblZipPostal.Text = "Postal code/Zip Code";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.BackColor = System.Drawing.Color.Transparent;
            this.lblCity.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCity.ForeColor = System.Drawing.Color.Maroon;
            this.lblCity.Location = new System.Drawing.Point(22, 175);
            this.lblCity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(47, 23);
            this.lblCity.TabIndex = 6;
            this.lblCity.Text = "City";
            // 
            // lblStreetName
            // 
            this.lblStreetName.AutoSize = true;
            this.lblStreetName.BackColor = System.Drawing.Color.Transparent;
            this.lblStreetName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStreetName.ForeColor = System.Drawing.Color.Maroon;
            this.lblStreetName.Location = new System.Drawing.Point(21, 112);
            this.lblStreetName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStreetName.Name = "lblStreetName";
            this.lblStreetName.Size = new System.Drawing.Size(133, 23);
            this.lblStreetName.TabIndex = 5;
            this.lblStreetName.Text = "Street Name";
            // 
            // lblBuilding
            // 
            this.lblBuilding.AutoSize = true;
            this.lblBuilding.BackColor = System.Drawing.Color.Transparent;
            this.lblBuilding.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuilding.ForeColor = System.Drawing.Color.Maroon;
            this.lblBuilding.Location = new System.Drawing.Point(22, 54);
            this.lblBuilding.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBuilding.Name = "lblBuilding";
            this.lblBuilding.Size = new System.Drawing.Size(97, 23);
            this.lblBuilding.TabIndex = 4;
            this.lblBuilding.Text = "Building#";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 23);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(65, 18);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(303, 56);
            this.label2.TabIndex = 0;
            this.label2.Text = "Add Student";
            // 
            // btnImport
            // 
            this.btnImport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(21)))), ((int)(((byte)(3)))));
            this.btnImport.FlatAppearance.BorderSize = 0;
            this.btnImport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImport.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImport.ForeColor = System.Drawing.Color.White;
            this.btnImport.Location = new System.Drawing.Point(969, 626);
            this.btnImport.Margin = new System.Windows.Forms.Padding(4);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(137, 50);
            this.btnImport.TabIndex = 2;
            this.btnImport.Text = "Import";
            this.btnImport.UseVisualStyleBackColor = false;
            this.btnImport.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(21)))), ((int)(((byte)(3)))));
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(793, 626);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(168, 50);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblStudenID
            // 
            this.lblStudenID.AutoSize = true;
            this.lblStudenID.BackColor = System.Drawing.Color.Transparent;
            this.lblStudenID.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudenID.ForeColor = System.Drawing.Color.Maroon;
            this.lblStudenID.Location = new System.Drawing.Point(47, 34);
            this.lblStudenID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStudenID.Name = "lblStudenID";
            this.lblStudenID.Size = new System.Drawing.Size(116, 23);
            this.lblStudenID.TabIndex = 6;
            this.lblStudenID.Text = "Student I.D";
            // 
            // lbl2Firstname
            // 
            this.lbl2Firstname.AutoSize = true;
            this.lbl2Firstname.BackColor = System.Drawing.Color.Transparent;
            this.lbl2Firstname.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2Firstname.ForeColor = System.Drawing.Color.Maroon;
            this.lbl2Firstname.Location = new System.Drawing.Point(47, 75);
            this.lbl2Firstname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl2Firstname.Name = "lbl2Firstname";
            this.lbl2Firstname.Size = new System.Drawing.Size(102, 23);
            this.lbl2Firstname.TabIndex = 1;
            this.lbl2Firstname.Text = "Firstname";
            // 
            // lblLastname
            // 
            this.lblLastname.AutoSize = true;
            this.lblLastname.BackColor = System.Drawing.Color.Transparent;
            this.lblLastname.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastname.ForeColor = System.Drawing.Color.Maroon;
            this.lblLastname.Location = new System.Drawing.Point(48, 109);
            this.lblLastname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLastname.Name = "lblLastname";
            this.lblLastname.Size = new System.Drawing.Size(106, 23);
            this.lblLastname.TabIndex = 2;
            this.lblLastname.Text = "Lastname";
            // 
            // lblMiddlename
            // 
            this.lblMiddlename.AutoSize = true;
            this.lblMiddlename.BackColor = System.Drawing.Color.Transparent;
            this.lblMiddlename.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMiddlename.ForeColor = System.Drawing.Color.Maroon;
            this.lblMiddlename.Location = new System.Drawing.Point(47, 147);
            this.lblMiddlename.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMiddlename.Name = "lblMiddlename";
            this.lblMiddlename.Size = new System.Drawing.Size(134, 23);
            this.lblMiddlename.TabIndex = 3;
            this.lblMiddlename.Text = "Middlename";
            // 
            // lblYearLevel
            // 
            this.lblYearLevel.AutoSize = true;
            this.lblYearLevel.BackColor = System.Drawing.Color.Transparent;
            this.lblYearLevel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYearLevel.ForeColor = System.Drawing.Color.Maroon;
            this.lblYearLevel.Location = new System.Drawing.Point(49, 318);
            this.lblYearLevel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblYearLevel.Name = "lblYearLevel";
            this.lblYearLevel.Size = new System.Drawing.Size(115, 23);
            this.lblYearLevel.TabIndex = 4;
            this.lblYearLevel.Text = "Year Level";
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtID.Location = new System.Drawing.Point(204, 29);
            this.txtID.Margin = new System.Windows.Forms.Padding(4);
            this.txtID.MaxLength = 8;
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(291, 26);
            this.txtID.TabIndex = 0;
            this.txtID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtID_KeyPress);
            // 
            // txtfname
            // 
            this.txtfname.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfname.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtfname.Location = new System.Drawing.Point(204, 70);
            this.txtfname.Margin = new System.Windows.Forms.Padding(4);
            this.txtfname.Name = "txtfname";
            this.txtfname.Size = new System.Drawing.Size(291, 26);
            this.txtfname.TabIndex = 1;
            // 
            // txtlname
            // 
            this.txtlname.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlname.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtlname.Location = new System.Drawing.Point(204, 109);
            this.txtlname.Margin = new System.Windows.Forms.Padding(4);
            this.txtlname.Name = "txtlname";
            this.txtlname.Size = new System.Drawing.Size(291, 26);
            this.txtlname.TabIndex = 2;
            // 
            // txtmname
            // 
            this.txtmname.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmname.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtmname.Location = new System.Drawing.Point(204, 147);
            this.txtmname.Margin = new System.Windows.Forms.Padding(4);
            this.txtmname.Name = "txtmname";
            this.txtmname.Size = new System.Drawing.Size(291, 26);
            this.txtmname.TabIndex = 3;
            // 
            // gbStudentInfo
            // 
            this.gbStudentInfo.BackColor = System.Drawing.Color.Transparent;
            this.gbStudentInfo.Controls.Add(this.label5);
            this.gbStudentInfo.Controls.Add(this.dateTimePicker1);
            this.gbStudentInfo.Controls.Add(this.label3);
            this.gbStudentInfo.Controls.Add(this.cmbGender);
            this.gbStudentInfo.Controls.Add(this.cmbYearLevel);
            this.gbStudentInfo.Controls.Add(this.txtContact);
            this.gbStudentInfo.Controls.Add(this.label4);
            this.gbStudentInfo.Controls.Add(this.txtmname);
            this.gbStudentInfo.Controls.Add(this.txtlname);
            this.gbStudentInfo.Controls.Add(this.txtfname);
            this.gbStudentInfo.Controls.Add(this.txtID);
            this.gbStudentInfo.Controls.Add(this.lblYearLevel);
            this.gbStudentInfo.Controls.Add(this.lblMiddlename);
            this.gbStudentInfo.Controls.Add(this.lblLastname);
            this.gbStudentInfo.Controls.Add(this.lbl2Firstname);
            this.gbStudentInfo.Controls.Add(this.lblStudenID);
            this.gbStudentInfo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbStudentInfo.ForeColor = System.Drawing.Color.Maroon;
            this.gbStudentInfo.Location = new System.Drawing.Point(27, 116);
            this.gbStudentInfo.Margin = new System.Windows.Forms.Padding(4);
            this.gbStudentInfo.Name = "gbStudentInfo";
            this.gbStudentInfo.Padding = new System.Windows.Forms.Padding(4);
            this.gbStudentInfo.Size = new System.Drawing.Size(556, 480);
            this.gbStudentInfo.TabIndex = 1;
            this.gbStudentInfo.TabStop = false;
            this.gbStudentInfo.Text = "Student Information ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Maroon;
            this.label5.Location = new System.Drawing.Point(48, 212);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 23);
            this.label5.TabIndex = 18;
            this.label5.Text = "Birth Date";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(204, 208);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(291, 23);
            this.dateTimePicker1.TabIndex = 17;
            this.dateTimePicker1.Value = new System.DateTime(2018, 3, 11, 13, 54, 38, 0);
         
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(48, 265);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 23);
            this.label3.TabIndex = 16;
            this.label3.Text = "Gender";
            // 
            // cmbGender
            // 
            this.cmbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Items.AddRange(new object[] {
            "M",
            "F"});
            this.cmbGender.Location = new System.Drawing.Point(204, 262);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(103, 31);
            this.cmbGender.TabIndex = 15;
            // 
            // cmbYearLevel
            // 
            this.cmbYearLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbYearLevel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbYearLevel.FormattingEnabled = true;
            this.cmbYearLevel.Items.AddRange(new object[] {
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cmbYearLevel.Location = new System.Drawing.Point(204, 315);
            this.cmbYearLevel.Name = "cmbYearLevel";
            this.cmbYearLevel.Size = new System.Drawing.Size(291, 31);
            this.cmbYearLevel.TabIndex = 4;
            // 
            // txtContact
            // 
            this.txtContact.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContact.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtContact.Location = new System.Drawing.Point(204, 374);
            this.txtContact.Margin = new System.Windows.Forms.Padding(4);
            this.txtContact.MaxLength = 11;
            this.txtContact.MinimumSize = new System.Drawing.Size(11, 11);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(291, 26);
            this.txtContact.TabIndex = 5;
            this.txtContact.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtContact_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(49, 378);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 22);
            this.label4.TabIndex = 14;
            this.label4.Text = "Contact No.";
            // 
            // addStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gbAddress);
            this.Controls.Add(this.gbStudentInfo);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "addStudent";
            this.Size = new System.Drawing.Size(1417, 756);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            this.gbAddress.ResumeLayout(false);
            this.gbAddress.PerformLayout();
            this.gbStudentInfo.ResumeLayout(false);
            this.gbStudentInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbAddress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblZipPostal;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblStreetName;
        private System.Windows.Forms.Label lblBuilding;
        private System.Windows.Forms.TextBox txtpostal;
        private System.Windows.Forms.TextBox txtcity;
        private System.Windows.Forms.TextBox txtstname;
        private System.Windows.Forms.TextBox txtBuilding;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblStudenID;
        private System.Windows.Forms.Label lbl2Firstname;
        private System.Windows.Forms.Label lblLastname;
        private System.Windows.Forms.Label lblMiddlename;
        private System.Windows.Forms.Label lblYearLevel;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtfname;
        private System.Windows.Forms.TextBox txtlname;
        private System.Windows.Forms.TextBox txtmname;
        private System.Windows.Forms.GroupBox gbStudentInfo;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbYearLevel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbGender;

    }
}
