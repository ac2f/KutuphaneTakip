using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
namespace KutuphaneTakip.Formlar.EmanetKitap
{
    public partial class EmanetKitap : Form
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
        private Dictionary<string, ComboBox[]> comboBoxArrayMap;
        Dictionary<string, string> data = new Dictionary<string, string>() { };
        AccessDB accdb;
        public EmanetKitap(AccessDB accdb)
        {
            this.accdb = accdb;
            InitializeComponent();
            Dictionary<string, DataTable> tables = new Dictionary<string, DataTable>()
            {
                {"uye", accdb.GetRows("uyeler") },
                {"kitap", accdb.GetRows("kitaplar") }
            };
            comboBoxArrayMap = new Dictionary<string, ComboBox[]>(){
                { "uye", new ComboBox[] { cmbAd, cmbSoyad, cmbTcNo, cmbTelefon } }, 
                { "kitap", new ComboBox[] { cmbBarkodNo, cmbKitapAdi, cmbKitapYazari, cmbYayinEvi, cmbSayfaSayisi, cmbKitapSayisi } } };
            foreach (var item in tables)
            {
                foreach (var comboBox in comboBoxArrayMap[item.Key])
                {
                    try
                    {
                        comboBox.Items.AddRange(tables[item.Key].AsEnumerable().Select(x => x.Field<string>(comboBox.Tag.ToString())).ToArray());
                    }
                    catch (Exception)
                    {
                        comboBox.Items.AddRange(tables[item.Key].AsEnumerable().Select(x => x.Field<int>(comboBox.Tag.ToString()).ToString() ).ToArray());
                    }
                }
            }
            btnYenile_Click(null, null);
            lblKayitliKitapSayisi.Text = accdb.SumColumn("kitaplar", "kitapStokSayisi") + "";
            lblKitapSayisi.Text = accdb.CountColumn("sepet", "*") + "";
            dtpIadeTarihi.Value = DateTime.Now.AddDays(99999);
            dtpTeslimTarihi.Value = DateTime.Now;
        }

        private void changeIndexOfCBArray(object sender, ComboBox[] comboBoxArray)
        {
            int selectedIndex = ((ComboBox)sender).SelectedIndex;
            foreach (var comboBox in comboBoxArray)
            {
                comboBox.SelectedIndex = selectedIndex;
            }
        }

        private void cmbTcNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            changeIndexOfCBArray(sender, comboBoxArrayMap["uye"]);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                changeIndexOfCBArray(sender, comboBoxArrayMap["kitap"]);
                int selectedIndex = ((ComboBox)sender).SelectedIndex;
                numKitapSayisi.Value = decimal.Parse(cmbKitapSayisi.Items[selectedIndex]+""); 
                numSayfaSayisi.Value = decimal.Parse(cmbSayfaSayisi.Items[selectedIndex]+"");
                data["barkodNo"] = cmbBarkodNo.Text;
                data["tcNo"] = cmbTcNo.Text;
                data["teslimTarihi"] = dtpTeslimTarihi.Value.ToShortDateString();
                data["iadeTarihi"] = dtpIadeTarihi.Value.ToShortDateString();
            }
            catch (Exception)
            {

            }
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            //DataTable dt = new DataTable();
            //new OleDbDataAdapter("SELECT M", accdb.connection).Fill(dt);
            //dataGridView1.DataSource = dt; ;
            lblKitapSayisi.Text = accdb.CountColumn("sepet", "*") + "";
            dataGridView1.DataSource = accdb.GetRows("sepet", "", "kitaplar", "barkodNo");
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            var selected = dataGridView1.CurrentRow.Cells;
            try
            {
                //cmbTcNo.SelectedIndex = cmbTcNo.Items.IndexOf(selected["tcNo"].Value.ToString());
                cmbBarkodNo.SelectedIndex = cmbBarkodNo.Items.IndexOf(selected["Sepet.barkodNo"].Value.ToString());
                //txtKitapAdi.Text = selected["kitapAdi"].Value.ToString();
                //txtYazari.Text = selected["kitapYazari"].Value.ToString();
                //txtYayinEvi.Text = selected["kitapYayinEvi"].Value.ToString();
                //numSayfaSayisi.Value = decimal.Parse(selected["kitapSayfaSayisi"].Value + "");
                //numStokSayisi.Value = decimal.Parse(selected["kitapStokSayisi"].Value + "");
                //cmbTürü.Text = selected["kitapTuru"].Value.ToString();
                //txtRafNo.Text = selected["kitapRafNo"].Value.ToString();
                //txtAciklama.Text = selected["kitapAciklama"].Value.ToString();
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

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                if (data.ContainsKey("barkodNo"))
                {
                    accdb.ExecuteQuery(accdb.CreateDeleteQueryString("sepet", accdb.CreateExactCondition(new Dictionary<string, string>() {
                        { "barkodNo", cmbBarkodNo.Text } })));
                    btnYenile_Click(null, null);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Hata! "+err.Message);

            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                if (data.ContainsKey("barkodNo"))
                {
                    string tcNo = "";
                    if (data.ContainsKey("tcNo"))
                    {
                        tcNo = data["tcNo"];
                        data.Remove("tcNo");
                    }
                    accdb.ExecuteQuery(accdb.CreateInsertIntoQueryString("sepet", data));
                    if (data.ContainsKey("tcNo"))
                        data["tcNo"] = tcNo;
                    btnYenile_Click(null, null);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Hata! Bir kitap aynı anda 2 defa sepete eklenemez.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var dt = accdb.GetRows("sepet", "", "kitaplar", "barkodNo");
                if (dt.Rows.Count < 1)
                {
                    MessageBox.Show("Hata! Sepet boş.");
                    return;
                } else if (dt.Rows.Count > 3)
                {
                    MessageBox.Show("Hata! Bir kullanıcı en fazla \"3\" emanet kitap edinebilir. Lütfen sepetten eşya siliniz.");
                    return;
                }
                string barkodNo = data["barkodNo"];
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    data["barkodNo"] = dt.Rows[i].Field<string>("Sepet.barkodNo");
                    accdb.ExecuteQuery(accdb.CreateInsertIntoQueryString("emanet-kitaplar", data));
                }
                data["barkodNo"] = barkodNo;
                accdb.ClearTable("sepet");
                btnYenile_Click(null, null);
            }
            catch (Exception err)
            {
                MessageBox.Show("Hata! " + err.Message);

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
