namespace TeknikServis
{
    partial class frmTeklifDurumlari
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTeklifDurumlari));
            this.imgMenu = new DevExpress.Utils.ImageCollection(this.components);
            this.imgToolBar = new DevExpress.Utils.ImageCollection(this.components);
            this.btnYenile = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem6 = new DevExpress.XtraBars.BarButtonItem();
            this.btnExcel = new DevExpress.XtraBars.BarButtonItem();
            this.btnText = new DevExpress.XtraBars.BarButtonItem();
            this.btnCsv = new DevExpress.XtraBars.BarButtonItem();
            this.btnPdf = new DevExpress.XtraBars.BarButtonItem();
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnTeklifDetayi = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.dataset = new TeknikServis.Dataset();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.dtTarih2 = new DevExpress.XtraEditors.DateEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.dtTarih1 = new DevExpress.XtraEditors.DateEdit();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.tblTeklifDurumlariBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colEvrakNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEvrakTarihi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMusteriKodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnvan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTelefon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTeklifBasligi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHareketDurumu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHareketDurumuStr = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDurumTarihi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHareketAciklamasi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTeklifVeren = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tblTeklifDurumlariTableAdapter = new TeknikServis.DatasetTableAdapters.tblTeklifDurumlariTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.imgMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgToolBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtTarih2.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtTarih2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtTarih1.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtTarih1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblTeklifDurumlariBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // imgMenu
            // 
            this.imgMenu.ImageSize = new System.Drawing.Size(24, 24);
            this.imgMenu.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imgMenu.ImageStream")));
            this.imgMenu.Images.SetKeyName(0, "Add.png");
            this.imgMenu.Images.SetKeyName(1, "Delete.png");
            this.imgMenu.Images.SetKeyName(2, "Edit.png");
            this.imgMenu.Images.SetKeyName(3, "Refresh.png");
            this.imgMenu.Images.SetKeyName(4, "1385947988_70.png");
            // 
            // imgToolBar
            // 
            this.imgToolBar.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imgToolBar.ImageStream")));
            this.imgToolBar.Images.SetKeyName(0, "export_csv.png");
            this.imgToolBar.Images.SetKeyName(1, "export_excel.png");
            this.imgToolBar.Images.SetKeyName(2, "export_pdf.png");
            this.imgToolBar.Images.SetKeyName(3, "export_text.png");
            // 
            // btnYenile
            // 
            this.btnYenile.Caption = "Yenile";
            this.btnYenile.Id = 0;
            this.btnYenile.ImageIndex = 3;
            this.btnYenile.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnYenile.ItemAppearance.Normal.Options.UseFont = true;
            this.btnYenile.Name = "btnYenile";
            this.btnYenile.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnYenile_ItemClick);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Excel";
            this.barButtonItem1.Id = 6;
            this.barButtonItem1.ImageIndex = 1;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Text";
            this.barButtonItem2.Id = 7;
            this.barButtonItem2.ImageIndex = 3;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Csv";
            this.barButtonItem3.Id = 8;
            this.barButtonItem3.ImageIndex = 0;
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "Pdf";
            this.barButtonItem4.Id = 9;
            this.barButtonItem4.ImageIndexDisabled = 0;
            this.barButtonItem4.Name = "barButtonItem4";
            // 
            // barButtonItem5
            // 
            this.barButtonItem5.Caption = "barButtonItem5";
            this.barButtonItem5.Id = 10;
            this.barButtonItem5.Name = "barButtonItem5";
            // 
            // barButtonItem6
            // 
            this.barButtonItem6.Caption = "barButtonItem6";
            this.barButtonItem6.Id = 11;
            this.barButtonItem6.Name = "barButtonItem6";
            // 
            // btnExcel
            // 
            this.btnExcel.Caption = "EXCEL";
            this.btnExcel.Glyph = ((System.Drawing.Image)(resources.GetObject("btnExcel.Glyph")));
            this.btnExcel.Id = 12;
            this.btnExcel.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnExcel.ItemAppearance.Normal.Options.UseFont = true;
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnExcel_ItemClick);
            // 
            // btnText
            // 
            this.btnText.Caption = "TEXT";
            this.btnText.Id = 13;
            this.btnText.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnText.ItemAppearance.Normal.Options.UseFont = true;
            this.btnText.Name = "btnText";
            this.btnText.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnText_ItemClick);
            // 
            // btnCsv
            // 
            this.btnCsv.Caption = "CSV";
            this.btnCsv.Id = 14;
            this.btnCsv.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnCsv.ItemAppearance.Normal.Options.UseFont = true;
            this.btnCsv.Name = "btnCsv";
            this.btnCsv.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCsv_ItemClick);
            // 
            // btnPdf
            // 
            this.btnPdf.Caption = "PDF";
            this.btnPdf.Id = 15;
            this.btnPdf.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnPdf.ItemAppearance.Normal.Options.UseFont = true;
            this.btnPdf.Name = "btnPdf";
            this.btnPdf.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPdf_ItemClick);
            // 
            // bar1
            // 
            this.bar1.BarName = "Custom 3";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Left;
            this.bar1.FloatLocation = new System.Drawing.Point(41, 218);
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnExcel, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnText, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnCsv, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnPdf, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.OptionsBar.AllowQuickCustomization = false;
            this.bar1.OptionsBar.DisableClose = true;
            this.bar1.OptionsBar.DisableCustomization = true;
            this.bar1.OptionsBar.DrawDragBorder = false;
            this.bar1.OptionsBar.DrawSizeGrip = true;
            this.bar1.OptionsBar.Hidden = true;
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.Text = "Custom 3";
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.FloatLocation = new System.Drawing.Point(140, 111);
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnYenile, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnTeklifDetayi, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.AllowQuickCustomization = false;
            this.bar2.OptionsBar.DrawDragBorder = false;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnTeklifDetayi
            // 
            this.btnTeklifDetayi.Caption = "Teklif Detayı";
            this.btnTeklifDetayi.Id = 17;
            this.btnTeklifDetayi.ImageIndex = 4;
            this.btnTeklifDetayi.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnTeklifDetayi.ItemAppearance.Normal.Options.UseFont = true;
            this.btnTeklifDetayi.Name = "btnTeklifDetayi";
            this.btnTeklifDetayi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTeklifDetayi_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(1034, 34);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 651);
            this.barDockControlBottom.Size = new System.Drawing.Size(1034, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 34);
            this.barDockControlLeft.Size = new System.Drawing.Size(26, 617);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1034, 34);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 617);
            // 
            // barManager1
            // 
            this.barManager1.AllowCustomization = false;
            this.barManager1.AllowMoveBarOnToolbar = false;
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2,
            this.bar1});
            this.barManager1.CloseButtonAffectAllTabs = false;
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Images = this.imgMenu;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnYenile,
            this.barButtonItem1,
            this.barButtonItem2,
            this.barButtonItem3,
            this.barButtonItem4,
            this.barButtonItem5,
            this.barButtonItem6,
            this.btnExcel,
            this.btnText,
            this.btnCsv,
            this.btnPdf,
            this.btnTeklifDetayi});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 18;
            this.barManager1.ShowFullMenusAfterDelay = false;
            this.barManager1.ShowScreenTipsInToolbars = false;
            this.barManager1.ShowShortcutInScreenTips = false;
            this.barManager1.TransparentEditors = true;
            // 
            // dataset
            // 
            this.dataset.DataSetName = "Dataset";
            this.dataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.dtTarih2);
            this.panelControl1.Controls.Add(this.labelControl6);
            this.panelControl1.Controls.Add(this.dtTarih1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(26, 34);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1008, 74);
            this.panelControl1.TabIndex = 13;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.labelControl1.Location = new System.Drawing.Point(14, 40);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(124, 20);
            this.labelControl1.TabIndex = 41;
            this.labelControl1.Text = "Tarih";
            // 
            // dtTarih2
            // 
            this.dtTarih2.EditValue = null;
            this.dtTarih2.EnterMoveNextControl = true;
            this.dtTarih2.Location = new System.Drawing.Point(138, 40);
            this.dtTarih2.Name = "dtTarih2";
            this.dtTarih2.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.dtTarih2.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.dtTarih2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtTarih2.Properties.Mask.EditMask = "";
            this.dtTarih2.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.dtTarih2.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dtTarih2.Size = new System.Drawing.Size(111, 20);
            this.dtTarih2.TabIndex = 40;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl6.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl6.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl6.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.labelControl6.Location = new System.Drawing.Point(14, 14);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(124, 20);
            this.labelControl6.TabIndex = 39;
            this.labelControl6.Text = "Tarih";
            // 
            // dtTarih1
            // 
            this.dtTarih1.EditValue = null;
            this.dtTarih1.EnterMoveNextControl = true;
            this.dtTarih1.Location = new System.Drawing.Point(138, 14);
            this.dtTarih1.Name = "dtTarih1";
            this.dtTarih1.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.dtTarih1.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.dtTarih1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtTarih1.Properties.Mask.EditMask = "";
            this.dtTarih1.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.dtTarih1.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dtTarih1.Size = new System.Drawing.Size(111, 20);
            this.dtTarih1.TabIndex = 38;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.tblTeklifDurumlariBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(26, 108);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.MenuManager = this.barManager1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1008, 543);
            this.gridControl1.TabIndex = 14;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // tblTeklifDurumlariBindingSource
            // 
            this.tblTeklifDurumlariBindingSource.DataMember = "tblTeklifDurumlari";
            this.tblTeklifDurumlariBindingSource.DataSource = this.dataset;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colEvrakNo,
            this.colEvrakTarihi,
            this.colMusteriKodu,
            this.colUnvan,
            this.colTelefon,
            this.colTeklifBasligi,
            this.colHareketDurumu,
            this.colHareketDurumuStr,
            this.colDurumTarihi,
            this.colHareketAciklamasi,
            this.colTeklifVeren});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
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
            this.colEvrakTarihi.OptionsColumn.ReadOnly = true;
            this.colEvrakTarihi.Visible = true;
            this.colEvrakTarihi.VisibleIndex = 1;
            // 
            // colMusteriKodu
            // 
            this.colMusteriKodu.FieldName = "MusteriKodu";
            this.colMusteriKodu.Name = "colMusteriKodu";
            this.colMusteriKodu.OptionsColumn.ReadOnly = true;
            this.colMusteriKodu.Visible = true;
            this.colMusteriKodu.VisibleIndex = 2;
            this.colMusteriKodu.Width = 81;
            // 
            // colUnvan
            // 
            this.colUnvan.FieldName = "Unvan";
            this.colUnvan.Name = "colUnvan";
            this.colUnvan.OptionsColumn.ReadOnly = true;
            this.colUnvan.Visible = true;
            this.colUnvan.VisibleIndex = 3;
            // 
            // colTelefon
            // 
            this.colTelefon.FieldName = "Telefon";
            this.colTelefon.Name = "colTelefon";
            this.colTelefon.OptionsColumn.ReadOnly = true;
            this.colTelefon.Visible = true;
            this.colTelefon.VisibleIndex = 4;
            // 
            // colTeklifBasligi
            // 
            this.colTeklifBasligi.FieldName = "TeklifBasligi";
            this.colTeklifBasligi.Name = "colTeklifBasligi";
            this.colTeklifBasligi.OptionsColumn.ReadOnly = true;
            this.colTeklifBasligi.Visible = true;
            this.colTeklifBasligi.VisibleIndex = 5;
            this.colTeklifBasligi.Width = 187;
            // 
            // colHareketDurumu
            // 
            this.colHareketDurumu.FieldName = "HareketDurumu";
            this.colHareketDurumu.Name = "colHareketDurumu";
            this.colHareketDurumu.OptionsColumn.ReadOnly = true;
            this.colHareketDurumu.Width = 97;
            // 
            // colHareketDurumuStr
            // 
            this.colHareketDurumuStr.Caption = "Hareket Durumu";
            this.colHareketDurumuStr.FieldName = "HareketDurumuStr";
            this.colHareketDurumuStr.Name = "colHareketDurumuStr";
            this.colHareketDurumuStr.OptionsColumn.ReadOnly = true;
            this.colHareketDurumuStr.Visible = true;
            this.colHareketDurumuStr.VisibleIndex = 6;
            this.colHareketDurumuStr.Width = 114;
            // 
            // colDurumTarihi
            // 
            this.colDurumTarihi.FieldName = "DurumTarihi";
            this.colDurumTarihi.Name = "colDurumTarihi";
            this.colDurumTarihi.OptionsColumn.ReadOnly = true;
            this.colDurumTarihi.Visible = true;
            this.colDurumTarihi.VisibleIndex = 7;
            this.colDurumTarihi.Width = 79;
            // 
            // colHareketAciklamasi
            // 
            this.colHareketAciklamasi.FieldName = "HareketAciklamasi";
            this.colHareketAciklamasi.Name = "colHareketAciklamasi";
            this.colHareketAciklamasi.OptionsColumn.ReadOnly = true;
            this.colHareketAciklamasi.Visible = true;
            this.colHareketAciklamasi.VisibleIndex = 8;
            this.colHareketAciklamasi.Width = 108;
            // 
            // colTeklifVeren
            // 
            this.colTeklifVeren.FieldName = "TeklifVeren";
            this.colTeklifVeren.Name = "colTeklifVeren";
            this.colTeklifVeren.OptionsColumn.ReadOnly = true;
            this.colTeklifVeren.Visible = true;
            this.colTeklifVeren.VisibleIndex = 9;
            // 
            // tblTeklifDurumlariTableAdapter
            // 
            this.tblTeklifDurumlariTableAdapter.ClearBeforeFill = true;
            // 
            // frmTeklifDurumlari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 651);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmTeklifDurumlari";
            this.Text = "[TEKLİF DURUMLARI]";
            this.Load += new System.EventHandler(this.frmTeklifDurumlari_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgToolBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtTarih2.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtTarih2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtTarih1.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtTarih1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblTeklifDurumlariBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.Utils.ImageCollection imgMenu;
        private DevExpress.Utils.ImageCollection imgToolBar;
        private DevExpress.XtraBars.BarButtonItem btnYenile;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private DevExpress.XtraBars.BarButtonItem barButtonItem6;
        private DevExpress.XtraBars.BarButtonItem btnExcel;
        private DevExpress.XtraBars.BarButtonItem btnText;
        private DevExpress.XtraBars.BarButtonItem btnCsv;
        private DevExpress.XtraBars.BarButtonItem btnPdf;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarManager barManager1;
        private Dataset dataset;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.DateEdit dtTarih2;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.DateEdit dtTarih1;
        private System.Windows.Forms.BindingSource tblTeklifDurumlariBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colEvrakNo;
        private DevExpress.XtraGrid.Columns.GridColumn colEvrakTarihi;
        private DevExpress.XtraGrid.Columns.GridColumn colMusteriKodu;
        private DevExpress.XtraGrid.Columns.GridColumn colUnvan;
        private DevExpress.XtraGrid.Columns.GridColumn colTelefon;
        private DevExpress.XtraGrid.Columns.GridColumn colTeklifBasligi;
        private DevExpress.XtraGrid.Columns.GridColumn colHareketDurumu;
        private DevExpress.XtraGrid.Columns.GridColumn colHareketDurumuStr;
        private DevExpress.XtraGrid.Columns.GridColumn colDurumTarihi;
        private DevExpress.XtraGrid.Columns.GridColumn colHareketAciklamasi;
        private DevExpress.XtraGrid.Columns.GridColumn colTeklifVeren;
        private DatasetTableAdapters.tblTeklifDurumlariTableAdapter tblTeklifDurumlariTableAdapter;
        private DevExpress.XtraBars.BarButtonItem btnTeklifDetayi;
    }
}