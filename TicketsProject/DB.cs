using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketsProject
{
    internal class DB
    {
        SqlConnection connection = new SqlConnection("Data Source=(local)\\SNAPPIXPC;Initial Catalog=Automize_ticket;Integrated Security=True");
        //SqlConnection connection = new SqlConnection("Data Source=215PC10\\SQLEXPRESS;Initial Catalog=Automize_ticket;Integrated Security=True");

        public void openConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
                connection.Open();
        }
        public void closeConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
                connection.Close();
        }
        public SqlConnection getConnection()
        {
            return connection;
        }
    }
}
