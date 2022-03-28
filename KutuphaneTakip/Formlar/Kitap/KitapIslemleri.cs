﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneTakip.Formlar.Kitap
{
    public partial class KitapIslemleri : Form
    {
        private const int WM_NCHITTEST = 0x84;
        private const int HTCLIENT = 0x1;
        private const int HTCAPTION = 0x2;
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCHITTEST:
                    base.WndProc(ref m);
                    if (Control.MouseButtons != MouseButtons.Right)
                    {
                        if ((int)m.Result == HTCLIENT)
                            m.Result = (IntPtr)HTCAPTION;
                    }
                    return;
            }
            base.WndProc(ref m);
        }
        public KitapIslemleri(AccessDB accdb)
        {
            InitializeComponent();
            this.accdb = accdb;
        }
        AccessDB accdb;
        Dictionary<string, string> data = new Dictionary<string, string>() { };

        private void textChangedEvent(object sender = null, EventArgs e = null)
        {
            data["tcNo"] = txtKitapBarkodNo.Text;
            data["ad"] = txtKitapAdi.Text;
            data["soyad"] = txtYazari.Text;
            data["yas"] = numSayfaSayisi.Value.ToString();
            data["cinsiyet"] = cmbTürü.Text;
            data["telefon"] = txtRafNo.Text;
            data["adres"] = txtAciklama.Text;
            data["eposta"] = txtEposta.Text;
            data["okunanKitapSayisi"] = numStokSayisi.Value.ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void errNotify(Exception err)
        {
            MessageBox.Show("Hata!\n" + err.Message);
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                accdb.ExecuteQuery(accdb.CreateInsertIntoQueryString("kitaplar", data));
                btnYenile_Click(null, null);
            }
            catch (Exception err)
            {
                errNotify(err);
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            string tcNo = data["tcNo"];
            data.Remove("tcNo");
            try
            {
                accdb.ExecuteQuery(accdb.CreateUpdateQueryString("kitaplar", data, accdb.CreateExactCondition(new Dictionary<string, string>() { { "tcNo", tcNo } })));
                btnYenile_Click(null, null);
            }
            catch (Exception err)
            {
                errNotify(err);
            }
            data["tcNo"] = tcNo;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                accdb.ExecuteQuery(accdb.CreateDeleteQueryString("kitaplar", accdb.CreateExactCondition(new Dictionary<string, string>() { { "tcNo", data["tcNo"] } })));
                btnYenile_Click(null, null);
            }
            catch (Exception err)
            {
                errNotify(err);
            }
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = accdb.GetRows("kitaplar");
            }
            catch (Exception err)
            {
                errNotify(err);
            }
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            var selected = dataGridView1.CurrentRow.Cells;
            try
            {
                txtKitapBarkodNo.Text = selected["tcNo"].Value.ToString();
                txtYazari.Text = selected["soyad"].Value.ToString();
                numSayfaSayisi.Value = int.Parse(selected["yas"].Value.ToString());
                cmbTürü.Text = selected["cinsiyet"].Value.ToString();
                txtRafNo.Text = selected["telefon"].Value.ToString();
                txtAciklama.Text = selected["adres"].Value.ToString();
                txtEposta.Text = selected["eposta"].Value.ToString();
                numStokSayisi.Value = int.Parse(selected["okunanKitapSayisi"].Value.ToString());
            }
            catch (Exception) { }
        }
    }
}
