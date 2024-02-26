namespace TeknikServis
{
    partial class frmArizaFormlari_lookUp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.tblLookUpArizaliUrunlerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataset = new TeknikServis.Dataset();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colEvrakNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEvrakTarihi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMusteriKodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMusteriAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTeslimAlan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tblLookUpArizaliUrunlerTableAdapter = new TeknikServis.DatasetTableAdapters.tblLookUpArizaliUrunlerTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblLookUpArizaliUrunlerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.tblLookUpArizaliUrunlerBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(480, 482);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.DoubleClick += new System.EventHandler(this.gridControl1_DoubleClick);
            // 
            // tblLookUpArizaliUrunlerBindingSource
            // 
            this.tblLookUpArizaliUrunlerBindingSource.DataMember = "tblLookUpArizaliUrunler";
            this.tblLookUpArizaliUrunlerBindingSource.DataSource = this.dataset;
            // 
            // dataset
            // 
            this.dataset.DataSetName = "Dataset";
            this.dataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colEvrakNo,
            this.colEvrakTarihi,
            this.colMusteriKodu,
            this.colMusteriAdi,
            this.colTeslimAlan});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridView1_KeyDown);
            // 
            // colEvrakNo
            // 
            this.colEvrakNo.FieldName = "EvrakNo";
            this.colEvrakNo.Name = "colEvrakNo";
            this.colEvrakNo.Visible = true;
            this.colEvrakNo.VisibleIndex = 0;
            // 
            // colEvrakTarihi
            // 
            this.colEvrakTarihi.FieldName = "EvrakTarihi";
            this.colEvrakTarihi.Name = "colEvrakTarihi";
            this.colEvrakTarihi.Visible = true;
            this.colEvrakTarihi.VisibleIndex = 1;
            // 
            // colMusteriKodu
            // 
            this.colMusteriKodu.FieldName = "MusteriKodu";
            this.colMusteriKodu.Name = "colMusteriKodu";
            this.colMusteriKodu.Visible = true;
            this.colMusteriKodu.VisibleIndex = 2;
            // 
            // colMusteriAdi
            // 
            this.colMusteriAdi.FieldName = "MusteriAdi";
            this.colMusteriAdi.Name = "colMusteriAdi";
            this.colMusteriAdi.Visible = true;
            this.colMusteriAdi.VisibleIndex = 3;
            // 
            // colTeslimAlan
            // 
            this.colTeslimAlan.FieldName = "TeslimAlan";
            this.colTeslimAlan.Name = "colTeslimAlan";
            this.colTeslimAlan.Visible = true;
            this.colTeslimAlan.VisibleIndex = 4;
            // 
            // tblLookUpArizaliUrunlerTableAdapter
            // 
            this.tblLookUpArizaliUrunlerTableAdapter.ClearBeforeFill = true;
            // 
            // frmArizaFormlari_lookUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 482);
            this.Controls.Add(this.gridControl1);
            this.KeyPreview = true;
            this.Name = "frmArizaFormlari_lookUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "[ARIZA FORMLARI]";
            this.Load += new System.EventHandler(this.frmArizaFormlari_lookUp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblLookUpArizaliUrunlerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private Dataset dataset;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource tblLookUpArizaliUrunlerBindingSource;
        private DatasetTableAdapters.tblLookUpArizaliUrunlerTableAdapter tblLookUpArizaliUrunlerTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colEvrakNo;
        private DevExpress.XtraGrid.Columns.GridColumn colEvrakTarihi;
        private DevExpress.XtraGrid.Columns.GridColumn colMusteriKodu;
        private DevExpress.XtraGrid.Columns.GridColumn colMusteriAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colTeslimAlan;
    }
}