using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StudentVoting
{
    public partial class Candidate : UserControl
    {
        public Candidate(string id,string image)
        {
            InitializeComponent();
            this.BackgroundImage = Image.FromFile(image);
            lblName.Text = id;
            int len = lblName.Text.Length;
            if (len >= 25)
            {
                lblName.Font = new Font("Century Gothic", 10, FontStyle.Regular);
                return;
            }
            int sizePadding = 60 - len;

            lblName.Padding = new Padding(sizePadding , 0, 0, 0);

        }

        private void Candidate_Load(object sender, EventArgs e)
        {
            
        }

       

        
        private void pictureBox1_Click(object sender, EventArgs e)
        {

            this.Candidate_MouseClick(sender, (MouseEventArgs)e);
        }

        private void Candidate_Click(object sender, EventArgs e)
        {
            
        }

        private void Candidate_MouseClick(object sender, MouseEventArgs e)
        {
            
        }
    }
}
