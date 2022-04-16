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
        private Dictionary<string, ComboBox[]> comboBoxArrayMap;
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
            //lblKitapSayisi.Text = accdb.CountColumn("emanet-kitaplar", "*") + "";

            //dataGridView1.DataSource = accdb.GetRows("sepet", "", "kitaplar", "barkodNo");
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var selected = dataGridView1.CurrentRow.Cells;
                data["barkodNo"] = selected[1].Value.ToString();
            }
            catch (Exception)
            {
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                if (data.ContainsKey("barkodNo"))
                {
                    accdb.ExecuteQuery(accdb.CreateDeleteQueryString("emanet-kitaplar", accdb.CreateExactCondition(new Dictionary<string, string>() {
                        { "barkodNo", data["barkodNo"] } })));
                    btnYenile_Click(null, null);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Hata! "+err.Message);

            }
        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            try
            {
                //new OleDbDataAdapter()
                dataGridView1.DataSource = accdb.GetRows("emanet-kitaplar", accdb.CreateLikeCondition(new string[] { "tcNo", "barkodNo", "kitapSayisi", "teslimTarihi", "iadeTarihi"  }, txtAra.Text));
            }
            catch (Exception)
            {

            }
        }
    }
}
