namespace TeknikServis
{
    partial class frmIsEmirleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIsEmirleri));
            this.dataset = new TeknikServis.Dataset();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnYenile = new DevExpress.XtraBars.BarButtonItem();
            this.btnDuzenle = new DevExpress.XtraBars.BarButtonItem();
            this.btnEkle = new DevExpress.XtraBars.BarButtonItem();
            this.btnSil = new DevExpress.XtraBars.BarButtonItem();
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnExcel = new DevExpress.XtraBars.BarButtonItem();
            this.btnText = new DevExpress.XtraBars.BarButtonItem();
            this.btnCsv = new DevExpress.XtraBars.BarButtonItem();
            this.btnPdf = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.imgMenu = new DevExpress.Utils.ImageCollection(this.components);
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem6 = new DevExpress.XtraBars.BarButtonItem();
            this.repositoryItemComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.sorgular1 = new TeknikServis.DatasetTableAdapters.sorgular();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.tblIsEmirleriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colEvrakNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTarih = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPersonel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMusteriKodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSikayet = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colServisTipi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colYapilanlar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAciklama = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmriVeren = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVerisTarihSaati = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHareketDurumu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnvan1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colServisFormNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colServisTipiStr = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmriKapatanKullanici = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKapatmaTarihSaati = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHareketDurumuStr = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEkleyenKullanici = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEklemeTarihSaati = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.imgToolBar = new DevExpress.Utils.ImageCollection(this.components);
            this.tblIsEmirleriTableAdapter = new TeknikServis.DatasetTableAdapters.tblIsEmirleriTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblIsEmirleriBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgToolBar)).BeginInit();
            this.SuspendLayout();
            // 
            // dataset
            // 
            this.dataset.DataSetName = "Dataset";
            this.dataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.btnSil,
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
            this.btnEkle,
            this.btnDuzenle});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 19;
            this.barManager1.ShowFullMenusAfterDelay = false;
            this.barManager1.ShowScreenTipsInToolbars = false;
            this.barManager1.ShowShortcutInScreenTips = false;
            this.barManager1.TransparentEditors = true;
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
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnDuzenle, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnEkle, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnSil, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.AllowQuickCustomization = false;
            this.bar2.OptionsBar.DrawDragBorder = false;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
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
            // btnDuzenle
            // 
            this.btnDuzenle.Caption = "Düzenle";
            this.btnDuzenle.Id = 17;
            this.btnDuzenle.ImageIndex = 2;
            this.btnDuzenle.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnDuzenle.ItemAppearance.Normal.Options.UseFont = true;
            this.btnDuzenle.Name = "btnDuzenle";
            this.btnDuzenle.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDuzenle_ItemClick);
            // 
            // btnEkle
            // 
            this.btnEkle.Caption = "Ekle";
            this.btnEkle.Id = 16;
            this.btnEkle.ImageIndex = 0;
            this.btnEkle.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnEkle.ItemAppearance.Normal.Options.UseFont = true;
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnEkle_ItemClick);
            // 
            // btnSil
            // 
            this.btnSil.Caption = "Sil";
            this.btnSil.Id = 3;
            this.btnSil.ImageIndex = 1;
            this.btnSil.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnSil.ItemAppearance.Normal.Options.UseFont = true;
            this.btnSil.LargeImageIndex = 0;
            this.btnSil.Name = "btnSil";
            this.btnSil.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSil_ItemClick);
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
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(1068, 34);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 634);
            this.barDockControlBottom.Size = new System.Drawing.Size(1068, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 34);
            this.barDockControlLeft.Size = new System.Drawing.Size(26, 600);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1068, 34);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 600);
            // 
            // imgMenu
            // 
            this.imgMenu.ImageSize = new System.Drawing.Size(24, 24);
            this.imgMenu.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imgMenu.ImageStream")));
            this.imgMenu.Images.SetKeyName(0, "Add.png");
            this.imgMenu.Images.SetKeyName(1, "Delete.png");
            this.imgMenu.Images.SetKeyName(2, "Edit.png");
            this.imgMenu.Images.SetKeyName(3, "Refresh.png");
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
            // repositoryItemComboBox1
            // 
            this.repositoryItemComboBox1.AutoHeight = false;
            this.repositoryItemComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBox1.Items.AddRange(new object[] {
            "Muhasebe",
            "Teknik Servis",
            "Yazılım",
            "Yönetici"});
            this.repositoryItemComboBox1.Name = "repositoryItemComboBox1";
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.tblIsEmirleriBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(26, 34);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.MenuManager = this.barManager1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemComboBox1});
            this.gridControl1.Size = new System.Drawing.Size(1042, 600);
            this.gridControl1.TabIndex = 7;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // tblIsEmirleriBindingSource
            // 
            this.tblIsEmirleriBindingSource.DataMember = "tblIsEmirleri";
            this.tblIsEmirleriBindingSource.DataSource = this.dataset;
            // 
            // gridView1
            // 
            this.gridView1.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gridView1.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.gridView1.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gridView1.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.ColumnFilterButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gridView1.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gridView1.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gridView1.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gridView1.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.White;
            this.gridView1.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(215)))));
            this.gridView1.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.White;
            this.gridView1.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.ColumnFilterButtonActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gridView1.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gridView1.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gridView1.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gridView1.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.gridView1.Appearance.Empty.Options.UseBackColor = true;
            this.gridView1.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gridView1.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.EvenRow.Options.UseBackColor = true;
            this.gridView1.Appearance.EvenRow.Options.UseForeColor = true;
            this.gridView1.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gridView1.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.gridView1.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gridView1.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gridView1.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gridView1.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gridView1.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(131)))), ((int)(((byte)(161)))));
            this.gridView1.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White;
            this.gridView1.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gridView1.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gridView1.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(124)))), ((int)(((byte)(148)))));
            this.gridView1.Appearance.FixedLine.Options.UseBackColor = true;
            this.gridView1.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(180)))), ((int)(((byte)(191)))));
            this.gridView1.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridView1.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gridView1.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gridView1.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.gridView1.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gridView1.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gridView1.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gridView1.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gridView1.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.gridView1.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.gridView1.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.GroupButton.Options.UseBackColor = true;
            this.gridView1.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gridView1.Appearance.GroupButton.Options.UseForeColor = true;
            this.gridView1.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.gridView1.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.gridView1.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gridView1.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gridView1.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gridView1.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(131)))), ((int)(((byte)(161)))));
            this.gridView1.Appearance.GroupPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gridView1.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gridView1.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gridView1.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.gridView1.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.gridView1.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.gridView1.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.GroupRow.Options.UseBackColor = true;
            this.gridView1.Appearance.GroupRow.Options.UseBorderColor = true;
            this.gridView1.Appearance.GroupRow.Options.UseFont = true;
            this.gridView1.Appearance.GroupRow.Options.UseForeColor = true;
            this.gridView1.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gridView1.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.gridView1.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gridView1.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gridView1.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gridView1.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gridView1.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gridView1.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(219)))), ((int)(((byte)(226)))));
            this.gridView1.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(131)))), ((int)(((byte)(161)))));
            this.gridView1.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gridView1.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gridView1.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(164)))), ((int)(((byte)(188)))));
            this.gridView1.Appearance.HorzLine.Options.UseBackColor = true;
            this.gridView1.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.gridView1.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.OddRow.Options.UseBackColor = true;
            this.gridView1.Appearance.OddRow.Options.UseForeColor = true;
            this.gridView1.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(253)))));
            this.gridView1.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(165)))), ((int)(((byte)(177)))));
            this.gridView1.Appearance.Preview.Options.UseBackColor = true;
            this.gridView1.Appearance.Preview.Options.UseForeColor = true;
            this.gridView1.Appearance.Row.BackColor = System.Drawing.Color.White;
            this.gridView1.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.Row.Options.UseBackColor = true;
            this.gridView1.Appearance.Row.Options.UseForeColor = true;
            this.gridView1.Appearance.RowSeparator.BackColor = System.Drawing.Color.White;
            this.gridView1.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gridView1.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(197)))), ((int)(((byte)(205)))));
            this.gridView1.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gridView1.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gridView1.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(164)))), ((int)(((byte)(188)))));
            this.gridView1.Appearance.VertLine.Options.UseBackColor = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colEvrakNo,
            this.colTarih,
            this.colPersonel,
            this.colMusteriKodu,
            this.colSikayet,
            this.colServisTipi,
            this.colYapilanlar,
            this.colAciklama,
            this.colEmriVeren,
            this.colVerisTarihSaati,
            this.colHareketDurumu,
            this.colUnvan1,
            this.colServisFormNo,
            this.colServisTipiStr,
            this.colEmriKapatanKullanici,
            this.colKapatmaTarihSaati,
            this.colHareketDurumuStr,
            this.colEkleyenKullanici,
            this.colEklemeTarihSaati,
            this.colID});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsNavigation.AutoFocusNewRow = true;
            this.gridView1.OptionsNavigation.EnterMoveNextColumn = true;
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.EnableAppearanceEvenRow = true;
            this.gridView1.OptionsView.EnableAppearanceOddRow = true;
            this.gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colEvrakNo
            // 
            this.colEvrakNo.FieldName = "EvrakNo";
            this.colEvrakNo.Name = "colEvrakNo";
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
            this.colPersonel.VisibleIndex = 4;
            // 
            // colMusteriKodu
            // 
            this.colMusteriKodu.FieldName = "MusteriKodu";
            this.colMusteriKodu.Name = "colMusteriKodu";
            this.colMusteriKodu.Visible = true;
            this.colMusteriKodu.VisibleIndex = 2;
            this.colMusteriKodu.Width = 84;
            // 
            // colSikayet
            // 
            this.colSikayet.Caption = "Müşteri Şikayeti";
            this.colSikayet.FieldName = "Sikayet";
            this.colSikayet.Name = "colSikayet";
            this.colSikayet.Visible = true;
            this.colSikayet.VisibleIndex = 5;
            this.colSikayet.Width = 97;
            // 
            // colServisTipi
            // 
            this.colServisTipi.FieldName = "ServisTipi";
            this.colServisTipi.Name = "colServisTipi";
            // 
            // colYapilanlar
            // 
            this.colYapilanlar.FieldName = "Yapilanlar";
            this.colYapilanlar.Name = "colYapilanlar";
            this.colYapilanlar.Visible = true;
            this.colYapilanlar.VisibleIndex = 7;
            // 
            // colAciklama
            // 
            this.colAciklama.FieldName = "Aciklama";
            this.colAciklama.Name = "colAciklama";
            this.colAciklama.Visible = true;
            this.colAciklama.VisibleIndex = 8;
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
            this.colVerisTarihSaati.Caption = "Veriliş Tarihi";
            this.colVerisTarihSaati.FieldName = "VerisTarihSaati";
            this.colVerisTarihSaati.Name = "colVerisTarihSaati";
            this.colVerisTarihSaati.Visible = true;
            this.colVerisTarihSaati.VisibleIndex = 11;
            this.colVerisTarihSaati.Width = 99;
            // 
            // colHareketDurumu
            // 
            this.colHareketDurumu.FieldName = "HareketDurumu";
            this.colHareketDurumu.Name = "colHareketDurumu";
            this.colHareketDurumu.Width = 100;
            // 
            // colUnvan1
            // 
            this.colUnvan1.FieldName = "Unvan1";
            this.colUnvan1.Name = "colUnvan1";
            this.colUnvan1.Visible = true;
            this.colUnvan1.VisibleIndex = 3;
            // 
            // colServisFormNo
            // 
            this.colServisFormNo.Caption = "Servis Form No";
            this.colServisFormNo.FieldName = "ServisFormNo";
            this.colServisFormNo.Name = "colServisFormNo";
            this.colServisFormNo.OptionsColumn.ReadOnly = true;
            this.colServisFormNo.Visible = true;
            this.colServisFormNo.VisibleIndex = 9;
            this.colServisFormNo.Width = 94;
            // 
            // colServisTipiStr
            // 
            this.colServisTipiStr.Caption = "Servis Tipi";
            this.colServisTipiStr.FieldName = "ServisTipiStr";
            this.colServisTipiStr.Name = "colServisTipiStr";
            this.colServisTipiStr.OptionsColumn.ReadOnly = true;
            this.colServisTipiStr.Visible = true;
            this.colServisTipiStr.VisibleIndex = 6;
            this.colServisTipiStr.Width = 87;
            // 
            // colEmriKapatanKullanici
            // 
            this.colEmriKapatanKullanici.FieldName = "EmriKapatanKullanici";
            this.colEmriKapatanKullanici.Name = "colEmriKapatanKullanici";
            this.colEmriKapatanKullanici.Visible = true;
            this.colEmriKapatanKullanici.VisibleIndex = 12;
            this.colEmriKapatanKullanici.Width = 125;
            // 
            // colKapatmaTarihSaati
            // 
            this.colKapatmaTarihSaati.FieldName = "KapatmaTarihSaati";
            this.colKapatmaTarihSaati.Name = "colKapatmaTarihSaati";
            this.colKapatmaTarihSaati.Visible = true;
            this.colKapatmaTarihSaati.VisibleIndex = 13;
            this.colKapatmaTarihSaati.Width = 118;
            // 
            // colHareketDurumuStr
            // 
            this.colHareketDurumuStr.FieldName = "HareketDurumuStr";
            this.colHareketDurumuStr.Name = "colHareketDurumuStr";
            this.colHareketDurumuStr.OptionsColumn.ReadOnly = true;
            this.colHareketDurumuStr.Width = 107;
            // 
            // colEkleyenKullanici
            // 
            this.colEkleyenKullanici.FieldName = "EkleyenKullanici";
            this.colEkleyenKullanici.Name = "colEkleyenKullanici";
            this.colEkleyenKullanici.Width = 89;
            // 
            // colEklemeTarihSaati
            // 
            this.colEklemeTarihSaati.FieldName = "EklemeTarihSaati";
            this.colEklemeTarihSaati.Name = "colEklemeTarihSaati";
            this.colEklemeTarihSaati.Width = 99;
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            // 
            // imgToolBar
            // 
            this.imgToolBar.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imgToolBar.ImageStream")));
            this.imgToolBar.Images.SetKeyName(0, "export_csv.png");
            this.imgToolBar.Images.SetKeyName(1, "export_excel.png");
            this.imgToolBar.Images.SetKeyName(2, "export_pdf.png");
            this.imgToolBar.Images.SetKeyName(3, "export_text.png");
            // 
            // tblIsEmirleriTableAdapter
            // 
            this.tblIsEmirleriTableAdapter.ClearBeforeFill = true;
            // 
            // frmIsEmirleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 634);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmIsEmirleri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "[İŞ EMİRLERİ]";
            this.Load += new System.EventHandler(this.frmIsEmirleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblIsEmirleriBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgToolBar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Dataset dataset;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btnYenile;
        private DevExpress.XtraBars.BarButtonItem btnDuzenle;
        private DevExpress.XtraBars.BarButtonItem btnEkle;
        private DevExpress.XtraBars.BarButtonItem btnSil;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem btnExcel;
        private DevExpress.XtraBars.BarButtonItem btnText;
        private DevExpress.XtraBars.BarButtonItem btnCsv;
        private DevExpress.XtraBars.BarButtonItem btnPdf;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox1;
        private DevExpress.Utils.ImageCollection imgMenu;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private DevExpress.XtraBars.BarButtonItem barButtonItem6;
        private DatasetTableAdapters.sorgular sorgular1;
        private DevExpress.Utils.ImageCollection imgToolBar;
        private System.Windows.Forms.BindingSource tblIsEmirleriBindingSource;
        private DatasetTableAdapters.tblIsEmirleriTableAdapter tblIsEmirleriTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colEvrakNo;
        private DevExpress.XtraGrid.Columns.GridColumn colTarih;
        private DevExpress.XtraGrid.Columns.GridColumn colPersonel;
        private DevExpress.XtraGrid.Columns.GridColumn colMusteriKodu;
        private DevExpress.XtraGrid.Columns.GridColumn colSikayet;
        private DevExpress.XtraGrid.Columns.GridColumn colServisTipi;
        private DevExpress.XtraGrid.Columns.GridColumn colYapilanlar;
        private DevExpress.XtraGrid.Columns.GridColumn colAciklama;
        private DevExpress.XtraGrid.Columns.GridColumn colEmriVeren;
        private DevExpress.XtraGrid.Columns.GridColumn colVerisTarihSaati;
        private DevExpress.XtraGrid.Columns.GridColumn colHareketDurumu;
        private DevExpress.XtraGrid.Columns.GridColumn colUnvan1;
        private DevExpress.XtraGrid.Columns.GridColumn colServisFormNo;
        private DevExpress.XtraGrid.Columns.GridColumn colServisTipiStr;
        private DevExpress.XtraGrid.Columns.GridColumn colEmriKapatanKullanici;
        private DevExpress.XtraGrid.Columns.GridColumn colKapatmaTarihSaati;
        private DevExpress.XtraGrid.Columns.GridColumn colHareketDurumuStr;
        private DevExpress.XtraGrid.Columns.GridColumn colEkleyenKullanici;
        private DevExpress.XtraGrid.Columns.GridColumn colEklemeTarihSaati;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
    }
}