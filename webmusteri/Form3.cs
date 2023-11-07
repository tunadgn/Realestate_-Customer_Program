using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;



namespace webmusteri
{
    public partial class Form3 : Form
    {
        public Form1 frm1;
        public Form2 frm2;
        public Form3()
        {
            InitializeComponent();
            
        }
        OleDbConnection baglan = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=data.mdb");
        OleDbCommand komut = new OleDbCommand();

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                baglan.Open();
                OleDbCommand komut = new OleDbCommand("insert into musteriler(TC,Adi,Soyadi,Tel,Adres,Urun,Tarih,Mail,Ucreti,Aciklama,Meslek,Firma) values('" + tc.Text + "','" + txtAdi.Text + "','" + txtSoyadi.Text + "','" + txtTel.Text + "','" + txtadres.Text + "','" + txturn.Text + "','" + txttrh.Text + "','" + txtmail.Text + "','" + txtucrt.Text + "','" + txta.Text + "','" + txtmeslek.Text + "','" + txtfirma.Text + "')", baglan);
                komut.ExecuteNonQuery();
                baglan.Close();
                MessageBox.Show("Kayıt Eklendi", "Kayıt");
               
                frm2.listele();
                for (int i = 0; i < this.Controls.Count; i++)
                {
                    if (Controls[i] is TextBox) Controls[i].Text = ""; ;
                    {

                    }
                }
                this.Close();
            }
            catch (Exception)
            {

                MessageBox.Show("Aynı Web Adresine Sahip Müşteri Zaten var!"+"\n\n"+"Aynı Web Adresine Sahip 2. Bir Kayıt Eklenemez!","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Stop);
                for (int i = 0; i < this.Controls.Count; i++)
                {
                    if (Controls[i] is TextBox) Controls[i].Text = ""; ;
                    {

                    }
                }
                baglan.Close();
                
            }
               

           
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < this.Controls.Count; i++)
            {
                if (Controls[i] is TextBox) Controls[i].Text = ""; ;
                {

                }
            }
        }

        private void txtAdi_TextChanged(object sender, EventArgs e)
        {
            txtAdi.Focus();
        }
    }
}
