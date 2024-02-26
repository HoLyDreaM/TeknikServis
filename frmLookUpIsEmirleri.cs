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
    public partial class frmLookUpIsEmirleri : DevExpress.XtraEditors.XtraForm
    {

        public frmLookUpIsEmirleri()
        {
            InitializeComponent();
        }

        public NKUllanici aktifKullanici { get; set; }
        public frmServisFormu frmServisFormu { get; set; }

        private void frmLookUpIsEmirleri_Load(object sender, EventArgs e)
        {
            this.tblGorev_PersonelGorevleriTableAdapter.Fill(this.dataset.tblGorev_PersonelGorevleri,aktifKullanici.AdiSoyadi);
            gridView1.BestFitColumns();
        }

        private void frmLookUpIsEmirleri_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (gridView1.DataRowCount > 0)
                {
                    frmServisFormu.psIsEmri(gridView1.GetFocusedRowCellValue(colMusteriKodu).ToString(), Convert.ToInt32(gridView1.GetFocusedRowCellValue(colEvrakNo)));

                    this.Dispose();
                    this.Close();  
                }             
            }


            if (e.KeyCode == Keys.Escape)
            {
                this.Dispose();
                this.Close();
            }
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            if (gridView1.DataRowCount > 0)
            {
                frmServisFormu.psIsEmri(gridView1.GetFocusedRowCellValue(colMusteriKodu).ToString(), Convert.ToInt32(gridView1.GetFocusedRowCellValue(colEvrakNo)));

                this.Dispose();
                this.Close();
            }
        }
    }
}