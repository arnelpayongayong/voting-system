using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace StudentVoting
{
    public partial class frmVoter : Form
    {
        public frmVoter(int _year,string stud_id)
        {
            InitializeComponent();
            year = _year;
            id = stud_id;
        }
        int year;
        string id = "";
        CandidateSetup setup = new CandidateSetup();
        List<string> listCandidate = new List<string>();
        int[] listPending = new int[8];
        int index = 0;
        public int counter = 0;
        int size = 0;
        public void viewCandidate(DataTable table)
        {
            for (int i = 0; i < table.Rows.Count; i++)
            {

                string name = table.Rows[i][0].ToString();
                string id = table.Rows[i][1].ToString();
                string filePath = table.Rows[i][2].ToString();

                Candidate candidate = new Candidate(name, filePath);
                candidate.Name = id;
                candidate.Click += new EventHandler(b_click);
                candidate.Size = new Size(300, 400);
                flowLayoutPanel1.Controls.Add(candidate);



            }
        }

        public void viewsCandidate(DataTable table)
        {
            for (int i = 0; i < table.Rows.Count; i++)
            {

                string name = table.Rows[i][0].ToString();
                string id = table.Rows[i][1].ToString();
                string filePath = table.Rows[i][2].ToString();

                Label padding = new Label();
                padding.Size = new Size(70, 50);
                Candidate candidate = new Candidate(name, filePath);
                candidate.Name = id;
                candidate.Click += new EventHandler(b_click);
                candidate.Size = new Size(250, 290);
               
               
                flowLayoutPanel1.Controls.Add(padding);
                flowLayoutPanel1.Controls.Add(candidate);

            }
        }

        public void fillPosition()
        {
            DataTable table = new DataTable();
            table = setup.viewPosition();
            size = table.Rows.Count;
            for (int i = 0; i < size; i++)
            {
                listCandidate.Add(table.Rows[i]["pos_name"].ToString());
            }

            switch (year)
            {
                case 7:
                    listCandidate.Remove("3rd Representative");
                    listCandidate.Remove("4th Representative");
                    listCandidate.Remove("2nd Representative");
                    break;
                case 8:
                    listCandidate.Remove("4th Representative");
                    listCandidate.Remove("3rd Representative");
                    listCandidate.Remove("1st Representative");
                    break;
                case 9:
                    listCandidate.Remove("4th Representative");
                    listCandidate.Remove("2nd Representative");
                    listCandidate.Remove("1st Representative");
                    break;
                case 10:
                    listCandidate.Remove("3rd Representative");
                    listCandidate.Remove("2nd Representative");
                    listCandidate.Remove("1st Representative");
                    break;
                default:
                    listCandidate.Remove("4th Representative");
                    listCandidate.Remove("3rd Representative");
                    listCandidate.Remove("2nd Representative");
                    listCandidate.Remove("1st Representative");
                    size = 4;
                    return;
                    
            }

            size = 5;
            
        }

        private void frmVoter_Load(object sender, EventArgs e)
        {

            fillPosition();
            btnNext.Image = Image.FromFile(@"F:\StudentVoting\Image\forward_48px.png");
            btnPrev.Image = Image.FromFile(@"F:\StudentVoting\Image\prev.png");
            DataTable table = new DataTable();
            btnSubmit.Location = new Point(btnSubmit.Location.X + 50, btnSubmit.Location.Y);
            btnBack.Location = new Point(btnBack.Location.X + 50, btnBack.Location.Y);
            pcbSchoolLogo.Image = Image.FromFile(@"F:\StudentVoting\Image\schoollogo.jpg");
            pcbUSGLOGO.Image = Image.FromFile(@"F:\StudentVoting\Image\SSGLOGO.png");
            this.panel1.Size = new Size(1920, this.panel1.Height);
            pcbUSGLOGO.Location = new Point(1350,this.pcbUSGLOGO.Location.Y);
            this.WindowState = FormWindowState.Maximized;
            this.flowLayoutPanel1.Location = new Point(this.flowLayoutPanel1.Location.X - 80 , this.flowLayoutPanel1.Location.Y);
            this.flowLayoutPanel1.Size = new Size(this.Size.Width, this.Size.Height);
           
            this.btnPrev.Location = new Point(this.Width / 2 - 100, this.Height - 100);
            this.btnNext.Location =  new Point(this.Width / 2 + 100, this.Height - 100);

            table = setup.viewCandidate("President");

            viewsCandidate(table);
        
        }

        
        public void b_click(object sender, EventArgs e)
        {

            counter++;
            
            UserControl user = sender as UserControl;
            
            listPending[index] = Int32.Parse(user.Name);
            flowLayoutPanel1.Controls.Clear();

            if (counter >= size)
            {
                flowLayoutPanel1.Controls.Clear();
                label1.Text = "Submit Form";
                pendingVote pending = new pendingVote(listPending,year);
                flowLayoutPanel1.Controls.Add(pending);
                btnNext.Visible = false;
                btnPrev.Visible = false;
                flowLayoutPanel1.Location = new Point(flowLayoutPanel1.Location.X + 200, flowLayoutPanel1.Location.Y);
                index++;
                btnBack.Visible = true;
                btnSubmit.Visible = true;
                return;
            }
            fillCandidate();
            index++;
            
           
            
        }

        public void fillCandidate()
        {
            DataTable table = new DataTable();
            table = setup.viewCandidate(listCandidate[counter]);
            label1.Text = listCandidate[counter];
            viewsCandidate(table);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (counter >= size - 1)
            {
                flowLayoutPanel1.Controls.Clear();
                pendingVote pending = new pendingVote(listPending, year);
                label1.Text = "Submit Form";
                flowLayoutPanel1.Controls.Add(pending);
                btnNext.Visible = false;
                btnPrev.Visible = false;
                flowLayoutPanel1.Location = new Point(flowLayoutPanel1.Location.X + 200, flowLayoutPanel1.Location.Y);
                index++;
                counter++;
                btnBack.Visible = true;
                btnSubmit.Visible = true;
                return;
            }

            flowLayoutPanel1.Controls.Clear();
            counter++;
            index++;
            
            fillCandidate();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (counter <= 0)
            {
                return;
            }
            flowLayoutPanel1.Controls.Clear();
            counter--;
            index--;
            
            fillCandidate();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            counter--;
            index--;
            
            fillCandidate();
            btnSubmit.Visible = false;
            btnBack.Visible = false;
            btnPrev.Visible = true;
            btnNext.Visible = true;
            flowLayoutPanel1.Location = new Point(flowLayoutPanel1.Location.X - 200, flowLayoutPanel1.Location.Y);
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= size; i++)
            {

                if (listPending[i] == 0)
                    continue;
                setup.insertVote(id, listPending[i]);
            }

            Form1 frm = new Form1();

            this.Hide();
            frm.ShowDialog();
            this.Close();



        }


        

        
       
    }
}
