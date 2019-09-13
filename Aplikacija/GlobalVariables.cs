using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;


namespace Aplikacija
{
    public sealed class GlobalVariables
    {
        private static GlobalVariables instance = new GlobalVariables();
        private int id_acc=-1;

        public static GlobalVariables Instance
        {
            get
            {
                return instance;
            }
        }

        private GlobalVariables()
        {
           
        }

        public int getIdAcc()
        {
            return this.id_acc;
        }

        public void setIdAcc(string username)
        {
            SQLiteConnection con = new SQLiteConnection("Data Source = Account.db; Version = 3");
            con.Open();

            SQLiteCommand cmd = new SQLiteCommand();

            string query = @"SELECT Account_ID FROM Account WHERE username ='" + username + "'";
            cmd.CommandText = query;
            cmd.Connection = con;


            this.id_acc = Convert.ToInt32(cmd.ExecuteScalar());

        }
       
    }
}