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
    public partial class Form2 : Form
    {
        public Form1 frm1;
        public Form3 frm3;
        public Form4 frm4;
        public Form5 frm5;
        public Form2()
        {
            InitializeComponent();
            frm3 = new Form3();
            frm3.frm2 = this;
            frm4 = new Form4();
            frm4.frm2 = this;
            frm5 = new Form5();
            frm5.frm2 = this;
        }
        OleDbConnection baglan = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=data.mdb");
        DataTable tablo = new DataTable();
        OleDbCommand komut = new OleDbCommand();
        public void listele()
        {
            tablo.Clear();
            OleDbDataAdapter adptr = new OleDbDataAdapter("Select * From musteriler", baglan);
            adptr.Fill(tablo);
            dataGridView1.DataSource = tablo;
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            listele();
            dataGridView1.Columns[0].HeaderText = "id";
            dataGridView1.Columns[1].HeaderText = "Adi";
            dataGridView1.Columns[2].HeaderText = "Soyadi";
            dataGridView1.Columns[3].HeaderText = "Tel";
            dataGridView1.Columns[4].HeaderText = "Adres";
            dataGridView1.Columns[5].HeaderText = "Urun";
            dataGridView1.Columns[6].HeaderText = "Tarih";
            dataGridView1.Columns[7].HeaderText = "Mail";
            dataGridView1.Columns[8].HeaderText = "Ucreti";
            dataGridView1.Columns[9].HeaderText = "Aciklama";
            dataGridView1.Columns[10].HeaderText = "Meslek";
            dataGridView1.Columns[11].HeaderText = "Firma";
            btnKayitGoster.Visible = false;

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Çıkmak İstediğinizden Emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                Application.Exit();
            }

            
        }

        private void btnKayitGoster_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            btnKayitGizle.Visible = true;
            btnKayitGoster.Visible = false;
            lblKayitGizle.Text = "";
           
        }

        private void btnKayitGizle_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            btnKayitGoster.Visible = true;
            lblKayitGizle.Text = "KAYITLAR GİZLENDİ";
           
        }

        private void btnKayitEkle_Click(object sender, EventArgs e)
        {
            frm3.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnKayitGuncelle_Click(object sender, EventArgs e)
        {
            frm4.ShowDialog();
        }

        private void txtAd_TextChanged(object sender, EventArgs e)
        {
            
           if ( txtAd.Text.Trim() == "")
            {
                tablo.Clear();
                OleDbDataAdapter adptr = new OleDbDataAdapter("Select * From musteriler", baglan);
                adptr.Fill(tablo);
                dataGridView1.DataSource = tablo;

            }
            else
            {
                tablo.Clear();
                OleDbDataAdapter adptr = new OleDbDataAdapter("Select * From musteriler where Adi Like '%" + txtAd.Text + "%'", baglan);
                adptr.Fill(tablo);
                dataGridView1.DataSource = tablo;
            }
        }

        private void txtSoyad_TextChanged(object sender, EventArgs e)
        {
            
            if (txtSoyad.Text.Trim() == "")
            {
                tablo.Clear();
                OleDbDataAdapter adptr = new OleDbDataAdapter("Select * From musteriler", baglan);
                adptr.Fill(tablo);
                dataGridView1.DataSource = tablo;

            }
            else
            {
                tablo.Clear();
                OleDbDataAdapter adptr = new OleDbDataAdapter("Select * From musteriler where Soyadi Like '%" + txtSoyad.Text + "%'", baglan);
                adptr.Fill(tablo);
                dataGridView1.DataSource = tablo;
            }
        }

        
       


        private void btnSil_Click(object sender, EventArgs e)
        {
            DialogResult cevap;
            cevap = MessageBox.Show("Kaydı Silmek İstediğinizden Eminmisiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (cevap == DialogResult.Yes)
            {
                baglan.Open();
                OleDbCommand komut = new OleDbCommand("delete *from musteriler where adi='" + dataGridView1.CurrentRow.Cells["adi"].Value.ToString() + "'",baglan);
                komut.ExecuteNonQuery();
                baglan.Close();
                MessageBox.Show("Kayıt Silindi", "Kayıt");
                tablo.Clear();
                listele();
            }
        }

       

        private void button1_Click_2(object sender, EventArgs e)
        {
            frm5.ShowDialog();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
           
                
        }

        private void btnRapor_Click(object sender, EventArgs e)
        {

        }
    }
}
