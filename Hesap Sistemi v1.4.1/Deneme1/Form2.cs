using System;
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
    public partial class Form2 : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=veritabanim;User ID=sa;Password=123");

        public Form2()
        {
            InitializeComponent();
        }

        bool kontrol = false;
        public void button1_Click(object sender, EventArgs e)
        {
            
            //MessageBox.Show(DateTime.Today.ToShortDateString());
            denetim();
            if(kontrol == true)
            {
                if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();

                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = baglanti;
                    cmd.CommandText = "INSERT INTO tablo(isim,soyisim,birikim,dogumtarihi,yas,cinsiyet) VALUES('" + textisim.Text + "','" + textsoyisim.Text + "','" + textbirikim.Text + "','" + dateTimePicker1.Value.Date.ToString("yyyyMMdd").Replace('.', '-') + "','" + int.Parse(textyas.Text) + "','" + cinsiyetBox1.Text + "')";
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    baglanti.Close();
                    //listeleme();
                    //temizleme();
                    //MessageBox.Show("KAYIT TAMAMLANMIŞTIR");
                    this.Close();
                }
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            cinsiyetBox1.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void denetim()
        {
            string isim = textisim.Text;
            string soyisim = textsoyisim.Text;
            string birikim = textbirikim.Text;
            string cinsiyet = cinsiyetBox1.Text;
            string yas = textyas.Text;
            string tarih = dateTimePicker1.Text;

            if (isim == "")
            {
                MessageBox.Show("İsim Girmediniz");
                textisim.Focus();
            }

            else if (soyisim == "")
            {
                MessageBox.Show("Soyisim Girmediniz");
                textsoyisim.Focus();
            }

            else if (birikim == "")
            {
                MessageBox.Show("Birikimi Girmediniz");
                textbirikim.Focus();
            }

            else if (yas == "")
            {
                MessageBox.Show("Yaşı Girmediniz");
                textyas.Focus();
            }

            else if (cinsiyet == "")
            {
                MessageBox.Show("Cinsiyet Girmediniz");
                cinsiyetBox1.Focus();
            }
            
            if (isim != "" && soyisim != "" && birikim != "" && cinsiyet != "" && yas != "")
            {
                kontrol = true;
            }
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
            if(!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
    }
}
