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
    public partial class UyeSiralama : Form
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
        public UyeSiralama(AccessDB accdb)
        {
            this.accdb = accdb;
            InitializeComponent();
            btnYenile_Click(null, null);
        }

        private void SayacGuncelle()
        {
            lblKitapSayisi.Text = (dataGridView1.Rows.Count - 1) + "";
        }
        private void button9_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = accdb.GetRows("uyeler", accdb.CreateOrderByQuery("okunanKitapSayisi", true));
            SayacGuncelle();
        }

    }
}
