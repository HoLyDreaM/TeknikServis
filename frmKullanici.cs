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
    public partial class frmKullanici : DevExpress.XtraEditors.XtraForm
    {
        public frmKullanici()
        {
            InitializeComponent();
        }

        private void frmKullanici_Load(object sender, EventArgs e)
        {
            this.tblKullanicilarTableAdapter.Fill(this.dataset.tblKullanicilar);
            gridView1.BestFitColumns();

        }

        private void btnYenile_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.tblKullanicilarTableAdapter.Fill(this.dataset.tblKullanicilar);
            gridView1.BestFitColumns();
        }

        private void btnSil_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (gridView1.DataRowCount > 0)
            {
                if (MessageBox.Show(this,"Silmek İsdeiğinize Emin misiniz?","Kayıt Sil",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
                {
                    this.tblKullanicilarBindingSource.RemoveCurrent();
                    this.tblKullanicilarTableAdapter.Update(this.dataset.tblKullanicilar);
                }
            }else
                MessageBox.Show("Silinecek Kayıt Bulunamadı!");
        }

        private void gridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (gridView1.FocusedColumn.VisibleIndex == gridView1.VisibleColumns.Count - 1)
                {
                    this.Validate();

                    DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
                    if (dr != null && dr.RowState != DataRowState.Unchanged)
                    {
                        if (MessageBox.Show(this, "Değişikleri Onaylıyormusunuz?", "Değişiklik", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            tblKullanicilarTableAdapter.Update(dr);

                            gridView1.MoveNext();
                            this.gridView1.FocusedColumn = this.gridView1.VisibleColumns[0];
                        }
                        else
                        {
                            this.tblKullanicilarTableAdapter.Fill(this.dataset.tblKullanicilar);
                        }
                    }
                    else
                    {
                        gridView1.MoveNext();
                        this.gridView1.FocusedColumn = this.gridView1.VisibleColumns[0];
                    }
                        
                }
            }
        }
    }
}