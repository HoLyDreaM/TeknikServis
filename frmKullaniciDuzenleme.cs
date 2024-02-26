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
    public partial class frmKullaniciDuzenleme : DevExpress.XtraEditors.XtraForm
    {
        public frmKullaniciDuzenleme()
        {
            InitializeComponent();
        }

        public NKUllanici aktifKullanici { get; set; }

        private void frmKullaniciDuzenleme_Load(object sender, EventArgs e)
        {
            txtKullaniciAdi.Text = aktifKullanici.KullaniciAdi;
            txtAdiSoyadi.Text = aktifKullanici.AdiSoyadi;
            txtSifre.Text = aktifKullanici.Sifre;
            txtEmail.Text = aktifKullanici.EMail;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtAdiSoyadi.Text) || !string.IsNullOrEmpty(txtSifre.Text))
            {
                if (MessageBox.Show(this,"Kaydetmek İstediğinize Emin misiniz?","Kaydet",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
                {
                    if (sorgular1.uKullaniciGuncelle(txtKullaniciAdi.Text,txtAdiSoyadi.Text,txtSifre.Text,txtEmail.Text,aktifKullanici.ID) == 1)
                    {
                        aktifKullanici.Sifre = txtSifre.Text;
                        aktifKullanici.AdiSoyadi = txtAdiSoyadi.Text;
                        aktifKullanici.EMail = txtEmail.Text;

                        MessageBox.Show("Kullanıcı Güncellenmiştir!");
                    }else
                        MessageBox.Show("Güncelleme İşlemi Başarısız!");

                    this.Dispose();
                    this.Close();
                }
            
            }else
                MessageBox.Show("{Adi Soyadi} , {Şifre} Boş Bırakılamaz!");
        }

        private void btnVazgec_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
        }
    }
}