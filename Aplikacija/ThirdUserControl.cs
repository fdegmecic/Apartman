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
    public partial class ThirdUserControl : UserControl
    {
        public ThirdUserControl()
        {
            InitializeComponent();
      

        }

        
        private DataSet ds = new DataSet();
        private DataTable dt = new DataTable();
        DataTable dbdataset;
        GlobalVariables global = GlobalVariables.Instance;
        
        private void ThirdUserControl_Load(object sender, EventArgs e)
        {

            dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            
            button2.Enabled = true;
            loadItems();




            



        }
        public void loadItems()
        {
            SQLiteConnection con = new SQLiteConnection("Data Source = Account.db; Version = 3");
            con.Open();
            SQLiteCommand cmd = new SQLiteCommand();
            string query = "select Slika, Lokacija, BrojSoba, Kat, Cijena, Adresa from Stan";

            cmd.CommandText = query;
            cmd.Connection = con;


            SQLiteDataAdapter sad = new SQLiteDataAdapter();
            sad.SelectCommand = cmd;
            dbdataset = new DataTable();
            sad.Fill(dbdataset);
            BindingSource bsSource = new BindingSource();

            bsSource.DataSource = dbdataset;

            dataGridView1.DataSource = bsSource;

            sad.Update(dbdataset);
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
                if (dataGridView1.Columns[i] is DataGridViewImageColumn)
                {
                    ((DataGridViewImageColumn)dataGridView1.Columns[i]).ImageLayout = DataGridViewImageCellLayout.Stretch;
                    break;
                }
            dataGridView1.Columns[0].Width = 300;
            dataGridView1.RowTemplate.Height = 300;
            
        }


        private void listView_SelectedIndexChanged(object sender, EventArgs e)
        {
            //
        }

        private void sortComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selected = this.sortComboBox.GetItemText(this.sortComboBox.SelectedItem);

            if (selected == "Najmanja cijena")
            {
                SQLiteConnection con = new SQLiteConnection("Data Source = Account.db; Version = 3");
                con.Open();
                SQLiteCommand cmd = new SQLiteCommand();
                string query = "select Slika, Lokacija, BrojSoba, Kat, Cijena, Adresa from Stan ORDER BY Cijena ASC";

                cmd.CommandText = query;
                cmd.Connection = con;


                SQLiteDataAdapter sad = new SQLiteDataAdapter();
                sad.SelectCommand = cmd;
                DataTable dbdataset = new DataTable();
                sad.Fill(dbdataset);
                BindingSource bsSource = new BindingSource();

                bsSource.DataSource = dbdataset;

                dataGridView1.DataSource = bsSource;

                sad.Update(dbdataset);
                for (int i = 0; i < dataGridView1.Columns.Count; i++)
                    if (dataGridView1.Columns[i] is DataGridViewImageColumn)
                    {
                        ((DataGridViewImageColumn)dataGridView1.Columns[i]).ImageLayout = DataGridViewImageCellLayout.Stretch;
                        break;
                    }
                dataGridView1.Columns[0].Width = 300;
                dataGridView1.RowTemplate.Height = 300;
            }
            if (selected == "Najveca cijena")
            {
                SQLiteConnection con = new SQLiteConnection("Data Source = Account.db; Version = 3");
                con.Open();
                SQLiteCommand cmd = new SQLiteCommand();
                string query = "select Slika, Lokacija, BrojSoba, Kat, Cijena, Adresa from Stan ORDER BY Cijena DESC";

                cmd.CommandText = query;
                cmd.Connection = con;


                SQLiteDataAdapter sad = new SQLiteDataAdapter();
                sad.SelectCommand = cmd;
                DataTable dbdataset = new DataTable();
                sad.Fill(dbdataset);
                BindingSource bsSource = new BindingSource();

                bsSource.DataSource = dbdataset;

                dataGridView1.DataSource = bsSource;

                sad.Update(dbdataset);
                for (int i = 0; i < dataGridView1.Columns.Count; i++)
                    if (dataGridView1.Columns[i] is DataGridViewImageColumn)
                    {
                        ((DataGridViewImageColumn)dataGridView1.Columns[i]).ImageLayout = DataGridViewImageCellLayout.Stretch;
                        break;
                    }
                dataGridView1.Columns[0].Width = 300;
                dataGridView1.RowTemplate.Height = 300;
               
            }

        }
       

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            
            string searchname = searchBox.Text;
            SQLiteConnection con = new SQLiteConnection("Data Source = Account.db; Version = 3");
            con.Open();
            SQLiteCommand cmd = new SQLiteCommand();
            string query = "select Slika, Lokacija, BrojSoba, Kat, Cijena, Adresa from Stan WHERE Lokacija LIKE @lokacija";
            cmd.CommandText = query;
            cmd.Connection = con;
            cmd.Parameters.Add(new SQLiteParameter("lokacija", "%" + searchname + "%"));
            SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();



        }
        public void F2_UpdateEventHandler1(object sender, DodajStan.UpdateEventArgs args)
        {
            dataGridView1.DataSource = Source();
        }


        public DataTable Source()
        {
            SQLiteConnection con = new SQLiteConnection("Data Source = Account.db; Version = 3");
            con.Open();
            try
            {
                SQLiteCommand cmd = new SQLiteCommand();
                string query = "select Slika, Lokacija, BrojSoba, Kat, Cijena, Adresa from Stan";

                cmd.CommandText = query;
                cmd.Connection = con;
                SQLiteDataAdapter adap = new SQLiteDataAdapter(cmd);
                dt.Clear();
                adap.Fill(ds);
                dt = ds.Tables[0];
                for (int i = 0; i < dataGridView1.Columns.Count; i++)
                    if (dataGridView1.Columns[i] is DataGridViewImageColumn)
                    {
                        ((DataGridViewImageColumn)dataGridView1.Columns[i]).ImageLayout = DataGridViewImageCellLayout.Stretch;
                        break;
                    }
                dataGridView1.Columns[0].Width = 300;
                dataGridView1.RowTemplate.Height = 300;
                con.Close();
               
            }
            catch
            {
                MessageBox.Show("Stan nije dodan.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (global.getIdAcc() == -1)
            {
                RegSuggest form = new RegSuggest();
                form.ShowDialog();

            }
            else
            {
                DodajStan form = new DodajStan(this);
                form.UpdateEventHandler += F2_UpdateEventHandler1;
                form.ShowDialog();
            }
           
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
             //
           
        }


        private void dataGridView1_Click(object sender, EventArgs e)
        {
            
            //
        }

        public void searchBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //

            
        }
        

        private void backgroundPannel_Paint(object sender, PaintEventArgs e)
        {
            //
        }

        private void brojLabel_Click(object sender, EventArgs e)
        {
            //
        }

        private void dataGridView1_Click_1(object sender, EventArgs e)
        {
            StanPregled StanPregled = new StanPregled();
            MemoryStream ms = new MemoryStream((byte[])dataGridView1.CurrentRow.Cells[0].Value‌​);
            StanPregled.pictureBox1.Image = Image.FromStream(ms);
            StanPregled.textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            StanPregled.textBox2.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            StanPregled.textBox3.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            StanPregled.textBox4.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            StanPregled.textBox7.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            StanPregled.lokacija = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            StanPregled.adresa = dataGridView1.CurrentRow.Cells[5].Value.ToString();

            StanPregled.ShowDialog();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_Scroll(object sender, ScrollEventArgs e)
        {

        }

       

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }
    }
}
