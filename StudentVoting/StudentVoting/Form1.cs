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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Image.FromFile(@"F:\StudentVoting\Image\submitbackground.png");
        }

        int second = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            second++;
            if (second > 50)
            {
                timer1.Stop();


                frmLogin frm = new frmLogin();

                this.Hide();
                frm.ShowDialog();
                this.Close();
                
            }
        }
    }
}
