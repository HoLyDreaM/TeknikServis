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
    public partial class frmPeriyodikBakimlar1 : DevExpress.XtraEditors.XtraForm
    {
        public frmPeriyodikBakimlar1()
        {
            InitializeComponent();
        }

        private void frmPeriyodikBakimlar1_Load(object sender, EventArgs e)
        {
            this.tblBakimAnlasmasi_DetayTableAdapter.Fill(this.dataset.tblBakimAnlasmasi_Detay);
            gridView1.BestFitColumns();
        }

        private void btnYenile_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.tblBakimAnlasmasi_DetayTableAdapter.Fill(this.dataset.tblBakimAnlasmasi_Detay);
            gridView1.BestFitColumns();
        }
    }
}