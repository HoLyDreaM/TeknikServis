namespace TeknikServis
{
    partial class frmAcikBakimAnlasmalari_lookUp
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
            this.tblLookUpAcikBakimAnlasmalariBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataset = new TeknikServis.Dataset();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colEvrakNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBakimTarihi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAciklama = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBakimBilgisi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNotlar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tblLookUpAcikBakimAnlasmalariTableAdapter = new TeknikServis.DatasetTableAdapters.tblLookUpAcikBakimAnlasmalariTableAdapter();
            this.colDetayNo = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblLookUpAcikBakimAnlasmalariBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.tblLookUpAcikBakimAnlasmalariBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(483, 549);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.DoubleClick += new System.EventHandler(this.gridControl1_DoubleClick);
            // 
            // tblLookUpAcikBakimAnlasmalariBindingSource
            // 
            this.tblLookUpAcikBakimAnlasmalariBindingSource.DataMember = "tblLookUpAcikBakimAnlasmalari";
            this.tblLookUpAcikBakimAnlasmalariBindingSource.DataSource = this.dataset;
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
            this.colDetayNo,
            this.colBakimTarihi,
            this.colAciklama,
            this.colBakimBilgisi,
            this.colNotlar});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridView1_KeyDown);
            // 
            // colEvrakNo
            // 
            this.colEvrakNo.FieldName = "EvrakNo";
            this.colEvrakNo.Name = "colEvrakNo";
            this.colEvrakNo.OptionsColumn.ReadOnly = true;
            this.colEvrakNo.Visible = true;
            this.colEvrakNo.VisibleIndex = 0;
            // 
            // colBakimTarihi
            // 
            this.colBakimTarihi.FieldName = "BakimTarihi";
            this.colBakimTarihi.Name = "colBakimTarihi";
            this.colBakimTarihi.Visible = true;
            this.colBakimTarihi.VisibleIndex = 2;
            // 
            // colAciklama
            // 
            this.colAciklama.FieldName = "Aciklama";
            this.colAciklama.Name = "colAciklama";
            this.colAciklama.Visible = true;
            this.colAciklama.VisibleIndex = 3;
            // 
            // colBakimBilgisi
            // 
            this.colBakimBilgisi.FieldName = "BakimBilgisi";
            this.colBakimBilgisi.Name = "colBakimBilgisi";
            this.colBakimBilgisi.Visible = true;
            this.colBakimBilgisi.VisibleIndex = 4;
            // 
            // colNotlar
            // 
            this.colNotlar.FieldName = "Notlar";
            this.colNotlar.Name = "colNotlar";
            this.colNotlar.Visible = true;
            this.colNotlar.VisibleIndex = 5;
            // 
            // tblLookUpAcikBakimAnlasmalariTableAdapter
            // 
            this.tblLookUpAcikBakimAnlasmalariTableAdapter.ClearBeforeFill = true;
            // 
            // colDetayNo
            // 
            this.colDetayNo.FieldName = "DetayNo";
            this.colDetayNo.Name = "colDetayNo";
            this.colDetayNo.Visible = true;
            this.colDetayNo.VisibleIndex = 1;
            // 
            // frmAcikBakimAnlasmalari_lookUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 549);
            this.Controls.Add(this.gridControl1);
            this.KeyPreview = true;
            this.Name = "frmAcikBakimAnlasmalari_lookUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "[AÇIK BAKIM ANLAŞMALARI]";
            this.Load += new System.EventHandler(this.frmAcikBakimAnlasmalari_lookUp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblLookUpAcikBakimAnlasmalariBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource tblLookUpAcikBakimAnlasmalariBindingSource;
        private Dataset dataset;
        private DevExpress.XtraGrid.Columns.GridColumn colEvrakNo;
        private DevExpress.XtraGrid.Columns.GridColumn colBakimTarihi;
        private DevExpress.XtraGrid.Columns.GridColumn colAciklama;
        private DevExpress.XtraGrid.Columns.GridColumn colBakimBilgisi;
        private DevExpress.XtraGrid.Columns.GridColumn colNotlar;
        private DatasetTableAdapters.tblLookUpAcikBakimAnlasmalariTableAdapter tblLookUpAcikBakimAnlasmalariTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colDetayNo;
    }
}