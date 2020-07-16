using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace WindowsFormsApplication5
{
    public partial class frmAdmin : Form
    {
        public frmAdmin()
        {
            InitializeComponent();
        }
        UserControl current;
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmAdmin_Load(object sender, EventArgs e)
        {
            this.Size = new Size(1290, 600);
            char drive = 'C';
            bool check = false;
            while(drive <= 'Z')
            {
                check = true;
            
                try
                {
                    pcbSchoolLogo.Image = Image.FromFile(drive + @":\VotingSystem\Image\schoollogo.jpg");
                    this.btnStudent.BackgroundImage = Image.FromFile(drive + @":\VotingSystem\Image\studeng_logo.png");
                    this.btnElection.BackgroundImage = Image.FromFile(drive + @":\VotingSystem\Image\election_logo.png");
                    this.btnRoom.BackgroundImage = Image.FromFile(drive + @":\VotingSystem\Image\room_logo.png");
                    this.btnRecord.BackgroundImage = Image.FromFile(drive + @":\VotingSystem\Image\record_logo.png");
                    this.btnLogout.BackgroundImage = Image.FromFile(drive + @":\VotingSystem\Image\logout_logo.png");
                    this.pcbPopulation.Image = Image.FromFile(drive + @":\VotingSystem\Image\totalVoter_logo.png");
                    this.pcbRemaining.Image = Image.FromFile(drive + @":\VotingSystem\Image\remaining_logo.png");
                    this.pcbVoted.Image = Image.FromFile(drive + @":\VotingSystem\Image\voted_logo.png");
                    this.btnResult.Image = Image.FromFile(drive + @":\VotingSystem\Image\result_logo.png");
                    timer1.Start();
                }
                catch (Exception)
                {
                    check = false;
                    
                }
                if (check == true)
                    break;
                drive++;
                
            }

            btnStudent.Text = "     Manage Student ▲";
            btnRecord.Text = "     Guidance Record ▲";
            btnElection.Text = "     Manage Election ▲";
            btnRoom.Text = "       Manage Room   ▲";
            timer1.Start();
            
            
        }

        int b1 = 0;
        int b2 = 0;
        int b3 = 0;
        int b4 = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            if (b1 % 2 == 0)
            {

                btnStudent.Text = "     Manage Student ▼";
             
                btnAddStudent.Visible = true;
                btnUpdateStudent.Visible = true;
                //Election Button
                btnElection.Location = new Point(this.btnElection.Location.X, this.btnElection.Location.Y + 50);
                btnAddCandidate.Location = new Point(this.btnAddCandidate.Location.X, this.btnAddCandidate.Location.Y + 50);
                btnUpdateCandidate.Location = new Point(this.btnUpdateCandidate.Location.X, this.btnUpdateCandidate.Location.Y + 50);
                //End of Election Button
                //Room Button
                btnRoom.Location = new Point(this.btnRoom.Location.X, this.btnRoom.Location.Y + 50);
                btnAssignStudent.Location = new Point(this.btnAssignStudent.Location.X, this.btnAssignStudent.Location.Y + 50);
                btnViewSection.Location = new Point(this.btnViewSection.Location.X, this.btnViewSection.Location.Y + 50);
                //End of Room Button
                //Guidance Record Button
                btnRecord.Location = new Point(this.btnRecord.Location.X, this.btnRecord.Location.Y + 50);
                btnAddRecord.Location = new Point(this.btnAddRecord.Location.X, this.btnAddRecord.Location.Y + 50);
                btnViewRecord.Location = new Point(this.btnViewRecord.Location.X, this.btnViewRecord.Location.Y + 50);
                //Enf of Guidance Record Button
                btnResult.Location = new Point(this.btnResult.Location.X, this.btnResult.Location.Y + 50);
                btnLogout.Location = new Point(this.btnLogout.Location.X, this.btnLogout.Location.Y + 50);

            }
            else
            {
                btnStudent.Text = "      Manage Student ▲";
                btnAddStudent.Visible = false;
                btnUpdateStudent.Visible = false;
                //Election Button
                btnElection.Location = new Point(this.btnElection.Location.X, this.btnElection.Location.Y - 50);
                btnAddCandidate.Location = new Point(this.btnAddCandidate.Location.X, this.btnAddCandidate.Location.Y - 50);
                btnUpdateCandidate.Location = new Point(this.btnUpdateCandidate.Location.X, this.btnUpdateCandidate.Location.Y - 50);
                //End of Election Button
                //Room Button
                btnRoom.Location = new Point(this.btnRoom.Location.X, this.btnRoom.Location.Y - 50);
                btnAssignStudent.Location = new Point(this.btnAssignStudent.Location.X, this.btnAssignStudent.Location.Y - 50);
                btnViewSection.Location = new Point(this.btnViewSection.Location.X, this.btnViewSection.Location.Y - 50);
                //End of Room Button
                //Guidance Record Button
                btnRecord.Location = new Point(this.btnRecord.Location.X, this.btnRecord.Location.Y - 50);
                btnAddRecord.Location = new Point(this.btnAddRecord.Location.X, this.btnAddRecord.Location.Y - 50);
                btnViewRecord.Location = new Point(this.btnViewRecord.Location.X, this.btnViewRecord.Location.Y - 50);
                //Enf of Guidance Record Button
                btnResult.Location = new Point(this.btnResult.Location.X, this.btnResult.Location.Y - 50);
                btnLogout.Location = new Point(this.btnLogout.Location.X, this.btnLogout.Location.Y - 50);
            }
            b1++;
            
                    
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (b3 % 2 == 0)
            {

                btnRoom.Text = "       Manage Room   ▼";
                btnAssignStudent.Visible = true;
                btnViewSection.Visible = true;
                //Guidance Record Button
                btnRecord.Location = new Point(this.btnRecord.Location.X, this.btnRecord.Location.Y + 50);
                btnAddRecord.Location = new Point(this.btnAddRecord.Location.X, this.btnAddRecord.Location.Y + 50);
                btnViewRecord.Location = new Point(this.btnViewRecord.Location.X, this.btnViewRecord.Location.Y + 50);
                //Enf of Guidance Record Button
                btnResult.Location = new Point(this.btnResult.Location.X, this.btnResult.Location.Y + 50);
                btnLogout.Location = new Point(this.btnLogout.Location.X, this.btnLogout.Location.Y + 50);
            }
            else
            {
                btnRoom.Text = "       Manage Room   ▲";
                btnAssignStudent.Visible = false;
                btnViewSection.Visible = false;
                //Guidance Record Button
                btnRecord.Location = new Point(this.btnRecord.Location.X, this.btnRecord.Location.Y - 50);
                btnAddRecord.Location = new Point(this.btnAddRecord.Location.X, this.btnAddRecord.Location.Y - 50);
                btnViewRecord.Location = new Point(this.btnViewRecord.Location.X, this.btnViewRecord.Location.Y - 50);
                //Enf of Guidance Record Button
                btnResult.Location = new Point(this.btnResult.Location.X, this.btnResult.Location.Y - 50);
                btnLogout.Location = new Point(this.btnLogout.Location.X, this.btnLogout.Location.Y - 50);
            }
            b3++;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (b4 % 2 == 0)
            {

                btnRecord.Text = "     Guidance Record ▼";
                btnAddRecord.Visible = true;
                btnViewRecord.Visible = true;
                btnResult.Location = new Point(this.btnResult.Location.X, this.btnResult.Location.Y + 50);
                btnLogout.Location = new Point(this.btnLogout.Location.X, this.btnLogout.Location.Y + 50);
            }
            else
            {

                btnRecord.Text = "     Guidance Record ▲";
                btnAddRecord.Visible = false;
                btnViewRecord.Visible = false;
                btnResult.Location = new Point(this.btnResult.Location.X, this.btnResult.Location.Y - 50);
                btnLogout.Location = new Point(this.btnLogout.Location.X, this.btnLogout.Location.Y - 50);
            }
            b4++;
        }

        

        private void btnElection_Click(object sender, EventArgs e)
        {
            if (b2 % 2 == 0)
            {

                btnElection.Text = "     Manage Election ▼";
                
                btnAddCandidate.Visible = true;
                btnUpdateCandidate.Visible = true;
                //Room Button
                btnRoom.Location = new Point(this.btnRoom.Location.X, this.btnRoom.Location.Y + 50);
                btnAssignStudent.Location = new Point(this.btnAssignStudent.Location.X, this.btnAssignStudent.Location.Y + 50);
                btnViewSection.Location = new Point(this.btnViewSection.Location.X, this.btnViewSection.Location.Y + 50);
                //End of Room Button
                //Guidance Record Button
                btnRecord.Location = new Point(this.btnRecord.Location.X, this.btnRecord.Location.Y + 50);
                btnAddRecord.Location = new Point(this.btnAddRecord.Location.X, this.btnAddRecord.Location.Y + 50);
                btnViewRecord.Location = new Point(this.btnViewRecord.Location.X, this.btnViewRecord.Location.Y + 50);
                //Enf of Guidance Record Button
                btnResult.Location = new Point(this.btnResult.Location.X, this.btnResult.Location.Y + 50);
                btnLogout.Location = new Point(this.btnLogout.Location.X, this.btnLogout.Location.Y + 50);
            }
            else
            {
                btnElection.Text = "     Manage Election ▲";
                btnAddCandidate.Visible = false;
                btnUpdateCandidate.Visible = false;
                //Room Button
                btnRoom.Location = new Point(this.btnRoom.Location.X, this.btnRoom.Location.Y - 50);
                btnAssignStudent.Location = new Point(this.btnAssignStudent.Location.X, this.btnAssignStudent.Location.Y - 50);
                btnViewSection.Location = new Point(this.btnViewSection.Location.X, this.btnViewSection.Location.Y - 50);
                //End of Room Button
                //Guidance Record Button
                btnRecord.Location = new Point(this.btnRecord.Location.X, this.btnRecord.Location.Y - 50);
                btnAddRecord.Location = new Point(this.btnAddRecord.Location.X, this.btnAddRecord.Location.Y - 50);
                btnViewRecord.Location = new Point(this.btnViewRecord.Location.X, this.btnViewRecord.Location.Y - 50);
                //Enf of Guidance Record Button
                btnResult.Location = new Point(this.btnResult.Location.X, this.btnResult.Location.Y - 50);
                btnLogout.Location = new Point(this.btnLogout.Location.X, this.btnLogout.Location.Y - 50);
            }
            b2++;
        }

        

        private void btnAddStudent_Click_1(object sender, EventArgs e)
        {
            this.panel2.Controls.Remove(current);
            current = new addStudent();
            current.AutoScroll = true;
            this.panel2.Controls.Add(current);
            current.Show();

        }

        private void btnUpdateStudent_Click(object sender, EventArgs e)
        {
            this.panel2.Controls.Remove(current);
            current = new updateStudent();
            current.AutoScroll = true;
            this.panel2.Controls.Add(current);
            current.Show();
        }

       

        private void timer1_Tick(object sender, EventArgs e)
        {

            Setup setup = new Setup();
            string myDate = DateTime.Now.ToString("MM.dd.yyyy") + "   " + DateTime.Now.ToLongTimeString();

            int count = setup.getVotedPopulation();
            lblVoted.Text = count.ToString();
            lblTime.Text = myDate;
            lblPopulation.Text = totalStudent().ToString();
            lblPending.Text = (totalStudent() - count).ToString();
        }

        public int totalStudent()
        {
            // Step 1. Creates an instance of DbConnHelper
            DbConnHelpe helper = new DbConnHelpe();

            // Step 2. Open a connection
            SqlConnection conn = helper.OpenConnection();

            // Step 3. Check the state of the connection.
            if (conn.State != ConnectionState.Open)
            {
                MessageBox.Show("Connection failed!");
                return 0;
            }

            // NOTE: From this point onwards we are sure that we are connected to the DB.
            // Step 4. Prepare parameters.
            var spParam = new SqlParameter[]{
              
            };

            // Step 5. Create a command.
            SqlCommand cmd = helper.CreateCommand(conn, "spTotalStudent", spParam);

            // Step 6. Execute the command.
            int total = (int)cmd.ExecuteScalar();


            helper.CloseConnection(conn);

            return total;
        }

        private void btnAddRecord_Click(object sender, EventArgs e)
        {
            this.panel2.Controls.Remove(current);
            current = new AddRecord();
            current.AutoScroll = true;
            this.panel2.Controls.Add(current);
            current.Show();
        }

        private void btnViewRecord_Click(object sender, EventArgs e)
        {
            this.panel2.Controls.Remove(current);
            current = new viewRecord();
            current.AutoScroll = true;
            this.panel2.Controls.Add(current);
            current.Show();
        }

        private void btnAssignStudent_Click(object sender, EventArgs e)
        {
            this.panel2.Controls.Remove(current);
            current = new assignRoom();
            current.AutoScroll = true;
            this.panel2.Controls.Add(current);
            current.Show();
        }

        private void btnViewSection_Click(object sender, EventArgs e)
        {
            this.panel2.Controls.Remove(current);
            current = new ViewSection();
            current.AutoScroll = true;
            this.panel2.Controls.Add(current);
            current.Show();
        }

        private void btnAddCandidate_Click(object sender, EventArgs e)
        {
            this.panel2.Controls.Remove(current);
            current = new Add_Candidate();
            current.AutoScroll = true;
            this.panel2.Controls.Add(current);
            current.Show();
        }

        private void btnUpdateCandidate_Click(object sender, EventArgs e)
        {
            this.panel2.Controls.Remove(current);
            current = new Update_Candidate();
            current.AutoScroll = true;
            this.panel2.Controls.Add(current);
            current.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you really want to log-out?", "Message", MessageBoxButtons.OKCancel);
            
            if (result == DialogResult.OK)
            {
                this.Close();
            }
    
        }

        

        private void btnResult_Click_1(object sender, EventArgs e)
        {
            this.panel2.Controls.Remove(current);
            current = new VoteResults();
            current.AutoScroll = true;
            this.panel2.Controls.Add(current);
            current.Show();
        }

      

      

    }
}
