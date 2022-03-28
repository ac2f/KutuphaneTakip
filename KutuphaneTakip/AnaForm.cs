using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneTakip
{
    public partial class AnaForm : Form
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
        public AnaForm(AccessDB accdb)
        {
            InitializeComponent();
            this.accdb = accdb;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEmanetKitap_Click(object sender, EventArgs e)
        {

        }

        private void btnSiralama_Click(object sender, EventArgs e)
        {

        }

        private void btnGrafikler_Click(object sender, EventArgs e)
        {

        }

        private void btnKitap_Click(object sender, EventArgs e)
        {

        }

        private void btnUye_Click(object sender, EventArgs e)
        {
            new Formlar.Uye.UyeIslemleri(accdb).ShowDialog();
        }
    }
}
