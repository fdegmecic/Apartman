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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
            
        }

        Authentication auth;
       

        private void registerButton_Click(object sender, EventArgs e)
        {
            
            if (imeText.Text != string.Empty &&
                prezimeText.Text != string.Empty &&
                usernameText.Text != string.Empty
                && passwordText.Text != string.Empty
                && confirmPasswordText.Text != string.Empty
                && emailText.Text != string.Empty
                && mobitelText.Text != string.Empty
                )
            {
                if (passwordText.Text == confirmPasswordText.Text)
                {

                    checkAccount(usernameText.Text);
                }
                else
                {
                    MessageBox.Show("Unesite jednake lozinke", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Unesite sve potrebne podatke", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void checkAccount(string username)
        {
            auth = new Authentication();
            auth.createDatabase();
            auth.getConnection();
            try
            {
                using (SQLiteConnection con = new SQLiteConnection(auth.connectionString))
                {
                    SQLiteCommand cmd = new SQLiteCommand();
                    con.Open();

                    
                    string query = @"SELECT * FROM Account WHERE Username='" + username + "'";
                    cmd.CommandText = query;
                    cmd.Connection = con;
                    int count = 0;
                    SQLiteDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        count++;
                    }
                    if (count == 1)
                    {
                        MessageBox.Show("Ovaj račun već postoji.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else if (count == 0)
                    {
                        insertData(imeText.Text, prezimeText.Text, usernameText.Text, passwordText.Text, emailText.Text, mobitelText.Text);
                        
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
        
        private void insertData(string ime, string prezime, string usernames, string password, string email, string mobitel)
        {
            try
            {
                auth = new Authentication();
                auth.getConnection();

                using (SQLiteConnection con = new SQLiteConnection(auth.connectionString))
                {
                    con.Open();
                    SQLiteCommand cmd = new SQLiteCommand();
                    string query = @"INSERT INTO Account(Ime, Prezime, Username, Password, Email, Mobitel) VALUES (@ime, @prezime, @username, @password, @email, @mobitel)";
                    cmd.CommandText = query;
                    cmd.Connection = con;
                    cmd.Parameters.Add(new SQLiteParameter("@ime", ime));
                    cmd.Parameters.Add(new SQLiteParameter("@prezime", prezime));
                    cmd.Parameters.Add(new SQLiteParameter("@username", usernames));
                    cmd.Parameters.Add(new SQLiteParameter("@password", password));
                    cmd.Parameters.Add(new SQLiteParameter("@email", email));
                    cmd.Parameters.Add(new SQLiteParameter("@mobitel", mobitel));
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Uspješno ste napravili račun!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
        

    }
}

