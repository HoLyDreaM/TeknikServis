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
    public partial class frmArizaFormlari : DevExpress.XtraEditors.XtraForm
    {
        public frmArizaFormlari()
        {
            InitializeComponent();
        }

        private void btnYenile_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.raporArizaFormlariTableAdapter.Fill(this.dataset.raporArizaFormlari,dtTarih.DateTime,dtTarih1.DateTime,(byte)cmbHareketDurumu.SelectedIndex);
            gridView1.BestFitColumns();
        }

        private void frmArizaFormlari_Load(object sender, EventArgs e)
        {
            cmbHareketDurumu.SelectedIndex = 2;
            dtTarih.DateTime = DateTime.Now;
            dtTarih1.DateTime = DateTime.Now;
        }
    }
}