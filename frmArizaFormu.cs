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
    public partial class frmArizaFormu : DevExpress.XtraEditors.XtraForm
    {
        public frmArizaFormu()
        {
            InitializeComponent();
        }

        public NKUllanici aktifKullanici { get; set; }
        frmArizaFormlari_lookUp frmArizaFormlari_lookUp;

     
        public void txtEvrakNo_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                if (e.Button.Index == 0)
                {
                    spEvrakGetir(Convert.ToInt32(txtEvrakNo.Text));
                }

                if (e.Button.Index == 1)
                {
                    frmArizaFormlari_lookUp = new frmArizaFormlari_lookUp();
                    frmArizaFormlari_lookUp.Owner = this;
                    frmArizaFormlari_lookUp.frmArizaFormu = this;
                    frmArizaFormlari_lookUp.islemTipi = 1;
                    frmArizaFormlari_lookUp.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }   
        }

        private void frmArizaFormu_Load(object sender, EventArgs e)
        {
            //Tanimlar
            this.cariTanimlariTableAdapter.Fill(this.dataset.CariTanimlari);
            this.tblKullanicilar_LookUpTableAdapter.Fill(this.dataset.tblKullanicilar_LookUp, "Teknik Servis");

            dtEvrakTaihi.DateTime = DateTime.Now;
            psSonEvrakNo(txtEvrakNo);

            lblDurumu.Text = "Açık";
            lblDurumu.BackColor = Color.LightGreen;
        }

        public void spEvrakGetir(int evrakNo)
        {
            if (this.tblArizaFormlariTableAdapter1.evrakGetir(this.dataset.tblArizaFormlari, evrakNo) == 0)
            {
                MessageBox.Show("Evrak Bulunamadı!");
            }
            else
            {
                this.cariTanimlariTableAdapter.Fill(this.dataset.CariTanimlari);
                this.tblKullanicilar_LookUpTableAdapter.Fill(this.dataset.tblKullanicilar_LookUp, "Teknik Servis");
                txtEvrakNo.Text = evrakNo.ToString().PadLeft(6,'0');

                DataRow dr = this.dataset.tblArizaFormlari.FirstOrDefault();
                txtMusteri.EditValue = dr["MusteriKodu"];

                DataRow drCari = this.dataset.CariTanimlari.Where(f => f.IsHesapKoduNull() == false && f.HesapKodu == dr["MusteriKodu"].ToString()).FirstOrDefault();
                if (drCari != null)
                {
                    txtUnvan1.Text = drCari[colUnvan2.FieldName].ToString();
                    txtAdres1.Text = drCari[colAdres1.FieldName].ToString();
                    txtAdres2.Text = drCari[colAdres2.FieldName].ToString();
                    txtTel.Text = drCari[colTelefon1.FieldName].ToString();
                    txtVergiDairesi.Text = drCari[colVergiDairesi.FieldName].ToString();
                    txtVergiNo.Text = drCari[colVergiHesapNo.FieldName].ToString();

                }
                else
                    MessageBox.Show("Müşteri Kartı Bulunamadı!");

                dtEvrakTaihi.DateTime = (DateTime)dr["EvrakTarihi"];
                txtTeslimAlan.EditValue = dr["TeslimAlan"].ToString();
                txtArizaliUrunler.Text = dr["ArizaliUrunler"].ToString();
                txtAriza.Text = dr["ArizaSebebi"].ToString();
                txtAksesuar.Text = dr["Aksesuar"].ToString();
                txtNotlar.Text = dr["Notlar"].ToString();

                if ((Boolean)dr["AcikMi"])
                {
                    lblDurumu.Text = "Açık";
                    lblDurumu.BackColor = Color.LightGreen;
                }
                else
                {
                    lblDurumu.Text = "Kapalı";
                    lblDurumu.BackColor = Color.Red;
                }


            }
        }

        private void psSonEvrakNo(TextEdit textEdit)
        {
            string sonEvrakNo = "000000";
            sorgular1.spSonEvrakNo((int)Enums.spSonEvrakNo_EvrakTipi.tblArizaFormlari, ref sonEvrakNo);

            textEdit.Text = sonEvrakNo;
        }

        private void btnYenile_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.cariTanimlariTableAdapter.Fill(this.dataset.CariTanimlari);
            this.tblKullanicilar_LookUpTableAdapter.Fill(this.dataset.tblKullanicilar_LookUp, "Teknik Servis");

            psSonEvrakNo(txtEvrakNo);
            txtMusteri.EditValue = null;
            txtUnvan1.Text = null;
            txtAdres1.Text = null;
            txtAdres2.Text = null;
            txtTel.Text = null;
            txtVergiDairesi.Text = null;
            txtVergiNo.Text = null;

            dtEvrakTaihi.DateTime = DateTime.Now;
            txtTeslimAlan.Text = null;

            this.dataset.tblServiseGidenPersoneller.Clear();
            this.dataset.tblKullanilanMalzemeler.Clear();

            txtArizaliUrunler.Text = null;
            txtAriza.Text = null;
            txtNotlar.Text = null;
            txtAksesuar.Text = null;

            lblDurumu.Text = "Açık";
            lblDurumu.BackColor = Color.LightGreen;
         
        }

        private void btnKaydet_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtMusteri.EditValue.ToString()) && !string.IsNullOrEmpty(txtEvrakNo.Text))
                {
                    if (MessageBox.Show(this, "Kaydetmek İstediğinize Emin misiniz?", "Kaydet", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (Convert.ToInt32(this.sorgular1.spMukerrerKotrol((int)Enums.spSonEvrakNo_EvrakTipi.tblArizaFormlari, Convert.ToInt32(txtEvrakNo.Text))) == 0)
                        {
                            sorgular1.spArizaFormuEkle(Convert.ToInt32(txtEvrakNo.Text), dtEvrakTaihi.DateTime, txtMusteri.EditValue.ToString(), txtTeslimAlan.EditValue.ToString(), txtArizaliUrunler.Text, txtAriza.Text, txtAksesuar.Text, txtNotlar.Text, true, aktifKullanici.AdiSoyadi, aktifKullanici.AdiSoyadi);
                            MessageBox.Show("Ariza Formu Eklenmiştir!");
                        }
                        else
                        {
                            MessageBox.Show("Mükerrer Kayıt!");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("{Müşteri Kodu} ,{Evrak No}  Boş Bırakılamaz!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void btnSil_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (MessageBox.Show(this,"Silmek İstediğinize emin misiniz?","Evrak Silme",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
                {
                    int? sonuc = null;
                    this.sorgular1.spArizaFormuSil(Convert.ToInt32(txtEvrakNo.Text), ref sonuc);

                    switch (sonuc)
                    {
                        case -1:
                            MessageBox.Show("Silinecek Kayıt Bulunamadı!");
                            break;

                        case 1:
                            MessageBox.Show("Kayıt Silinmiştir!");
                            break;

                        case 2:
                            MessageBox.Show("Bu Kayıt Teslim Formu İle Kapatıldığı İçin Silinemez!");
                            break;
                    }           
                }          
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }         
        }

        private void btnYazdir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            report1.Load(Application.StartupPath + @"/RaporTasarimi/arizaFormu.frx");
            report1.SetParameterValue("unvan1",txtMusteri.Text);
            report1.SetParameterValue("unvan2", txtUnvan1.Text);
            report1.SetParameterValue("adres1", txtAdres1.Text);
            report1.SetParameterValue("adres2", txtAdres2.Text);
            report1.SetParameterValue("telefon",txtTel.Text);
            report1.SetParameterValue("vergiDairesi", txtVergiDairesi.Text);
            report1.SetParameterValue("vergiNo", txtVergiNo.Text);
            report1.Show();
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

        private void txtEvrakNo_Leave(object sender, EventArgs e)
        {
            txtEvrakNo.Text = txtEvrakNo.Text.PadLeft(6, '0');
        }

        private void frmArizaFormu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.E)
            {
                if (MessageBox.Show(this, "Servis Formunu Düzenlemek İstediğinize Emin misiniz?", "Servis Formu Düzenle", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    report1.Load(Application.StartupPath + @"/RaporTasarimi/arizaFormu.frx");
                    report1.Design();
                }
            }
        }
    }
}