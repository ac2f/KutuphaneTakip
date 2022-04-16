using System;
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
            btnYenile_Click(null, null);
        }
        AccessDB accdb;
        Dictionary<string, string> data = new Dictionary<string, string>() { };

        private void textChangedEvent(object sender = null, EventArgs e = null)
        {
            data["barkodNo"] = txtKitapBarkodNo.Text;
            data["kitapAdi"] = txtKitapAdi.Text;
            data["kitapYazari"] = txtYazari.Text;
            data["kitapYayinEvi"] = txtYayinEvi.Text;
            data["kitapSayfaSayisi"] = int.Parse(numSayfaSayisi.Value+"")+"";
            data["kitapStokSayisi"] = int.Parse(numStokSayisi.Value+"")+"";
            data["kitapTuru"] = cmbTürü.Text;
            data["kitapRafNo"] = txtRafNo.Text;
            data["kitapAciklama"] = txtAciklama.Text;
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
            if (data.ContainsKey("barkodNo"))
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
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (data.ContainsKey("barkodNo"))
            {
                string barkodNo = data["barkodNo"];
                data.Remove("barkodNo");
                try
                {
                    accdb.ExecuteQuery(accdb.CreateUpdateQueryString("kitaplar", data, accdb.CreateExactCondition(new Dictionary<string, string>() { { "barkodNo", barkodNo } })));
                    btnYenile_Click(null, null);
                }
                catch (Exception err)
                {
                    errNotify(err);
                }
                data["barkodNo"] = barkodNo;
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (data.ContainsKey("barkodNo"))
            {
                try
                {
                    accdb.ExecuteQuery(accdb.CreateDeleteQueryString("kitaplar", accdb.CreateExactCondition(new Dictionary<string, string>() { { "barkodNo", data["barkodNo"] } })));
                    btnYenile_Click(null, null);
                }
                catch (Exception err)
                {
                    errNotify(err);
                }
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
                txtKitapBarkodNo.Text = selected["barkodNo"].Value.ToString();
                txtKitapAdi.Text = selected["kitapAdi"].Value.ToString();
                txtYazari.Text = selected["kitapYazari"].Value.ToString();
                txtYayinEvi.Text = selected["kitapYayinEvi"].Value.ToString();
                numSayfaSayisi.Value = decimal.Parse(selected["kitapSayfaSayisi"].Value+"");
                numStokSayisi.Value = decimal.Parse(selected["kitapStokSayisi"].Value+"");
                cmbTürü.Text = selected["kitapTuru"].Value.ToString();
                txtRafNo.Text = selected["kitapRafNo"].Value.ToString();
                txtAciklama.Text = selected["kitapAciklama"].Value.ToString();
                //    txtKitapBarkodNo.Text = selected["barkodNo"].Value.ToString();
                //    txtYazari.Text = selected["soyad"].Value.ToString();
                //    numSayfaSayisi.Value = int.Parse(selected["yas"].Value.ToString());
                //    cmbTürü.Text = selected["cinsiyet"].Value.ToString();
                //    txtRafNo.Text = selected["telefon"].Value.ToString();
                //    txtAciklama.Text = selected["adres"].Value.ToString();
                //    //txtEposta.Text = selected["eposta"].Value.ToString();
                //    numStokSayisi.Value = int.Parse(selected["okunanKitapSayisi"].Value.ToString());
            }
            catch (Exception) { }
        }
    }
}
