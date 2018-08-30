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
    public partial class Form1 : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=veritabanim;User ID=sa;Password=123");

        public Form1()
        {
            InitializeComponent();
        }
        
        void temizleme()
        {
            textisim.Text = "";
            textsoyisim.Text = "";
            cinsiyetBox.Text = "";
        }
        private void btnkaydet_Click(object sender, EventArgs e)
        {
            
            Form2 f2 = new Form2();
            f2.ShowDialog();
            listeleme();
            
        }

        void listeleme()
        {
            if(baglanti.State==ConnectionState.Closed)
            {
                baglanti.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = baglanti;
                cmd.CommandText = "select * from tablo";
                SqlDataAdapter adaptr = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adaptr.Fill(ds, "tablo");
                dataGridView1.DataSource = ds.Tables["tablo"];
                dataGridView1.Columns[0].Visible = false;
                baglanti.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listeleme();
            //MessageBox.Show(DateTime.Today.ToShortDateString());
            //MessageBox.Show(tarihPicker1.Text);
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("SİLMEK İSTEDİĞİNİZE EMİN MİSİNİZ","DİKKAT",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = baglanti;
                    cmd.CommandText = "delete from tablo where id=@numara";
                    cmd.Parameters.AddWithValue("@numara", dataGridView1.CurrentRow.Cells[0].Value.ToString());
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    baglanti.Close();
                    listeleme();
                    //MessageBox.Show("SİLME TAMAMLANMIŞTIR");
                }
            }
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.id = Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[0].Value);
            f3.textisim.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            f3.textsoyisim.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            f3.textbirikim.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
            f3.dateTimePicker1.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
            f3.textyas.Text = this.dataGridView1.CurrentRow.Cells[5].Value.ToString();
            f3.cinsiyetBox.Text = this.dataGridView1.CurrentRow.Cells[6].Value.ToString();
            f3.ShowDialog();
            listeleme();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            /*textisim.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textsoyisim.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textbirikim.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            dogumTarihiPicker.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textyas.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            cinsiyetBox.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = baglanti;
                string isim = textisim.Text;
                string soyisim = textsoyisim.Text;
                string birikim1 = textbirikim1.Text;
                string birikim2 = textbirikim2.Text;
                string cinsiyet = cinsiyetBox.Text;
                string tarih1 = tarihPicker1.Text;
                string tarih2 = tarihPicker2.Text;
                string yas1 = YasBox1.Text;
                string yas2 = YasBox2.Text;

                if (isim != "")
                {
                    cmd.CommandText = "select * from tablo where isim = '"+isim+"' order by yas";
                    SqlDataAdapter adaptr = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    adaptr.Fill(ds, "tablo");
                    dataGridView1.DataSource = ds.Tables["tablo"];
                    dataGridView1.Columns[0].Visible = false;
                }

                if (soyisim != "")
                {
                    cmd.CommandText = "select * from tablo where soyisim = '" + soyisim + "' order by yas";
                    SqlDataAdapter adaptr = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    adaptr.Fill(ds, "tablo");
                    dataGridView1.DataSource = ds.Tables["tablo"];
                    dataGridView1.Columns[0].Visible = false;
                }

                if (isim != "" && soyisim != "")
                {
                    cmd.CommandText = "select * from tablo where isim = '" + isim + "' AND soyisim = '" + soyisim + "' order by yas";
                    SqlDataAdapter adaptr = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    adaptr.Fill(ds, "tablo");
                    dataGridView1.DataSource = ds.Tables["tablo"];
                    dataGridView1.Columns[0].Visible = false;
                }

                if (cinsiyet != "")
                {
                    cmd.CommandText = "select * from tablo where cinsiyet = '" + cinsiyet + "' order by yas";
                    SqlDataAdapter adaptr = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    adaptr.Fill(ds, "tablo");
                    dataGridView1.DataSource = ds.Tables["tablo"];
                    dataGridView1.Columns[0].Visible = false;
                }

                if (isim != "" && cinsiyet != "")
                {
                    cmd.CommandText = "select * from tablo where cinsiyet = '" + cinsiyet + "' AND isim = '" + isim + "' order by yas";
                    SqlDataAdapter adaptr = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    adaptr.Fill(ds, "tablo");
                    dataGridView1.DataSource = ds.Tables["tablo"];
                    dataGridView1.Columns[0].Visible = false;
                }

                if (soyisim != "" && cinsiyet != "")
                {
                    cmd.CommandText = "select * from tablo where cinsiyet = '" + cinsiyet + "' AND soyisim = '" + soyisim + "' order by yas";
                    SqlDataAdapter adaptr = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    adaptr.Fill(ds, "tablo");
                    dataGridView1.DataSource = ds.Tables["tablo"];
                    dataGridView1.Columns[0].Visible = false;
                }

                if (isim != "" && soyisim != "" && cinsiyet != "")
                {
                    cmd.CommandText = "select * from tablo where cinsiyet = '" + cinsiyet + "' AND isim = '" + isim + "' AND soyisim = '" + soyisim + "' order by yas";
                    SqlDataAdapter adaptr = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    adaptr.Fill(ds, "tablo");
                    dataGridView1.DataSource = ds.Tables["tablo"];
                    dataGridView1.Columns[0].Visible = false;
                }

                if (tarih1 != DateTime.Today.ToShortDateString() && tarih2 != DateTime.Today.ToShortDateString())
                {
                    cmd.CommandText = "select * from tablo where dogumtarihi between '" + tarihPicker1.Value.ToString("yyyyMMdd").Replace('.','-') + "' and '" + tarihPicker2.Value.ToString("yyyyMMdd").Replace('.', '-') + "' order by dogumtarihi";
                    SqlDataAdapter adaptr = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    adaptr.Fill(ds, "tablo");
                    dataGridView1.DataSource = ds.Tables["tablo"];
                    dataGridView1.Columns[0].Visible = false;
                }

                if (isim != "" && tarih1 != DateTime.Today.ToShortDateString() && tarih2 != DateTime.Today.ToShortDateString())
                {
                    cmd.CommandText = "select * from tablo where dogumtarihi between '" + tarihPicker1.Value.ToString("yyyyMMdd").Replace('.', '-') + "' and '" + tarihPicker2.Value.ToString("yyyyMMdd").Replace('.', '-') + "' AND isim = '" + isim + "' order by dogumtarihi";
                    SqlDataAdapter adaptr = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    adaptr.Fill(ds, "tablo");
                    dataGridView1.DataSource = ds.Tables["tablo"];
                    dataGridView1.Columns[0].Visible = false;
                }

                if (soyisim != "" && tarih1 != DateTime.Today.ToShortDateString() && tarih2 != DateTime.Today.ToShortDateString())
                {
                    cmd.CommandText = "select * from tablo where dogumtarihi between '" + tarihPicker1.Value.ToString("yyyyMMdd").Replace('.', '-') + "' and '" + tarihPicker2.Value.ToString("yyyyMMdd").Replace('.', '-') + "' AND soyisim = '" + soyisim + "' order by dogumtarihi";
                    SqlDataAdapter adaptr = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    adaptr.Fill(ds, "tablo");
                    dataGridView1.DataSource = ds.Tables["tablo"];
                    dataGridView1.Columns[0].Visible = false;
                }

                if (isim != "" && soyisim != "" && tarih1 != DateTime.Today.ToShortDateString() && tarih2 != DateTime.Today.ToShortDateString())
                {
                    cmd.CommandText = "select * from tablo where dogumtarihi between '" + tarihPicker1.Value.ToString("yyyyMMdd").Replace('.', '-') + "' and '" + tarihPicker2.Value.ToString("yyyyMMdd").Replace('.', '-') + "' AND isim = '" + isim + "' AND soyisim = '" + soyisim + "' order by dogumtarihi";
                    SqlDataAdapter adaptr = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    adaptr.Fill(ds, "tablo");
                    dataGridView1.DataSource = ds.Tables["tablo"];
                    dataGridView1.Columns[0].Visible = false;
                }

                if (yas1 != "" && yas2 != "")
                { 
                    cmd.CommandText = "select * from tablo where yas between " +yas1+ " and " +yas2+ " order by yas";
                    SqlDataAdapter adaptr = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    adaptr.Fill(ds, "tablo");
                    dataGridView1.DataSource = ds.Tables["tablo"];
                    dataGridView1.Columns[0].Visible = false;
                }

                if (isim != "" && yas1 != "" && yas2 != "")
                {
                    cmd.CommandText = "select * from tablo where yas between " + yas1 + " and " + yas2 + " AND isim = '" + isim + "' order by yas";
                    SqlDataAdapter adaptr = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    adaptr.Fill(ds, "tablo");
                    dataGridView1.DataSource = ds.Tables["tablo"];
                    dataGridView1.Columns[0].Visible = false;
                }

                if (soyisim != "" && yas1 != "" && yas2 != "")
                {
                    cmd.CommandText = "select * from tablo where yas between " + yas1 + " and " + yas2 + " AND soyisim = '" + soyisim + "' order by yas";
                    SqlDataAdapter adaptr = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    adaptr.Fill(ds, "tablo");
                    dataGridView1.DataSource = ds.Tables["tablo"];
                    dataGridView1.Columns[0].Visible = false;
                }

                if (isim != "" && soyisim != "" && yas1 != "" && yas2 != "")
                {
                    cmd.CommandText = "select * from tablo where yas between " + yas1 + " and " + yas2 + " AND isim = '" + isim + "' AND soyisim = '" + soyisim + "' order by yas";
                    SqlDataAdapter adaptr = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    adaptr.Fill(ds, "tablo");
                    dataGridView1.DataSource = ds.Tables["tablo"];
                    dataGridView1.Columns[0].Visible = false;
                }

                if (birikim1 != "" && birikim2 != "")
                {
                    cmd.CommandText = "select * from tablo where birikim between " + birikim1 + " and " + birikim2 + " order by birikim";
                    SqlDataAdapter adaptr = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    adaptr.Fill(ds, "tablo");
                    dataGridView1.DataSource = ds.Tables["tablo"];
                    dataGridView1.Columns[0].Visible = false;
                }

                if (isim != "" && birikim1 != "" && birikim2 != "")
                {
                    cmd.CommandText = "select * from tablo where birikim between " + birikim1 + " and " + birikim2 + " AND isim = '" + isim + "' order by yas";
                    SqlDataAdapter adaptr = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    adaptr.Fill(ds, "tablo");
                    dataGridView1.DataSource = ds.Tables["tablo"];
                    dataGridView1.Columns[0].Visible = false;
                }

                if (soyisim != "" && birikim1 != "" && birikim2 != "")
                {
                    cmd.CommandText = "select * from tablo where birikim between " + birikim1 + " and " + birikim2 + " AND soyisim = '" + soyisim + "' order by yas";
                    SqlDataAdapter adaptr = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    adaptr.Fill(ds, "tablo");
                    dataGridView1.DataSource = ds.Tables["tablo"];
                    dataGridView1.Columns[0].Visible = false;
                }

                if (isim != "" && soyisim != "" && birikim1 != "" && birikim2 != "")
                {
                    cmd.CommandText = "select * from tablo where birikim between " + birikim1 + " and " + birikim2 + " AND isim = '" + isim + "' AND soyisim = '" + soyisim + "' order by yas";
                    SqlDataAdapter adaptr = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    adaptr.Fill(ds, "tablo");
                    dataGridView1.DataSource = ds.Tables["tablo"];
                    dataGridView1.Columns[0].Visible = false;
                }  
                
                //19 farklı türde sıralama yapabiliyor :)

                baglanti.Close();
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Form3 f3 = new Form3();
            f3.textisim.Text=this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            f3.textsoyisim.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            f3.textbirikim.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
            f3.dateTimePicker1.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
            f3.textyas.Text = this.dataGridView1.CurrentRow.Cells[5].Value.ToString();
            f3.cinsiyetBox.Text = this.dataGridView1.CurrentRow.Cells[6].Value.ToString();
            f3.ShowDialog();
            listeleme();
        }
    }
}
