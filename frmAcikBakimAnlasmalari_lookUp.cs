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
    public partial class frmAcikBakimAnlasmalari_lookUp : DevExpress.XtraEditors.XtraForm
    {
        public frmAcikBakimAnlasmalari_lookUp()
        {
            InitializeComponent();
        }

        public frmServisFormu frmServisFormu { get; set; }
        public string musteriKodu { get; set; }

        private void frmAcikBakimAnlasmalari_lookUp_Load(object sender, EventArgs e)
        {
            this.tblLookUpAcikBakimAnlasmalariTableAdapter.Fill(this.dataset.tblLookUpAcikBakimAnlasmalari, musteriKodu);
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            if (gridView1.DataRowCount > 0)
            {
                frmServisFormu.txtArizaFormNo.Text = gridView1.GetFocusedRowCellValue(colDetayNo).ToString().PadLeft(6,'0');
                this.Dispose();
                this.Close();
            }
        }

        private void gridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            if (gridView1.DataRowCount > 0)
            {
                frmServisFormu.txtArizaFormNo.Text = gridView1.GetFocusedRowCellValue(colDetayNo).ToString().PadLeft(6, '0');
                this.Dispose();
                this.Close();
            }


            if (e.KeyCode == Keys.Escape)
            {
                this.Dispose();
                this.Close();
            }
        }
    }
}