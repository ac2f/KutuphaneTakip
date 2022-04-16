namespace KutuphaneTakip
{
    partial class AnaForm
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
            this.btnUyeEkleme = new System.Windows.Forms.Button();
            this.btnKitapEkleme = new System.Windows.Forms.Button();
            this.btnEmanetKitapVerme = new System.Windows.Forms.Button();
            this.btnGrafikler = new System.Windows.Forms.Button();
            this.btnSiralama = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button9 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(145, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Üye İşlemleri ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(141, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kitap İşlemleri ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(109, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(195, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Emanet Kitap İşlemleri";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(109, 274);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Sıralama ve Grafikler";
            // 
            // btnUyeEkleme
            // 
            this.btnUyeEkleme.BackColor = System.Drawing.Color.DimGray;
            this.btnUyeEkleme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUyeEkleme.ForeColor = System.Drawing.Color.Chartreuse;
            this.btnUyeEkleme.Location = new System.Drawing.Point(66, 86);
            this.btnUyeEkleme.Name = "btnUyeEkleme";
            this.btnUyeEkleme.Size = new System.Drawing.Size(280, 30);
            this.btnUyeEkleme.TabIndex = 4;
            this.btnUyeEkleme.Text = "Üye İşlemleri";
            this.btnUyeEkleme.UseVisualStyleBackColor = false;
            this.btnUyeEkleme.Click += new System.EventHandler(this.btnUye_Click);
            // 
            // btnKitapEkleme
            // 
            this.btnKitapEkleme.BackColor = System.Drawing.Color.DimGray;
            this.btnKitapEkleme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKitapEkleme.ForeColor = System.Drawing.Color.Chartreuse;
            this.btnKitapEkleme.Location = new System.Drawing.Point(66, 160);
            this.btnKitapEkleme.Name = "btnKitapEkleme";
            this.btnKitapEkleme.Size = new System.Drawing.Size(280, 30);
            this.btnKitapEkleme.TabIndex = 6;
            this.btnKitapEkleme.Text = "Kitap İşlemleri";
            this.btnKitapEkleme.UseVisualStyleBackColor = false;
            this.btnKitapEkleme.Click += new System.EventHandler(this.btnKitap_Click);
            // 
            // btnEmanetKitapVerme
            // 
            this.btnEmanetKitapVerme.BackColor = System.Drawing.Color.DimGray;
            this.btnEmanetKitapVerme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmanetKitapVerme.ForeColor = System.Drawing.Color.Chartreuse;
            this.btnEmanetKitapVerme.Location = new System.Drawing.Point(66, 234);
            this.btnEmanetKitapVerme.Name = "btnEmanetKitapVerme";
            this.btnEmanetKitapVerme.Size = new System.Drawing.Size(280, 30);
            this.btnEmanetKitapVerme.TabIndex = 8;
            this.btnEmanetKitapVerme.Text = "Emanet Kitap İşlemleri";
            this.btnEmanetKitapVerme.UseVisualStyleBackColor = false;
            this.btnEmanetKitapVerme.Click += new System.EventHandler(this.btnEmanetKitap_Click);
            // 
            // btnGrafikler
            // 
            this.btnGrafikler.BackColor = System.Drawing.Color.DimGray;
            this.btnGrafikler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGrafikler.ForeColor = System.Drawing.Color.Chartreuse;
            this.btnGrafikler.Location = new System.Drawing.Point(66, 348);
            this.btnGrafikler.Name = "btnGrafikler";
            this.btnGrafikler.Size = new System.Drawing.Size(280, 30);
            this.btnGrafikler.TabIndex = 11;
            this.btnGrafikler.Text = "Grafikler";
            this.btnGrafikler.UseVisualStyleBackColor = false;
            this.btnGrafikler.Click += new System.EventHandler(this.btnGrafikler_Click);
            // 
            // btnSiralama
            // 
            this.btnSiralama.BackColor = System.Drawing.Color.DimGray;
            this.btnSiralama.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSiralama.ForeColor = System.Drawing.Color.Chartreuse;
            this.btnSiralama.Location = new System.Drawing.Point(66, 308);
            this.btnSiralama.Name = "btnSiralama";
            this.btnSiralama.Size = new System.Drawing.Size(280, 30);
            this.btnSiralama.TabIndex = 10;
            this.btnSiralama.Text = "Sıralama";
            this.btnSiralama.UseVisualStyleBackColor = false;
            this.btnSiralama.Click += new System.EventHandler(this.btnSiralama_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.button9);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(416, 29);
            this.panel1.TabIndex = 12;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.SystemColors.Control;
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.ForeColor = System.Drawing.Color.IndianRed;
            this.button9.Location = new System.Drawing.Point(384, 0);
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
            this.label5.Location = new System.Drawing.Point(12, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Ana Form";
            // 
            // AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(414, 406);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnGrafikler);
            this.Controls.Add(this.btnSiralama);
            this.Controls.Add(this.btnEmanetKitapVerme);
            this.Controls.Add(this.btnKitapEkleme);
            this.Controls.Add(this.btnUyeEkleme);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AnaForm";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnUyeEkleme;
        private System.Windows.Forms.Button btnKitapEkleme;
        private System.Windows.Forms.Button btnEmanetKitapVerme;
        private System.Windows.Forms.Button btnGrafikler;
        private System.Windows.Forms.Button btnSiralama;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Label label5;
    }
}

