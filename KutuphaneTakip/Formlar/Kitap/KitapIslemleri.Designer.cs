namespace KutuphaneTakip.Formlar.Kitap
{
    partial class KitapIslemleri
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
            this.btnYenile = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.numSayfaSayisi = new System.Windows.Forms.NumericUpDown();
            this.numStokSayisi = new System.Windows.Forms.NumericUpDown();
            this.cmbTürü = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.txtRafNo = new System.Windows.Forms.TextBox();
            this.txtYazari = new System.Windows.Forms.TextBox();
            this.txtKitapAdi = new System.Windows.Forms.TextBox();
            this.txtKitapBarkodNo = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtYayinEvi = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSayfaSayisi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStokSayisi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.button9);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(801, 29);
            this.panel1.TabIndex = 14;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.IndianRed;
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.ForeColor = System.Drawing.Color.Black;
            this.button9.Location = new System.Drawing.Point(773, 3);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(22, 22);
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
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Kitap İşlemleri";
            // 
            // btnYenile
            // 
            this.btnYenile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYenile.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnYenile.Location = new System.Drawing.Point(539, 349);
            this.btnYenile.Name = "btnYenile";
            this.btnYenile.Size = new System.Drawing.Size(249, 40);
            this.btnYenile.TabIndex = 56;
            this.btnYenile.Text = "Yenile";
            this.btnYenile.UseVisualStyleBackColor = true;
            this.btnYenile.Click += new System.EventHandler(this.btnYenile_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuncelle.ForeColor = System.Drawing.Color.Turquoise;
            this.btnGuncelle.Location = new System.Drawing.Point(539, 303);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(249, 40);
            this.btnGuncelle.TabIndex = 55;
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
            this.btnSil.TabIndex = 54;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEkle.ForeColor = System.Drawing.Color.LawnGreen;
            this.btnEkle.Location = new System.Drawing.Point(284, 303);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(249, 40);
            this.btnEkle.TabIndex = 53;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // numSayfaSayisi
            // 
            this.numSayfaSayisi.BackColor = System.Drawing.Color.IndianRed;
            this.numSayfaSayisi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numSayfaSayisi.ForeColor = System.Drawing.SystemColors.Control;
            this.numSayfaSayisi.Location = new System.Drawing.Point(120, 164);
            this.numSayfaSayisi.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numSayfaSayisi.Name = "numSayfaSayisi";
            this.numSayfaSayisi.Size = new System.Drawing.Size(144, 20);
            this.numSayfaSayisi.TabIndex = 52;
            this.numSayfaSayisi.ValueChanged += new System.EventHandler(this.textChangedEvent);
            // 
            // numStokSayisi
            // 
            this.numStokSayisi.BackColor = System.Drawing.Color.IndianRed;
            this.numStokSayisi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numStokSayisi.ForeColor = System.Drawing.SystemColors.Control;
            this.numStokSayisi.Location = new System.Drawing.Point(120, 189);
            this.numStokSayisi.Name = "numStokSayisi";
            this.numStokSayisi.Size = new System.Drawing.Size(144, 20);
            this.numStokSayisi.TabIndex = 51;
            this.numStokSayisi.ValueChanged += new System.EventHandler(this.textChangedEvent);
            // 
            // cmbTürü
            // 
            this.cmbTürü.BackColor = System.Drawing.Color.IndianRed;
            this.cmbTürü.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbTürü.FormattingEnabled = true;
            this.cmbTürü.Location = new System.Drawing.Point(120, 214);
            this.cmbTürü.Name = "cmbTürü";
            this.cmbTürü.Size = new System.Drawing.Size(144, 21);
            this.cmbTürü.TabIndex = 50;
            this.cmbTürü.TextChanged += new System.EventHandler(this.textChangedEvent);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.SystemColors.Control;
            this.label16.Location = new System.Drawing.Point(42, 190);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(62, 13);
            this.label16.TabIndex = 48;
            this.label16.Text = "Stok Sayısı:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.Control;
            this.label10.Location = new System.Drawing.Point(51, 274);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 13);
            this.label10.TabIndex = 46;
            this.label10.Text = "Açıklama:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.SystemColors.Control;
            this.label11.Location = new System.Drawing.Point(60, 240);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 13);
            this.label11.TabIndex = 47;
            this.label11.Text = "Raf No:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.SystemColors.Control;
            this.label12.Location = new System.Drawing.Point(72, 215);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(32, 13);
            this.label12.TabIndex = 44;
            this.label12.Text = "Türü:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.SystemColors.Control;
            this.label13.Location = new System.Drawing.Point(50, 140);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(54, 13);
            this.label13.TabIndex = 45;
            this.label13.Text = "Yayın Evi:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(65, 115);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 13);
            this.label9.TabIndex = 43;
            this.label9.Text = "Yazarı:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(52, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 42;
            this.label7.Text = "Kitap Adı:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(16, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 13);
            this.label6.TabIndex = 41;
            this.label6.Text = "Kitap Barkod No:";
            // 
            // txtAciklama
            // 
            this.txtAciklama.BackColor = System.Drawing.Color.IndianRed;
            this.txtAciklama.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAciklama.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtAciklama.Location = new System.Drawing.Point(120, 265);
            this.txtAciklama.MaxLength = 150;
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(144, 39);
            this.txtAciklama.TabIndex = 38;
            this.txtAciklama.TextChanged += new System.EventHandler(this.textChangedEvent);
            // 
            // txtRafNo
            // 
            this.txtRafNo.BackColor = System.Drawing.Color.IndianRed;
            this.txtRafNo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRafNo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtRafNo.Location = new System.Drawing.Point(120, 240);
            this.txtRafNo.MaxLength = 15;
            this.txtRafNo.Multiline = true;
            this.txtRafNo.Name = "txtRafNo";
            this.txtRafNo.Size = new System.Drawing.Size(144, 20);
            this.txtRafNo.TabIndex = 37;
            this.txtRafNo.TextChanged += new System.EventHandler(this.textChangedEvent);
            // 
            // txtYazari
            // 
            this.txtYazari.BackColor = System.Drawing.Color.IndianRed;
            this.txtYazari.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtYazari.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtYazari.Location = new System.Drawing.Point(122, 114);
            this.txtYazari.MaxLength = 25;
            this.txtYazari.Multiline = true;
            this.txtYazari.Name = "txtYazari";
            this.txtYazari.Size = new System.Drawing.Size(144, 20);
            this.txtYazari.TabIndex = 36;
            this.txtYazari.TextChanged += new System.EventHandler(this.textChangedEvent);
            // 
            // txtKitapAdi
            // 
            this.txtKitapAdi.BackColor = System.Drawing.Color.IndianRed;
            this.txtKitapAdi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtKitapAdi.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtKitapAdi.Location = new System.Drawing.Point(122, 89);
            this.txtKitapAdi.MaxLength = 40;
            this.txtKitapAdi.Multiline = true;
            this.txtKitapAdi.Name = "txtKitapAdi";
            this.txtKitapAdi.Size = new System.Drawing.Size(144, 20);
            this.txtKitapAdi.TabIndex = 35;
            this.txtKitapAdi.TextChanged += new System.EventHandler(this.textChangedEvent);
            // 
            // txtKitapBarkodNo
            // 
            this.txtKitapBarkodNo.BackColor = System.Drawing.Color.IndianRed;
            this.txtKitapBarkodNo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtKitapBarkodNo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtKitapBarkodNo.Location = new System.Drawing.Point(122, 64);
            this.txtKitapBarkodNo.MaxLength = 11;
            this.txtKitapBarkodNo.Multiline = true;
            this.txtKitapBarkodNo.Name = "txtKitapBarkodNo";
            this.txtKitapBarkodNo.Size = new System.Drawing.Size(144, 20);
            this.txtKitapBarkodNo.TabIndex = 40;
            this.txtKitapBarkodNo.TextChanged += new System.EventHandler(this.textChangedEvent);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(284, 59);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(504, 228);
            this.dataGridView1.TabIndex = 34;
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(37, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 45;
            this.label1.Text = "Sayfa Sayısı:";
            // 
            // txtYayinEvi
            // 
            this.txtYayinEvi.BackColor = System.Drawing.Color.IndianRed;
            this.txtYayinEvi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtYayinEvi.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtYayinEvi.Location = new System.Drawing.Point(122, 139);
            this.txtYayinEvi.MaxLength = 25;
            this.txtYayinEvi.Multiline = true;
            this.txtYayinEvi.Name = "txtYayinEvi";
            this.txtYayinEvi.Size = new System.Drawing.Size(144, 20);
            this.txtYayinEvi.TabIndex = 36;
            this.txtYayinEvi.TextChanged += new System.EventHandler(this.textChangedEvent);
            // 
            // KitapIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(800, 402);
            this.Controls.Add(this.btnYenile);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.txtKitapBarkodNo);
            this.Controls.Add(this.numSayfaSayisi);
            this.Controls.Add(this.txtKitapAdi);
            this.Controls.Add(this.numStokSayisi);
            this.Controls.Add(this.txtYayinEvi);
            this.Controls.Add(this.txtYazari);
            this.Controls.Add(this.cmbTürü);
            this.Controls.Add(this.txtRafNo);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label13);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "KitapIslemleri";
            this.Text = "KitapIslemleri";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSayfaSayisi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStokSayisi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnYenile;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.NumericUpDown numSayfaSayisi;
        private System.Windows.Forms.NumericUpDown numStokSayisi;
        private System.Windows.Forms.ComboBox cmbTürü;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.TextBox txtRafNo;
        private System.Windows.Forms.TextBox txtYazari;
        private System.Windows.Forms.TextBox txtKitapAdi;
        private System.Windows.Forms.TextBox txtKitapBarkodNo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtYayinEvi;
    }
}