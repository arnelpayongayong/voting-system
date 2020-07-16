using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
namespace StudentVoting
{
    public partial class pendingVote : UserControl
    {
        int[] arrayPending = new int[8];
        public pendingVote(int[] array,int _year)
        {
            InitializeComponent();
            Thread fill = new Thread(fillPictureBoxAndNameBlank);

            fill.Start();
            for (int i = 0; i < 8; i++)
            {
                arrayPending[i] = array[i];
            }
            year = _year;
        }

        int year;


        CandidateSetup setup = new CandidateSetup();
        private void pendingVote_Load(object sender, EventArgs e)
        {
         

            DataTable table = new DataTable();
            Person[] candidate = new Person[8];
          

            for (int i = 0; i < 8; i++)
            {
                string name = "";
                string filePath = "";
                candidate[i] = new Person();
                if (arrayPending[i] == 0)
                {
                    candidate[i].setName("None");
                    continue;
                }
                
                table = setup.selectCandidate(arrayPending[i]);
                name = table.Rows[0][1].ToString();
                filePath = table.Rows[0][0].ToString();
                fillPictureBoxAndName(filePath, name, i);
                
            }

            
        }

        public void fillPictureBoxAndName(string filePath, string name,int index)
        {
            switch (index)
            {
                case 0:
                    pcbPresident.Image = Image.FromFile(filePath);
                    lblPresident.Text = name;
                    break;
                case 1:
                    pcbVicePresident.Image = Image.FromFile(filePath);
                    lblVicePresident.Text = name;
                    break;
                case 2:
                    pcbSecretary.Image = Image.FromFile(filePath);
                    lblSecretary.Text = name;
                    break;
                case 3:
                    pcbAuditor.Image = Image.FromFile(filePath);
                    lblAuditor.Text = name;
                    break;
                case 4:
                    showRepresentative(filePath,name);
                    break;
                
            }
        }

        public void fillPictureBoxAndNameBlank()
        {
            pcbPresident.Image = Image.FromFile(@"F:\StudentVoting\Image\sample.png");
            pcbVicePresident.Image = Image.FromFile(@"F:\StudentVoting\Image\sample.png");
            pcbSecretary.Image = Image.FromFile(@"F:\StudentVoting\Image\sample.png");
            pcbAuditor.Image = Image.FromFile(@"F:\StudentVoting\Image\sample.png");
            pcb4th.Image = Image.FromFile(@"F:\StudentVoting\Image\sample.png");
            pcb3rd.Image = Image.FromFile(@"F:\StudentVoting\Image\sample.png");
            pcb2nd.Image = Image.FromFile(@"F:\StudentVoting\Image\sample.png");
            pcb1st.Image = Image.FromFile(@"F:\StudentVoting\Image\sample.png");
        }

        public void showRepresentative(string filePath,string name)
        {
            switch (year)
            {
                case 7:
                    pcb1st.Visible = true;
                    lbl1st.Visible = true;
                    panel1st.Visible = true;
                    pcb1st.Image = Image.FromFile(filePath);
                    lbl1st.Text = name;
                    break;
                case 8:
                    pcb2nd.Visible = true;
                    lbl2th.Visible = true;
                    panel2nd.Visible = true;
                    pcb2nd.Image = Image.FromFile(filePath);
                    lbl2th.Text = name;
                    break;
                case 9:
                    pcb3rd.Visible = true;
                    lbl3rd.Visible = true;
                    panel3rd.Visible = true;
                    pcb3rd.Image = Image.FromFile(filePath);
                    lbl3rd.Text = name;
                    break;
                case 10:
                    pcb4th.Visible = true;
                    lbl4th.Visible = true;
                    panel4th.Visible = true;
                    pcb4th.Image = Image.FromFile(filePath);
                    lbl4th.Text = name;
                    break;
            }
        }

       

        
    }
}
