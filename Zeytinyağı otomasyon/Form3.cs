using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.IO;


namespace Zeytinyağı_otomasyon
{
   
    public partial class Form3 : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-39J40U9;Initial Catalog=Zeytin;Integrated Security=True");
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void verilerigöster()
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * From Siparis_Tablo", baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            
            baglanti.Close();


        }
    
        private void Btnsiparis_Click(object sender, EventArgs e)
        {
            verilerigöster();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Siparis_Tablo(Musteriİd,Ad,Soyad,TelefonNumarasi,Adres,ZeytinTuru,Kilogram,Litre) values('" + Txtad.Text.ToString() + "','" + Txtsoyad.Text.ToString() + "','" + Mskdtelno.Text.ToString() + "','" + Rchtxtadres.Text.ToString() + "','" + Cmbzytncesit.Text.ToString() + "','" + Txtmiktar.Text.ToString() + "','" + Txtzytnyagmiktar.Text.ToString() + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            verilerigöster();

        }

       
    }
}
