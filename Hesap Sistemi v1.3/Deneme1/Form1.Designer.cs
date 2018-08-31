namespace Deneme1
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.textbirikim2 = new System.Windows.Forms.TextBox();
            this.tarihPicker2 = new System.Windows.Forms.DateTimePicker();
            this.tarihPicker1 = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.YasBox2 = new System.Windows.Forms.ComboBox();
            this.YasBox1 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cinsiyetBox = new System.Windows.Forms.ComboBox();
            this.btnsil = new System.Windows.Forms.Button();
            this.btnguncelle = new System.Windows.Forms.Button();
            this.btnkaydet = new System.Windows.Forms.Button();
            this.textbirikim1 = new System.Windows.Forms.TextBox();
            this.textsoyisim = new System.Windows.Forms.TextBox();
            this.textisim = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.siralaBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.form3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.form3BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.siralaBox1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.textbirikim2);
            this.groupBox1.Controls.Add(this.tarihPicker2);
            this.groupBox1.Controls.Add(this.tarihPicker1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.YasBox2);
            this.groupBox1.Controls.Add(this.YasBox1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cinsiyetBox);
            this.groupBox1.Controls.Add(this.btnsil);
            this.groupBox1.Controls.Add(this.btnguncelle);
            this.groupBox1.Controls.Add(this.btnkaydet);
            this.groupBox1.Controls.Add(this.textbirikim1);
            this.groupBox1.Controls.Add(this.textsoyisim);
            this.groupBox1.Controls.Add(this.textisim);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(836, 183);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bilgiler";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(570, 125);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 38);
            this.button2.TabIndex = 24;
            this.button2.Text = "Tüm Veriler";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(250, 84);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(54, 21);
            this.checkBox2.TabIndex = 23;
            this.checkBox2.Text = "Yaş";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckStateChanged += new System.EventHandler(this.checkBox2_CheckStateChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(250, 56);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(115, 21);
            this.checkBox1.TabIndex = 22;
            this.checkBox1.Text = "Doğum Tarihi";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckStateChanged += new System.EventHandler(this.checkBox1_CheckStateChanged);
            // 
            // textbirikim2
            // 
            this.textbirikim2.Location = new System.Drawing.Point(484, 27);
            this.textbirikim2.Name = "textbirikim2";
            this.textbirikim2.Size = new System.Drawing.Size(107, 22);
            this.textbirikim2.TabIndex = 21;
            // 
            // tarihPicker2
            // 
            this.tarihPicker2.CustomFormat = "dd.MM.yyyy";
            this.tarihPicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.tarihPicker2.Location = new System.Drawing.Point(484, 56);
            this.tarihPicker2.Name = "tarihPicker2";
            this.tarihPicker2.Size = new System.Drawing.Size(107, 22);
            this.tarihPicker2.TabIndex = 20;
            this.tarihPicker2.Value = new System.DateTime(2018, 8, 29, 16, 13, 38, 0);
            this.tarihPicker2.Visible = false;
            // 
            // tarihPicker1
            // 
            this.tarihPicker1.CustomFormat = "dd.MM.yyyy";
            this.tarihPicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.tarihPicker1.Location = new System.Drawing.Point(371, 55);
            this.tarihPicker1.Name = "tarihPicker1";
            this.tarihPicker1.Size = new System.Drawing.Size(107, 22);
            this.tarihPicker1.TabIndex = 19;
            this.tarihPicker1.Value = new System.DateTime(2018, 8, 29, 16, 13, 30, 0);
            this.tarihPicker1.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(472, 125);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 38);
            this.button1.TabIndex = 18;
            this.button1.Text = "Sırala";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // YasBox2
            // 
            this.YasBox2.FormattingEnabled = true;
            this.YasBox2.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59",
            "60",
            "61",
            "62",
            "63",
            "64",
            "65",
            "66",
            "67",
            "68",
            "69",
            "70",
            "71",
            "72",
            "73",
            "74",
            "75",
            "76",
            "77",
            "78",
            "79",
            "80",
            "81",
            "82",
            "83",
            "84",
            "85",
            "86",
            "87",
            "88",
            "89",
            "90",
            "91",
            "92",
            "93",
            "94",
            "95",
            "96",
            "97",
            "98",
            "99",
            "100",
            "101",
            "102",
            "103",
            "104",
            "105",
            "106",
            "107",
            "108",
            "109",
            "110",
            "111",
            "112",
            "113",
            "114",
            "115",
            "116",
            "117",
            "118",
            "119",
            "120",
            "121",
            "122",
            "123",
            "124",
            "125",
            "126",
            "127",
            "128",
            "129",
            "130",
            "131",
            "132",
            "133",
            "134",
            "135",
            "136",
            "137",
            "138",
            "139",
            "140",
            "141",
            "142",
            "143",
            "144",
            "145",
            "146",
            "147",
            "148",
            "149",
            "150"});
            this.YasBox2.Location = new System.Drawing.Point(484, 84);
            this.YasBox2.Name = "YasBox2";
            this.YasBox2.Size = new System.Drawing.Size(107, 24);
            this.YasBox2.TabIndex = 17;
            this.YasBox2.Visible = false;
            // 
            // YasBox1
            // 
            this.YasBox1.FormattingEnabled = true;
            this.YasBox1.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59",
            "60",
            "61",
            "62",
            "63",
            "64",
            "65",
            "66",
            "67",
            "68",
            "69",
            "70",
            "71",
            "72",
            "73",
            "74",
            "75",
            "76",
            "77",
            "78",
            "79",
            "80",
            "81",
            "82",
            "83",
            "84",
            "85",
            "86",
            "87",
            "88",
            "89",
            "90",
            "91",
            "92",
            "93",
            "94",
            "95",
            "96",
            "97",
            "98",
            "99",
            "100",
            "101",
            "102",
            "103",
            "104",
            "105",
            "106",
            "107",
            "108",
            "109",
            "110",
            "111",
            "112",
            "113",
            "114",
            "115",
            "116",
            "117",
            "118",
            "119",
            "120",
            "121",
            "122",
            "123",
            "124",
            "125",
            "126",
            "127",
            "128",
            "129",
            "130",
            "131",
            "132",
            "133",
            "134",
            "135",
            "136",
            "137",
            "138",
            "139",
            "140",
            "141",
            "142",
            "143",
            "144",
            "145",
            "146",
            "147",
            "148",
            "149",
            "150"});
            this.YasBox1.Location = new System.Drawing.Point(371, 84);
            this.YasBox1.Name = "YasBox1";
            this.YasBox1.Size = new System.Drawing.Size(107, 24);
            this.YasBox1.TabIndex = 16;
            this.YasBox1.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "Cinsiyet";
            // 
            // cinsiyetBox
            // 
            this.cinsiyetBox.FormattingEnabled = true;
            this.cinsiyetBox.Items.AddRange(new object[] {
            "Tümü",
            "Erkek",
            "Kadın"});
            this.cinsiyetBox.Location = new System.Drawing.Point(107, 84);
            this.cinsiyetBox.Name = "cinsiyetBox";
            this.cinsiyetBox.Size = new System.Drawing.Size(101, 24);
            this.cinsiyetBox.TabIndex = 14;
            // 
            // btnsil
            // 
            this.btnsil.Location = new System.Drawing.Point(374, 125);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(92, 38);
            this.btnsil.TabIndex = 8;
            this.btnsil.Text = "Sil";
            this.btnsil.UseVisualStyleBackColor = true;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // btnguncelle
            // 
            this.btnguncelle.Location = new System.Drawing.Point(276, 125);
            this.btnguncelle.Name = "btnguncelle";
            this.btnguncelle.Size = new System.Drawing.Size(92, 38);
            this.btnguncelle.TabIndex = 7;
            this.btnguncelle.Text = "Güncelle";
            this.btnguncelle.UseVisualStyleBackColor = true;
            this.btnguncelle.Click += new System.EventHandler(this.btnguncelle_Click);
            // 
            // btnkaydet
            // 
            this.btnkaydet.Location = new System.Drawing.Point(178, 125);
            this.btnkaydet.Name = "btnkaydet";
            this.btnkaydet.Size = new System.Drawing.Size(92, 38);
            this.btnkaydet.TabIndex = 6;
            this.btnkaydet.Text = "Yeni Kayıt";
            this.btnkaydet.UseVisualStyleBackColor = true;
            this.btnkaydet.Click += new System.EventHandler(this.btnkaydet_Click);
            // 
            // textbirikim1
            // 
            this.textbirikim1.Location = new System.Drawing.Point(371, 27);
            this.textbirikim1.Name = "textbirikim1";
            this.textbirikim1.Size = new System.Drawing.Size(107, 22);
            this.textbirikim1.TabIndex = 5;
            // 
            // textsoyisim
            // 
            this.textsoyisim.Location = new System.Drawing.Point(107, 56);
            this.textsoyisim.Name = "textsoyisim";
            this.textsoyisim.Size = new System.Drawing.Size(101, 22);
            this.textsoyisim.TabIndex = 4;
            // 
            // textisim
            // 
            this.textisim.Location = new System.Drawing.Point(107, 28);
            this.textisim.Name = "textisim";
            this.textisim.Size = new System.Drawing.Size(101, 22);
            this.textisim.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(247, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Birikim";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soyisim";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "İsim";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(0, 405);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(836, 132);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "İstatistikler";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 183);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(836, 222);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // siralaBox1
            // 
            this.siralaBox1.FormattingEnabled = true;
            this.siralaBox1.Items.AddRange(new object[] {
            "Sıralama",
            "İsme Göre",
            "Soyisme Göre",
            "Cinsiyete Göre",
            "Birikime Göre",
            "Doğum Tarihine Göre",
            "Yaşa Göre"});
            this.siralaBox1.Location = new System.Drawing.Point(680, 53);
            this.siralaBox1.Name = "siralaBox1";
            this.siralaBox1.Size = new System.Drawing.Size(121, 24);
            this.siralaBox1.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(615, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 17);
            this.label4.TabIndex = 26;
            this.label4.Text = "Sırala";
            // 
            // form3BindingSource
            // 
            this.form3BindingSource.DataSource = typeof(Deneme1.Form3);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 537);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hesap Sistemi";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.form3BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Button btnguncelle;
        private System.Windows.Forms.Button btnkaydet;
        private System.Windows.Forms.TextBox textsoyisim;
        private System.Windows.Forms.TextBox textisim;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cinsiyetBox;
        private System.Windows.Forms.ComboBox YasBox2;
        private System.Windows.Forms.ComboBox YasBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource form3BindingSource;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker tarihPicker2;
        private System.Windows.Forms.DateTimePicker tarihPicker1;
        private System.Windows.Forms.TextBox textbirikim2;
        private System.Windows.Forms.TextBox textbirikim1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox siralaBox1;
    }
}

