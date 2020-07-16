namespace WindowsFormsApplication5
{
    partial class frmAdmin
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnResult = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnAddRecord = new System.Windows.Forms.Button();
            this.btnRecord = new System.Windows.Forms.Button();
            this.btnElection = new System.Windows.Forms.Button();
            this.btnStudent = new System.Windows.Forms.Button();
            this.btnRoom = new System.Windows.Forms.Button();
            this.btnViewRecord = new System.Windows.Forms.Button();
            this.btnUpdateStudent = new System.Windows.Forms.Button();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.pcbSchoolLogo = new System.Windows.Forms.PictureBox();
            this.btnAddCandidate = new System.Windows.Forms.Button();
            this.btnViewSection = new System.Windows.Forms.Button();
            this.btnAssignStudent = new System.Windows.Forms.Button();
            this.btnUpdateCandidate = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblPending = new System.Windows.Forms.Label();
            this.lblVoted = new System.Windows.Forms.Label();
            this.lblPopulation = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.pcbRemaining = new System.Windows.Forms.PictureBox();
            this.pcbVoted = new System.Windows.Forms.PictureBox();
            this.pcbPopulation = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbSchoolLogo)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbRemaining)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbVoted)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPopulation)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(21)))), ((int)(((byte)(3)))));
            this.panel1.Controls.Add(this.btnResult);
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.btnAddRecord);
            this.panel1.Controls.Add(this.btnRecord);
            this.panel1.Controls.Add(this.btnElection);
            this.panel1.Controls.Add(this.btnStudent);
            this.panel1.Controls.Add(this.btnRoom);
            this.panel1.Controls.Add(this.btnViewRecord);
            this.panel1.Controls.Add(this.btnUpdateStudent);
            this.panel1.Controls.Add(this.btnAddStudent);
            this.panel1.Controls.Add(this.pcbSchoolLogo);
            this.panel1.Controls.Add(this.btnAddCandidate);
            this.panel1.Controls.Add(this.btnViewSection);
            this.panel1.Controls.Add(this.btnAssignStudent);
            this.panel1.Controls.Add(this.btnUpdateCandidate);
            this.panel1.Location = new System.Drawing.Point(-3, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(313, 751);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnResult
            // 
            this.btnResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(21)))), ((int)(((byte)(3)))));
            this.btnResult.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnResult.FlatAppearance.BorderSize = 0;
            this.btnResult.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
            this.btnResult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResult.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResult.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnResult.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnResult.Location = new System.Drawing.Point(8, 468);
            this.btnResult.Margin = new System.Windows.Forms.Padding(4);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(299, 68);
            this.btnResult.TabIndex = 4;
            this.btnResult.Text = "Vote Result";
            this.btnResult.UseVisualStyleBackColor = false;
            this.btnResult.Click += new System.EventHandler(this.btnResult_Click_1);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(21)))), ((int)(((byte)(3)))));
            this.btnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLogout.Location = new System.Drawing.Point(8, 544);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(299, 68);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.Text = "Logout";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnAddRecord
            // 
            this.btnAddRecord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(21)))), ((int)(((byte)(3)))));
            this.btnAddRecord.FlatAppearance.BorderSize = 0;
            this.btnAddRecord.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
            this.btnAddRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddRecord.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddRecord.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAddRecord.Location = new System.Drawing.Point(5, 463);
            this.btnAddRecord.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddRecord.Name = "btnAddRecord";
            this.btnAddRecord.Size = new System.Drawing.Size(297, 30);
            this.btnAddRecord.TabIndex = 9;
            this.btnAddRecord.Text = "Add Record";
            this.btnAddRecord.UseVisualStyleBackColor = false;
            this.btnAddRecord.Visible = false;
            this.btnAddRecord.Click += new System.EventHandler(this.btnAddRecord_Click);
            // 
            // btnRecord
            // 
            this.btnRecord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(21)))), ((int)(((byte)(3)))));
            this.btnRecord.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnRecord.FlatAppearance.BorderSize = 0;
            this.btnRecord.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
            this.btnRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecord.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecord.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnRecord.Location = new System.Drawing.Point(8, 404);
            this.btnRecord.Margin = new System.Windows.Forms.Padding(4);
            this.btnRecord.Name = "btnRecord";
            this.btnRecord.Size = new System.Drawing.Size(299, 68);
            this.btnRecord.TabIndex = 3;
            this.btnRecord.Text = "Guidance Record";
            this.btnRecord.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRecord.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnRecord.UseVisualStyleBackColor = false;
            this.btnRecord.Click += new System.EventHandler(this.button6_Click);
            // 
            // btnElection
            // 
            this.btnElection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(21)))), ((int)(((byte)(3)))));
            this.btnElection.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnElection.FlatAppearance.BorderSize = 0;
            this.btnElection.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
            this.btnElection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnElection.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnElection.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnElection.Location = new System.Drawing.Point(8, 258);
            this.btnElection.Margin = new System.Windows.Forms.Padding(4);
            this.btnElection.Name = "btnElection";
            this.btnElection.Size = new System.Drawing.Size(299, 68);
            this.btnElection.TabIndex = 1;
            this.btnElection.Text = "Manage Election";
            this.btnElection.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnElection.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnElection.UseVisualStyleBackColor = false;
            this.btnElection.Click += new System.EventHandler(this.btnElection_Click);
            // 
            // btnStudent
            // 
            this.btnStudent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(21)))), ((int)(((byte)(3)))));
            this.btnStudent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnStudent.FlatAppearance.BorderSize = 0;
            this.btnStudent.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnStudent.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
            this.btnStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStudent.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudent.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnStudent.Location = new System.Drawing.Point(8, 191);
            this.btnStudent.Margin = new System.Windows.Forms.Padding(4);
            this.btnStudent.Name = "btnStudent";
            this.btnStudent.Size = new System.Drawing.Size(299, 68);
            this.btnStudent.TabIndex = 0;
            this.btnStudent.Text = "Manage Student";
            this.btnStudent.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnStudent.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnStudent.UseVisualStyleBackColor = false;
            this.btnStudent.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnRoom
            // 
            this.btnRoom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(21)))), ((int)(((byte)(3)))));
            this.btnRoom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnRoom.FlatAppearance.BorderSize = 0;
            this.btnRoom.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
            this.btnRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRoom.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoom.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnRoom.Location = new System.Drawing.Point(8, 334);
            this.btnRoom.Margin = new System.Windows.Forms.Padding(4);
            this.btnRoom.Name = "btnRoom";
            this.btnRoom.Size = new System.Drawing.Size(299, 68);
            this.btnRoom.TabIndex = 2;
            this.btnRoom.Text = "Manage Room";
            this.btnRoom.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRoom.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnRoom.UseVisualStyleBackColor = false;
            this.btnRoom.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnViewRecord
            // 
            this.btnViewRecord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(21)))), ((int)(((byte)(3)))));
            this.btnViewRecord.FlatAppearance.BorderSize = 0;
            this.btnViewRecord.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
            this.btnViewRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewRecord.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewRecord.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnViewRecord.Location = new System.Drawing.Point(5, 488);
            this.btnViewRecord.Margin = new System.Windows.Forms.Padding(4);
            this.btnViewRecord.Name = "btnViewRecord";
            this.btnViewRecord.Size = new System.Drawing.Size(297, 30);
            this.btnViewRecord.TabIndex = 10;
            this.btnViewRecord.Text = "View Record";
            this.btnViewRecord.UseVisualStyleBackColor = false;
            this.btnViewRecord.Visible = false;
            this.btnViewRecord.Click += new System.EventHandler(this.btnViewRecord_Click);
            // 
            // btnUpdateStudent
            // 
            this.btnUpdateStudent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(21)))), ((int)(((byte)(3)))));
            this.btnUpdateStudent.FlatAppearance.BorderSize = 0;
            this.btnUpdateStudent.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
            this.btnUpdateStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateStudent.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateStudent.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnUpdateStudent.Location = new System.Drawing.Point(3, 288);
            this.btnUpdateStudent.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdateStudent.Name = "btnUpdateStudent";
            this.btnUpdateStudent.Size = new System.Drawing.Size(297, 30);
            this.btnUpdateStudent.TabIndex = 5;
            this.btnUpdateStudent.Text = "Update Student";
            this.btnUpdateStudent.UseVisualStyleBackColor = false;
            this.btnUpdateStudent.Visible = false;
            this.btnUpdateStudent.Click += new System.EventHandler(this.btnUpdateStudent_Click);
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(21)))), ((int)(((byte)(3)))));
            this.btnAddStudent.FlatAppearance.BorderSize = 0;
            this.btnAddStudent.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
            this.btnAddStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddStudent.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddStudent.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAddStudent.Location = new System.Drawing.Point(3, 258);
            this.btnAddStudent.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(297, 30);
            this.btnAddStudent.TabIndex = 7;
            this.btnAddStudent.Text = "AddStudent";
            this.btnAddStudent.UseVisualStyleBackColor = false;
            this.btnAddStudent.Visible = false;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click_1);
            // 
            // pcbSchoolLogo
            // 
            this.pcbSchoolLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcbSchoolLogo.Location = new System.Drawing.Point(40, 21);
            this.pcbSchoolLogo.Margin = new System.Windows.Forms.Padding(4);
            this.pcbSchoolLogo.Name = "pcbSchoolLogo";
            this.pcbSchoolLogo.Size = new System.Drawing.Size(219, 162);
            this.pcbSchoolLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbSchoolLogo.TabIndex = 6;
            this.pcbSchoolLogo.TabStop = false;
            // 
            // btnAddCandidate
            // 
            this.btnAddCandidate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(21)))), ((int)(((byte)(3)))));
            this.btnAddCandidate.FlatAppearance.BorderSize = 0;
            this.btnAddCandidate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
            this.btnAddCandidate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCandidate.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCandidate.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAddCandidate.Location = new System.Drawing.Point(5, 329);
            this.btnAddCandidate.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddCandidate.Name = "btnAddCandidate";
            this.btnAddCandidate.Size = new System.Drawing.Size(297, 30);
            this.btnAddCandidate.TabIndex = 13;
            this.btnAddCandidate.Text = "Add Candidate";
            this.btnAddCandidate.UseVisualStyleBackColor = false;
            this.btnAddCandidate.Visible = false;
            this.btnAddCandidate.Click += new System.EventHandler(this.btnAddCandidate_Click);
            // 
            // btnViewSection
            // 
            this.btnViewSection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(21)))), ((int)(((byte)(3)))));
            this.btnViewSection.FlatAppearance.BorderSize = 0;
            this.btnViewSection.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
            this.btnViewSection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewSection.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewSection.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnViewSection.Location = new System.Drawing.Point(1, 432);
            this.btnViewSection.Margin = new System.Windows.Forms.Padding(4);
            this.btnViewSection.Name = "btnViewSection";
            this.btnViewSection.Size = new System.Drawing.Size(297, 30);
            this.btnViewSection.TabIndex = 12;
            this.btnViewSection.Text = "View Section";
            this.btnViewSection.UseVisualStyleBackColor = false;
            this.btnViewSection.Visible = false;
            this.btnViewSection.Click += new System.EventHandler(this.btnViewSection_Click);
            // 
            // btnAssignStudent
            // 
            this.btnAssignStudent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(21)))), ((int)(((byte)(3)))));
            this.btnAssignStudent.FlatAppearance.BorderSize = 0;
            this.btnAssignStudent.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
            this.btnAssignStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAssignStudent.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAssignStudent.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAssignStudent.Location = new System.Drawing.Point(1, 403);
            this.btnAssignStudent.Margin = new System.Windows.Forms.Padding(4);
            this.btnAssignStudent.Name = "btnAssignStudent";
            this.btnAssignStudent.Size = new System.Drawing.Size(297, 30);
            this.btnAssignStudent.TabIndex = 11;
            this.btnAssignStudent.Text = "Assign Student";
            this.btnAssignStudent.UseVisualStyleBackColor = false;
            this.btnAssignStudent.Visible = false;
            this.btnAssignStudent.Click += new System.EventHandler(this.btnAssignStudent_Click);
            // 
            // btnUpdateCandidate
            // 
            this.btnUpdateCandidate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(21)))), ((int)(((byte)(3)))));
            this.btnUpdateCandidate.FlatAppearance.BorderSize = 0;
            this.btnUpdateCandidate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
            this.btnUpdateCandidate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateCandidate.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateCandidate.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnUpdateCandidate.Location = new System.Drawing.Point(5, 358);
            this.btnUpdateCandidate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdateCandidate.Name = "btnUpdateCandidate";
            this.btnUpdateCandidate.Size = new System.Drawing.Size(297, 30);
            this.btnUpdateCandidate.TabIndex = 4;
            this.btnUpdateCandidate.Text = "Update Candidate";
            this.btnUpdateCandidate.UseVisualStyleBackColor = false;
            this.btnUpdateCandidate.Visible = false;
            this.btnUpdateCandidate.Click += new System.EventHandler(this.btnUpdateCandidate_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Location = new System.Drawing.Point(309, -4);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1111, 751);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(21)))), ((int)(((byte)(3)))));
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.lblPending);
            this.panel3.Controls.Add(this.lblVoted);
            this.panel3.Controls.Add(this.lblPopulation);
            this.panel3.Controls.Add(this.lblTime);
            this.panel3.Controls.Add(this.pcbRemaining);
            this.panel3.Controls.Add(this.pcbVoted);
            this.panel3.Controls.Add(this.pcbPopulation);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(1429, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(301, 747);
            this.panel3.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(19, 427);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 23);
            this.label6.TabIndex = 10;
            this.label6.Text = "Pending Voter";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(21, 251);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 23);
            this.label7.TabIndex = 9;
            this.label7.Text = "Voted";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.Location = new System.Drawing.Point(21, 91);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 23);
            this.label8.TabIndex = 8;
            this.label8.Text = "Population";
            // 
            // lblPending
            // 
            this.lblPending.AutoSize = true;
            this.lblPending.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPending.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblPending.Location = new System.Drawing.Point(165, 507);
            this.lblPending.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPending.Name = "lblPending";
            this.lblPending.Size = new System.Drawing.Size(70, 23);
            this.lblPending.TabIndex = 7;
            this.lblPending.Text = "10,000";
            // 
            // lblVoted
            // 
            this.lblVoted.AutoSize = true;
            this.lblVoted.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVoted.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblVoted.Location = new System.Drawing.Point(165, 321);
            this.lblVoted.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVoted.Name = "lblVoted";
            this.lblVoted.Size = new System.Drawing.Size(21, 23);
            this.lblVoted.TabIndex = 6;
            this.lblVoted.Text = "0";
            // 
            // lblPopulation
            // 
            this.lblPopulation.AutoSize = true;
            this.lblPopulation.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPopulation.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblPopulation.Location = new System.Drawing.Point(165, 156);
            this.lblPopulation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPopulation.Name = "lblPopulation";
            this.lblPopulation.Size = new System.Drawing.Size(72, 23);
            this.lblPopulation.TabIndex = 5;
            this.lblPopulation.Text = "label3";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTime.Location = new System.Drawing.Point(23, 711);
            this.lblTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(72, 23);
            this.lblTime.TabIndex = 4;
            this.lblTime.Text = "label2";
            // 
            // pcbRemaining
            // 
            this.pcbRemaining.Location = new System.Drawing.Point(23, 462);
            this.pcbRemaining.Margin = new System.Windows.Forms.Padding(4);
            this.pcbRemaining.Name = "pcbRemaining";
            this.pcbRemaining.Size = new System.Drawing.Size(123, 106);
            this.pcbRemaining.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbRemaining.TabIndex = 3;
            this.pcbRemaining.TabStop = false;
            // 
            // pcbVoted
            // 
            this.pcbVoted.Location = new System.Drawing.Point(23, 287);
            this.pcbVoted.Margin = new System.Windows.Forms.Padding(4);
            this.pcbVoted.Name = "pcbVoted";
            this.pcbVoted.Size = new System.Drawing.Size(123, 106);
            this.pcbVoted.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbVoted.TabIndex = 2;
            this.pcbVoted.TabStop = false;
            // 
            // pcbPopulation
            // 
            this.pcbPopulation.Location = new System.Drawing.Point(23, 124);
            this.pcbPopulation.Margin = new System.Windows.Forms.Padding(4);
            this.pcbPopulation.Name = "pcbPopulation";
            this.pcbPopulation.Size = new System.Drawing.Size(123, 106);
            this.pcbPopulation.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbPopulation.TabIndex = 1;
            this.pcbPopulation.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(17, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dashboard";
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(165)))), ((int)(((byte)(22)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1723, 742);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAdmin";
            this.Load += new System.EventHandler(this.frmAdmin_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcbSchoolLogo)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbRemaining)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbVoted)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPopulation)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnRecord;
        private System.Windows.Forms.Button btnElection;
        private System.Windows.Forms.Button btnRoom;
        private System.Windows.Forms.Button btnStudent;
        private System.Windows.Forms.PictureBox pcbSchoolLogo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnUpdateCandidate;
        private System.Windows.Forms.Button btnViewSection;
        private System.Windows.Forms.Button btnAssignStudent;
        private System.Windows.Forms.Button btnViewRecord;
        private System.Windows.Forms.Button btnAddRecord;
        private System.Windows.Forms.Button btnUpdateStudent;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.Button btnAddCandidate;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblPending;
        private System.Windows.Forms.Label lblVoted;
        private System.Windows.Forms.Label lblPopulation;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.PictureBox pcbRemaining;
        private System.Windows.Forms.PictureBox pcbVoted;
        private System.Windows.Forms.PictureBox pcbPopulation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnResult;
    }
}