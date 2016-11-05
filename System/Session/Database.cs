using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using System.Data;
using System.Windows.Forms;

namespace Session
{
    public class Database
    {
        OleDbConnection connection;
        OleDbCommand command;

        private void ConnectTo()
        {
            connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Pandemonium\Documents\Visual Studio 2015\Projects\System\Database.accdb;Persist Security Info=False");
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

        public void WriteDB(String querry)
        {
            try
            {
                command.CommandText = querry;
                command.CommandType = CommandType.Text;
                connection.Open();

                command.ExecuteNonQuery();
            }
            catch(Exception)
            {
                throw;
            }
            finally
            {
                if(connection != null)
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
