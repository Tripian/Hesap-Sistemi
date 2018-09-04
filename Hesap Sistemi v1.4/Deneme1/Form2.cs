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

        public void button1_Click(object sender, EventArgs e)
        {
            string isim = textisim.Text;
            string soyisim = textsoyisim.Text;
            string birikim = textbirikim.Text;
            string cinsiyet = cinsiyetBox1.Text;
            string yas = textyas.Text;
            string tarih = dateTimePicker1.Text;
            
            //MessageBox.Show(DateTime.Today.ToShortDateString());

            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
                
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = baglanti;
                
               /* if (isim == "")
                {

                    textisim.Text="İsim Giriniz";
                    MessageBox.Show("İsim Girmediniz");
                    
                }

                if (soyisim == "")
                {

                    textsoyisim.Text = "Soyisim Giriniz";
                    MessageBox.Show("Soyisim Girmediniz");

                }

                if ( int.Parse(yas) < 0 || yas=="")
                {
                    textbirikim.Text = "0";
                    MessageBox.Show("Yaşı Negatif/Boş Girdiniz");
                }

                if (int.Parse(birikim) < 0 || birikim=="")
                {
                    textbirikim.Text = "0";
                    MessageBox.Show("Birikimi Negatif/Boş Girdiniz");
                }

                if (cinsiyet == "")
                {
                    
                    cinsiyetBox1.Text = "Cinsiyet Giriniz";
                    MessageBox.Show("Cinsiyet Girmediniz");

                }

                if (tarih == DateTime.Today.ToShortDateString())
                {
                    
                    MessageBox.Show("Geçerli Bir Tarih Girmediniz");

                }*/

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

        private void Form2_Load(object sender, EventArgs e)
        {
            cinsiyetBox1.DropDownStyle = ComboBoxStyle.DropDownList;
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
