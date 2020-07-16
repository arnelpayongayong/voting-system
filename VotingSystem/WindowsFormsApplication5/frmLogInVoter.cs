using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication5
{
    public partial class frmLogInVoter : Form
    {
        public frmLogInVoter()
        {
            InitializeComponent();
            timer1.Start();
        }
        int i = 0;
        bool check1 = false;
        bool check2 = false;
        bool check3 = false;
        bool check4 = false;
        private void frmLogInVoter_Load(object sender, EventArgs e)
        {
            timer1.Start();
            timer1.Interval = 1;
            panelLogin.Visible = false;
            pcbUser.Image = Image.FromFile(@"D:\WindowsFormsApplication5\User_96px.png");
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
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (check4 != true)
            {
                e.Cancel = true;
            }
            else
            {
                e.Cancel = false;
                this.Hide();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            
            if (txtUsername.Text.Equals("//@**Exit") == true)
            {
                check4 = true;
                this.Close();
            }
            
        }
    }
}
