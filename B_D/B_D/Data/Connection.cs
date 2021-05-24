using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace B_D_111.Data
{
    class Connection
    {
        public static MySqlConnection connMaster = new MySqlConnection();

        static string server = "127.0.0.1";
        static string database = "ломбард";
        static string Uid = "root";
        static string password = "root";
      //  static string port = "3306";

        public static MySqlConnection dataSource()

        {
            try
            {
                connMaster = new MySqlConnection($"server ={server} database={database} Uid={Uid} password = {password} ");
                return connMaster;
            }
            catch (Exception)
            {
                throw new Exception("не подкл");
            }
        }
        public void connOpen()
        {
            dataSource();
            connMaster.Open();
        }
        public void connClose()
        {
            dataSource();
        connMaster.Close();

            }
    }
}
