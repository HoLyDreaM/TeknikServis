using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views;
using System.Linq;

namespace TeknikServis
{
    public partial class frmServisFormu : DevExpress.XtraEditors.XtraForm
    {
        public frmServisFormu()
        {
            InitializeComponent();
        }

        frmAcikBakimAnlasmalari_lookUp frmAcikBakimAnlasmalari_lookUp;
        frmArizaFormlari_lookUp frmArizaFormlari_lookUp;
        frmServisFomu_lookUp frmServisFomu_lookUp;
        frmLookUpIsEmirleri frmLookUpIsEmirleri;

        public NKUllanici aktifKullanici { get; set; }

        private void frmServisFormu_Load(object sender, EventArgs e)
        {
            cmbIslemTipi.SelectedIndex = 0;

            //Tanimlar
            this.tblStokKartlariTableAdapter.Fill(this.dataset.tblStokKartlari);
            this.cariTanimlariTableAdapter.Fill(this.dataset.CariTanimlari);
            this.tblKullanicilar_LookUpTableAdapter.Fill(this.dataset.tblKullanicilar_LookUp, "Teknik Servis");

            dtEvrakTaihi.DateTime = DateTime.Now;
            dtBaslangicTarihSaati.DateTime = DateTime.Now;
            dtBitisTarihSaati.DateTime = DateTime.Now;

            psSonEvrakNo(txtEvrakNo);
        }

        private void psSonEvrakNo(TextEdit textEdit) {
            string sonEvrakNo = "000000";
            sorgular1.spSonEvrakNo((int)Enums.spSonEvrakNo_EvrakTipi.tblServisFormlari,ref sonEvrakNo);
            
            textEdit.Text = sonEvrakNo;
        }
        public void psArizaFormuGetir(int evrakNo) {
            if (cmbIslemTipi.SelectedIndex == 2)
            {
                MessageBox.Show("İşlem Tipi : Bakım Anlaşması!");
            }
            else
            {
                if (this.tblArizaFormlariTableAdapter1.evrakGetir(this.dataset.tblArizaFormlari, evrakNo) == 0)
                {
                    pageArizaBilgileri.PageVisible = false;
                    MessageBox.Show("Evrak Bulunamadı!");
                }
                else
                {
                    pageArizaBilgileri.PageVisible = true;

                    DataRow dr = this.dataset.tblArizaFormlari.FirstOrDefault();

                    //txtTeslimAlan.EditValue = dr["TeslimAlan"].ToString();
                    txtArizaliUrunler.Text = dr["ArizaliUrunler"].ToString();
                    txtAriza.Text = dr["ArizaSebebi"].ToString();
                    //txtAksesuar.Text = dr["Aksesuar"].ToString();
                    txtNotlar.Text = dr["Notlar"].ToString();
                }
            }
        }
       
        public void psArizaFormuGetir1(string musteriKodu,int evrakNo) {          
            txtArizaFormNo.Text = evrakNo.ToString().PadLeft(6, '0');
            if (this.tblArizaFormlariTableAdapter1.evrakGetir(this.dataset.tblArizaFormlari, evrakNo) == 0)
            {
                pageArizaBilgileri.PageVisible = false;
                MessageBox.Show("Evrak Bulunamadı!");
            }
            else
            {
                cmbIslemTipi.SelectedIndex = 0;

                this.tblStokKartlariTableAdapter.Fill(this.dataset.tblStokKartlari);
                this.cariTanimlariTableAdapter.Fill(this.dataset.CariTanimlari);
                this.tblKullanicilar_LookUpTableAdapter.Fill(this.dataset.tblKullanicilar_LookUp, "Teknik Servis");

                dtEvrakTaihi.DateTime = DateTime.Now;
                dtBaslangicTarihSaati.DateTime = DateTime.Now;
                dtBitisTarihSaati.DateTime = DateTime.Now;

                psSonEvrakNo(txtEvrakNo);

                DataRow drCari = this.dataset.CariTanimlari.Where(f => f.IsHesapKoduNull() == false && f.HesapKodu == musteriKodu).FirstOrDefault();
                if (drCari != null)
                {
                    txtMusteri.EditValue = musteriKodu;
                    txtUnvan1.Text = drCari[colUnvan2.FieldName].ToString();
                    txtAdres1.Text = drCari[colAdres1.FieldName].ToString();
                    txtAdres2.Text = drCari[colAdres2.FieldName].ToString();
                    txtTel.Text = drCari[colTelefon1.FieldName].ToString();
                    txtVergiDairesi.Text = drCari[colVergiDairesi.FieldName].ToString();
                    txtVergiNo.Text = drCari[colVergiHesapNo.FieldName].ToString();

                }
                else
                    MessageBox.Show("Müşteri Kartı Bulunamadı!");


                pageArizaBilgileri.PageVisible = true;

                DataRow dr = this.dataset.tblArizaFormlari.FirstOrDefault();
                //txtTeslimAlan.EditValue = dr["TeslimAlan"].ToString();
                txtArizaliUrunler.Text = dr["ArizaliUrunler"].ToString();
                txtAriza.Text = dr["ArizaSebebi"].ToString();
                //txtAksesuar.Text = dr["Aksesuar"].ToString();
                txtNotlar.Text = dr["Notlar"].ToString();
            }
        }

        public void psSerisFormuGetir(int evrakNo) {
            if (this.tblServisFormlariTableAdapter.evrakGetir(this.dataset.tblServisFormlari, Convert.ToInt32(evrakNo)) == 0)
            {
                MessageBox.Show("Evrak Bulunamadı!");
            }
            else
            {
                DataRow dr = this.dataset.tblServisFormlari.FirstOrDefault();
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
                string arizaFormNo = dr["ArizaFormu"].ToString() == "0" ? "" : dr["ArizaFormu"].ToString();
                txtArizaFormNo.Text = arizaFormNo.PadLeft(6,'0');
                
                dtBaslangicTarihSaati.DateTime = (DateTime)dr["BaslangicTarihSaati"];
                dtBitisTarihSaati.DateTime = (DateTime)dr["BitisTarihiSaati"];
                txtServisNotu.Text = dr["ServisNotu"].ToString();
                txtNotlar.Text = dr["Notlar"].ToString();
                txtHizmetTutari.Text = dr["HizmetBedeli"].ToString();
                txtMalzemeTutari.Text = dr["MalzemeBedeli"].ToString();
                txtGenelTutar.Text = dr["ToplamTutar"].ToString();
                txtIsEmri.Text = (int)dr["IsEmriNo"]== 0 ? null : dr["IsEmriNo"].ToString().PadLeft(6,'0');
                cmbIslemTipi.SelectedIndex = Convert.ToInt32(dr["IslemTipi"]);

                this.tblServiseGidenPersonellerTableAdapter.formaGetir(this.dataset.tblServiseGidenPersoneller, evrakNo);
                this.tblKullanilanMalzemelerTableAdapter.formaGetir(this.dataset.tblKullanilanMalzemeler, evrakNo);

                if (!string.IsNullOrEmpty(arizaFormNo) && Convert.ToInt32(dr["IslemTipi"]) != 2)
                {
                    if (this.tblArizaFormlariTableAdapter1.evrakGetir(this.dataset.tblArizaFormlari, Convert.ToInt32(txtArizaFormNo.Text)) == 0)
                    {
                        pageArizaBilgileri.PageVisible = false;
                        MessageBox.Show("Arızalı Kabul Formu Bulunamadı!");
                    }
                    else
                    {
                        pageArizaBilgileri.PageVisible = true;

                        DataRow drArizali = this.dataset.tblArizaFormlari.FirstOrDefault();

                        //txtTeslimAlan.EditValue = dr["TeslimAlan"].ToString();
                        txtArizaliUrunler.Text = drArizali["ArizaliUrunler"].ToString();
                        txtAriza.Text = drArizali["ArizaSebebi"].ToString();
                        //txtAksesuar.Text = dr["Aksesuar"].ToString();
                        txtNotlar.Text = drArizali["Notlar"].ToString();
                    }
                }
                else
                    pageArizaBilgileri.PageVisible = false;

            }
        }

        public void psIsEmri(string musteriKodu,int evrakNo) {
            cmbIslemTipi.SelectedIndex = 0;

            //Tanimlar
            this.tblStokKartlariTableAdapter.Fill(this.dataset.tblStokKartlari);
            this.cariTanimlariTableAdapter.Fill(this.dataset.CariTanimlari);
            this.tblKullanicilar_LookUpTableAdapter.Fill(this.dataset.tblKullanicilar_LookUp, "Teknik Servis");

            dtEvrakTaihi.DateTime = DateTime.Now;
            dtBaslangicTarihSaati.DateTime = DateTime.Now;
            dtBitisTarihSaati.DateTime = DateTime.Now;

            psSonEvrakNo(txtEvrakNo);

            DataRow drCari = this.dataset.CariTanimlari.Where(f => f.IsHesapKoduNull() == false && f.HesapKodu == musteriKodu).FirstOrDefault();
            if (drCari != null)
            {
                txtMusteri.EditValue = musteriKodu;
                txtUnvan1.Text = drCari[colUnvan2.FieldName].ToString();
                txtAdres1.Text = drCari[colAdres1.FieldName].ToString();
                txtAdres2.Text = drCari[colAdres2.FieldName].ToString();
                txtTel.Text = drCari[colTelefon1.FieldName].ToString();
                txtVergiDairesi.Text = drCari[colVergiDairesi.FieldName].ToString();
                txtVergiNo.Text = drCari[colVergiHesapNo.FieldName].ToString();

            }
            else
                MessageBox.Show("Müşteri Kartı Bulunamadı!");

            txtIsEmri.Text = evrakNo.ToString().PadLeft(6,'0');
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

        private void btnTikerSil_Click(object sender, EventArgs e)
        {
            if(gwTekniker.DataRowCount > 0)
            if (MessageBox.Show(this,"Silmek İstediğinize Emin msiniz?","Sil",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                this.tblServiseGidenPersonellerBindingSource.RemoveCurrent();
            }
        }

        private void gwKullanilanMalzemeler_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Delete)
            {
                 if(gwKullanilanMalzemeler.DataRowCount>0)
                 if (MessageBox.Show(this,"Seçili Satırı Silmek İstiyor musunuz?","Sil",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
                 {
                     this.tblKullanilanMalzemelerBindingSource.RemoveCurrent();
                 }
            }
        }

        private void maskMiktar_Leave(object sender, EventArgs e)
        {
            DataRow dr = gwKullanilanMalzemeler.GetFocusedDataRow();
            if (dr != null)
            {
                dr[colTutar.FieldName] = (decimal)dr[colMiktar.FieldName] * (decimal)dr[colBirimFiyat.FieldName];
                this.Validate();
            }                  
        }

        private void maskBirimFiyat_Leave(object sender, EventArgs e)
        {
            DataRow dr = gwKullanilanMalzemeler.GetFocusedDataRow();
            if (dr != null)
            { 
                dr[colTutar.FieldName] = (decimal)dr[colMiktar.FieldName] * (decimal)dr[colBirimFiyat.FieldName];
                this.Validate();
            }           
        }

        private void txtHizmetTutari_EditValueChanged(object sender, EventArgs e)
        {
            txtGenelTutar.Text =  (Convert.ToDecimal(txtHizmetTutari.Text) + Convert.ToDecimal(txtMalzemeTutari.Text)).ToString();
        }

        private void txtMalzemeTutari_EditValueChanged(object sender, EventArgs e)
        {
            txtGenelTutar.Text = (Convert.ToDecimal(txtHizmetTutari.Text) + Convert.ToDecimal(txtMalzemeTutari.Text)).ToString();
        }

        private void gwKullanilanMalzemeler_BeforeLeaveRow(object sender, DevExpress.XtraGrid.Views.Base.RowAllowEventArgs e)
        {
            txtMalzemeTutari.Text = this.dataset.tblKullanilanMalzemeler.Sum(x => x.Tutar).ToString();
        }

        private void btnYenile_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.tblStokKartlariTableAdapter.Fill(this.dataset.tblStokKartlari);
            this.cariTanimlariTableAdapter.Fill(this.dataset.CariTanimlari);
            this.tblKullanicilar_LookUpTableAdapter.Fill(this.dataset.tblKullanicilar_LookUp, "Teknik Servis");

            dtBaslangicTarihSaati.DateTime = DateTime.Now;
            dtBitisTarihSaati.DateTime = DateTime.Now;

            psSonEvrakNo(txtEvrakNo);
            txtMusteri.EditValue = null;
            txtUnvan1.Text = null;
            txtAdres1.Text = null;
            txtAdres2.Text = null;
            txtTel.Text = null;
            txtVergiDairesi.Text = null;
            txtVergiNo.Text = null;
            txtIsEmri.Text = null;

            dtEvrakTaihi.DateTime = DateTime.Now;
            txtArizaFormNo.Text = null;

            this.dataset.tblServiseGidenPersoneller.Clear();
            this.dataset.tblKullanilanMalzemeler.Clear();

            txtServisNotu.Text = null;
            txtNotlar.Text = null;
            txtHizmetTutari.Text = "0";
            txtMalzemeTutari.Text = "0";
            txtGenelTutar.Text = "0";
        }
      
        private void btnKaydet_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtMusteri.Text) && !string.IsNullOrEmpty(txtEvrakNo.Text) && !string.IsNullOrEmpty(cmbIslemTipi.Text))
                {
                    if (gwTekniker.DataRowCount > 0)
                    {
                        if (MessageBox.Show(this, "Kaydetmek İstediğinize Emin misiniz?", "Kaydet", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            if (Convert.ToInt32(this.sorgular1.spMukerrerKotrol((int)Enums.spSonEvrakNo_EvrakTipi.tblServisFormlari,Convert.ToInt32(txtEvrakNo.Text))) == 0)
                            {
                                int? sonuc = 0;
                                this.sorgular1.spArizaIsemriFormKontrol(string.IsNullOrEmpty(txtArizaFormNo.Text) == true ? 0 : Convert.ToInt32(txtArizaFormNo.Text) , cmbIslemTipi.SelectedIndex == 2 ? 2 : 1 ,ref sonuc);

                                if (sonuc == 1) // Arıza Formu Kontrol
                                {
                                    int? sonuc1 = 0;
                                    this.sorgular1.spArizaIsemriFormKontrol(string.IsNullOrEmpty(txtIsEmri.Text) == true ? 0 : Convert.ToInt32(txtIsEmri.Text), 3, ref sonuc1);
                                   
                                    if (sonuc1 == 1) // İş emri Kontrol
                                    {
                                        sorgular1.spServisFormuEkle((byte)cmbIslemTipi.SelectedIndex, Convert.ToInt32(txtEvrakNo.Text), dtEvrakTaihi.DateTime, txtMusteri.EditValue.ToString(), dtBaslangicTarihSaati.DateTime, dtBitisTarihSaati.DateTime,
                                        txtServisNotu.Text, txtNotlar.Text, Convert.ToDecimal(txtHizmetTutari.Text), Convert.ToDecimal(txtMalzemeTutari.Text), Convert.ToDecimal(txtGenelTutar.Text), aktifKullanici.AdiSoyadi, aktifKullanici.AdiSoyadi, (string.IsNullOrEmpty(txtArizaFormNo.Text) == true ? 0 : Convert.ToInt32(txtArizaFormNo.Text)), (string.IsNullOrEmpty(txtIsEmri.Text) == true ? 0 : Convert.ToInt32(txtIsEmri.Text)));

                                        foreach (DataRow dr in this.dataset.tblServiseGidenPersoneller)
                                        {
                                            dr[colServisEvrakNo.FieldName] = Convert.ToInt32(txtEvrakNo.Text);
                                            this.tblServiseGidenPersonellerTableAdapter.Update(dr);
                                        }

                                        foreach (DataRow dr1 in this.dataset.tblKullanilanMalzemeler)
                                        {
                                            dr1[colServisEvrakNo.FieldName] = Convert.ToInt32(txtEvrakNo.Text);
                                            this.tblKullanilanMalzemelerTableAdapter.Update(dr1);
                                        }

                                        MessageBox.Show("Servis Formu Kaydetilmiştir!");
                                    }
                                    else
                                    {
                                        if (sonuc == -1) //Kayıt Bulunamadı!
                                            MessageBox.Show("{" + txtArizaFormNo.Text.PadLeft(6, '0') + "} İş Emri Bulunamadı!");
                                        else //Başka Forma Bağlı
                                            MessageBox.Show("{" + txtArizaFormNo.Text.PadLeft(6, '0') + "} İş Emri Başka Bir Servis Formunda Kullanılmış!");
                                    }
                                }
                                else
                                {
                                    if (sonuc == -1) //Kayıt Bulunamadı!
                                        MessageBox.Show("{"+txtArizaFormNo.Text.PadLeft(6,'0') +"} Arıza Formu Bulunamadı!");
                                    else //Başka Forma Bağlı
                                        MessageBox.Show("{" + txtArizaFormNo.Text.PadLeft(6, '0') + "} Arıza Formu Başka Bir Servis Formunda Kullanılmış!");
                                }
                                
                            }
                            else
                            {
                                MessageBox.Show("Mükerrer Kayıt!");
                            }

                        }
                        
                    }else
                        MessageBox.Show("En az bir {Tekniker} girilmesi zorunludur!");
                }
                else
                {
                    MessageBox.Show("{Müşteri Kodu} ,{Evrak No} , {İşlem Tipi}  Boş Bırakılamaz!");
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
                if (MessageBox.Show(this, "Silmek İstediğinize Emin misiniz?", "Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    var q = this.sorgular1.spServisFormuSil(Convert.ToInt32(txtEvrakNo.Text));
                    if ((int)q > 0)
                    {
                        DataTable tempPErsonel = new DataTable();
                        DataTable tempMalzeme = new DataTable();

                        tempPErsonel = this.dataset.tblServiseGidenPersoneller.Copy();
                        tempMalzeme = this.dataset.tblKullanilanMalzemeler.Copy();

                        this.dataset.tblServiseGidenPersoneller.Clear();
                        this.dataset.tblServiseGidenPersoneller.AcceptChanges();

                        this.dataset.tblKullanilanMalzemeler.Clear();
                        this.dataset.tblKullanilanMalzemeler.AcceptChanges();

                        foreach (DataRow dr in tempPErsonel.Rows)
                        {
                            DataRow dr1 = this.dataset.tblServiseGidenPersoneller.NewRow();
                            dr1[0] = dr[0];
                            dr1[1] = dr[1];
                            dr1[2] = dr[2];
                            dr1[3] = dr[3];
                            this.dataset.tblServiseGidenPersoneller.Rows.Add(dr1);
                        }

                        foreach (DataRow dr in tempMalzeme.Rows)
                        {
                            DataRow dr1 = this.dataset.tblKullanilanMalzemeler.NewRow();
                            dr1[0] = dr[0];
                            dr1[1] = dr[1];
                            dr1[2] = dr[2];
                            dr1[3] = dr[3];
                            dr1[4] = dr[4];
                            dr1[5] = dr[5];
                            dr1[6] = dr[6];
                            dr1[7] = dr[7];
                            this.dataset.tblKullanilanMalzemeler.Rows.Add(dr1);
                        }

                        MessageBox.Show("Servis Formu Silinmiştir!");
                    }else
                        MessageBox.Show("Silinecek Kayıt Bulunamadı!");
                   
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            
        }

        private void btnYazdir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string personeller = "";
            foreach (DataRow personel in this.dataset.tblServiseGidenPersoneller)
            {
                personeller += personel[colAdiSoyadi.FieldName].ToString() + ",";
            }

            personeller = personeller.Substring(0,personeller.Length -1);

            report1.Load(Application.StartupPath + @"/RaporTasarimi/servisFormu.frx");
            report1.SetParameterValue("unvan1", txtMusteri.Text);
            report1.SetParameterValue("unvan2", txtUnvan1.Text);
            report1.SetParameterValue("adres1", txtAdres1.Text);
            report1.SetParameterValue("adres2", txtAdres2.Text);
            report1.SetParameterValue("telefon", txtTel.Text);
            report1.SetParameterValue("vergiDairesi", txtVergiDairesi.Text);
            report1.SetParameterValue("vergiNo", txtVergiNo.Text);
            report1.SetParameterValue("personeller", personeller);
            report1.Show();
        }

        private void txtEvrakNo_Leave(object sender, EventArgs e)
        {
            txtEvrakNo.Text =  txtEvrakNo.Text.PadLeft(6,'0');
        }

        private void txtArizaFormNo_Leave(object sender, EventArgs e)
        {
            if (txtArizaFormNo.Text.Length > 0)
                txtArizaFormNo.Text = txtArizaFormNo.Text.PadLeft(6, '0');
        }

        private void txtEvrakNo_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                if (e.Button.Index == 0)
                {
                    psSerisFormuGetir(Convert.ToInt32(txtEvrakNo.Text));
                }

                if (e.Button.Index == 1)
                {
                    frmServisFomu_lookUp = new frmServisFomu_lookUp();
                    frmServisFomu_lookUp.Owner = this;
                    frmServisFomu_lookUp.frmServisFormu = this;
                    frmServisFomu_lookUp.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
           
        }

        private void repositoryItemGridLookUpEdit1_Closed(object sender, DevExpress.XtraEditors.Controls.ClosedEventArgs e)
        {
            GridLookUpEdit gv = sender as GridLookUpEdit;
            DataRow dr = gv.Properties.View.GetFocusedDataRow();

            if (dr != null)
            {
                
            }
        }

        private void gwTekniker_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (gwTekniker.DataRowCount > 0)
                if(MessageBox.Show(this,"Silmek İstediğinize Emin misiniz?","Sil",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes){               
                    this.tblServiseGidenPersonellerBindingSource.RemoveCurrent();
                }			
            }
        }

        private void txtArizaFormNo_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                if (e.Button.Index == 0)
                {
                    psArizaFormuGetir(Convert.ToInt32(txtArizaFormNo.Text));
                }


                if (e.Button.Index == 1)
                {
                    if (cmbIslemTipi.SelectedIndex == 2)//Periyodik Bakım
                    {
                        if (!string.IsNullOrEmpty(txtMusteri.EditValue.ToString()) && txtMusteri.EditValue.ToString().Length > 5)
                        {
                            frmAcikBakimAnlasmalari_lookUp = new frmAcikBakimAnlasmalari_lookUp();
                            frmAcikBakimAnlasmalari_lookUp.Owner = this;
                            frmAcikBakimAnlasmalari_lookUp.frmServisFormu = this;
                            frmAcikBakimAnlasmalari_lookUp.musteriKodu = txtMusteri.EditValue.ToString();
                            frmAcikBakimAnlasmalari_lookUp.ShowDialog();
                        }
                        else
                            MessageBox.Show("Müşteri Seçmelisiniz!");
                    }
                    else {
                            frmArizaFormlari_lookUp = new frmArizaFormlari_lookUp();
                            frmArizaFormlari_lookUp.Owner = this;
                            frmArizaFormlari_lookUp.frmServisFormu = this;
                            frmArizaFormlari_lookUp.islemTipi = 0;
                            frmArizaFormlari_lookUp.ShowDialog();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
           
        }

        private void cmbIslemTipi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbIslemTipi.SelectedIndex == 2)
                lblArizaVeBakimEvrakBaslik.Text = "BAKIM ANLAŞMASI";                
            else
                lblArizaVeBakimEvrakBaslik.Text = "ARIZA FORM NO";   
        }

        private void txtIsEmri_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            frmLookUpIsEmirleri = new frmLookUpIsEmirleri();
            frmLookUpIsEmirleri.Owner = this;
            frmLookUpIsEmirleri.aktifKullanici = aktifKullanici;
            frmLookUpIsEmirleri.frmServisFormu = this;
            frmLookUpIsEmirleri.ShowDialog();
        }

        private void frmServisFormu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.E)
            {
                if (MessageBox.Show(this,"Servis Formunu Düzenlemek İstediğinize Emin misiniz?","Servis Formu Düzenle",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
                {
                    report1.Load(Application.StartupPath + @"/RaporTasarimi/servisFormu.frx");
                    report1.Design();
                }
            }
        }
       
    }
}