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
        SqlConnection connect=new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\opilane\source\repos\tooted\AppData\Toote_DB.mdf;Integrated Security=True");
        SqlDataAdapter adapter_toode, adapter_kategooria;
        SqlCommand command;
        public Form1()
        {
            InitializeComponent();
            NaitaAndmed(); 
            NaitaKategooriad();
        }
        
        public void NaitaAndmed()
        {
            connect.Open();
            DataTable dt_toode = new DataTable();
            
            adapter_toode = new SqlDataAdapter("SELECT Tooted.ID, Tooted.ToodeNimetus,Tooted.Kogus, Tooted.Hind, Tooted.Pilt, Tooted.Kogus,Kategooriad.kategooria_nimetus from Tooted INNER JOIN Kategooriad on Tooted.Id=Kategooriad.Id", connect);
            
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
            if (Toode_txt.Text.Trim()!=string.Empty && Kogus_txt.Text.Trim()!=string.Empty && Hind_txt.Text.Trim()!=string.Empty && KategooriaBox1.SelectedItem!=null)
            {
                try
                {
                    connect.Open();
                    command = new SqlCommand("INSERT INTO Tooted (Id,ToodeNimetus,Kogus,Hind,Pilt,Kategooriad) VALUES (@id,@toode,@kogus,@hind,@pilt,@kat)", connect);
                    command.Parameters.AddWithValue("@id", id_txt.Text);
                    command.Parameters.AddWithValue("@toode", Toode_txt.Text);
                    command.Parameters.AddWithValue("@kogus", Kogus_txt.Text);
                    command.Parameters.AddWithValue("@hind", Hind_txt.Text);
                    command.Parameters.AddWithValue("@pilt", Pilt_txt.Text);
                    command.Parameters.AddWithValue("@kat", KategooriaBox1.SelectedIndex + 1);

                    command.ExecuteNonQuery();
                    connect.Close();
                    NaitaAndmed();
                }
                catch (Exception)
                {
                MessageBox.Show("Andmebaasiga viga!");
                }
            }
        }
        private void Kusta_but_Click(object sender, EventArgs e)
        {
            if (id_txt.Text.Trim() != string.Empty)
            {
                try
                {
                    connect.Open();
                    command = new SqlCommand("DELETE FROM Tooted WHERE id=@id", connect);
                    command.Parameters.AddWithValue("@id", id_txt.Text);

                    command.ExecuteNonQuery();
                    connect.Close();
                    NaitaAndmed();
                }
                catch (Exception)
                {
                    MessageBox.Show("Andmebaasiga viga!");
                }
            }
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

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void KategooriaBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
