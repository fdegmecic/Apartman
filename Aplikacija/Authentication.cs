﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data.SQLite;

namespace Aplikacija
{
    public class Authentication
    {
        public string connectionString { get; set; }
        string connection;

        public void getConnection()
        {
            connection = @"Data Source=Account.db; Version=3";
            connectionString = connection;
        }
        public void createDatabase()
        {
            if (File.Exists("Account.db"))
            {
                try
                {
                    File.Create("Account.db");

                    createTable();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }
            else
            {

                createTable();
            }
        }
        public void createTable()
        {
            try
            {
                getConnection();
                using (SQLiteConnection con = new SQLiteConnection(connection))
                {
                    con.Open();
                    SQLiteCommand cmd = new SQLiteCommand();


                    string query = @"CREATE TABLE Account (Account_ID INTEGER PRIMARY KEY AUTOINCREMENT, Ime Text(25), Prezime Text(25),
                                            Username Text(25), Password Text(25), Email Text(25), Mobitel Text (25))";
                    cmd.CommandText = query;
                    cmd.Connection = con;
                    cmd.ExecuteNonQuery();

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
