using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tooted
{
    public partial class Form1 : Form
    {
        SqlConnection connect=new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|Toote_DB.mdf;Integrated Security=True");
        SqlDataAdapter adapter_toode, adapter_kategooria;
        SqlCommand command;
        public Form1()
        {
            InitializeComponent();
            NaitaAndmed(); 
            NaitaKategooriad();
        }
        public void Lisa_Kategooriad()
        {

        }
        public void NaitaAndmed()
        {
            connect.Open();
            DataTable dt_toode = new DataTable();
            adapter_toode = new SqlDataAdapter("SELECT * FROM Tooted", connect);
            adapter_toode.Fill(dt_toode);
            dataGridView1.DataSource= dt_toode;

            connect.Close();

        }
        public void NaitaKategooriad()
        {
            connect.Open();
            adapter_kategooria = new SqlDataAdapter("SELECT Kategooria_nimetus FROM Kategooriad", connect);
            DataTable dt_kat = new DataTable();
            adapter_kategooria.Fill(dt_kat);
            foreach (DataRow item in dt_kat.Rows) 
            {
                KategooriaBox1.Items.Add(item["Kategooria_nimetus"]);
            }
            connect.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            connect.Open();
            command = new SqlCommand("INSERT INTO Kategooriad(Kategooria_nimetus)VALUES (@kat)",connect);
            command.Parameters.AddWithValue("@kat",KategooriaBox1.Text);
            command.ExecuteNonQuery();
            connect.Close();
            NaitaKategooriad();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void KategooriaBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
