using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;

namespace webmusteri
{
    public partial class Form4 : Form
    {
        public Form1 frm1;
        public Form2 frm2;
        public Form4()
        {
            InitializeComponent();

        }
        OleDbConnection baglan = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=data.mdb");
        OleDbCommand komut = new OleDbCommand();
        private void Form4_Load(object sender, EventArgs e)
        {
            tc.Text = frm2.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtAdi.Text = frm2.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtSoyadi.Text = frm2.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtTel.Text = frm2.dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtadrs.Text = frm2.dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txturn.Text = frm2.dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txttrh.Text = frm2.dataGridView1.CurrentRow.Cells[6].Value.ToString();
            txtmail.Text = frm2.dataGridView1.CurrentRow.Cells[7].Value.ToString();
            txtucret.Text = frm2.dataGridView1.CurrentRow.Cells[8].Value.ToString();
            txta.Text = frm2.dataGridView1.CurrentRow.Cells[9].Value.ToString();
            txtmslk.Text = frm2.dataGridView1.CurrentRow.Cells[10].Value.ToString();
            txtfirma.Text = frm2.dataGridView1.CurrentRow.Cells[11].Value.ToString();

        }

        private void txtAdi_TextChanged(object sender, EventArgs e)
        {
            txtAdi.Focus();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {

                txtAdi.Focus();
                baglan.Open();
                komut.Connection = baglan;
                komut.CommandText = "update musteriler set  TC='" + tc.Text + "',Adi='" + txtAdi.Text + "',Soyadi='" + txtSoyadi.Text + "',Tel='" + txtTel.Text + "',Adres='" + txtadrs.Text + "',Urun='" + txturn.Text + "',Tarih='" + txttrh.Text + "',Mail='" + txtmail.Text + "',Ucreti='" + txtucret.Text + "',Aciklama='" + txta.Text + "',Meslek='" + txtmslk.Text + "',Firma='" + txtfirma.Text + "' where TC="+tc.Text+"";
                komut.ExecuteNonQuery();
                baglan.Close();
                MessageBox.Show("Kayıt Güncelleme İşlemi Tamamlandı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frm2.listele();
                baglan.Close();


            
    }
    }
}
