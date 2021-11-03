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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
 
            
           
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                label3.Visible = true;
                richTextBox1.Visible = true;
                pictureBox2.Visible = true;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                label3.Text = "Gemlik Zeytin";
                richTextBox1.Text = "Bir Gemlik zeytini veya Tirilye zeytini, Türkiye'nin kuzeyindeki Gemlik, Zeytinbağı bölgesinden bir çeşittir. Gemlik zeytinleri Tirilye, Kıvırcık, sargı kağıdı ve siyah olarak aşağıdaki isimlerle anılır. Yağ içeriği yüksek olan küçük ve orta boy siyah zeytinlerdir.";
            }
            if (comboBox1.SelectedIndex == 1)
            {
                label3.Visible = true;
                richTextBox1.Visible = true;
                pictureBox2.Visible = false;
                pictureBox3.Visible = true;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                label3.Text ="Eşek Zeytin";
                richTextBox1.Text = "Kalamata, Karamürsel, Kocaeli'nin Karamürsel, Gebze, Gölcük ilçeleri ve Bursa civarı ve Yunanistan'ın güneyindeki Kalamata şehri yöresinde yetişen yumuşak ve etli bir zeytin türüdür";

            }
            if(comboBox1.SelectedIndex==2)
            {
                label3.Visible = true;
                richTextBox1.Visible = true;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = true;
                pictureBox5.Visible = false;
                label3.Text = "Domat Zeytin";
                richTextBox1.Text = " Domat zeytini genellikle dolmalık zeytin olarak tüketiliyor. Bu tür iri ve etli bir görünüme sahiptir. %23 oranında yağ içerir. Bu zeytin türüne Antalya, Şanlıurfa, Adana, Mersin ve Gaziantep illerinde rastlamak mümkündür. ";
            }
            if (comboBox1.SelectedIndex == 3)
            {
                label3.Visible = true;
                richTextBox1.Visible = true;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;     //fotoğraf ekle ve ayvalık zeytini nedir yazısı
                pictureBox4.Visible = false;
                pictureBox5.Visible = true;
                label3.Text = "Ayvalık Zeytin";
                richTextBox1.Text = "Zeytincilik, Ayvalıkta yapılan en yaygın tarımsal faaliyet. Ayvalık zeytini, gerek yağlık, gerekse sofralık zeytin üretimine uygun bir çeşit. ... Kendi yöresinde iyi yetiştirilip, iyi işlendiğinde yüksek duyusal ve kimyasal kalite özelliklerine sahip bir zeytinyağı üretiyor.";
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
