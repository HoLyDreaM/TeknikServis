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
    public partial class frmAnaform : DevExpress.XtraEditors.XtraForm
    {
        public frmAnaform()
        {
            InitializeComponent();
        }

        public NKUllanici aktifKullanici { get; set; }

        frmServisFormu frmServisFormu;
        private void frmServisFormu_Ac() {
            if (frmServisFormu == null || frmServisFormu.IsDisposed)
            {
                frmServisFormu = new frmServisFormu();
                frmServisFormu.Owner = this;
                frmServisFormu.MdiParent = this;
                frmServisFormu.aktifKullanici = aktifKullanici;
                frmServisFormu.Show();
            }
            else
                frmServisFormu.Activate();
        }

        frmCariTanimlari frmCariTanimlari;
        private void frmCariTanimlari_Ac()
        {
            if (frmCariTanimlari == null || frmCariTanimlari.IsDisposed)
            {
                frmCariTanimlari = new frmCariTanimlari();
                frmCariTanimlari.Owner = this;
                frmCariTanimlari.MdiParent = this;
                frmCariTanimlari.Show();
            }
            else
                frmCariTanimlari.Activate();
        }

        frmKullanici frmKullanici;
        private void frmKullanici_Ac()
        {
            if (frmKullanici == null || frmKullanici.IsDisposed)
            {
                frmKullanici = new frmKullanici();
                frmKullanici.Owner = this;
                frmKullanici.MdiParent = this;
                frmKullanici.Show();
            }
            else
                frmKullanici.Activate();
        }

        frmStokKartlari frmStokKartlari;
        private void frmStokKartlari_Ac()
        {
            if (frmStokKartlari == null || frmStokKartlari.IsDisposed)
            {
                frmStokKartlari = new frmStokKartlari();
                frmStokKartlari.Owner = this;
                frmStokKartlari.MdiParent = this;
                frmStokKartlari.Show();
            }
            else
                frmStokKartlari.Activate();
        }

        frmKullaniciDuzenleme frmKullaniciDuzenleme;
        private void frmKullaniciDuzenleme_Ac()
        {
            if (frmKullaniciDuzenleme == null || frmKullaniciDuzenleme.IsDisposed)
            {
                frmKullaniciDuzenleme = new frmKullaniciDuzenleme();
                frmKullaniciDuzenleme.Owner = this;
                frmKullaniciDuzenleme.aktifKullanici = aktifKullanici;
                frmKullaniciDuzenleme.ShowDialog();
            }
            else
                frmKullaniciDuzenleme.Activate();
        }

        frmTema frmTema;
        private void frmTema_Ac()
        {
            if (frmTema == null || frmTema.IsDisposed)
            {
                frmTema = new frmTema();
                frmTema.Owner = this;
                frmTema.aktifKullanici = aktifKullanici;
                frmTema.frmanaform = this;
                frmTema.ShowDialog();
            }
            else
                frmTema.Activate();
        }

        frmTeklifFormu frmTeklifFormu;
        private void frmTeklifFormu_Ac()
        {
            if (frmTeklifFormu == null || frmTeklifFormu.IsDisposed)
            {
                frmTeklifFormu = new frmTeklifFormu();
                frmTeklifFormu.Owner = this;
                frmTeklifFormu.MdiParent = this;
                frmTeklifFormu.Show();
            }
            else
                frmTeklifFormu.Activate();
        }

        frmArizaFormu frmArizaFormu;
        private void frmArizaFormu_Ac()
        {
            if (frmArizaFormu == null || frmArizaFormu.IsDisposed)
            {
                frmArizaFormu = new frmArizaFormu();
                frmArizaFormu.Owner = this;
                frmArizaFormu.MdiParent = this;
                frmArizaFormu.aktifKullanici = aktifKullanici;
                frmArizaFormu.Show();
            }
            else
                frmArizaFormu.Activate();
        }

        frmPeriyodikBakimlar frmPeriyodikBakimlar;
        private void frmPeriyodikBakimlar_Ac()
        {
            if (frmPeriyodikBakimlar == null || frmPeriyodikBakimlar.IsDisposed)
            {
                frmPeriyodikBakimlar = new frmPeriyodikBakimlar();
                frmPeriyodikBakimlar.Owner = this;
                frmPeriyodikBakimlar.MdiParent = this;
                frmPeriyodikBakimlar.Show();
            }
            else
                frmPeriyodikBakimlar.Activate();
        }

        frmPeriyodikBakimlar1 frmPeriyodikBakimlar1;
        private void frmPeriyodikBakimlar1_Ac()
        {
            if (frmPeriyodikBakimlar1 == null || frmPeriyodikBakimlar1.IsDisposed)
            {
                frmPeriyodikBakimlar1 = new frmPeriyodikBakimlar1();
                frmPeriyodikBakimlar1.Owner = this;
                frmPeriyodikBakimlar1.MdiParent = this;
                frmPeriyodikBakimlar1.Show();
            }
            else
                frmPeriyodikBakimlar1.Activate();
        }

        frmIsEmirleri frmIsEmirleri;
        private void frmIsEmirleri_Ac()
        {
            if (frmIsEmirleri == null || frmIsEmirleri.IsDisposed)
            {
                frmIsEmirleri = new frmIsEmirleri();
                frmIsEmirleri.Owner = this;
                frmIsEmirleri.aktifKullanici = aktifKullanici;
                frmIsEmirleri.MdiParent = this;
                frmIsEmirleri.Show();
            }
            else
                frmIsEmirleri.Activate();
        }

        frmGorevler frmGorevler;
        private void frmGorevler_Ac()
        {
            if (frmGorevler == null || frmGorevler.IsDisposed)
            {
                frmGorevler = new frmGorevler();
                frmGorevler.Owner = this;
                frmGorevler.aktifKullanici = aktifKullanici;
                frmGorevler.MdiParent = this;
                frmGorevler.frmAnafrm = this;
                frmGorevler.Show();
            }
            else
                frmGorevler.Activate();
        }

        frmTekliFormu1 frmTekliFormu1;
        private void frmTekliFormu1_Ac()
        {
            if (frmTekliFormu1 == null || frmTekliFormu1.IsDisposed)
            {
                frmTekliFormu1 = new frmTekliFormu1();
                frmTekliFormu1.Owner = this;
                frmTekliFormu1.MdiParent = this;
                frmTekliFormu1.aktifKullanici = aktifKullanici;
                frmTekliFormu1.Show();
            }
            else
                frmTekliFormu1.Activate();
        }

        frmTeklifDurumlari frmTeklifDurumlari;
        private void frmTeklifDurumlari_Ac()
        {
            if (frmTeklifDurumlari == null || frmTeklifDurumlari.IsDisposed)
            {
                frmTeklifDurumlari = new frmTeklifDurumlari();
                frmTeklifDurumlari.Owner = this;
                frmTeklifDurumlari.MdiParent = this;
                frmTeklifDurumlari.aktifKullanici = aktifKullanici;
                frmTeklifDurumlari.Show();
            }
            else
                frmTeklifDurumlari.Activate();
        }

        frmArizaFormlari frmArizaFormlari;
        private void frmArizaFormlari_Ac() {
            if (frmArizaFormlari == null || frmArizaFormlari.IsDisposed)
            {
                frmArizaFormlari = new frmArizaFormlari();
                frmArizaFormlari.Owner = this;
                frmArizaFormlari.MdiParent = this;
                frmArizaFormlari.Show();
            }
            else
                frmArizaFormlari.Activate();
        }

        frmKesilenServisFormlari frmKesilenServisFormlari;
        private void frmKesilenServisFormlari_Ac()
        {
            if (frmKesilenServisFormlari == null || frmKesilenServisFormlari.IsDisposed)
            {
                frmKesilenServisFormlari = new frmKesilenServisFormlari();
                frmKesilenServisFormlari.Owner = this;
                frmKesilenServisFormlari.MdiParent = this;
                frmKesilenServisFormlari.Show();
            }
            else
                frmKesilenServisFormlari.Activate();
        }

        private void frmAnaform_Load(object sender, EventArgs e)
        {
            frmGorevler_Ac();
        }
        private void timerTarih_Tick(object sender, EventArgs e)
        {
            lblTarih.Text = DateTime.Now.ToString();
        }

        private void btnServisFormu_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmServisFormu_Ac();
        }

        private void btnCariTanimlari_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmCariTanimlari_Ac();
        }

        private void btmKullaniciTanimlari_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmKullanici_Ac();
        }

        private void btnStokKartlari_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmStokKartlari_Ac();
        }

        private void lblKullanici_Click(object sender, EventArgs e)
        {
            frmKullaniciDuzenleme_Ac();
        }

        private void lblTema_Click(object sender, EventArgs e)
        {
            frmTema_Ac();
        }

        private void btnTeklifFormu_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {

            frmTekliFormu1_Ac();
            //frmTeklifFormu_Ac();
        }

        private void btnArizaFormu_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmArizaFormu_Ac();
        }

        private void navBarItem1_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmPeriyodikBakimlar_Ac();
        }

        private void btnPeriyodikBakimlar1_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmPeriyodikBakimlar1_Ac();
        }

        private void btnIsEmri_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmIsEmirleri_Ac();
        }

        private void btnGorevler_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmGorevler_Ac();
        }

        private void btnTeklifDurumlari_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmTeklifDurumlari_Ac();
        }

        private void frmAnaform_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show(this, "Çıkmak İstediğiniz?", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else
                e.Cancel = true;
        }

        private void btnArizFormlari_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmArizaFormlari_Ac();
        }

        private void btnKesilenServisFormlari_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmKesilenServisFormlari_Ac();
        }

       
    }
}