namespace KutuphaneTakip.Formlar.EmanetKitapGoruntule
{
    partial class EmanetKitapGoruntule
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
            this.btnYenile = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button9 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSil = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnEkle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblKayitliKitapSayisi = new System.Windows.Forms.Label();
            this.lblKitapSayisi = new System.Windows.Forms.Label();
            this.cmbKitapSayisi = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAra = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnYenile
            // 
            this.btnYenile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYenile.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnYenile.Location = new System.Drawing.Point(540, 302);
            this.btnYenile.Name = "btnYenile";
            this.btnYenile.Size = new System.Drawing.Size(249, 40);
            this.btnYenile.TabIndex = 80;
            this.btnYenile.Text = "Yenile";
            this.btnYenile.UseVisualStyleBackColor = true;
            this.btnYenile.Click += new System.EventHandler(this.btnYenile_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.Controls.Add(this.button9);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(801, 29);
            this.panel1.TabIndex = 57;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.ForeColor = System.Drawing.Color.IndianRed;
            this.button9.Location = new System.Drawing.Point(772, 0);
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
            this.label5.Location = new System.Drawing.Point(11, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(173, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Emanet Kitap Görüntüleme İşlemleri";
            // 
            // btnSil
            // 
            this.btnSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSil.ForeColor = System.Drawing.Color.Red;
            this.btnSil.Location = new System.Drawing.Point(285, 348);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(249, 40);
            this.btnSil.TabIndex = 78;
            this.btnSil.Text = "E.K Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(285, 58);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(504, 228);
            this.dataGridView1.TabIndex = 58;
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            // 
            // btnEkle
            // 
            this.btnEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEkle.ForeColor = System.Drawing.Color.LawnGreen;
            this.btnEkle.Location = new System.Drawing.Point(285, 302);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(249, 40);
            this.btnEkle.TabIndex = 77;
            this.btnEkle.Text = "E.K İade Et";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(424, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 82;
            this.label1.Text = "Kayıtlı Kitap Sayısı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(582, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 82;
            this.label2.Text = "Görünen Kitap Sayısı:";
            // 
            // lblKayitliKitapSayisi
            // 
            this.lblKayitliKitapSayisi.AutoSize = true;
            this.lblKayitliKitapSayisi.ForeColor = System.Drawing.Color.IndianRed;
            this.lblKayitliKitapSayisi.Location = new System.Drawing.Point(524, 39);
            this.lblKayitliKitapSayisi.Name = "lblKayitliKitapSayisi";
            this.lblKayitliKitapSayisi.Size = new System.Drawing.Size(13, 13);
            this.lblKayitliKitapSayisi.TabIndex = 83;
            this.lblKayitliKitapSayisi.Text = "0";
            // 
            // lblKitapSayisi
            // 
            this.lblKitapSayisi.AutoSize = true;
            this.lblKitapSayisi.ForeColor = System.Drawing.Color.IndianRed;
            this.lblKitapSayisi.Location = new System.Drawing.Point(700, 39);
            this.lblKitapSayisi.Name = "lblKitapSayisi";
            this.lblKitapSayisi.Size = new System.Drawing.Size(13, 13);
            this.lblKitapSayisi.TabIndex = 83;
            this.lblKitapSayisi.Text = "0";
            // 
            // cmbKitapSayisi
            // 
            this.cmbKitapSayisi.BackColor = System.Drawing.Color.IndianRed;
            this.cmbKitapSayisi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbKitapSayisi.FormattingEnabled = true;
            this.cmbKitapSayisi.Location = new System.Drawing.Point(728, 416);
            this.cmbKitapSayisi.Name = "cmbKitapSayisi";
            this.cmbKitapSayisi.Size = new System.Drawing.Size(49, 21);
            this.cmbKitapSayisi.TabIndex = 72;
            this.cmbKitapSayisi.TabStop = false;
            this.cmbKitapSayisi.Tag = "kitapStokSayisi";
            this.cmbKitapSayisi.Visible = false;
            this.cmbKitapSayisi.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(44, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 84;
            this.label3.Text = "Ara: ";
            // 
            // txtAra
            // 
            this.txtAra.BackColor = System.Drawing.Color.IndianRed;
            this.txtAra.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAra.ForeColor = System.Drawing.SystemColors.Window;
            this.txtAra.Location = new System.Drawing.Point(93, 58);
            this.txtAra.MaxLength = 50;
            this.txtAra.Multiline = true;
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(146, 20);
            this.txtAra.TabIndex = 85;
            this.txtAra.TextChanged += new System.EventHandler(this.txtAra_TextChanged);
            // 
            // EmanetKitapGoruntule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(800, 402);
            this.Controls.Add(this.txtAra);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbKitapSayisi);
            this.Controls.Add(this.lblKitapSayisi);
            this.Controls.Add(this.lblKayitliKitapSayisi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnYenile);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnEkle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EmanetKitapGoruntule";
            this.Text = " ";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnYenile;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblKayitliKitapSayisi;
        private System.Windows.Forms.Label lblKitapSayisi;
        private System.Windows.Forms.ComboBox cmbKitapSayisi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAra;
    }
}