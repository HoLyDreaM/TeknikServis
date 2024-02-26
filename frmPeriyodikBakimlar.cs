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
    public partial class frmPeriyodikBakimlar : DevExpress.XtraEditors.XtraForm
    {
        public frmPeriyodikBakimlar()
        {
            InitializeComponent();
        }

        Fonksiyonlar fn = new Fonksiyonlar();
        public NKUllanici aktifKullanici { get; set; }
        frmPeriyodikBakimEkle frmPeriyodikBakimEkle;

        public void psYenile() {
            this.tblBakimAnlasmalari1TableAdapter.Fill(this.dataset.tblBakimAnlasmalari1);
            gridView1.BestFitColumns();
        }

        private void frmPeriyodikBakimlar_Load(object sender, EventArgs e)
        {
            psYenile();
        }

        private void btnYenile_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            psYenile();
        }

        private void btnEkle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmPeriyodikBakimEkle = new frmPeriyodikBakimEkle();
            frmPeriyodikBakimEkle.Owner = this;
            frmPeriyodikBakimEkle.aktifKullanici = aktifKullanici;
            frmPeriyodikBakimEkle.frmPeriyodikBakimlar = this;
            frmPeriyodikBakimEkle.islemTipi = 0;
            frmPeriyodikBakimEkle.ShowDialog();
        }

        private void btnDuzenle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (gridView1.DataRowCount > 0)
            {
                DataRow dr = gridView1.GetFocusedDataRow();

                NPeriyodikBakim periyodikBakim = new NPeriyodikBakim();
                periyodikBakim.ID = (int)dr[colID.FieldName];
                periyodikBakim.musteriKodu = dr[colMusteriKodu.FieldName].ToString();
                periyodikBakim.evrakNo = Convert.ToInt32(dr[colEvrakNo.FieldName]);
                periyodikBakim.evrakTarihi = (DateTime)dr[colEvrakTarihi.FieldName];
                periyodikBakim.baslangicTarihi = (DateTime)dr[colBaslangicTarih.FieldName];
                periyodikBakim.bitisTarihi = (DateTime)dr[colBitisTarihi.FieldName];
                periyodikBakim.periyotAraligi = Convert.ToInt32(dr[colPeriyotAraligi.FieldName]);
                periyodikBakim.bakimBilgisi = dr[colBakimBilgisi.FieldName].ToString();
                periyodikBakim.notlar = dr[colNotlar.FieldName].ToString();
                periyodikBakim.hareketDurumu = dr[colHareketDurumu.FieldName].ToString();

                frmPeriyodikBakimEkle = new frmPeriyodikBakimEkle();
                frmPeriyodikBakimEkle.Owner = this;
                frmPeriyodikBakimEkle.aktifKullanici = aktifKullanici;
                frmPeriyodikBakimEkle.frmPeriyodikBakimlar = this;
                frmPeriyodikBakimEkle.islemTipi = 1;
                frmPeriyodikBakimEkle.periyodikBakim = periyodikBakim;
                frmPeriyodikBakimEkle.ShowDialog(); 
            }else
                MessageBox.Show("Düzenlenecek Kayıt Bulunamadı!");
            
        }

        private void btnSil_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (gridView1.DataRowCount > 0)
            {
                if (MessageBox.Show(this, "Silmek İstediğinize Emin misiniz?", "Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int q = (int)this.sorgular1.spPeriyodikBakimAnlasmasiSil(Convert.ToInt32(gridView1.GetFocusedRowCellValue(colEvrakNo)));
                    if (q == 0)
                    {
                        MessageBox.Show("Bu bakım anlaşmasına ait kapalı hareketler olduğu için silinemez!");
                    }
                    else
                    {
                        MessageBox.Show("Bakım anlaşması silinmiştir!");
                        psYenile();
                    }                    
                }
            }else
                MessageBox.Show("Silinecek Kayıt Bulunamadı!");
           
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
    }
}