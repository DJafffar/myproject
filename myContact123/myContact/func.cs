using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace myContact
{
    internal class func
    {
        private SqlConnection Con;
        private SqlCommand Cmd;
        private DataTable dt;
        private SqlDataAdapter sda;
        private string ConStr;

        public func()
        {
            // Remove Encrypt=True from the connection string
            ConStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Dell\OneDrive\Documents\Student.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=True";

            Con = new SqlConnection(ConStr);
            Cmd = new SqlCommand();
            Cmd.Connection = Con;

            dt = new DataTable();
            sda = new SqlDataAdapter();
        }

        public DataTable GetData(string Query)
        {
            try
            {
                dt.Clear();
                using (SqlCommand command = new SqlCommand(Query, Con))
                using (sda = new SqlDataAdapter(command))
                {
                    sda.Fill(dt);
                }
            }
            catch (SqlException ex)
            {
                // Handle specific SQL-related exceptions
                Console.WriteLine("SQL Exception: " + ex.Message);
            }
            catch (Exception ex)
            {
                // Handle other exceptions
                Console.WriteLine("Exception: " + ex.Message);
            }
            return dt;
        }

        public int SetData(string Query, List<SqlParameter> parameters)
        {
            int cnt = 0;
            if (Con.State == ConnectionState.Closed)
            {
                Con.Open();
            }

            // Create a new SqlCommand for each SetData call
            using (SqlCommand command = new SqlCommand(Query, Con))
            {
                // Clear existing parameters before adding new ones
                command.Parameters.Clear();

                // Add parameters to the command
                foreach (var parameter in parameters)
                {
                    command.Parameters.Add(parameter);
                }

                cnt = command.ExecuteNonQuery();
            }

            return cnt;
        }
    }
}
