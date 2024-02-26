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
    public partial class frmTekliFormu1 : DevExpress.XtraEditors.XtraForm
    {
        public frmTekliFormu1()
        {
            InitializeComponent();
        }

        public NKUllanici aktifKullanici { get; set; }
        frmLookUpTeklifler frmLookUpTeklifler;

        private void frmTekliFormu1_Load(object sender, EventArgs e)
        {
            this.tblStokKartlariTableAdapter.Fill(this.dataset.tblStokKartlari);
            this.cariTanimlariTableAdapter.Fill(this.dataset.CariTanimlari);

            psSonEvrakNo(txtEvrakNo);

            txtMusteri.EditValue = null;
            txtUnvan1.Text = null;
            txtAdres1.Text = null;
            txtAdres2.Text = null;
            txtTel.Text = null;
            txtVergiDairesi.Text = null;
            txtVergiNo.Text = null;

            dtEvrakTaihi.DateTime = DateTime.Now;
            dtDurumTarihi.DateTime = DateTime.Now;
            txtHareketAciklamasi.Text = null;

            cmbDurum.SelectedIndex = 0;
            txtTeklifVeren.Text = aktifKullanici.AdiSoyadi;
        }

        private void psSonEvrakNo(TextEdit textEdit)
        {
            string sonEvrakNo = "000000";
            sorgular1.spSonEvrakNo((int)Enums.spSonEvrakNo_EvrakTipi.tblTeklifler, ref sonEvrakNo);

            textEdit.Text = sonEvrakNo;
        }

        public void psEvrakGetir(int evrakNo) {
            txtEvrakNo.Text = evrakNo.ToString().PadLeft(6,'0');

            this.tblStokKartlariTableAdapter.Fill(this.dataset.tblStokKartlari);
            this.cariTanimlariTableAdapter.Fill(this.dataset.CariTanimlari);

            if (this.tblTekliflerTableAdapter.evrakGetir(this.dataset.tblTeklifler,evrakNo)>0)
            {
                DataRow dr = this.dataset.tblTeklifler.FirstOrDefault();
                if (dr!= null)
                {
                    txtTeklifBasligi.Text = dr[colTeklifBasligi.FieldName].ToString();
                    dtEvrakTaihi.DateTime = (DateTime)dr[colEvrakTarihi.FieldName];
                    dtDurumTarihi.DateTime = (DateTime)dr[colDurumTarihi.FieldName];
                    cmbDurum.SelectedIndex = Convert.ToInt32(dr[colHareketDurumu.FieldName]);
                    txtHareketAciklamasi.Text = dr[colHareketAciklamasi.FieldName].ToString();

                    txtAciklama.Text = dr[colAciklama.FieldName].ToString();
                    DataRow drCari = this.dataset.CariTanimlari.Where(f => f.HesapKodu == dr[colMusteriKodu.FieldName].ToString()).FirstOrDefault();
                    if (drCari != null)
                    {
                        txtMusteri.EditValue = dr[colMusteriKodu.FieldName].ToString();
                        txtUnvan1.Text = drCari[colUnvan2.FieldName].ToString();
                        txtAdres1.Text = drCari[colAdres1.FieldName].ToString();
                        txtAdres2.Text = drCari[colAdres2.FieldName].ToString();
                        txtVergiDairesi.Text = drCari[colVergiDairesi.FieldName].ToString();
                        txtVergiNo.Text = drCari[colVergiHesapNo.FieldName].ToString();
                        txtTel.Text = drCari[colTelefon1.FieldName].ToString();
                    }
                }
            }else
                MessageBox.Show("Evrak Bulunamadı!");
        }

        private void txtMusteri_Closed(object sender, DevExpress.XtraEditors.Controls.ClosedEventArgs e)
        {
            GridLookUpEdit lkp = sender as GridLookUpEdit;
            DataRow dr = lkp.Properties.View.GetFocusedDataRow();

            if (dr != null)
            {
                txtUnvan1.Text = dr[colUnvan1.FieldName].ToString();
                txtAdres1.Text = dr[colAdres1.FieldName].ToString();
                txtAdres2.Text = dr[colAdres2.FieldName].ToString();
                txtTel.Text = dr[colTelefon1.FieldName].ToString();
                txtVergiDairesi.Text = dr[colVergiDairesi.FieldName].ToString();
                txtVergiNo.Text = dr[colVergiHesapNo.FieldName].ToString();
            }
            
        }

        private void lookUpMalAdi_Closed(object sender, DevExpress.XtraEditors.Controls.ClosedEventArgs e)
        {
            GridLookUpEdit lkp = sender as GridLookUpEdit;
            DataRow dr = lkp.Properties.View.GetFocusedDataRow();

            if (dr != null)
            {
                dr.BeginEdit();;
                gridView1.SetFocusedRowCellValue(colMalKodu,dr[colStokKodu.FieldName].ToString());
                dr.EndEdit();
            }

        }

        private void btnYenile_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.tblStokKartlariTableAdapter.Fill(this.dataset.tblStokKartlari);
            this.tblTekliflerTableAdapter.Fill(this.dataset.tblTeklifler);
            this.cariTanimlariTableAdapter.Fill(this.dataset.CariTanimlari);

            psSonEvrakNo(txtEvrakNo);
            
            txtMusteri.EditValue = null;
            txtUnvan1.Text = null;
            txtAdres1.Text = null;
            txtAdres2.Text = null;
            txtTel.Text = null;
            txtVergiDairesi.Text = null;
            txtVergiNo.Text = null;

            dtEvrakTaihi.DateTime = DateTime.Now;
            dtDurumTarihi.DateTime = DateTime.Now;
            txtHareketAciklamasi.Text = null;
            txtTeklifBasligi.Text = null;

            cmbDurum.SelectedIndex = 0;
            txtTeklifVeren.Text = aktifKullanici.AdiSoyadi;

            this.dataset.tblTeklifler.Clear();

        }

        private void btnKaydet_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtMusteri.EditValue.ToString()) || string.IsNullOrEmpty(txtTeklifVeren.Text))
                {
                    if (MessageBox.Show(this, "Kaydetmek İStediğinize Emin misiniz?", "Kaydet", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (gridView1.DataRowCount > 0)
                        {
                            foreach (DataRow dr in this.dataset.tblTeklifler.Rows)
                            {

                                this.sorgular1.spTeklifFormuEkle(Convert.ToInt32(txtEvrakNo.Text), dtEvrakTaihi.DateTime, txtMusteri.EditValue.ToString(), txtTeklifBasligi.Text, (byte)cmbDurum.SelectedIndex, cmbDurum.Text, dtDurumTarihi.DateTime, txtHareketAciklamasi.Text, txtAciklama.Text, dr[colMalKodu.FieldName].ToString(), dr[colMalAdi.FieldName].ToString(), dr[colKalemAciklamasi.FieldName].ToString(), dr[colDovizCinsi.FieldName].ToString(), Convert.ToInt32(dr[colDovizKuru.FieldName]), "ADET", Convert.ToDecimal(dr[colMiktar.FieldName]), Convert.ToDecimal(dr[colBirimFiyat.FieldName]), Convert.ToDecimal(dr[colTutar.FieldName]), txtTeklifVeren.Text, DateTime.Now);

                            }
                            MessageBox.Show("Teklif Kaydetildi!");
                        }
                        else
                            MessageBox.Show("Teklif Satırı Girmelisiniz!");
                    }
                }else
                    MessageBox.Show("{Müşte} , {Teklif Veren} Boş Geçilemez!");
                            
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
                if (MessageBox.Show(this,"Silmek İstediğinize Emin misiniz?","Sil",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
                {
                    var q = this.sorgular1.spTeklifFormuSil(Convert.ToInt32(txtEvrakNo.Text));
                    switch (Convert.ToInt32(q))
                    {       
                        case -1:
                            MessageBox.Show("Silinecek Kayıt Bulunamadı!");
                        break;

                        case 1:
                            MessageBox.Show("Kayıt Silinmiştir!");
                        break;


                        case 2:
                            MessageBox.Show("Teklif Formu Onaylandığı İçin Silinemez!");
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void rpsMiktar_Leave(object sender, EventArgs e)
        {
            this.Validate();
            DataRow dr = gridView1.GetFocusedDataRow();
            if (dr  != null)
            {
                dr.BeginEdit();
                dr[colTutar.FieldName] = Convert.ToDecimal(dr[colMiktar.FieldName]) * Convert.ToDecimal(dr[colBirimFiyat.FieldName]);
                dr.EndEdit();
            }
        }

        private void rpsBirimFiyat_Leave(object sender, EventArgs e)
        {
            this.Validate();
            DataRow dr = gridView1.GetFocusedDataRow();
            if (dr != null)
            {
                dr.BeginEdit();
                dr[colTutar.FieldName] = Convert.ToDecimal(dr[colMiktar.FieldName]) * Convert.ToDecimal(dr[colBirimFiyat.FieldName]);
                dr.EndEdit();
            }
        }

        private void cmbDurum_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDurum.SelectedIndex == 2 || cmbDurum.SelectedIndex == 3)
            {
                txtHareketAciklamasi.Visible = true;
            }
            else
            {
                txtHareketAciklamasi.Visible = false;
            }



            if (cmbDurum.SelectedIndex == 1 || cmbDurum.SelectedIndex == 2 || cmbDurum.SelectedIndex == 3)
            {
                lblDurumBaslik.Visible = true;
                dtDurumTarihi.Visible = true;
            }
            else
            {
                lblDurumBaslik.Visible = false;
                dtDurumTarihi.Visible = false;
            }
        }

        private void txtEvrakNo_Leave(object sender, EventArgs e)
        {
            txtEvrakNo.Text = txtEvrakNo.Text.PadLeft(6, '0');
        }

        private void txtEvrakNo_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                if (e.Button.Index == 1)
                {
                    frmLookUpTeklifler = new frmLookUpTeklifler();
                    frmLookUpTeklifler.Owner = this;
                    frmLookUpTeklifler.aktiKullanici = aktifKullanici;
                    frmLookUpTeklifler.frmTekliFormu1 = this;
                    frmLookUpTeklifler.ShowDialog();
                }
                else
                {
                    psEvrakGetir(Convert.ToInt32(txtEvrakNo.Text));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }         
        }

        private void btnYazdir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                report1.Load(Application.StartupPath + @"/RaporTasarimi/teklifFormu.frx");
                report1.SetParameterValue("musteriAdi", txtMusteri.Text);
                report1.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void frmTekliFormu1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.E)
            {
                try
                {
                    report1.Load(Application.StartupPath + @"/RaporTasarimi/teklifFormu.frx");
                    report1.Design();
                }
                catch (Exception)
                {
                }
            }
        }
    }
}