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
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
            buttonPannel.Height = homeButton.Height;
            firstUserControl.BringToFront();
            
            
            
        }

        GlobalVariables global = GlobalVariables.Instance;
    
        private void homeButton_Click(object sender, EventArgs e)
        {
            buttonPannel.Height = homeButton.Height;
            buttonPannel.Top = homeButton.Top;
            firstUserControl.BringToFront();
            FirstUserControl first = new FirstUserControl();
            first.loadPics();

        }

        private void pretragaButton_Click(object sender, EventArgs e)
        {
            buttonPannel.Height = pretragaButton.Height;
            buttonPannel.Top = pretragaButton.Top;
            thirdUserControl.BringToFront();

        }

        private void dodajButton_Click(object sender, EventArgs e)
        {
         
            ObrisiStan obrisi = new ObrisiStan();
            obrisi.ShowDialog();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            Login login = new Login();
            login.ShowDialog();
         

            if (global.getIdAcc()==-1)
            {
                dodajButton.Visible = false;
             
                welcomeLabel.Visible = false;
                welcomeLabel2.Visible = false;
            }
            else
            {
                dodajButton.Enabled = true;
                welcomeLabel.Text = "Dobrodošli";
                welcomeLabel2.Text = login.usernames + "!";
             
            }
        }

       
        
    }
}
