using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.IO;

namespace TeknikServis
{
    public partial class frmTeklifFormu : DevExpress.XtraEditors.XtraForm
    {
        public frmTeklifFormu()
        {
            InitializeComponent();
        }

        string sablonYolu = Application.StartupPath + @"/DocSablonlari";
        private void frmTeklifFormu_Load(object sender, EventArgs e)
        {
            
            string[] dosyalar = Directory.GetFiles(sablonYolu);
            string dosya = "";

            if (dosyalar.Length > 0)
            {
                foreach (var item in dosyalar)
                {
                    FileInfo fi = new FileInfo(item);
                    dosya = fi.Name;
                    lblSablonlar.Items.Add(dosya);
                }
            }
        }

        private void lblSablonlar_DoubleClick(object sender, EventArgs e)
        {
            if (lblSablonlar.Items.Count > 0)
            {
                if (File.Exists(sablonYolu +"/"+ lblSablonlar.SelectedItem.ToString()))
                {
                    richEditControl1.LoadDocumentTemplate(sablonYolu + "/" + lblSablonlar.SelectedItem.ToString());
                    //richEditControl1.RtfText = richEditControl1.RtfText.ToString().Replace("{Tarih}", DateTime.Now.ToShortDateString());
                }else
                    MessageBox.Show("Dosya Bulunamadı!");
                                  
            }

        }
    }
}