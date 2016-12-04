using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session
{
    public class Database
    {
        OleDbConnection connection;
        OleDbCommand command;

        private void ConnectTo()
        {
            connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\BalatasSL\Database.accdb;Persist Security Info=False");
            command = connection.CreateCommand();
        }

        public Database()
        {
            ConnectTo();
        }

        public void Close_Database()
        {
            connection.Close();
        }

        public bool WriteDB(String querry)
        {
            try
            {
                command.CommandText = querry;
                command.CommandType = CommandType.Text;
                connection.Open();

                command.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }
        }

        public OleDbDataReader ReadDB(String querry)
        {
            try
            {
                command.CommandText = querry;
                command.CommandType = CommandType.Text;
                connection.Open();

                OleDbDataReader reader = command.ExecuteReader();

                return reader;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
