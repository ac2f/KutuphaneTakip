namespace KutuphaneTakip.Formlar.Uye
{
    partial class UyeIslemleri
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button9 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtTcNo = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.txtEposta = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.cmbCinsiyet = new System.Windows.Forms.ComboBox();
            this.numOkunanKitapSayisi = new System.Windows.Forms.NumericUpDown();
            this.numYas = new System.Windows.Forms.NumericUpDown();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnYenile = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOkunanKitapSayisi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numYas)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.Controls.Add(this.button9);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 29);
            this.panel1.TabIndex = 13;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.ForeColor = System.Drawing.Color.IndianRed;
            this.button9.Location = new System.Drawing.Point(771, 0);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(29, 29);
            this.button9.TabIndex = 1;
            this.button9.Text = "X";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Üye İşlemleri";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(284, 59);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(504, 228);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            // 
            // txtTcNo
            // 
            this.txtTcNo.BackColor = System.Drawing.Color.IndianRed;
            this.txtTcNo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTcNo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtTcNo.Location = new System.Drawing.Point(123, 59);
            this.txtTcNo.MaxLength = 11;
            this.txtTcNo.Multiline = true;
            this.txtTcNo.Name = "txtTcNo";
            this.txtTcNo.Size = new System.Drawing.Size(144, 20);
            this.txtTcNo.TabIndex = 19;
            this.txtTcNo.TextChanged += new System.EventHandler(this.textChangedEvent);
            // 
            // txtAd
            // 
            this.txtAd.BackColor = System.Drawing.Color.IndianRed;
            this.txtAd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtAd.Location = new System.Drawing.Point(123, 85);
            this.txtAd.MaxLength = 45;
            this.txtAd.Multiline = true;
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(144, 20);
            this.txtAd.TabIndex = 19;
            this.txtAd.TextChanged += new System.EventHandler(this.textChangedEvent);
            // 
            // txtSoyad
            // 
            this.txtSoyad.BackColor = System.Drawing.Color.IndianRed;
            this.txtSoyad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSoyad.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtSoyad.Location = new System.Drawing.Point(123, 111);
            this.txtSoyad.MaxLength = 45;
            this.txtSoyad.Multiline = true;
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(144, 20);
            this.txtSoyad.TabIndex = 19;
            this.txtSoyad.TextChanged += new System.EventHandler(this.textChangedEvent);
            // 
            // txtTelefon
            // 
            this.txtTelefon.BackColor = System.Drawing.Color.IndianRed;
            this.txtTelefon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTelefon.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtTelefon.Location = new System.Drawing.Point(123, 190);
            this.txtTelefon.MaxLength = 15;
            this.txtTelefon.Multiline = true;
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(144, 20);
            this.txtTelefon.TabIndex = 19;
            this.txtTelefon.TextChanged += new System.EventHandler(this.textChangedEvent);
            // 
            // txtAdres
            // 
            this.txtAdres.BackColor = System.Drawing.Color.IndianRed;
            this.txtAdres.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAdres.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtAdres.Location = new System.Drawing.Point(123, 216);
            this.txtAdres.MaxLength = 60;
            this.txtAdres.Multiline = true;
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(144, 20);
            this.txtAdres.TabIndex = 19;
            this.txtAdres.TextChanged += new System.EventHandler(this.textChangedEvent);
            // 
            // txtEposta
            // 
            this.txtEposta.BackColor = System.Drawing.Color.IndianRed;
            this.txtEposta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEposta.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtEposta.Location = new System.Drawing.Point(123, 242);
            this.txtEposta.MaxLength = 45;
            this.txtEposta.Multiline = true;
            this.txtEposta.Name = "txtEposta";
            this.txtEposta.Size = new System.Drawing.Size(144, 20);
            this.txtEposta.TabIndex = 19;
            this.txtEposta.TextChanged += new System.EventHandler(this.textChangedEvent);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(76, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "TC No:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(94, 86);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Ad:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(76, 113);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "Soyad:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.Control;
            this.label10.Location = new System.Drawing.Point(80, 221);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 13);
            this.label10.TabIndex = 26;
            this.label10.Text = "Adres:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.SystemColors.Control;
            this.label11.Location = new System.Drawing.Point(71, 194);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 13);
            this.label11.TabIndex = 27;
            this.label11.Text = "Telefon:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.SystemColors.Control;
            this.label12.Location = new System.Drawing.Point(71, 167);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(46, 13);
            this.label12.TabIndex = 24;
            this.label12.Text = "Cinsiyet:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.SystemColors.Control;
            this.label13.Location = new System.Drawing.Point(89, 140);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(28, 13);
            this.label13.TabIndex = 25;
            this.label13.Text = "Yaş:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.SystemColors.Control;
            this.label16.Location = new System.Drawing.Point(12, 275);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(105, 13);
            this.label16.TabIndex = 28;
            this.label16.Text = "Okunan Kitap Sayısı:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ForeColor = System.Drawing.SystemColors.Control;
            this.label17.Location = new System.Drawing.Point(71, 248);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(46, 13);
            this.label17.TabIndex = 29;
            this.label17.Text = "E-posta:";
            // 
            // cmbCinsiyet
            // 
            this.cmbCinsiyet.BackColor = System.Drawing.Color.IndianRed;
            this.cmbCinsiyet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbCinsiyet.FormattingEnabled = true;
            this.cmbCinsiyet.Location = new System.Drawing.Point(123, 163);
            this.cmbCinsiyet.Name = "cmbCinsiyet";
            this.cmbCinsiyet.Size = new System.Drawing.Size(144, 21);
            this.cmbCinsiyet.TabIndex = 30;
            this.cmbCinsiyet.TextChanged += new System.EventHandler(this.textChangedEvent);
            // 
            // numOkunanKitapSayisi
            // 
            this.numOkunanKitapSayisi.BackColor = System.Drawing.Color.IndianRed;
            this.numOkunanKitapSayisi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numOkunanKitapSayisi.ForeColor = System.Drawing.SystemColors.Control;
            this.numOkunanKitapSayisi.Location = new System.Drawing.Point(123, 268);
            this.numOkunanKitapSayisi.Name = "numOkunanKitapSayisi";
            this.numOkunanKitapSayisi.Size = new System.Drawing.Size(144, 20);
            this.numOkunanKitapSayisi.TabIndex = 31;
            this.numOkunanKitapSayisi.ValueChanged += new System.EventHandler(this.textChangedEvent);
            // 
            // numYas
            // 
            this.numYas.BackColor = System.Drawing.Color.IndianRed;
            this.numYas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numYas.ForeColor = System.Drawing.SystemColors.Control;
            this.numYas.Location = new System.Drawing.Point(123, 137);
            this.numYas.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numYas.Name = "numYas";
            this.numYas.Size = new System.Drawing.Size(144, 20);
            this.numYas.TabIndex = 32;
            this.numYas.ValueChanged += new System.EventHandler(this.textChangedEvent);
            // 
            // btnEkle
            // 
            this.btnEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEkle.ForeColor = System.Drawing.Color.LawnGreen;
            this.btnEkle.Location = new System.Drawing.Point(284, 303);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(249, 40);
            this.btnEkle.TabIndex = 33;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuncelle.ForeColor = System.Drawing.Color.Turquoise;
            this.btnGuncelle.Location = new System.Drawing.Point(539, 303);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(249, 40);
            this.btnGuncelle.TabIndex = 33;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSil.ForeColor = System.Drawing.Color.Red;
            this.btnSil.Location = new System.Drawing.Point(284, 349);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(249, 40);
            this.btnSil.TabIndex = 33;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnYenile
            // 
            this.btnYenile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYenile.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnYenile.Location = new System.Drawing.Point(539, 349);
            this.btnYenile.Name = "btnYenile";
            this.btnYenile.Size = new System.Drawing.Size(249, 40);
            this.btnYenile.TabIndex = 33;
            this.btnYenile.Text = "Yenile";
            this.btnYenile.UseVisualStyleBackColor = true;
            this.btnYenile.Click += new System.EventHandler(this.btnYenile_Click);
            // 
            // UyeIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(800, 402);
            this.Controls.Add(this.btnYenile);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.numYas);
            this.Controls.Add(this.numOkunanKitapSayisi);
            this.Controls.Add(this.cmbCinsiyet);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtEposta);
            this.Controls.Add(this.txtAdres);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.txtTcNo);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UyeIslemleri";
            this.Text = "UyeEkle";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOkunanKitapSayisi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numYas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtTcNo;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.TextBox txtEposta;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox cmbCinsiyet;
        private System.Windows.Forms.NumericUpDown numOkunanKitapSayisi;
        private System.Windows.Forms.NumericUpDown numYas;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnYenile;
    }
}