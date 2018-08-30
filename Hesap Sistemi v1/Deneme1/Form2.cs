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

        private void button1_Click(object sender, EventArgs e)
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
}
