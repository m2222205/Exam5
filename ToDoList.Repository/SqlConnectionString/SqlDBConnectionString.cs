using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList.Repository.SqlConnectionString
{
    public class SqlDBConnectionString
    {
        private string ConnectionString;

        public string connectionString
        {
            get { return ConnectionString; }
            set { ConnectionString = value; }
        }

        public SqlDBConnectionString(string connectionString)
        {
            connectionString = ConnectionString;
        }

    }
}
