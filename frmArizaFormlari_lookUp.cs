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
    public partial class frmArizaFormlari_lookUp : DevExpress.XtraEditors.XtraForm
    {
        public frmArizaFormlari_lookUp()
        {
            InitializeComponent();
        }

        public frmServisFormu frmServisFormu { get; set; }
        public frmArizaFormu frmArizaFormu { get; set; }

        public Int16 islemTipi { get; set; }


        private void frmArizaFormlari_lookUp_Load(object sender, EventArgs e)
        {
            if (islemTipi == 0)
            {
                this.tblLookUpArizaliUrunlerTableAdapter.Fill(this.dataset.tblLookUpArizaliUrunler);
                gridView1.BestFitColumns();
            }
            else
            {
                this.tblLookUpArizaliUrunlerTableAdapter.Fill(this.dataset.tblLookUpArizaliUrunler);
                gridView1.BestFitColumns();
            }
            

        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            if (gridView1.DataRowCount > 0)
            {
                if (islemTipi == 0)
                {
                    frmServisFormu.txtArizaFormNo.Text = gridView1.GetFocusedRowCellValue(colEvrakNo).ToString();
                    
                }
                else {
                    frmArizaFormu.txtEvrakNo.Text = gridView1.GetFocusedRowCellValue(colEvrakNo).ToString();
                    frmArizaFormu.spEvrakGetir(Convert.ToInt32(gridView1.GetFocusedRowCellValue(colEvrakNo)));
                }
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
                    if (islemTipi == 0)
                    {
                        frmServisFormu.txtArizaFormNo.Text = gridView1.GetFocusedRowCellValue(colEvrakNo).ToString();
                    
                    }
                    else
                    {
                        frmArizaFormu.txtEvrakNo.Text = gridView1.GetFocusedRowCellValue(colEvrakNo).ToString();
                        frmArizaFormu.spEvrakGetir(Convert.ToInt32(gridView1.GetFocusedRowCellValue(colEvrakNo)));
                    }
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