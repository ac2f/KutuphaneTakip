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
namespace KutuphaneTakip.Formlar.EmanetKitapGoruntule
{
    public partial class EmanetKitapGoruntule : Form
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
        Dictionary<string, string> data = new Dictionary<string, string>() { };
        AccessDB accdb;
        public EmanetKitapGoruntule(AccessDB accdb)
        {
            this.accdb = accdb;
            InitializeComponent();
            btnYenile_Click(null, null);
            lblKayitliKitapSayisi.Text = accdb.SumColumn("kitaplar", "kitapStokSayisi") + "";
            lblKitapSayisi.Text = accdb.CountColumn("sepet", "*") + "";
        }
        private void cmbTcNo_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int selectedIndex = ((ComboBox)sender).SelectedIndex;
            }
            catch (Exception)
            {

            }
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            new OleDbDataAdapter("SELECT * FROM (EmanetKitaplar AS EK INNER JOIN Kitaplar AS K ON K.barkodNo=EK.barkodNo) INNER JOIN Uyeler AS U ON U.tcNo=EK.tcNo", accdb.connection).Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var selected = dataGridView1.CurrentRow.Cells;
                data["barkodNo"] = selected[1].Value.ToString();
                data["tcNo"] = selected[0].Value.ToString();
            }
            catch (Exception err)
            {
                MessageBox.Show("Hata! " + err.Message);
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                if (data.ContainsKey("barkodNo"))
                {
                    accdb.ExecuteQuery(accdb.CreateDeleteQueryString(
                        "emanet-kitaplar",
                        accdb.CreateExactCondition(new Dictionary<string, string>() {
                            { "barkodNo", data["barkodNo"] }
                        })
                    ));
                    btnYenile_Click(null, null);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Hata! " + err.Message);
            }
        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            if (txtAra.Text == "")
            {
                btnYenile_Click(null, null);
                return;
            }
            try
            {
                DataTable dt = new DataTable();
                new OleDbDataAdapter("SELECT * FROM (EmanetKitaplar AS EK INNER JOIN Kitaplar AS K ON K.barkodNo=EK.barkodNo) INNER JOIN Uyeler AS U ON U.tcNo=EK.tcNo " + accdb.CreateLikeCondition(new string[] { "EK.tcNo", "EK.barkodNo", "EK.kitapSayisi", "EK.teslimTarihi", "EK.iadeTarihi" }, txtAra.Text), accdb.connection).Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                if (data.ContainsKey("tcNo"))
                {
                    accdb.ExecuteQuery(
                        accdb.CreateUpdateQueryString(
                            "emanet-kitaplar",
                            new Dictionary<string, string>() {
                                { "iadeTarihi", DateTime.Now.ToShortDateString() }
                            },
                            accdb.CreateExactCondition(new Dictionary<string, string>() {
                                { "tcNo", data["tcNo"]},
                                {"barkodNo", data["barkodNo"]}
                            })
                   ));
                    accdb.CreateIncreaseColumnValue("uyeler", "okunanKitapSayisi", 1);
                    MessageBox.Show("Kitap iade edildi ve üyenin bilgileri +1 kitap okudu olarak güncellendi!");
                    btnYenile_Click(null, null);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Hata! " + err.Message);
            }
        }
    }
}
