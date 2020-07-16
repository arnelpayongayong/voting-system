using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StudentVoting
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            timer1.Start();
        }
        int i = 0;
        bool check1 = false;
        bool check2 = false;
        bool check3 = false;
        

        CandidateSetup setup = new CandidateSetup();

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1;
            panelLogin.Visible = false;
            
            char drive = 'C';
            bool check = false;
            while (drive <= 'Z')
            {
                check = true;

                try
                {

                    pcbUser.Image = Image.FromFile(@"F:\StudentVoting\Image\User_96px.png");

                }
                catch (Exception)
                {
                    check = false;

                }
                if (check == true)
                    break;
                drive++;

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (label1.Location.Y < 103 && check1 != true)
            {
                i++;

            }
            else if (label1.Location.Y > 56 && check2 != true)
            {
                check1 = true;
                i--;
            }
            else if (check3 != true)
            {
                check2 = true;
                i++;
            }
            if (label1.Location.Y > 103)
            {
                timer1.Stop();
                panelLogin.Visible = true;
            }


            label1.Location = new Point(67, i);
        }

       

        private void btnLogin_Click(object sender, EventArgs e)
        {

           
            if (setup.login(txtUsername.Text) != 0)
            {
                if (setup.loginValidation(txtUsername.Text) > 0)
                {
                    MessageBox.Show("You have been voted recently");
                    return;
                }
                else
                {
                    string name = setup.getName(txtUsername.Text);
                    string id = setup.getStudentID(txtUsername.Text);
                    int year = setup.getYearLevel(txtUsername.Text);
                    frmPopup frm = new frmPopup(name,year,id);
                    this.Hide();
                    frm.ShowDialog();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Please check your student i.d");
            }
        }
    }
}
