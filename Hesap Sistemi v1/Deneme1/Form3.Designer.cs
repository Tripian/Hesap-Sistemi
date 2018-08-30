namespace Deneme1
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.guncelle = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cinsiyetBox = new System.Windows.Forms.ComboBox();
            this.textyas = new System.Windows.Forms.TextBox();
            this.textbirikim = new System.Windows.Forms.TextBox();
            this.textsoyisim = new System.Windows.Forms.TextBox();
            this.textisim = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // guncelle
            // 
            this.guncelle.Location = new System.Drawing.Point(559, 59);
            this.guncelle.Name = "guncelle";
            this.guncelle.Size = new System.Drawing.Size(114, 44);
            this.guncelle.TabIndex = 25;
            this.guncelle.Text = "Güncelle";
            this.guncelle.UseVisualStyleBackColor = true;
            this.guncelle.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd-MM-yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(406, 30);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(100, 22);
            this.dateTimePicker1.TabIndex = 24;
            // 
            // cinsiyetBox
            // 
            this.cinsiyetBox.FormattingEnabled = true;
            this.cinsiyetBox.Items.AddRange(new object[] {
            "Erkek",
            "Kadın"});
            this.cinsiyetBox.Location = new System.Drawing.Point(406, 106);
            this.cinsiyetBox.Name = "cinsiyetBox";
            this.cinsiyetBox.Size = new System.Drawing.Size(100, 24);
            this.cinsiyetBox.TabIndex = 23;
            // 
            // textyas
            // 
            this.textyas.Location = new System.Drawing.Point(406, 70);
            this.textyas.Name = "textyas";
            this.textyas.Size = new System.Drawing.Size(100, 22);
            this.textyas.TabIndex = 22;
            // 
            // textbirikim
            // 
            this.textbirikim.Location = new System.Drawing.Point(151, 108);
            this.textbirikim.Name = "textbirikim";
            this.textbirikim.Size = new System.Drawing.Size(100, 22);
            this.textbirikim.TabIndex = 21;
            // 
            // textsoyisim
            // 
            this.textsoyisim.Location = new System.Drawing.Point(151, 70);
            this.textsoyisim.Name = "textsoyisim";
            this.textsoyisim.Size = new System.Drawing.Size(100, 22);
            this.textsoyisim.TabIndex = 20;
            // 
            // textisim
            // 
            this.textisim.Location = new System.Drawing.Point(151, 32);
            this.textisim.Name = "textisim";
            this.textisim.Size = new System.Drawing.Size(100, 22);
            this.textisim.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(294, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 17);
            this.label6.TabIndex = 18;
            this.label6.Text = "Cinsiyet";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(294, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 17);
            this.label5.TabIndex = 17;
            this.label5.Text = "Yaş";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(294, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 17);
            this.label4.TabIndex = 16;
            this.label4.Text = "Doğum Tarihi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "Birikim";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Soyisim";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "İsim";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(708, 163);
            this.Controls.Add(this.guncelle);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.cinsiyetBox);
            this.Controls.Add(this.textyas);
            this.Controls.Add(this.textbirikim);
            this.Controls.Add(this.textsoyisim);
            this.Controls.Add(this.textisim);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Güncelleme";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button guncelle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DateTimePicker dateTimePicker1;
        public System.Windows.Forms.ComboBox cinsiyetBox;
        public System.Windows.Forms.TextBox textyas;
        public System.Windows.Forms.TextBox textbirikim;
        public System.Windows.Forms.TextBox textsoyisim;
        public System.Windows.Forms.TextBox textisim;
    }
}