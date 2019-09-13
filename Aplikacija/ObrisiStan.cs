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
    public partial class ObrisiStan : Form
    {
        public ObrisiStan()
        {
            InitializeComponent();
            
        }

        private void ObrisiStan_Load(object sender, EventArgs e)
        {
           
            dataGridView1.DataSource = Source();

            dataGridView1.ClearSelection();
            dataGridView1.RowHeadersVisible = false;

        }
        String text;
        DataTable dt = new DataTable();
        DataSet ds = new DataSet();
        GlobalVariables global = GlobalVariables.Instance;
       
        public DataTable Source()
        {
            SQLiteConnection con = new SQLiteConnection("Data Source = Account.db; Version = 3");
            con.Open();
            try
            {
                SQLiteCommand cmd = new SQLiteCommand();
                string query = "select Lokacija, Adresa from Stan WHERE ID_ACC ='" + global.getIdAcc() + "'";

                cmd.CommandText = query;
                cmd.Connection = con;
                SQLiteDataAdapter adap = new SQLiteDataAdapter(cmd);
                dt.Clear();
                adap.Fill(ds);
                dt = ds.Tables[0];
                con.Close();


            }
            catch
            {
                MessageBox.Show("data sourc err", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return dt;
        }

        

        public void dataGridView1_Click(object sender, EventArgs e)
        {
             text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }

        private void obrisiButton_Click(object sender, EventArgs e)
        {

            obrisiStan();


        }
        private void obrisiStan()
        {
            if (MessageBox.Show("Sigurno zelite obrisati ovu objavu?", "Provjera", MessageBoxButtons.OK, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                SQLiteConnection con = new SQLiteConnection("Data Source = Account.db; Version = 3");
                con.Open();
                SQLiteCommand cmd = new SQLiteCommand();
                string query = "delete from Stan where Lokacija='" + text + "'";
                cmd.CommandText = query;
                cmd.Connection = con;
                cmd.ExecuteNonQuery();
                dataGridView1.DataSource = Source();

                MessageBox.Show("Stan je obrisan", "Obrisan stan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView1.ClearSelection();
            }
        }
    }
}
