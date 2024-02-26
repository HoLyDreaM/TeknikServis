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
    public partial class frmKesilenServisFormlari : DevExpress.XtraEditors.XtraForm
    {
        public frmKesilenServisFormlari()
        {
            InitializeComponent();
        }

        private void frmKesilenServisFormlari_Load(object sender, EventArgs e)
        {
            this.tblKullanicilar_LookUpTableAdapter.Fill(this.dataset.tblKullanicilar_LookUp,"Teknik Servis");
            dtTarih.DateTime = DateTime.Now;
            dtTarih1.DateTime = DateTime.Now;
        }

        private void btnYenile_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.raporKesilenServisFormlariTableAdapter.Fill(this.dataset.raporKesilenServisFormlari,dtTarih.DateTime,dtTarih1.DateTime,txtPersonel.Text);
            gridView1.BestFitColumns();
        }
    }
}