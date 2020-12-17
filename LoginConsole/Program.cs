using System;
using System.Data.Common;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Linq;

namespace LoginConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            MySqlConnection mySqlConnection = new MySqlConnection("Server=localhost;Database=db_users;Uid=root;Pwd=CSS144");
            mySqlConnection.Open();
           
        }
    }
}
