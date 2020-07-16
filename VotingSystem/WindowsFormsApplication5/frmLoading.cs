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
    public partial class frmLoading : Form
    {
        public frmLoading()
        {
            InitializeComponent();
        }
        int i = 0;
        int sec = 0;
        private void frmLoading_Load(object sender, EventArgs e)
        {
            timer1.Interval = 200;
            timer1.Start();
            char drive = 'C';
            bool check = false;
            while (drive <= 'Z')
            {
                check = true;

                try
                {

                    this.BackgroundImage = Image.FromFile(drive + @":\VotingSystem\Image\background.jpg");         
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
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
         
            if (sec > 20)
            {
                frmLoginAdmin form2 = new frmLoginAdmin();
                timer1.Stop();
                
                this.Hide();
                form2.ShowDialog();
                this.Close();


            }

            i++;
            sec++;
        }
    }
}
