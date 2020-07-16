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
    public partial class AddRecord : UserControl
    {
        public AddRecord()
        {
            InitializeComponent();
        }

        Setup setup = new Setup();
        private void AddRecord_Load(object sender, EventArgs e)
        {
            setup.fillSearchBox(txtID);

        }

        public void clear()
        {
            txtID.Text = "";
            txtViolation.Text = "";
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            setup.addNewRecord(txtViolation.Text);
            int index = setup.getNewRecord();
            setup.studentAddRecord(txtID.Text, index.ToString());
            clear();
            MessageBox.Show("Successfully added new record");

        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {
            if (txtID.Text == "")
            {
                txtID.Text = "";
                txtfname.Text = "";
                txtmname.Text = "";
                txtlname.Text = "";
            }
            // Step 1. Creates an instance of DbConnHelper
            DbConnHelpe helper = new DbConnHelpe();

            // Step 2. Open a connection
            SqlConnection conn = helper.OpenConnection();

            // Step 3. Check the state of the connection.
            if (conn.State != ConnectionState.Open)
            {
                MessageBox.Show("Connection failed!");
                return;
            }

            // NOTE: From this point onwards we are sure that we are connected to the DB.
            // Step 4. Prepare parameters.
            var spParams = new SqlParameter[] { 
                new SqlParameter("@stud_id",txtID.Text.Trim())
          
            };

            // Step 5. Create a command.

            SqlDataAdapter sample = new SqlDataAdapter(helper.CreateCommand(conn, "spSearchStudent", spParams));

            // Step 6. Execute the command.
            DataTable table = new DataTable();
            sample.Fill(table);


            try
            {
                txtID.Text = table.Rows[0][0].ToString();
                txtfname.Text = table.Rows[0][1].ToString();
                txtmname.Text = table.Rows[0][2].ToString();
                txtlname.Text = table.Rows[0][3].ToString();
               
            }
            catch (Exception)
            {
                helper.CloseConnection(conn);
                return;
            }

            helper.CloseConnection(conn);
        }

        private void txtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) )
            {
                e.Handled = true;
            }
        }

       
    }
}
