using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;


namespace Aplikacija
{
    public  partial class StanPregled : Form
    {
        public StanPregled()
        {
            InitializeComponent();
            
    }
        //private void loadPicture()
        //{
        //    SQLiteConnection con = new SQLiteConnection("Data Source = Account.db; Version = 3");
        //    con.Open();
        //    SQLiteCommand cmd = new SQLiteCommand();
        //    string query = "SELECT Slika from Account";
        //    cmd.CommandText = query;
        //    cmd.Connection = con;



        //}
        public string lokacija;
        public string adresa;
        int account;
        string mobitel;
        string email;

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //
        }

        private void StanPregled_Load(object sender, EventArgs e)
        {
            getAcc();
            getKontakt();
            mobitelText.Text = mobitel;
            emailText.Text = email;

        }
        private void getAcc()
        {
            SQLiteConnection con = new SQLiteConnection("Data Source = Account.db; Version = 3");
            con.Open();
            SQLiteCommand cmd = new SQLiteCommand();
            cmd = con.CreateCommand();
            cmd.CommandText = "Select ID_ACC from Stan Where Lokacija ='" + lokacija + "' and Adresa='" + adresa + "'";
            account = Convert.ToInt32(cmd.ExecuteScalar());
        }
        private void getKontakt()
        {
            SQLiteConnection con = new SQLiteConnection("Data Source = Account.db; Version = 3");
            con.Open();
            SQLiteCommand cmd = new SQLiteCommand();
            cmd = con.CreateCommand();
            cmd.CommandText = "Select Email, Mobitel from Account Where Account_ID ='" + account + "'";

            SQLiteDataReader read = cmd.ExecuteReader();

            while (read.Read())
            {
                email = read["Email"].ToString();
                mobitel = read["Mobitel"].ToString();
                
            }
            
        }
    }
}
