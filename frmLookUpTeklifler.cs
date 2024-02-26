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
    public partial class frmLookUpTeklifler : DevExpress.XtraEditors.XtraForm
    {
        public frmLookUpTeklifler()
        {
            InitializeComponent();
        }

        public NKUllanici aktiKullanici { get; set; }
        public frmTekliFormu1 frmTekliFormu1 { get; set; }

        private void frmLookUpTeklifler_Load(object sender, EventArgs e)
        {
            this.tblLookUpTeklifFormlariTableAdapter.Fill(this.dataset.tblLookUpTeklifFormlari,aktiKullanici.AdiSoyadi);
        }

        private void frmLookUpTeklifler_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (gridView1.DataRowCount > 0)
                {
                    frmTekliFormu1.psEvrakGetir(Convert.ToInt32(gridView1.GetFocusedRowCellValue(colEvrakNo.FieldName)));

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
                frmTekliFormu1.psEvrakGetir(Convert.ToInt32(gridView1.GetFocusedRowCellValue(colEvrakNo.FieldName)));

                this.Dispose();
                this.Close();
            }
        }
    }
}