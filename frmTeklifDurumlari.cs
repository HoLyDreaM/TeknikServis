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
    public partial class frmTeklifDurumlari : DevExpress.XtraEditors.XtraForm
    {
        public frmTeklifDurumlari()
        {
            InitializeComponent();
        }
        Fonksiyonlar fn = new Fonksiyonlar();
        public NKUllanici aktifKullanici { get; set; }
        public frmAnaform frmAnaform { get; set; }

        frmTekliFormu1 frmTekliFormu1;

        private void frmTeklifDurumlari_Load(object sender, EventArgs e)
        {
            dtTarih1.DateTime = DateTime.Now;
            dtTarih2.DateTime = DateTime.Now;
        }

        private void btnYenile_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.tblTeklifDurumlariTableAdapter.Fill(this.dataset.tblTeklifDurumlari,dtTarih1.DateTime.ToShortDateString(),dtTarih2.DateTime.ToShortDateString());
            gridView1.BestFitColumns();
        }

        private void btnExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            fn.ps_disariAktar(gridView1, Fonksiyonlar.ciktiTuru.Excel);
        }

        private void btnText_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            fn.ps_disariAktar(gridView1, Fonksiyonlar.ciktiTuru.Text);
        }

        private void btnCsv_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            fn.ps_disariAktar(gridView1, Fonksiyonlar.ciktiTuru.Csv);
        }

        private void btnPdf_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            fn.ps_disariAktar(gridView1, Fonksiyonlar.ciktiTuru.Pdf);
        }

        private void btnTeklifDetayi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (gridView1.DataRowCount > 0)
            {
                frmTekliFormu1 = new frmTekliFormu1();
                frmTekliFormu1.aktifKullanici = aktifKullanici;
                frmTekliFormu1.MdiParent = frmAnaform;
                frmTekliFormu1.Owner = this;
                frmTekliFormu1.Show();
                frmTekliFormu1.psEvrakGetir(Convert.ToInt32(gridView1.GetFocusedRowCellValue(colEvrakNo)));
            }          
        }
    }
}