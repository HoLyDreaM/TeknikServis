using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Linq;

namespace TeknikServis
{
    public partial class frmPeriyodikBakimEkle : DevExpress.XtraEditors.XtraForm
    {
        public frmPeriyodikBakimEkle()
        {
            InitializeComponent();
        }

        public NKUllanici aktifKullanici { get; set; }
        public frmPeriyodikBakimlar frmPeriyodikBakimlar { get; set; }
        public int islemTipi { get; set; } // 0 => ekleme ; 1 = > Düzenleme   
        public int evrakNo { get; set; }
        public NPeriyodikBakim periyodikBakim { get; set; }

        private void psSonEvrakNo(TextEdit textEdit)
        {
            string sonEvrakNo = "000000";
            sorgular1.spSonEvrakNo((int)Enums.spSonEvrakNo_EvrakTipi.tblBakimAnlasmalari, ref sonEvrakNo);

            textEdit.Text = sonEvrakNo;
        }

        private void frmPeriyodikBakimEkle_Load(object sender, EventArgs e)
        {
            this.cariTanimlariTableAdapter.Fill(this.dataset.CariTanimlari);

            if (islemTipi == 0)
            {
                dtEvrakTarihi.DateTime = DateTime.Now;
                dtBitisTarihi.DateTime = DateTime.Now;
                dtBaslangicTarihi.DateTime = DateTime.Now;
                dtBaslangicTarihi.DateTime = DateTime.Now;
                psSonEvrakNo(txtEvrakNo);

                btnKaydet.Enabled = true;
            }
            else {
                txtEvrakNo.Text = periyodikBakim.evrakNo.ToString().PadLeft(6, '0');
                dtEvrakTarihi.DateTime = periyodikBakim.evrakTarihi;
                txtMusteri.EditValue = periyodikBakim.musteriKodu;
                dtBaslangicTarihi.DateTime = periyodikBakim.baslangicTarihi;
                dtBitisTarihi.DateTime = periyodikBakim.bitisTarihi;
                txtPeriyot.Text = periyodikBakim.periyotAraligi.ToString();
                txtBakimBilgisi.Text = periyodikBakim.bakimBilgisi;
                txtNotlar.Text = periyodikBakim.notlar;
                btnKaydet.Enabled = false;

                DataRow drCari = this.dataset.CariTanimlari.Where(f => !f.IsHesapKoduNull() && f.HesapKodu == periyodikBakim.musteriKodu.ToString()).FirstOrDefault();
                if (drCari != null)
                {
                    txtUnvan1.Text = drCari["Unvan1"].ToString();
                    txtAdres1.Text = drCari["Adres1"].ToString();
                    txtAdres2.Text = drCari["Adres2"].ToString();
                    txtTel.Text = drCari["Telefon1"].ToString();
                    txtVergiDairesi.Text = drCari["VergiDairesi"].ToString();
                    txtVergiNo.Text = drCari["VergiHesapNo"].ToString();
                }

                this.tblBakimAnlasmaDetayiTableAdapter1.evrakGetir(this.dataset.tblBakimAnlasmaDetayi,periyodikBakim.evrakNo);
                gridView1.BestFitColumns();
            }
            
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            this.sorgular1.spBakimAnlasmasiEkle(Convert.ToInt32(txtEvrakNo.Text), dtEvrakTarihi.DateTime, txtMusteri.EditValue.ToString(), dtBaslangicTarihi.DateTime, dtBitisTarihi.DateTime, Convert.ToInt32(txtPeriyot.Text), txtBakimBilgisi.Text, txtNotlar.Text, "ea");
            this.tblBakimAnlasmaDetayiTableAdapter1.evrakGetir(this.dataset.tblBakimAnlasmaDetayi, Convert.ToInt32(txtEvrakNo.Text));
            gwPeriyotlar.BestFitColumns();

            frmPeriyodikBakimlar.psYenile();
            this.Dispose();
            this.Close();
        }

        private void btnOlustur_Click(object sender, EventArgs e)
        {
            this.sorgular1.spBakimAnlasmasiEkle(Convert.ToInt32(txtEvrakNo.Text), dtEvrakTarihi.DateTime, txtMusteri.EditValue.ToString(), dtBaslangicTarihi.DateTime, dtBitisTarihi.DateTime, Convert.ToInt32(txtPeriyot.Text), txtBakimBilgisi.Text, txtNotlar.Text, "ea");
            this.tblBakimAnlasmaDetayiTableAdapter1.evrakGetir(this.dataset.tblBakimAnlasmaDetayi,Convert.ToInt32(txtEvrakNo.Text));
            gwPeriyotlar.BestFitColumns();

           
        }

        private void txtMusteri_Closed(object sender, DevExpress.XtraEditors.Controls.ClosedEventArgs e)
        {
            GridLookUpEdit gv = sender as GridLookUpEdit;
            DataRow dr = gv.Properties.View.GetFocusedDataRow();

            if (dr != null)
            {
                txtUnvan1.Text = dr[colUnvan2.FieldName].ToString();
                txtAdres1.Text = dr[colAdres1.FieldName].ToString();
                txtAdres2.Text = dr[colAdres2.FieldName].ToString();
                txtVergiDairesi.Text = dr[colVergiDairesi.FieldName].ToString();
                txtVergiNo.Text = dr[colVergiHesapNo.FieldName].ToString();
                txtTel.Text = dr[colTelefon1.FieldName].ToString();
            }
        }

        private void btnVazgec_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
        }

        private void btnSozlesmeyiKapat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this,"Bu işlem bakım sözleşmesini sonlandıracak.Hareketleri kapatacaktır.","Sözleşmeyi Sonlandır!",MessageBoxButtons.YesNo,MessageBoxIcon.Warning)==DialogResult.Yes)
            {
                this.sorgular1.psPeriyodikBakimSonlandir(periyodikBakim.evrakNo);
                frmPeriyodikBakimlar.psYenile();

                this.Dispose();
                this.Close();
            }
        }
    }
}