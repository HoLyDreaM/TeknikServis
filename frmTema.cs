using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.LookAndFeel;
using DevExpress.Skins;

namespace TeknikServis
{
    public partial class frmTema : DevExpress.XtraEditors.XtraForm
    {
        public frmTema()
        {
            InitializeComponent();
        }
        public NKUllanici aktifKullanici { get; set; }
        public frmAnaform frmanaform { get; set; }

        private void frmTema_Load(object sender, EventArgs e)
        {
            SkinContainerCollection skins = SkinManager.Default.Skins;
            for (int i = 0; i < skins.Count; i++)
            {
                this.listBoxControl1.Items.Add(skins[i].SkinName);
            }

            listBoxControl1.SelectedItem = frmanaform.aktifKullanici.Tema;
        }

        private void listBoxControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            frmanaform.LookAndFeelStyle.LookAndFeel.SetSkinStyle(listBoxControl1.SelectedItem.ToString());
        }

        private void btnVazgec_Click(object sender, EventArgs e)
        {
            frmanaform.LookAndFeelStyle.LookAndFeel.SetSkinStyle(frmanaform.aktifKullanici.Tema);
            this.Dispose();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                frmanaform.lblTema.Text = "Tema : " + listBoxControl1.SelectedItem.ToString();
                frmanaform.aktifKullanici.Tema = listBoxControl1.SelectedItem.ToString();
                this.sorgular1.uTemaGuncelle(listBoxControl1.SelectedItem.ToString(), frmanaform.aktifKullanici.ID);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            this.Dispose();
        }

        private void frmTema_FormClosed(object sender, FormClosedEventArgs e)
        {
            btnVazgec_Click(null, null);
        }
    }
}