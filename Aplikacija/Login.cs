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
    public partial class Login : Form
    {
       

        public Login()
        {
            InitializeComponent();
          
            

        }
        public string usernames;
     
        Authentication auth;

        GlobalVariables global = GlobalVariables.Instance;
        

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (usernameText.Text != string.Empty
               && passwordText.Text != string.Empty)
            {
                checkAccount(usernameText.Text, passwordText.Text);

                global.setIdAcc(usernameText.Text);

            }
            else
            {
                MessageBox.Show("Molim vas unesite korisničko ime i lozinku", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            Register reg = new Register();
            reg.ShowDialog();
        }

        private void checkAccount(string username, string password)
        {
            auth = new Authentication();
            auth.getConnection();
            
            try
            {
                using (SQLiteConnection con = new SQLiteConnection(auth.connectionString))
                {
                    con.Open();
                    SQLiteCommand cmd = new SQLiteCommand();
                    string query = @"SELECT * FROM Account WHERE username='" + username + "' and Password='" + password + "'";
                    

                    cmd.CommandText = query;
                    cmd.Connection = con;
                    int count = 0;
                    SQLiteDataReader read = cmd.ExecuteReader();
                    
                    while (read.Read())
                    {
                        count++;
                        
                    }
                    if (count == 1)
                    {
                        MessageBox.Show("Uspješna prijava!", "Uspjeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        usernames = username;
                      
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Netočno korisničko ime ili lozinka", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        usernameText.Clear();
                        passwordText.Clear();
                        usernameText.Select();
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void registerButton_Click_1(object sender, EventArgs e)
        {
            Register reg = new Register();
            reg.ShowDialog();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            //
        }
        
    }
}
