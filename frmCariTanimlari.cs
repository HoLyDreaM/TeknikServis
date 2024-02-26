using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace TeknikServis
{
    public partial class frmCariTanimlari : DevExpress.XtraEditors.XtraForm
    {
        public frmCariTanimlari()
        {
            InitializeComponent();
        }

        private void frmCariTanimlari_Load(object sender, EventArgs e)
        {
            this.cariTanimlariTableAdapter.Fill(this.dataset.CariTanimlari);
            gridView1.BestFitColumns();
        }

        private void btnYenile_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.cariTanimlariTableAdapter.Fill(this.dataset.CariTanimlari);
            gridView1.BestFitColumns();
        }
    }
}