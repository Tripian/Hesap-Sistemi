﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Threading;
using System.Globalization;

namespace Deneme1
{
    public partial class Form3 : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=veritabanim;User ID=sa;Password=123");

        public Form3()
        {
            InitializeComponent();
        }

        public int id;
        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();

            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = baglanti;
                cmd.CommandText = "update tablo set isim='" + textisim.Text + "',soyisim='" + textsoyisim.Text + "',birikim='" + textbirikim.Text.Replace(',','.') + "',dogumtarihi='" + dateTimePicker1.Value.Date.ToString("yyyyMMdd").Replace('.', '-') + "',yas='" + int.Parse(textyas.Text) + "',cinsiyet='" + cinsiyetBox.Text + "' where id=@numara";
                cmd.Parameters.AddWithValue("@numara", id);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                baglanti.Close();
                //listeleme();
                //temizleme();
                //MessageBox.Show("GÜNCELLEME TAMAMLANMIŞTIR");
                this.Close();
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            cinsiyetBox.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void textbirikim_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void textyas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
    }
}
