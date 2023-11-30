using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
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
            DataGridViewComboBoxColumn combo_kat = new DataGridViewComboBoxColumn();
            foreach(DataRow item in dt_toode.Rows)
            {
                if (!combo_kat.Items.Contains(item["Kategooria_nimetus"]))
                {
                    combo_kat.Items.Add(item["Kategooria_nimetus"]);
                }
            }
            dataGridView1.Columns.Add(combo_kat);
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
                //try
                //{
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
                //}
                //catch (Exception)
                //{
                //MessageBox.Show("Andmebaasiga viga!");
                //}
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

        
        string kat;
        SaveFileDialog save;
        OpenFileDialog open;
        private void button1_Click_1(object sender, EventArgs e)
        {
            open = new OpenFileDialog();
            open.InitialDirectory= @"C:\Users\opilane\Pictures";
            open.Multiselect = true;
            open.Filter = "Images Files(*.jpeg;*.bmp;*.png;*.jpg)|*.jpeg;*.bmp;*.png;*.jpg";

            FileInfo open_info = new FileInfo(@"C:\Users\opilane\source\repos\tooted\pildid"+open.FileName);
            if(open.ShowDialog()==DialogResult.OK && Toode_txt.Text != null)
            {
                save = new SaveFileDialog();
                save.InitialDirectory=Path.GetFullPath(@"..\..\pildid");
                save.FileName=Toode_txt.Text+Path.GetExtension(open.FileName);
                save.Filter="Images" + Path.GetExtension(open.FileName)+"|"+Path.GetExtension(open.FileName);
                if (save.ShowDialog()==DialogResult.OK)
                {
                    File.Copy(open.FileName, save.FileName);
                    Toode_pictureBox.Image=Image.FromFile(save.FileName);
                }
            }
            else
            {
                MessageBox.Show("Puudub toode nimetus");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void KategooriaBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
