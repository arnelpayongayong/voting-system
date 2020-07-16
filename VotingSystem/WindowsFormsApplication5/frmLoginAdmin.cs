using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication5
{
    public partial class frmLoginAdmin : Form
    {
        public frmLoginAdmin()
        {
            InitializeComponent();
        }

        private void frmLoginAdmin_Load(object sender, EventArgs e)
        {

            char drive = 'C';
            bool check = false;
            while (drive <= 'Z')
            {
                check = true;

                try
                {

                    pcbLogo.Image = Image.FromFile(drive + @":\VotingSystem\Image\12.jpg");
                    pcbUserLogo.Image = Image.FromFile(drive + @":\VotingSystem\Image\User_80px.png");
                    
                }
                catch (Exception)
                {
                    check = false;

                }
                if (check == true)
                    break;
                drive++;

            }
            button1.BackColor = (TransparencyKey);
            
           
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void loginMethod()
        {
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
            var spParam = new SqlParameter[]{
                new SqlParameter("@username",txtUsername.Text),
                new SqlParameter("@password",txtPassword.Text),

            };

            // Step 5. Create a command.
            SqlCommand cmd = helper.CreateCommand(conn, "spLogin", spParam);

            // Step 6. Execute the command.
            if ((int)cmd.ExecuteScalar() != 0)
            {
                frmAdmin adminFrm = new frmAdmin();

                this.Hide();
                adminFrm.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid username or password please try again.", "Voting System Message");
            }


            helper.CloseConnection(conn);
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {

            loginMethod();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            
        }

  

       
    }
}
