using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Green_house_chikale.Authn
{

    internal class Database
    {
        readonly MySqlConnection Connect = new MySqlConnection("datasource= localhost; port= 3306; username= root; password=; database= Greendb;convert Zero Datetime=True");

        public MySqlConnection GetConnection
        {
            get
            {
                return Connect;
            }
        }

        public void OpenConnection()
        {
            if (Connect.State == System.Data.ConnectionState.Closed)
                Connect.Open();
        }

        public void CloseConnection()
        {
            if (Connect.State == System.Data.ConnectionState.Open)
                Connect.Close();
        }

       
    }
}


