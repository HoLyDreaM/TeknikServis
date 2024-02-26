namespace TeknikServis
{
    partial class frmLookUpTeklifler
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
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.dataset = new TeknikServis.Dataset();
            this.tblLookUpTeklifFormlariBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblLookUpTeklifFormlariTableAdapter = new TeknikServis.DatasetTableAdapters.tblLookUpTeklifFormlariTableAdapter();
            this.colEvrakNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEvrakTarihi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMusteriKodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnvan1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTelefon1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTeklifBasligi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHareketDurumu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHareketDurumuStr = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHareketAciklamasi = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblLookUpTeklifFormlariBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.tblLookUpTeklifFormlariBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(639, 570);
            this.gridControl1.TabIndex = 3;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.DoubleClick += new System.EventHandler(this.gridControl1_DoubleClick);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colEvrakNo,
            this.colEvrakTarihi,
            this.colMusteriKodu,
            this.colUnvan1,
            this.colTelefon1,
            this.colTeklifBasligi,
            this.colHareketDurumu,
            this.colHareketDurumuStr,
            this.colHareketAciklamasi});
            this.gridView1.CustomizationFormBounds = new System.Drawing.Rectangle(477, 532, 216, 190);
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // dataset
            // 
            this.dataset.DataSetName = "Dataset";
            this.dataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblLookUpTeklifFormlariBindingSource
            // 
            this.tblLookUpTeklifFormlariBindingSource.DataMember = "tblLookUpTeklifFormlari";
            this.tblLookUpTeklifFormlariBindingSource.DataSource = this.dataset;
            // 
            // tblLookUpTeklifFormlariTableAdapter
            // 
            this.tblLookUpTeklifFormlariTableAdapter.ClearBeforeFill = true;
            // 
            // colEvrakNo
            // 
            this.colEvrakNo.FieldName = "EvrakNo";
            this.colEvrakNo.Name = "colEvrakNo";
            this.colEvrakNo.OptionsColumn.ReadOnly = true;
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
            this.colMusteriKodu.Width = 81;
            // 
            // colUnvan1
            // 
            this.colUnvan1.FieldName = "Unvan1";
            this.colUnvan1.Name = "colUnvan1";
            this.colUnvan1.Visible = true;
            this.colUnvan1.VisibleIndex = 3;
            // 
            // colTelefon1
            // 
            this.colTelefon1.FieldName = "Telefon1";
            this.colTelefon1.Name = "colTelefon1";
            this.colTelefon1.Visible = true;
            this.colTelefon1.VisibleIndex = 4;
            // 
            // colTeklifBasligi
            // 
            this.colTeklifBasligi.FieldName = "TeklifBasligi";
            this.colTeklifBasligi.Name = "colTeklifBasligi";
            this.colTeklifBasligi.Visible = true;
            this.colTeklifBasligi.VisibleIndex = 5;
            this.colTeklifBasligi.Width = 76;
            // 
            // colHareketDurumu
            // 
            this.colHareketDurumu.FieldName = "HareketDurumu";
            this.colHareketDurumu.Name = "colHareketDurumu";
            this.colHareketDurumu.Width = 97;
            // 
            // colHareketDurumuStr
            // 
            this.colHareketDurumuStr.Caption = "Hareket Durumu";
            this.colHareketDurumuStr.FieldName = "HareketDurumuStr";
            this.colHareketDurumuStr.Name = "colHareketDurumuStr";
            this.colHareketDurumuStr.Visible = true;
            this.colHareketDurumuStr.VisibleIndex = 6;
            this.colHareketDurumuStr.Width = 114;
            // 
            // colHareketAciklamasi
            // 
            this.colHareketAciklamasi.FieldName = "HareketAciklamasi";
            this.colHareketAciklamasi.Name = "colHareketAciklamasi";
            this.colHareketAciklamasi.Width = 108;
            // 
            // frmLookUpTeklifler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 570);
            this.Controls.Add(this.gridControl1);
            this.KeyPreview = true;
            this.Name = "frmLookUpTeklifler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "[TEKLİFLER]";
            this.Load += new System.EventHandler(this.frmLookUpTeklifler_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmLookUpTeklifler_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblLookUpTeklifFormlariBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private Dataset dataset;
        private System.Windows.Forms.BindingSource tblLookUpTeklifFormlariBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colEvrakNo;
        private DevExpress.XtraGrid.Columns.GridColumn colEvrakTarihi;
        private DevExpress.XtraGrid.Columns.GridColumn colMusteriKodu;
        private DevExpress.XtraGrid.Columns.GridColumn colUnvan1;
        private DevExpress.XtraGrid.Columns.GridColumn colTelefon1;
        private DevExpress.XtraGrid.Columns.GridColumn colTeklifBasligi;
        private DevExpress.XtraGrid.Columns.GridColumn colHareketDurumu;
        private DevExpress.XtraGrid.Columns.GridColumn colHareketDurumuStr;
        private DevExpress.XtraGrid.Columns.GridColumn colHareketAciklamasi;
        private DatasetTableAdapters.tblLookUpTeklifFormlariTableAdapter tblLookUpTeklifFormlariTableAdapter;
    }
}