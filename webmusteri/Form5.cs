using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace webmusteri
{
    public partial class Form5 : Form
    {
        public Form1 frm1;
        public Form2 frm2;
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == "admin" && textBox2.Text.Trim() == "demo")
            {
                label1.Text = "Veritabanını Yedeklemek için Giriş Yaptınız";
                label1.ForeColor = Color.Green;
                label2.Text = "Veritabanı Adı :";
                label3.Visible = false;
                button1.Visible = false;
                textBox2.Visible = false;
                textBox1.Clear();
                button3.Visible = true;
                textBox1.Focus();
                
            }
            else
            {
                MessageBox.Show("Giriş Başarısız","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            textBox1.Focus();
            button3.Visible = false;
            string klasorYeri = "C:\\";
            string klasorAdi = "YEDEK";
            string klasorOlustur = klasorYeri + @"\" + klasorAdi;
            Directory.CreateDirectory(klasorOlustur);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            button3.Visible = false;
            label1.Text = "Veritabanını Yedeklemek için Giriş Yapmanız Gerekmektedir";
            label2.Text = "Kullanıcı Adı :";
            label3.Visible = true;
            button1.Visible = true;
            textBox2.Visible = true;
            textBox1.Clear();
            button3.Visible = true;
            textBox2.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == "")
                {
                    MessageBox.Show("Lütfen Yedeklenecek Veritabanı İsmini Giriniz", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    System.IO.File.Copy("data.mdb", "C:\\YEDEK\\" + textBox1.Text + ".mdb");
                    MessageBox.Show("Veritabanı C:\\YEDEK Klasörü İçine Kaydedilmiştir", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Zaten Aynı isimde Bir Veritabanı Yedeği Mevcut! "+"\n\n"+"1.) Aynı isimde 2. veritabanı oluşturulamaz"+"\n"+"2.) Veritabanı ismini Değiştirip Tekrar Deneyin","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                
            }
           
        }
    }
}
