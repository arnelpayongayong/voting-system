using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
namespace WindowsFormsApplication5
{
    public partial class addStudent : UserControl
    {
        public addStudent()
        {
            InitializeComponent();
        }
        string fileName = string.Empty;
        private void UserControl1_Load(object sender, EventArgs e)
        {
            cmbYearLevel.SelectedIndex = 0;
            cmbGender.SelectedIndex = 0;
           
        }
        Setup setup = new Setup();


        public void clearTextBox()
        {
            txtID.Text = "";
            txtfname.Text = "";
            txtmname.Text = "";
            txtlname.Text = "";
            cmbYearLevel.Text = "";
            txtContact.Text = "";
            txtpostal.Text = "";
            txtBuilding.Text = "";
            txtstname.Text = "";
            txtcity.Text = "";
        }

        public bool validSubmit(string id, string fname, string mname, string lname, string postal, string stname, string building, string city, string contact, string year)
        {
            if (id == "" || fname == "" || mname == "" || lname == "" || postal == "" || city == "" || building == "" || stname == "" || contact == "")
                return false;

            return true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            try
            {
                string year_level = cmbYearLevel.SelectedItem.ToString();
                char gender = char.Parse(cmbGender.SelectedItem.ToString());
                if (setup.addStudent(txtID.Text, txtfname.Text, txtmname.Text, txtlname.Text, txtpostal.Text, txtstname.Text, txtBuilding.Text, txtcity.Text, txtContact.Text, year_level, dateTimePicker1.Value.ToShortDateString(), gender) != 1)
                {
                    throw new Exception("Error");
                }
                else
                {
                    MessageBox.Show("Successfully inserting data");
                    clearTextBox();
                }
            }
            catch (Exception)
            {
                
            }
           
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            frmImport importFrm = new frmImport();
            importFrm.ShowDialog();
              
        }

        private void txtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !(e.KeyChar == '-'))
            {
                e.Handled = true;
            }
        }

        private void txtContact_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtpostal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        

      
       

       

        

       

       

        
    }
}
