using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSBank
{
    static class WSAPI
    {
        public static bool makeTransaction(WSDB db, string sender_uid,string receiver_login,int amount)
        {
            try
            {
                var cmd = new MySqlCommand();
                cmd.Connection = db.getConnection();
                String s = String.Format("UPDATE users SET balance=balance-{0} WHERE userid='{1}'", amount, sender_uid);
                cmd.CommandText = s;
                cmd.ExecuteNonQuery();
                s = String.Format("UPDATE users SET balance=balance+{0} WHERE username='{1}'", amount, receiver_login);
                cmd.CommandText = s;
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public static int getBalance(WSDB db, string userid)
        {
            try
            {
                String s = String.Format("SELECT * FROM users WHERE userid='{0}'", userid);
                MySqlCommand cmd = new MySqlCommand(s, db.getConnection());
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    int balance = reader.GetInt32(7);
                    reader.Close();
                    return balance ;
                }
                else
                {
                    reader.Close();
                    return -1;
                }
            }
            catch (Exception ex)
            {
                return -1;
            }
        }
        public static bool registerUser(WSDB db, string fname,string lname,string login, string password,int balance)
        {
            try
            {
                Guid g = Guid.NewGuid();
                string userid = g.ToString();
                string timestamp = ((Int32)(DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1))).TotalSeconds).ToString();
                var cmd = new MySqlCommand();
                cmd.Connection = db.getConnection();
                String s = String.Format("INSERT INTO users (userid,username,password,fname,lname,timestamp,balance) VALUES('{0}','{1}','{2}','{3}','{4}',{5},{6})", userid, login, password, fname, lname, timestamp, balance.ToString());
                cmd.CommandText = s;
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
            
        }
        public static bool deleteUser(WSDB db,string userid)
        {
            try
            {
                var cmd = new MySqlCommand();
                cmd.Connection = db.getConnection();
                String s = String.Format("DELETE FROM users WHERE userid='{0}'", userid);
                cmd.CommandText = s;
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public static WSUser loginUser(WSDB db, string login,string password)
        {
            
            try
            {
                String s = String.Format("SELECT * FROM users WHERE username='{0}' AND password='{1}'", login, password);
                MySqlCommand cmd = new MySqlCommand(s, db.getConnection());
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    WSUser tuser = new WSUser(reader.GetString(1), reader.GetString(4), reader.GetString(5), reader.GetInt32(6), reader.GetInt32(7));
                    reader.Close();
                    return tuser;
                }
                else
                {
                    reader.Close();
                    return null;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
        public static bool loginAvailable(WSDB db, string login)
        {
            try
            {
                String s = String.Format("SELECT * FROM users WHERE username='{0}'", login);
                MySqlCommand cmd = new MySqlCommand(s, db.getConnection());
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    reader.Close();
                    return false;
                }
                else
                {
                    reader.Close();
                    return true;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
