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
namespace KutuphaneTakip.Formlar.Siralama
{
    public partial class KitapSiralama : Form
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
        AccessDB accdb;
        public KitapSiralama(AccessDB accdb)
        {
            this.accdb = accdb;
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
            btnYenile_Click(null, null);
        }

        private void SayacGuncelle()
        {
            lblKitapSayisi.Text = (dataGridView1.Rows.Count > 1 ? dataGridView1.Rows.Count - 1 : 0) + "";
        }
        private void button9_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            comboBox1_SelectedIndexChanged(sender, e);
            SayacGuncelle();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = null;
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    dt = accdb.GetRows("emanet-kitaplar");
                    break;
                case 1:
                    dt = accdb.GetRows("emanet-kitaplar", accdb.CreateDatediffFromNowCondition("teslimTarihi", "d", 30, false));
                    break;
                case 2:
                    dt = accdb.GetRows("emanet-kitaplar", accdb.CreateDatediffFromNowCondition("teslimTarihi", "d", 30, true));
                    break;
                default:
                    break;
            }
            dataGridView1.DataSource = dt;
        }
    }
}
