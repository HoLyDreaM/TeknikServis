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
    public partial class frmIsEmriEkleDuzenle : DevExpress.XtraEditors.XtraForm
    {
        public NKUllanici aktifKullanici { get; set; }
        public int islemTipi { get; set; } // 0 => ekleme ; 1 = > Düzenleme 
        public NIsEmri isEmri { get; set; }
        public frmIsEmirleri frmIsEmirleri { get; set; }

        public frmIsEmriEkleDuzenle()
        {
            InitializeComponent();
        }

       
        private void frmIsEmriEkleDuzenle_Load(object sender, EventArgs e)
        {
            this.cariTanimlariTableAdapter.Fill(this.dataset.CariTanimlari);
            this.tblKullanicilar_LookUpTableAdapter.Fill(this.dataset.tblKullanicilar_LookUp,"Teknik Servis");

            this.cariTanimlariTableAdapter.Fill(this.dataset.CariTanimlari);

            if (islemTipi == 0)
            {
                dtTarih.DateTime = DateTime.Now;
            }
            else
            {
                txtEvrakNo.Text = isEmri.evrakNo.ToString().PadLeft(6, '0');
                dtTarih.DateTime = isEmri.tarih;
                txtMusteri.EditValue = isEmri.musteriKodu;
                txtPersonel.Text = isEmri.personel;
                txtSikayet.Text = isEmri.sikayet;

                DataRow drCari = this.dataset.CariTanimlari.Where(f => !f.IsHesapKoduNull() && f.HesapKodu == isEmri.musteriKodu.ToString()).FirstOrDefault();
                if (drCari != null)
                {
                    txtUnvan1.Text = drCari["Unvan1"].ToString();
                    txtAdres1.Text = drCari["Adres1"].ToString();
                    txtAdres2.Text = drCari["Adres2"].ToString();
                    txtTel.Text = drCari["Telefon1"].ToString();
                    txtVergiDairesi.Text = drCari["VergiDairesi"].ToString();
                    txtVergiNo.Text = drCari["VergiHesapNo"].ToString();
                }

            }
            
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtMusteri.EditValue.ToString()) || !string.IsNullOrEmpty(txtPersonel.Text) || !string.IsNullOrEmpty(txtSikayet.Text))
            {
                if (MessageBox.Show(this, "Kaydetmek İstediğinize Emin misiniz?", "Kaydet", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (isEmri == null)
                    {
                        this.sorgular1.spIsEmriEkle(txtMusteri.EditValue.ToString(), dtTarih.DateTime, txtPersonel.Text, txtSikayet.Text, aktifKullanici.AdiSoyadi, DateTime.Now);
                      
                        this.Dispose();
                        this.Close();
                    }
                    else
                    {
                        this.sorgular1.spIsemriDuzenle(txtMusteri.EditValue.ToString(), dtTarih.DateTime, txtPersonel.Text, txtSikayet.Text, aktifKullanici.AdiSoyadi, DateTime.Now,isEmri.ID);
                        
                        
                        this.Dispose();
                        this.Close();
                    }
                    frmIsEmirleri.psYenile();
                }
            }
            else { 
                MessageBox.Show("{Müşteri Kodu} , {Personel} , {Şikayet}  Boş Geçilemez!");
            }
           
        }

        private void btnVazgec_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
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
    }
}