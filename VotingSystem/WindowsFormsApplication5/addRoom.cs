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
    public partial class addRoom : Form
    {
        public addRoom()
        {
            InitializeComponent();
        }

        Setup setup = new Setup();
        private void btnAdd_Click(object sender, EventArgs e)
        {
            setup.addRoom(txtSectionName.Text);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
