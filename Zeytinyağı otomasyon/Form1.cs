using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zeytinyağı_otomasyon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            this.Hide();
            string kullanıcıadı, sifre;
            kullanıcıadı = textBox1.Text;
            sifre = textBox2.Text;

            if (kullanıcıadı == "admin" && sifre == "12345")
            {
                Form2 frm2 = new Form2();
                frm2.ShowDialog();
            }

            else
            {
                MessageBox.Show("Giriş Bilgileri Hatalı..");
            }
        }
    }
}
