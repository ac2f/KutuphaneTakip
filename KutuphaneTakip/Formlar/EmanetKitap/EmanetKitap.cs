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
        Dictionary<string, string> dataSepet = new Dictionary<string, string>() { };
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
                        comboBox.Items.AddRange(tables[item.Key].AsEnumerable().Select(x => x.Field<int>(comboBox.Tag.ToString()).ToString()).ToArray());
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

        private void button9_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void panelUye_SelectedIndexChanged(object sender, EventArgs e)
        {
            data["tcNo"] = cmbTcNo.Text;
            changeIndexOfCBArray(sender, comboBoxArrayMap["uye"]);
        }
        private void panelKitap_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                changeIndexOfCBArray(sender, comboBoxArrayMap["kitap"]);
                int selectedIndex = ((ComboBox)sender).SelectedIndex;
                numKitapSayisi.Value = decimal.Parse(cmbKitapSayisi.Items[selectedIndex] + "");
                numSayfaSayisi.Value = decimal.Parse(cmbSayfaSayisi.Items[selectedIndex] + "");
                data["barkodNo"] = cmbBarkodNo.Text;
                dataSepet["barkodNo"] = data["barkodNo"];
                data["kitapSayisi"] = cmbKitapSayisi.Text;
                data["teslimTarihi"] = dtpTeslimTarihi.Value.ToShortDateString();
                dataSepet["teslimTarihi"] = data["teslimTarihi"];
                data["iadeTarihi"] = dtpIadeTarihi.Value.ToShortDateString();
                dataSepet["iadeTarihi"] = data["iadeTarihi"];
            }
            catch (Exception)
            {

            }
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            lblKitapSayisi.Text = accdb.CountColumn("sepet", "*") + "";
            dataGridView1.DataSource = accdb.GetRows("sepet", "", "kitaplar", "barkodNo");
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            var selected = dataGridView1.CurrentRow.Cells;
            try
            {
                cmbBarkodNo.SelectedIndex = cmbBarkodNo.Items.IndexOf(selected["Sepet.barkodNo"].Value.ToString());
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
                MessageBox.Show("Hata! " + err.Message);

            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                if (data.ContainsKey("barkodNo"))
                {
                    accdb.ExecuteQuery(accdb.CreateInsertIntoQueryString("sepet", dataSepet));
                    btnYenile_Click(null, null);
                    return;
                }
                MessageBox.Show("Hata! Bir kitap seçmelisiniz.");
            }
            catch (Exception err)
            {
                if (err.Message.ToLower().Contains("primary") || err.Message.ToLower().Contains("birincil"))
                    MessageBox.Show("Hata! Bir kitap aynı anda 2 defa sepete eklenemez.");
                else
                    MessageBox.Show("Hata! " + err.Message);
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
                }
                else if (dt.Rows.Count > 3)
                {
                    MessageBox.Show("Hata! Bir kullanıcı en fazla \"3\" emanet kitap edinebilir. Lütfen sepetten eşya siliniz.");
                    return;
                }
                if (data["tcNo"] == "")
                {
                    MessageBox.Show("Hata! Lütfen kitabı teslim etmek için bir üye seçin.");
                    return;
                }
                string barkodNo = data["barkodNo"];
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
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
            new Formlar.EmanetKitapGoruntule.EmanetKitapGoruntule(accdb).ShowDialog();
        }

    }
}
