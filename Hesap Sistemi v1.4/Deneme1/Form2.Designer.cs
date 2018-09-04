namespace Deneme1
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textisim = new System.Windows.Forms.TextBox();
            this.textsoyisim = new System.Windows.Forms.TextBox();
            this.textbirikim = new System.Windows.Forms.TextBox();
            this.textyas = new System.Windows.Forms.TextBox();
            this.cinsiyetBox1 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.kaydet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "İsim";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soyisim";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Birikim";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(288, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Doğum Tarihi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(288, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Yaş";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(288, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Cinsiyet";
            // 
            // textisim
            // 
            this.textisim.Location = new System.Drawing.Point(145, 33);
            this.textisim.Name = "textisim";
            this.textisim.Size = new System.Drawing.Size(100, 22);
            this.textisim.TabIndex = 6;
            // 
            // textsoyisim
            // 
            this.textsoyisim.Location = new System.Drawing.Point(145, 71);
            this.textsoyisim.Name = "textsoyisim";
            this.textsoyisim.Size = new System.Drawing.Size(100, 22);
            this.textsoyisim.TabIndex = 7;
            // 
            // textbirikim
            // 
            this.textbirikim.Location = new System.Drawing.Point(145, 109);
            this.textbirikim.Name = "textbirikim";
            this.textbirikim.Size = new System.Drawing.Size(100, 22);
            this.textbirikim.TabIndex = 8;
            this.textbirikim.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textbirikim_KeyPress);
            // 
            // textyas
            // 
            this.textyas.Location = new System.Drawing.Point(400, 71);
            this.textyas.Name = "textyas";
            this.textyas.Size = new System.Drawing.Size(100, 22);
            this.textyas.TabIndex = 9;
            this.textyas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textyas_KeyPress);
            // 
            // cinsiyetBox1
            // 
            this.cinsiyetBox1.FormattingEnabled = true;
            this.cinsiyetBox1.Items.AddRange(new object[] {
            "Erkek",
            "Kadın"});
            this.cinsiyetBox1.Location = new System.Drawing.Point(400, 107);
            this.cinsiyetBox1.Name = "cinsiyetBox1";
            this.cinsiyetBox1.Size = new System.Drawing.Size(100, 24);
            this.cinsiyetBox1.TabIndex = 10;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd-MM-yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(400, 31);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(100, 22);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // kaydet
            // 
            this.kaydet.Location = new System.Drawing.Point(553, 60);
            this.kaydet.Name = "kaydet";
            this.kaydet.Size = new System.Drawing.Size(114, 44);
            this.kaydet.TabIndex = 12;
            this.kaydet.Text = "Kaydet";
            this.kaydet.UseVisualStyleBackColor = true;
            this.kaydet.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(704, 170);
            this.Controls.Add(this.kaydet);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.cinsiyetBox1);
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
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kayıt";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button kaydet;
        public System.Windows.Forms.TextBox textisim;
        public System.Windows.Forms.TextBox textsoyisim;
        public System.Windows.Forms.TextBox textbirikim;
        public System.Windows.Forms.TextBox textyas;
        public System.Windows.Forms.ComboBox cinsiyetBox1;
        public System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}