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
    public partial class frmGiris : DevExpress.XtraEditors.XtraForm
    {
        public frmGiris()
        {
            InitializeComponent();
        }

        iniOku.iniOku iniOku = new iniOku.iniOku(Application.StartupPath + "\\LoginSettings.eakin");
    

        frmAnaform frmAnaform;
        NKUllanici aktifKullanici;

        private void frmGiris_Load(object sender, EventArgs e)
        {
            try
            {
                txtServer.Text = iniOku.IniOku("Ayar", "Server");
                txtSirket.Text = iniOku.IniOku("Ayar", "Sirket");
            }
            catch
            {
                lblDurum.Text = "Hata : Bağlantı sağlanamadı...";
            }
            //txtKullanici.Text = "ea";
            //txtSifre.Text = "ea";

            //btnBaglan_Click(null, null);
        }

        private void btnBaglan_Click(object sender, EventArgs e)
        {
            try
            {
                //conCs.Close();
                //conCs.ConnectionString = "Data Source=" + txtServer.Text + ";Persist Security Info=True;Initial Catalog=YNS" + txtSirket.Text + ";User ID=YNS" + txtSirket.Text + ";Password=PSW" + txtSirket.Text;

                //Properties.Settings.Default["conLink"] = conCs.ConnectionString.ToString();
                //conCs.Open();

                conTS.Close();
                conTS.ConnectionString = "Data Source="+ txtServer.Text +";Initial Catalog=TeknikServis;Persist Security Info=True;User ID=sa;Password=1";          
                Properties.Settings.Default["conTS"] = conTS.ConnectionString.ToString();
                conTS.Open();

                if (this.spKullaniciGirisiTableAdapter1.kullaniciGirisi(this.dataset1.spKullaniciGirisi,txtKullanici.Text,txtSifre.Text,"") > 0)
                {
                    DataRow drKullanici = this.dataset1.spKullaniciGirisi.FirstOrDefault();

                    aktifKullanici = new NKUllanici();

                    aktifKullanici.ID = (int)drKullanici["ID"];
                    aktifKullanici.KullaniciAdi = drKullanici["KullaniciAdi"].ToString();
                    aktifKullanici.AdiSoyadi = drKullanici["AdiSoyadi"].ToString();
                    aktifKullanici.Departman = drKullanici["Departman"].ToString();
                    aktifKullanici.EMail = drKullanici["EMail"].ToString();
                    aktifKullanici.Tema = drKullanici["Tema"].ToString();
                    aktifKullanici.Sifre = drKullanici["Sifre"].ToString();

                    iniOku.IniYaz("Ayar", "Server", txtServer.Text);
                    iniOku.IniYaz("Ayar", "Sirket", txtSirket.Text);

                    frmAnaform = new frmAnaform();
                    Program.ac.MainForm = frmAnaform;

                    frmAnaform.aktifKullanici = aktifKullanici;
                    frmAnaform.LookAndFeelStyle.LookAndFeel.SetSkinStyle(aktifKullanici.Tema);
                    frmAnaform.lblTema.Text = "Tema : " + aktifKullanici.Tema;
                    frmAnaform.lblSirket.Text = txtSirket.Text;
                    frmAnaform.lblKullanici.Text = aktifKullanici.AdiSoyadi;
                    frmAnaform.Show();
                    this.Close();
                }
                else
                {
                    lblDurum.Text = "Hatalı Kullanıcı Girişi!";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}