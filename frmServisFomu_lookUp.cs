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
    public partial class frmServisFomu_lookUp : DevExpress.XtraEditors.XtraForm
    {
        public frmServisFomu_lookUp()
        {
            InitializeComponent();
        }

        public frmServisFormu frmServisFormu { get; set; }
        public NKUllanici aktifKullanici { get; set; }

        private void frmServisFomu_lookUp_Load(object sender, EventArgs e)
        {
            this.tblLookUpSeevisFormlariTableAdapter.Fill(this.dataset.tblLookUpSeevisFormlari);
            gridView1.BestFitColumns();

        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            if (gridView1.DataRowCount > 0)
            {
                frmServisFormu.txtEvrakNo.Text = gridView1.GetFocusedRowCellValue(colEvrakNo).ToString();
                frmServisFormu.psSerisFormuGetir(Convert.ToInt32(gridView1.GetFocusedRowCellValue(colEvrakNo)));
                
                this.Dispose();
                this.Close();
            }
        }

        private void gridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (gridView1.DataRowCount > 0)
                {
                    frmServisFormu.txtEvrakNo.Text = gridView1.GetFocusedRowCellValue(colEvrakNo).ToString();
                    frmServisFormu.psSerisFormuGetir(Convert.ToInt32(gridView1.GetFocusedRowCellValue(colEvrakNo)));

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
    }
}