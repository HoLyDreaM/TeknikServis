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
    public partial class frmIsEmirleri : DevExpress.XtraEditors.XtraForm
    {
        public frmIsEmirleri()
        {
            InitializeComponent();
        }

        frmIsEmriEkleDuzenle frmIsEmriEkleDuzenle;
        public NKUllanici aktifKullanici { get; set; }

        Fonksiyonlar fn = new Fonksiyonlar();

        public void psYenile() {
            this.tblIsEmirleriTableAdapter.Fill(this.dataset.tblIsEmirleri);
            gridView1.BestFitColumns();

        }

        private void frmIsEmirleri_Load(object sender, EventArgs e)
        {
            psYenile();
        }

        private void btnYenile_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            psYenile();
        }

        private void btnDuzenle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (gridView1.DataRowCount > 0)
            {
                DataRow dr = gridView1.GetFocusedDataRow();
                if (Convert.ToInt32(dr[colHareketDurumu.FieldName]) == 0)
                {
                    NIsEmri isEmri = new NIsEmri();
                    isEmri.ID = (int)dr[colID.FieldName];
                    isEmri.musteriKodu = dr[colMusteriKodu.FieldName].ToString();
                    isEmri.personel = dr[colPersonel.FieldName].ToString();
                    isEmri.sikayet = dr[colSikayet.FieldName].ToString();
                    isEmri.tarih = (DateTime)dr[colTarih.FieldName];
                    isEmri.evrakNo = Convert.ToInt32(dr[colEvrakNo.FieldName]);
                    isEmri.hareketDurumu = Convert.ToInt32(dr[colHareketDurumu.FieldName]);

                    frmIsEmriEkleDuzenle = new frmIsEmriEkleDuzenle();
                    frmIsEmriEkleDuzenle.Owner = this;
                    frmIsEmriEkleDuzenle.aktifKullanici = aktifKullanici;
                    frmIsEmriEkleDuzenle.frmIsEmirleri = this;
                    frmIsEmriEkleDuzenle.islemTipi = 1;
                    frmIsEmriEkleDuzenle.isEmri = isEmri;
                    frmIsEmriEkleDuzenle.ShowDialog();
                }else
                    MessageBox.Show("İşlem Gören Hareket Düzenlenemez!");
            }
            else
                MessageBox.Show("Düzenlenecek Kayıt Bulunamadı!");  
        }

        private void btnEkle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmIsEmriEkleDuzenle = new frmIsEmriEkleDuzenle();
            frmIsEmriEkleDuzenle.Owner = this;
            frmIsEmriEkleDuzenle.aktifKullanici = aktifKullanici;
            frmIsEmriEkleDuzenle.islemTipi = 0;
            frmIsEmriEkleDuzenle.frmIsEmirleri = this;
            frmIsEmriEkleDuzenle.ShowDialog();
        }

        private void btnSil_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(gridView1.DataRowCount > 0)
            if (MessageBox.Show(this,"Silmek İstediğinize Emin misiniz?","Sil",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                if (Convert.ToInt32(gridView1.GetFocusedRowCellValue(colHareketDurumu)) == 0)
                {
                    this.sorgular1.spIsemriSil(Convert.ToInt32(gridView1.GetFocusedRowCellValue(colID)));
                    this.tblIsEmirleriBindingSource.RemoveCurrent();
                }else
                    MessageBox.Show("Hareket Gören Emir Silinemez!");
            }
        }

        private void btnExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            fn.ps_disariAktar(gridView1,Fonksiyonlar.ciktiTuru.Excel);
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
    }
}