using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
namespace WindowsFormsApplication5
{
    public partial class frmImport : Form
    {
        public frmImport()
        {
            InitializeComponent();
        }
        Setup setup = new Setup();
        string filename = string.Empty;
        private void txtBrowse_Click(object sender, EventArgs e)
        {
            filename = string.Empty;
            OpenFileDialog file = new OpenFileDialog();

    
            file.Filter = "Excel (*.xlsx ) |  *xlsx";
            file.ShowDialog();
            filename = file.FileName.ToString();

            //Read Excel File Using Microsoft.Office.Interop.Excel
            dataGridView1.DataSource =  setup.readFileExcel(filename);
           
            
        }

        private void txtSubmit_Click(object sender, EventArgs e)
        {
            string id = "", fname = "", mname = "", lname = "", year_level = "", contactno = "", building = "", stname = "", city = "", postal = "",gender = "";
            string date = "";
            for (int i = 1; i < dataGridView1.Rows.Count; i++)
            {
                try
                {

                    for (int j = 0; j < dataGridView1.ColumnCount; j++)
                    {
                        id = (dataGridView1.Rows[i].Cells[0].FormattedValue.ToString());
                        fname = (dataGridView1.Rows[i].Cells[1].FormattedValue.ToString());
                        mname = (dataGridView1.Rows[i].Cells[2].FormattedValue.ToString());
                        lname = (dataGridView1.Rows[i].Cells[3].FormattedValue.ToString());
                        year_level = (dataGridView1.Rows[i].Cells[4].FormattedValue.ToString());
                        contactno = (dataGridView1.Rows[i].Cells[5].FormattedValue.ToString());
                        building = (dataGridView1.Rows[i].Cells[6].FormattedValue.ToString());
                        stname = (dataGridView1.Rows[i].Cells[7].FormattedValue.ToString());
                        city = (dataGridView1.Rows[i].Cells[8].FormattedValue.ToString());
                        postal = (dataGridView1.Rows[i].Cells[9].FormattedValue.ToString());
                        gender = (dataGridView1.Rows[i].Cells[10].FormattedValue.ToString());
                        date = (dataGridView1.Rows[i].Cells[11].FormattedValue.ToString());
                    }
                    if (!(Int32.Parse(year_level) >= 7) && !((Int32.Parse(year_level) <= 12)))
                        return;

                    char c = char.Parse(gender);
                    setup.addStudent(id, fname, mname, lname, postal, stname, building, city, contactno, year_level, date, c);
                }
                catch (Exception) { }

            }
            

        }
    }
}
