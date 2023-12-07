using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Komis
{
    public class DataBaseManager
    {
        private static DataBaseManager instance;
        private MySqlConnection connection;

        private DataBaseManager()
        {
            InitializeConnection(); 
        }
        
        public static DataBaseManager Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DataBaseManager();
                }
                return instance;
            }
        }

        private void InitializeConnection()
        {
            string connectionString = "Server=localhost; DataBase=komissamochodowy; Uid=root; Pwd=Supernoob234"; 
            connection = new MySqlConnection(connectionString);
        }

        public MySqlConnection GetConnection()
        {
            return connection;
        }
    }
}
