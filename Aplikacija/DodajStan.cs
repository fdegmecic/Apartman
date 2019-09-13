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
using System.IO;

namespace Aplikacija
{
    public partial class DodajStan : Form
    {

        public DodajStan(ThirdUserControl third)
        {
            InitializeComponent();
            createTable();

            Login login = new Login();
            
        }
       

        GlobalVariables global = GlobalVariables.Instance;
        public delegate void UpdateDelegate(object sender, UpdateEventArgs args);
        public event UpdateDelegate UpdateEventHandler;
        DataSet ds = new DataSet();

        public class UpdateEventArgs : EventArgs
        {
            public string Data { get; set; }
        }
       
        protected void insert()
        {
            UpdateEventArgs args = new UpdateEventArgs();
            UpdateEventHandler.Invoke(this, args);

        }
        public void createTable()
        {
            SQLiteConnection con = new SQLiteConnection("Data Source = Account.db; Version = 3");
            con.Open();

            SQLiteCommand cmd = new SQLiteCommand();

            string query = @"CREATE TABLE if not exists Stan (ID INTEGER PRIMARY KEY AUTOINCREMENT, Lokacija Text(25), BrojSoba INTGER(25), Kat INTGER(25), 
                                                Cijena INTGER(25),Slika BLOB, Adresa Text(25),
                                                ID_ACC INTEGER, FOREIGN KEY(ID_ACC) REFERENCES 'Account'('Account_ID'))";
            cmd.CommandText = query;
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
        }
        private void dodajStanButton_Click(object sender, EventArgs e)
        {
            dodajStan();
            pictureBox1.Image = null;
        }

        private void cijenaLabel_Click(object sender, EventArgs e)
        {
            //
        }

        private void informacijeLabel_Click(object sender, EventArgs e)
        {
            //
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            //
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "JPG Files(*.jpg)|*.jpg|PNG Files(*.png)|*.png|All Files(*.*)|*.*";
           
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string picPath = dlg.FileName.ToString();
                txtPath.Text = picPath;
                pictureBox1.ImageLocation = picPath;
            }
        }
        private void dodajStan()
        {
            if (lokacijaText.Text == string.Empty
               && brojSobaText.Text == string.Empty
               && katText.Text == string.Empty
               && cijenaText.Text == string.Empty
               && adresaText.Text == string.Empty)
            {
                MessageBox.Show("Unesite sve potrebne informacije o stanu", "Unesite sve", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SQLiteConnection con = new SQLiteConnection("Data Source = Account.db; Version = 3");
                con.Open();
                SQLiteCommand cmd = new SQLiteCommand();
                cmd = con.CreateCommand();
                cmd.CommandText = "Select * from Stan Where Lokacija ='" + lokacijaText.Text + "' and Kat='" + katText.Text + "' and Adresa='" + adresaText.Text + "'";
                SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
                da.Fill(ds);
                int i = ds.Tables[0].Rows.Count;
                if (i > 0)
                {
                    MessageBox.Show("Stan na adresi " + adresaText.Text + " već postoji.", "Stan postoji", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ds.Clear();
                }
                else
                {
                    try
                    {
                        cmd = new SQLiteCommand();
                        byte[] imgBt = null;
                        FileStream fstream = new FileStream(this.txtPath.Text, FileMode.Open, FileAccess.Read);
                        BinaryReader br = new BinaryReader(fstream);
                        imgBt = br.ReadBytes((int)fstream.Length);


                        cmd = con.CreateCommand();
                        cmd.CommandText = "INSERT INTO Stan(Lokacija,Adresa, BrojSoba, Kat, Cijena, Slika, ID_ACC ) VALUES (@lokacija, @adresa, @BrojSoba, @Kat, @cijena, @IMG, @ID_ACC)";
                        cmd.Parameters.AddWithValue("@lokacija", lokacijaText.Text);
                        cmd.Parameters.AddWithValue("@adresa", adresaText.Text);
                        cmd.Parameters.AddWithValue("@BrojSoba", brojSobaText.Text);
                        cmd.Parameters.AddWithValue("@Kat", katText.Text);
                        cmd.Parameters.AddWithValue("@cijena", cijenaText.Text);
                        cmd.Parameters.AddWithValue("@ID_ACC", global.getIdAcc());
                       
                        cmd.Parameters.Add(new SQLiteParameter("@IMG", imgBt));
                        
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Stan je uspješno dodan", "Uspjeh!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch
                    {
                        MessageBox.Show("Nije dodan", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    insert();
                    lokacijaText.Clear();
                    adresaText.Clear();
                    brojSobaText.Clear();
                    katText.Clear();
                    cijenaText.Clear();
                    lokacijaText.Clear();
                    txtPath.Clear();




                }

                


            }

           
        }

    }
}

