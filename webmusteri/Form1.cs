using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace webmusteri
{
    public partial class Form1 : Form
    {
        public Form2 frm2;
        public Form3 frm3;
        public Form4 frm4;
        public Form5 frm5;
        public Form1()
        {
            InitializeComponent();
            frm2 = new Form2();
            frm3 = new Form3();
            frm4 = new Form4();
            frm5 = new Form5();
            frm2.frm1 = this;
            frm3.frm1 = this;
            frm4.frm1 = this;
            frm5.frm1 = this;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.Focus();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

                MessageBox.Show("Lütfen Boş Alanları Doldurun.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                if (textBox1.Text == "")
                {
                    textBox1.Focus();
                }
                else if (textBox2.Text == "")
                {
                    textBox2.Focus();
                }
            
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre yanlış.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Clear();
                textBox2.Clear();
            }
            
         
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click_2(object sender, EventArgs e)
        {

            if (textBox1.Text.ToLower().Trim() == "harun" && textBox2.Text.Trim().ToLower() == "harun")
            {
                frm2.Show();
                this.Hide();
            }
            else if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Lütfen Boş Alanları Doldurun.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                if (textBox1.Text == "")
                {
                    textBox1.Focus();
                }
                else if (textBox2.Text == "")
                {
                    textBox2.Focus();
                }
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre yanlış.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Clear();
                textBox2.Clear();
            }


        }

        private void button2_Click_1(object sender, EventArgs e)
        {
           
            {
                Application.Exit();
            }

        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            {
                Application.Exit();
            }
        }
    }
    }

