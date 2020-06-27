using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace WSBank
{
    class WSDB
    {
        private MySqlConnection conn;
        private string connectionString;
        public WSDB(string login,string password,string host,string dbname)
        {
            this.connectionString = "server="+host+";database="+dbname+";uid="+login+";pwd="+password+";";
        }
        public bool connect()
        {
            conn = new MySqlConnection(connectionString);
            try
            {
                conn.Open();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool close()
        {
            try
            {
                conn.Close();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }
        public MySqlConnection getConnection()
        {
            return conn;
        }
    }
}
