namespace TeknikServis
{
    partial class frmLookUpIsEmirleri
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
            this.dataset = new TeknikServis.Dataset();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.tblGorevPersonelGorevleriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblGorev_PersonelGorevleriTableAdapter = new TeknikServis.DatasetTableAdapters.tblGorev_PersonelGorevleriTableAdapter();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEvrakNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTarih = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPersonel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMusteriKodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnvan1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnvan2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAdres1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAdres2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTelefon1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSikayet = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmriVeren = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVerisTarihSaati = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblGorevPersonelGorevleriBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.tblGorevPersonelGorevleriBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1016, 540);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.DoubleClick += new System.EventHandler(this.gridControl1_DoubleClick);
            // 
            // dataset
            // 
            this.dataset.DataSetName = "Dataset";
            this.dataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colEvrakNo,
            this.colTarih,
            this.colPersonel,
            this.colMusteriKodu,
            this.colUnvan1,
            this.colUnvan2,
            this.colAdres1,
            this.colAdres2,
            this.colTelefon1,
            this.colSikayet,
            this.colEmriVeren,
            this.colVerisTarihSaati});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // tblGorevPersonelGorevleriBindingSource
            // 
            this.tblGorevPersonelGorevleriBindingSource.DataMember = "tblGorev_PersonelGorevleri";
            this.tblGorevPersonelGorevleriBindingSource.DataSource = this.dataset;
            // 
            // tblGorev_PersonelGorevleriTableAdapter
            // 
            this.tblGorev_PersonelGorevleriTableAdapter.ClearBeforeFill = true;
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.OptionsColumn.ReadOnly = true;
            // 
            // colEvrakNo
            // 
            this.colEvrakNo.FieldName = "EvrakNo";
            this.colEvrakNo.Name = "colEvrakNo";
            this.colEvrakNo.OptionsColumn.ReadOnly = true;
            this.colEvrakNo.Visible = true;
            this.colEvrakNo.VisibleIndex = 0;
            // 
            // colTarih
            // 
            this.colTarih.FieldName = "Tarih";
            this.colTarih.Name = "colTarih";
            this.colTarih.Visible = true;
            this.colTarih.VisibleIndex = 1;
            // 
            // colPersonel
            // 
            this.colPersonel.FieldName = "Personel";
            this.colPersonel.Name = "colPersonel";
            this.colPersonel.Visible = true;
            this.colPersonel.VisibleIndex = 2;
            // 
            // colMusteriKodu
            // 
            this.colMusteriKodu.FieldName = "MusteriKodu";
            this.colMusteriKodu.Name = "colMusteriKodu";
            this.colMusteriKodu.Visible = true;
            this.colMusteriKodu.VisibleIndex = 3;
            // 
            // colUnvan1
            // 
            this.colUnvan1.FieldName = "Unvan1";
            this.colUnvan1.Name = "colUnvan1";
            this.colUnvan1.Visible = true;
            this.colUnvan1.VisibleIndex = 4;
            // 
            // colUnvan2
            // 
            this.colUnvan2.FieldName = "Unvan2";
            this.colUnvan2.Name = "colUnvan2";
            this.colUnvan2.Visible = true;
            this.colUnvan2.VisibleIndex = 5;
            // 
            // colAdres1
            // 
            this.colAdres1.FieldName = "Adres1";
            this.colAdres1.Name = "colAdres1";
            this.colAdres1.Visible = true;
            this.colAdres1.VisibleIndex = 6;
            // 
            // colAdres2
            // 
            this.colAdres2.FieldName = "Adres2";
            this.colAdres2.Name = "colAdres2";
            this.colAdres2.Visible = true;
            this.colAdres2.VisibleIndex = 7;
            // 
            // colTelefon1
            // 
            this.colTelefon1.FieldName = "Telefon1";
            this.colTelefon1.Name = "colTelefon1";
            this.colTelefon1.Visible = true;
            this.colTelefon1.VisibleIndex = 8;
            // 
            // colSikayet
            // 
            this.colSikayet.FieldName = "Sikayet";
            this.colSikayet.Name = "colSikayet";
            this.colSikayet.Visible = true;
            this.colSikayet.VisibleIndex = 9;
            // 
            // colEmriVeren
            // 
            this.colEmriVeren.FieldName = "EmriVeren";
            this.colEmriVeren.Name = "colEmriVeren";
            this.colEmriVeren.Visible = true;
            this.colEmriVeren.VisibleIndex = 10;
            // 
            // colVerisTarihSaati
            // 
            this.colVerisTarihSaati.FieldName = "VerisTarihSaati";
            this.colVerisTarihSaati.Name = "colVerisTarihSaati";
            this.colVerisTarihSaati.Visible = true;
            this.colVerisTarihSaati.VisibleIndex = 11;
            // 
            // frmLookUpIsEmirleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 540);
            this.Controls.Add(this.gridControl1);
            this.KeyPreview = true;
            this.Name = "frmLookUpIsEmirleri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "[AÇIK İŞ EMİRLERİ]";
            this.Load += new System.EventHandler(this.frmLookUpIsEmirleri_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmLookUpIsEmirleri_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblGorevPersonelGorevleriBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private Dataset dataset;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource tblGorevPersonelGorevleriBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colEvrakNo;
        private DevExpress.XtraGrid.Columns.GridColumn colTarih;
        private DevExpress.XtraGrid.Columns.GridColumn colPersonel;
        private DevExpress.XtraGrid.Columns.GridColumn colMusteriKodu;
        private DevExpress.XtraGrid.Columns.GridColumn colUnvan1;
        private DevExpress.XtraGrid.Columns.GridColumn colUnvan2;
        private DevExpress.XtraGrid.Columns.GridColumn colAdres1;
        private DevExpress.XtraGrid.Columns.GridColumn colAdres2;
        private DevExpress.XtraGrid.Columns.GridColumn colTelefon1;
        private DevExpress.XtraGrid.Columns.GridColumn colSikayet;
        private DevExpress.XtraGrid.Columns.GridColumn colEmriVeren;
        private DevExpress.XtraGrid.Columns.GridColumn colVerisTarihSaati;
        private DatasetTableAdapters.tblGorev_PersonelGorevleriTableAdapter tblGorev_PersonelGorevleriTableAdapter;
    }
}