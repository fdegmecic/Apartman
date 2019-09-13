using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplikacija
{
    public partial class RegSuggest : Form
    {
        public RegSuggest()
        {
            InitializeComponent();
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Register reg = new Register();
            reg.ShowDialog();
        }
        private void asdf_Load(object sender, EventArgs e)
        {
            GlobalVariables global = GlobalVariables.Instance;
            if (global.getIdAcc() == -1)
            {
                registerButton.Visible = true;
              
             

            }
            else
            {
                
                registerButton.Visible = false;
                

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Application.Restart();

           

            
        }
    }
}
