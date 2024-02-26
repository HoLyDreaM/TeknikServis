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
    public partial class frmGorevler : DevExpress.XtraEditors.XtraForm
    {
        public frmGorevler()
        {
            InitializeComponent();
        }
        public NKUllanici aktifKullanici { get; set; }
        public frmAnaform frmAnafrm { get; set; }


        frmArizaFormu frmArzaFormu;
        frmServisFormu frmServisFormu;

        private void frmGorevler_Load(object sender, EventArgs e)
        {
            dtTarih1.DateTime = DateTime.Parse( "1." + DateTime.Now.Month.ToString() + "." + DateTime.Now.Year.ToString());
            dtTarih2.DateTime = DateTime.Parse((DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month).ToString() + "." + DateTime.Now.Month.ToString() + "." + DateTime.Now.Year.ToString()).ToString());

            string tarih1 = dtTarih1.DateTime.ToShortDateString();
            string tarih2 = dtTarih2.DateTime.ToShortDateString();

            this.tblGorev_AcikArizaFormlariTableAdapter.Fill(this.dataset.tblGorev_AcikArizaFormlari);
            this.tblGorev_PersonelGorevleriTableAdapter.Fill(this.dataset.tblGorev_PersonelGorevleri, aktifKullanici.AdiSoyadi);
            this.tblGorev_YaklasanBakimlarTableAdapter.Fill(this.dataset.tblGorev_YaklasanBakimlar, tarih1, tarih2);

            gridView1.BestFitColumns();
            gridView2.BestFitColumns();
            gridView3.BestFitColumns();
        }

        private void btnYenile_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string tarih1 = dtTarih1.DateTime.ToShortDateString();
            string tarih2 = dtTarih2.DateTime.ToShortDateString();     

            this.tblGorev_AcikArizaFormlariTableAdapter.Fill(this.dataset.tblGorev_AcikArizaFormlari);
            this.tblGorev_PersonelGorevleriTableAdapter.Fill(this.dataset.tblGorev_PersonelGorevleri,aktifKullanici.AdiSoyadi);
            this.tblGorev_YaklasanBakimlarTableAdapter.Fill(this.dataset.tblGorev_YaklasanBakimlar, tarih1,tarih2);

            gridView1.BestFitColumns();
            gridView2.BestFitColumns();
            gridView3.BestFitColumns();
        }

        private void arızaFormunuAçToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (gridView1.DataRowCount > 0)
            {
                frmArzaFormu = new frmArizaFormu();
                frmArzaFormu.aktifKullanici = aktifKullanici;
                frmArzaFormu.MdiParent = frmAnafrm;
                frmArzaFormu.spEvrakGetir(Convert.ToInt32(gridView1.GetFocusedRowCellValue(colEvrakNo.FieldName)));
                frmArzaFormu.Show();
            }else
                MessageBox.Show("Kayıt Yok!");
        }

        private void servisFormuOlarakAçToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (gridView1.DataRowCount > 0)
            {
                frmServisFormu = new frmServisFormu();
                frmServisFormu.aktifKullanici = aktifKullanici;
                frmServisFormu.MdiParent = frmAnafrm;
                frmServisFormu.psArizaFormuGetir1(gridView1.GetFocusedRowCellValue(colMusteriKodu).ToString(), Convert.ToInt32(gridView1.GetFocusedRowCellValue(colEvrakNo)));
                frmServisFormu.Show();
            }
            else
                MessageBox.Show("Kayıt Yok!");
        }

        private void teknikServisFormuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (gridView2.DataRowCount > 0)
            {
                frmServisFormu = new frmServisFormu();
                frmServisFormu.aktifKullanici = aktifKullanici;
                frmServisFormu.MdiParent = frmAnafrm;
                frmServisFormu.psIsEmri(gridView2.GetFocusedRowCellValue(colMusteriKodu).ToString(), Convert.ToInt32(gridView2.GetFocusedRowCellValue(colEvrakNo)));
                frmServisFormu.Show();
            }
            else
                MessageBox.Show("Kayıt Yok!"); 
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string tarih1 = dtTarih1.DateTime.ToShortDateString();
            string tarih2 = dtTarih2.DateTime.ToShortDateString();    

            this.tblGorev_AcikArizaFormlariTableAdapter.Fill(this.dataset.tblGorev_AcikArizaFormlari);
            this.tblGorev_PersonelGorevleriTableAdapter.Fill(this.dataset.tblGorev_PersonelGorevleri, aktifKullanici.AdiSoyadi);
            this.tblGorev_YaklasanBakimlarTableAdapter.Fill(this.dataset.tblGorev_YaklasanBakimlar, tarih1, tarih2);

            gridView1.BestFitColumns();
            gridView2.BestFitColumns();
            gridView3.BestFitColumns();
        }
    }
}