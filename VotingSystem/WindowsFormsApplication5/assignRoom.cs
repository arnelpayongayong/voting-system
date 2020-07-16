using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace WindowsFormsApplication5
{
    public partial class assignRoom : UserControl
    {
        public assignRoom()
        {
            InitializeComponent();
        }
        Setup setup = new Setup();


        private void assignRoom_Load(object sender, EventArgs e)
        {
            
            setup.fillSearchBox(txtSearch);
            setup.showSection(cmbRoom);
        }
       
        private void txtOther_Click(object sender, EventArgs e)
        {
            addRoom room = new addRoom();

            room.ShowDialog();
            
        }

        public void emptyTextBox()
        {
            txtId.Text = "";
            txtfname.Text = "";
            txtmname.Text = "";
            txtlname.Text = "";
            txtYearLevel.Text = "";
  
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                emptyTextBox();
            }

            DataTable table = new DataTable();
            table = setup.selectStudent(txtSearch.Text);


            try
            {
                txtId.Text= table.Rows[0][0].ToString();
                txtfname.Text = table.Rows[0][1].ToString();
                txtmname.Text = table.Rows[0][2].ToString();
                txtlname.Text = table.Rows[0][3].ToString();
                txtYearLevel.Text = table.Rows[0][8].ToString();
               

            }
            catch (Exception)
            {

                return;
            }
        }

        private void cmbRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = setup.getSectionID(cmbRoom.SelectedItem.ToString());
            txtTotalStudent.Text = setup.getSectionPopulation(index).ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int index = setup.getSectionID(cmbRoom.SelectedItem.ToString());


            if (setup.insertStudentToRoom(txtId.Text, index) != false)
            {
                DialogResult result = MessageBox.Show("Do you want to transfer this student to another room?", "Message", MessageBoxButtons.OKCancel);

                if (result == DialogResult.OK)
                {
                    setup.updateStudentRoom(txtId.Text, index);
                }
            }
            
            
        }
        
    }
}
