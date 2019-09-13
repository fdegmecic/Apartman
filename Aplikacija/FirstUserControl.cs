using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;

namespace Aplikacija
{
    public partial class FirstUserControl : UserControl
    {
        public FirstUserControl()
        {
            InitializeComponent();
            
        }
        
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //
        }

        private void FirstUserControl_Load(object sender, EventArgs e)
        {
            loadPics();

        }
        public void loadPics()
        {
            SQLiteConnection con = new SQLiteConnection("Data Source = Account.db; Version = 3");
            con.Open();
            SQLiteCommand cmd = new SQLiteCommand();
            string query = "select ID, Lokacija, Slika from Stan ORDER by ID Desc";
            cmd.CommandText = query;
            cmd.Connection = con;
            
            SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(cmd);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);

            if (dataSet.Tables[0].Rows.Count > 0)
            {
                Byte[] data = new Byte[0];
                data = (Byte[])(dataSet.Tables[0].Rows[0]["Slika"]);

                label1.Text = dataSet.Tables[0].Rows[0]["Lokacija"].ToString();

                MemoryStream mem = new MemoryStream(data);
                pictureBox1.Image = Image.FromStream(mem); 
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                
            }
            if (dataSet.Tables[0].Rows.Count > 0)
            {
                Byte[] data = new Byte[1];
                data = (Byte[])(dataSet.Tables[0].Rows[1]["Slika"]);
                label2.Text = dataSet.Tables[0].Rows[1]["Lokacija"].ToString();
                MemoryStream mem = new MemoryStream(data);
                pictureBox2.Image = Image.FromStream(mem);
                pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            if (dataSet.Tables[0].Rows.Count > 0)
            {
                Byte[] data = new Byte[2];
                data = (Byte[])(dataSet.Tables[0].Rows[2]["Slika"]);
                label3.Text = dataSet.Tables[0].Rows[2]["Lokacija"].ToString();
                MemoryStream mem = new MemoryStream(data);
                pictureBox3.Image = Image.FromStream(mem);
                pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            }
           
        }

        private void headerPannel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
