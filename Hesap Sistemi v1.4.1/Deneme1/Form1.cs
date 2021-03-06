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
    public partial class Form1 : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=veritabanim;User ID=sa;Password=123");

        public Form1()
        {
            InitializeComponent();
        }

        public int ID;
        bool kontrol = false;
        private void btnkaydet_Click(object sender, EventArgs e)
        {
            
            Form2 f2 = new Form2();
            ID = dataGridView1.Rows.Count;
            f2.ShowDialog();
            listeleme();

            if (ID != dataGridView1.Rows.Count)
            {
                dataGridView1.Rows[ID].Selected = true;
                dataGridView1.CurrentCell = dataGridView1.Rows[ID].Cells[1];
                dataGridView1.Focus();
            }

        }

        private void listeleme()
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
            cinsiyetBox.DropDownStyle = ComboBoxStyle.DropDownList;
            cinsiyetBox.SelectedIndex= 0;
            siralaBox1.SelectedIndex = 0;
            siralaBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            YasBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            YasBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;
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
            if (kontrol == true)
            {
                Form3 f3 = new Form3();
                f3.id = Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[0].Value);
                ID = dataGridView1.CurrentCell.RowIndex;
                f3.textisim.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
                f3.textsoyisim.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
                f3.textbirikim.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
                f3.dateTimePicker1.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
                f3.textyas.Text = this.dataGridView1.CurrentRow.Cells[5].Value.ToString();
                f3.cinsiyetBox.Text = this.dataGridView1.CurrentRow.Cells[6].Value.ToString();
                f3.ShowDialog();
                listeleme();
                dataGridView1.Rows[ID].Selected = true;
                dataGridView1.CurrentCell = dataGridView1.Rows[ID].Cells[1];
                dataGridView1.Focus();
            }
        }
        
        string sorgu = "";
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
                string sirala = siralaBox1.Text;
                

                sorgu = "select * from tablo where 1=1";

                if (isim != "")
                {
                    sorgu = sorgu + " and isim like '%" + isim + "%'";
                    cmd.CommandText = sorgu;                    
                }

                if (soyisim != "")
                {
                    sorgu = sorgu + " and soyisim like '%" + soyisim + "%'";
                    cmd.CommandText = sorgu;
                }

                if (cinsiyet != "" && cinsiyet != "Tümü")
                {
                    sorgu = sorgu + " and cinsiyet = '" + cinsiyet + "'";
                    cmd.CommandText = sorgu;
                }

                if (cinsiyet != "" && cinsiyet == "Tümü")
                {
                    sorgu = sorgu + " and (cinsiyet = 'erkek' or cinsiyet = 'kadın')";
                    cmd.CommandText = sorgu;
                }

                if(birikim1 != "" && birikim2 != "")
                {
                    sorgu = sorgu + " and birikim between " + birikim1 + " and " + birikim2 + "";
                    cmd.CommandText = sorgu;
                }

                if (yas1 != "" && yas2 != "")
                {
                    sorgu = sorgu + " and yas between " + yas1 + " and " + yas2 + "";
                    cmd.CommandText = sorgu;
                }

                if (checkBox1.CheckState==CheckState.Checked)// && tarih1 != DateTime.Today.ToShortDateString() && tarih2 != DateTime.Today.ToShortDateString())
                {
                    sorgu = sorgu + " and dogumtarihi between '" + tarihPicker1.Value.ToString("yyyyMMdd").Replace('.', '-') + "' and '" + tarihPicker2.Value.ToString("yyyyMMdd").Replace('.', '-') + "'";
                    cmd.CommandText = sorgu;
                }
                
                if (sirala != "" && sirala== "İsme Göre")
                {
                    sorgu = sorgu + " order by isim";
                    cmd.CommandText = sorgu;
                }

                if (sirala != "" && sirala == "Soyisme Göre")
                {
                    sorgu = sorgu + " order by soyisim";
                    cmd.CommandText = sorgu;
                }

                if (sirala != "" && sirala == "Cinsiyete Göre")
                {
                    sorgu = sorgu + " order by cinsiyet";
                    cmd.CommandText = sorgu;
                }

                if (sirala != "" && sirala == "Birikime Göre")
                {
                    sorgu = sorgu + " order by birikim";
                    cmd.CommandText = sorgu;
                }

                if (sirala != "" && sirala == "Doğum Tarihine Göre")
                {
                    sorgu = sorgu + " order by dogumtarihi";
                    cmd.CommandText = sorgu;
                }

                if (sirala != "" && sirala == "Yaşa Göre")
                {
                    sorgu = sorgu + " order by yas";
                    cmd.CommandText = sorgu;
                }

                if(sirala!="" && sirala == "Sıralama")
                {
                    cmd.CommandText = sorgu;
                }

                SqlDataAdapter adaptr = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adaptr.Fill(ds, "tablo");
                dataGridView1.DataSource = ds.Tables["tablo"];
                
                baglanti.Close();
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Form3 f3 = new Form3();
            f3.id = Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[0].Value);
            ID = dataGridView1.CurrentCell.RowIndex;
            f3.textisim.Text=this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            f3.textsoyisim.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            f3.textbirikim.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
            f3.dateTimePicker1.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
            f3.textyas.Text = this.dataGridView1.CurrentRow.Cells[5].Value.ToString();
            f3.cinsiyetBox.Text = this.dataGridView1.CurrentRow.Cells[6].Value.ToString();
            f3.ShowDialog();
            listeleme();
            dataGridView1.Rows[ID].Selected = true;
            dataGridView1.CurrentCell = dataGridView1.Rows[ID].Cells[1];
            dataGridView1.Focus();
        }

        private void checkBox1_CheckStateChanged(object sender, EventArgs e)
        {
            if (checkBox1.CheckState == CheckState.Checked)
            {
                tarihPicker1.Visible = true;
                tarihPicker2.Visible = true;
            }

            if (checkBox1.CheckState == CheckState.Unchecked)
            {
                tarihPicker1.Visible = false;
                tarihPicker2.Visible = false;
                tarihPicker1.Text = DateTime.Today.ToShortDateString();
                tarihPicker2.Text = DateTime.Today.ToShortDateString();
            }
        }

        private void checkBox2_CheckStateChanged(object sender, EventArgs e)
        {
            if (checkBox2.CheckState == CheckState.Checked)
            {
                YasBox1.Visible = true;
                YasBox2.Visible = true;
            }

            if (checkBox2.CheckState == CheckState.Unchecked)
            {
                YasBox1.Visible = false;
                YasBox2.Visible = false;
                YasBox1.SelectedItem = null;
                YasBox2.SelectedItem = null;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (baglanti.State == ConnectionState.Closed)
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

        private void textbirikim1_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textbirikim2_KeyPress(object sender, KeyPressEventArgs e)
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            kontrol = true;
        }
    }
}
