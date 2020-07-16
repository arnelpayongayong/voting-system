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
    public partial class frmPopup : Form
    {
        public frmPopup(string _name,int _year,string _id)
        {
            InitializeComponent();
            lblname.Text = "Hey " + _name + ",";
            year = _year;
            id = _id;
            timer1.Start();
        }
        int year;
        string id;
        private void frmPopup_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Image.FromFile(@"F:\StudentVoting\Image\popbackground.png");
        }
        int seconds = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            seconds++;

            if (seconds > 30)
            {
                CandidateSetup setup = new CandidateSetup();
                timer1.Stop();
                frmVoter frm = new frmVoter(year,id);
                this.Hide();
                frm.ShowDialog();
                this.Close();
            }
        }
    }
}
