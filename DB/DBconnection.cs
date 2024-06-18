using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Mysqlx.Crud;


namespace AirProject.DB

{
    internal static class DBconnection
    {

        private static string connSetting = "Server=localhost;Database=boat_project;Uid=root;pwd=2999;charset=utf8;";
        public static MySqlConnection connection;
        public static void dbInit() {
            try
            {
                connection = new MySqlConnection(connSetting);
                Console.WriteLine("Соединение установленно)");
            }catch (Exception ex)
            {
                Console.WriteLine("Соединение провалено(");
                Console.WriteLine(ex.ToString());
            }
            
        }
        public static MySqlConnection getConnection(){
            return connection;
        }
        
            
    }
}
