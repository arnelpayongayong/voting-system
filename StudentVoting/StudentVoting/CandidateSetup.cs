using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace StudentVoting
{
    class CandidateSetup
    {

        public DataTable viewCandidate(string position)
        {
            DataTable table = new DataTable();
            DbConnHelper helper = new DbConnHelper();
            SqlConnection conn = helper.OpenConnection();

            if (conn.State != ConnectionState.Open)
            {
                MessageBox.Show("ERROR CONNECTING");
                return table;
            }
            var spParams = new SqlParameter[]
            {
                new SqlParameter("@pos_name",position)
            };

            SqlCommand cmd = helper.CreateCommand(conn, "spVotingCandidate", spParams);
            
            table.Load(cmd.ExecuteReader());
            helper.CloseConnection(conn);
            return table;
        }

        public DataTable viewPosition()
        {
            DataTable table = new DataTable();
            DbConnHelper helper = new DbConnHelper();
            SqlConnection conn = helper.OpenConnection();

            if (conn.State != ConnectionState.Open)
            {
                MessageBox.Show("ERROR CONNECTING");
                return table;
            }
            var spParams = new SqlParameter[]
            {
               
            };

            SqlCommand cmd = helper.CreateCommand(conn, "spShowPosition", spParams);

            table.Load(cmd.ExecuteReader());
            helper.CloseConnection(conn);
            return table;
        }

        public DataTable selectCandidate(int id)
        {
            DataTable table = new DataTable();
            DbConnHelper helper = new DbConnHelper();
            SqlConnection conn = helper.OpenConnection();

            if (conn.State != ConnectionState.Open)
            {
                MessageBox.Show("ERROR CONNECTING");
                return table;
            }
            var spParams = new SqlParameter[]
            {
               new SqlParameter("@candidate_id",id)
            };

            SqlCommand cmd = helper.CreateCommand(conn, "spCandidateInformation", spParams);

            table.Load(cmd.ExecuteReader());
            helper.CloseConnection(conn);
            return table;
        }

        public void insertVote(string stud_id, int candidate_id)
        {
            DbConnHelper helper = new DbConnHelper();
            SqlConnection conn = helper.OpenConnection();

            if (conn.State != ConnectionState.Open)
            {
                MessageBox.Show("ERROR CONNECTING");
                return;
            }
            var spParams = new SqlParameter[]
            {
               new SqlParameter("@stud_id",stud_id),
               new SqlParameter("@candidate_id",candidate_id)
            };

            SqlCommand cmd = helper.CreateCommand(conn, "spInsertVote", spParams);

            cmd.ExecuteNonQuery();
            helper.CloseConnection(conn);
        }

        public int loginValidation(string stud_id)
        {
            DbConnHelper helper = new DbConnHelper();
            SqlConnection conn = helper.OpenConnection();

            if (conn.State != ConnectionState.Open)
            {
                MessageBox.Show("ERROR CONNECTING");
                return 0;
            }
            var spParams = new SqlParameter[]
            {
               new SqlParameter("@stud_id",stud_id),
            };

            SqlCommand cmd = helper.CreateCommand(conn, "spVoterValidation", spParams);

            int count = (int)cmd.ExecuteScalar();
           helper.CloseConnection(conn);

           return count;
        }

        public int login(string stud_id)
        {
            DbConnHelper helper = new DbConnHelper();
            SqlConnection conn = helper.OpenConnection();

            if (conn.State != ConnectionState.Open)
            {
                MessageBox.Show("ERROR CONNECTING");
                return 0;
            }
            var spParams = new SqlParameter[]
            {
               new SqlParameter("@stud_id",stud_id),
            };

            SqlCommand cmd = helper.CreateCommand(conn, "spVoterLogin", spParams);

            int count = (int)cmd.ExecuteScalar();
            helper.CloseConnection(conn);

            return count;
        }

        public string  getName(string stud_id)
        {
            DbConnHelper helper = new DbConnHelper();
            SqlConnection conn = helper.OpenConnection();

            if (conn.State != ConnectionState.Open)
            {
                MessageBox.Show("ERROR CONNECTING");
                return "";
            }
            var spParams = new SqlParameter[]
            {
               new SqlParameter("@stud_id",stud_id),
            };

            SqlCommand cmd = helper.CreateCommand(conn, "spGetName", spParams);

            string name = cmd.ExecuteScalar().ToString();
            helper.CloseConnection(conn);

            return name;
        }

        public int getYearLevel(string stud_id)
        {
            DbConnHelper helper = new DbConnHelper();
            SqlConnection conn = helper.OpenConnection();

            if (conn.State != ConnectionState.Open)
            {
                MessageBox.Show("ERROR CONNECTING");
                return 0;
            }
            var spParams = new SqlParameter[]
            {
               new SqlParameter("@stud_id",stud_id),
            };

            SqlCommand cmd = helper.CreateCommand(conn, "spGetYearLevel", spParams);

            int count = Int32.Parse(cmd.ExecuteScalar().ToString());
            helper.CloseConnection(conn);

            return count;
        }

        public string getStudentID(string stud_id)
        {
            DbConnHelper helper = new DbConnHelper();
            SqlConnection conn = helper.OpenConnection();

            if (conn.State != ConnectionState.Open)
            {
                MessageBox.Show("ERROR CONNECTING");
                return "";
            }
            var spParams = new SqlParameter[]
            {
               new SqlParameter("@stud_id",stud_id),
            };

            SqlCommand cmd = helper.CreateCommand(conn, "spGetStudentID", spParams);

            string id = cmd.ExecuteScalar().ToString();
            helper.CloseConnection(conn);

            return id;
        }
    }
}
