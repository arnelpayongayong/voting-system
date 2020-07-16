using System;
using System.Data;
using System.Data.SqlClient;
namespace WindowsFormsApplication5
{
    class DbConnHelpe
    {
        /// <summary>
        /// Closes a DB connection.
        /// </summary>
        /// <param name="dbConn"></param>
        public void CloseConnection(SqlConnection dbConn)
        {
            try
            {
                dbConn.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error occurred while closing the connection" + e.Message);
            }
        }

        /// <summary>
        /// Creates a DB command using the given DB connection.
        /// </summary>
        /// <param name="dbConn">The DB connection to reuse.</param>
        /// <param name="spName">The name of the stored procedure to execute.</param>\
        /// <param name="spParams">The SQL parameters needed by the stored procedure.</param>
        public SqlCommand CreateCommand(SqlConnection dbConn, string spName, SqlParameter[] spParams)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = dbConn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = spName;
            cmd.Parameters.AddRange(spParams);
            return cmd;
        }

        /// <summary>
        /// Executes an INSERT, DELETE or UPDATE query.
        /// </summary>
        /// <param name="dbConn">The DB connection to reuse.</param>
        /// <param name="spName">The name of the stored procedure to execute.</param>\
        /// <param name="spParams">The SQL parameters needed by the stored procedure.</param>
        public void ExecuteNonQuery(SqlConnection dbConn, string spName, SqlParameter[] spParams)
        {
            SqlCommand cmd = CreateCommand(dbConn, spName, spParams);
            cmd.ExecuteNonQuery();
        }

        /// <summary>
        /// Executes a SELECT query.
        /// </summary>
        /// <param name="dbConn">The DB connection to reuse.</param>
        /// <param name="spName">The name of the stored procedure to execute.</param>\
        /// <param name="spParams">The SQL parameters needed by the stored procedure.</param>
        /// <returns>The SQLDataReader to be used for accessing the results.</returns>
        public SqlDataReader ExecuteReader(SqlConnection dbConn, string spName, SqlParameter[] spParams)
        {
            SqlCommand cmd = CreateCommand(dbConn, spName, spParams);
            return cmd.ExecuteReader();
        }

        /// <summary>
        /// Creates and opens a DB connection.
        /// </summary>
        /// <returns></returns>
        public SqlConnection OpenConnection()
        {
            SqlConnection dbConn = new SqlConnection();

            // Provides the connection string
            dbConn.ConnectionString = @"Server=.\SQLExpress;" +
                "Integrated Security=SSPI;Database=voting_db";

            try
            {
                // Opens the connection
                dbConn.Open();
                return dbConn;
            }
            catch
            {
                // Error connecting to database
                return null;
            }
        }
    }
}
