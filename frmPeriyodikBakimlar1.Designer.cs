namespace TeknikServis
{
    partial class frmPeriyodikBakimlar1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPeriyodikBakimlar1));
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition1 = new DevExpress.XtraGrid.StyleFormatCondition();
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition2 = new DevExpress.XtraGrid.StyleFormatCondition();
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition3 = new DevExpress.XtraGrid.StyleFormatCondition();
            this.colDetayHareketDurumu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tblBakimAnlasmalari1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataset = new TeknikServis.Dataset();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnYenile = new DevExpress.XtraBars.BarButtonItem();
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
            this.tblBakimAnlasmalari1TableAdapter = new TeknikServis.DatasetTableAdapters.tblBakimAnlasmalari1TableAdapter();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.tblBakimAnlasmasiDetayBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEvrakNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHareketDurumu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAciklama = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEvrakTarihi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMusteriKodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnvan1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBaslangicTarih = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBitisTarihi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPeriyotAraligi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBakimBilgisi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNotlar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBakimTarihi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAciklama1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKapatanServisFormNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDetayHareketDurumuStr = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDetayID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.imgToolBar = new DevExpress.Utils.ImageCollection(this.components);
            this.tblBakimAnlasmasi_DetayTableAdapter = new TeknikServis.DatasetTableAdapters.tblBakimAnlasmasi_DetayTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tblBakimAnlasmalari1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblBakimAnlasmasiDetayBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgToolBar)).BeginInit();
            this.SuspendLayout();
            // 
            // colDetayHareketDurumu
            // 
            this.colDetayHareketDurumu.FieldName = "DetayHareketDurumu";
            this.colDetayHareketDurumu.Name = "colDetayHareketDurumu";
            this.colDetayHareketDurumu.Width = 132;
            // 
            // tblBakimAnlasmalari1BindingSource
            // 
            this.tblBakimAnlasmalari1BindingSource.DataMember = "tblBakimAnlasmalari1";
            this.tblBakimAnlasmalari1BindingSource.DataSource = this.dataset;
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
            this.barButtonItem1,
            this.barButtonItem2,
            this.barButtonItem3,
            this.barButtonItem4,
            this.barButtonItem5,
            this.barButtonItem6,
            this.btnExcel,
            this.btnText,
            this.btnCsv,
            this.btnPdf});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 17;
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
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnYenile, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
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
            // 
            // btnText
            // 
            this.btnText.Caption = "TEXT";
            this.btnText.Id = 13;
            this.btnText.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnText.ItemAppearance.Normal.Options.UseFont = true;
            this.btnText.Name = "btnText";
            // 
            // btnCsv
            // 
            this.btnCsv.Caption = "CSV";
            this.btnCsv.Id = 14;
            this.btnCsv.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnCsv.ItemAppearance.Normal.Options.UseFont = true;
            this.btnCsv.Name = "btnCsv";
            // 
            // btnPdf
            // 
            this.btnPdf.Caption = "PDF";
            this.btnPdf.Id = 15;
            this.btnPdf.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnPdf.ItemAppearance.Normal.Options.UseFont = true;
            this.btnPdf.Name = "btnPdf";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(1156, 34);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 680);
            this.barDockControlBottom.Size = new System.Drawing.Size(1156, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 34);
            this.barDockControlLeft.Size = new System.Drawing.Size(26, 646);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1156, 34);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 646);
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
            // tblBakimAnlasmalari1TableAdapter
            // 
            this.tblBakimAnlasmalari1TableAdapter.ClearBeforeFill = true;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.tblBakimAnlasmasiDetayBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(26, 34);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.MenuManager = this.barManager1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemComboBox1});
            this.gridControl1.Size = new System.Drawing.Size(1130, 646);
            this.gridControl1.TabIndex = 7;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // tblBakimAnlasmasiDetayBindingSource
            // 
            this.tblBakimAnlasmasiDetayBindingSource.DataMember = "tblBakimAnlasmasi_Detay";
            this.tblBakimAnlasmasiDetayBindingSource.DataSource = this.dataset;
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
            this.colID,
            this.colEvrakNo,
            this.colHareketDurumu,
            this.colAciklama,
            this.colEvrakTarihi,
            this.colMusteriKodu,
            this.colUnvan1,
            this.colBaslangicTarih,
            this.colBitisTarihi,
            this.colPeriyotAraligi,
            this.colBakimBilgisi,
            this.colNotlar,
            this.colBakimTarihi,
            this.colAciklama1,
            this.colDetayHareketDurumu,
            this.colKapatanServisFormNo,
            this.colDetayHareketDurumuStr,
            this.colDetayID});
            styleFormatCondition1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            styleFormatCondition1.Appearance.Options.UseBackColor = true;
            styleFormatCondition1.ApplyToRow = true;
            styleFormatCondition1.Column = this.colDetayHareketDurumu;
            styleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal;
            styleFormatCondition1.Value1 = "0";
            styleFormatCondition2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            styleFormatCondition2.Appearance.Options.UseBackColor = true;
            styleFormatCondition2.ApplyToRow = true;
            styleFormatCondition2.Column = this.colDetayHareketDurumu;
            styleFormatCondition2.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal;
            styleFormatCondition2.Value1 = "1";
            styleFormatCondition3.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Strikeout);
            styleFormatCondition3.Appearance.Options.UseFont = true;
            styleFormatCondition3.ApplyToRow = true;
            styleFormatCondition3.Column = this.colHareketDurumu;
            styleFormatCondition3.Value1 = "1";
            this.gridView1.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[] {
            styleFormatCondition1,
            styleFormatCondition2,
            styleFormatCondition3});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.GroupCount = 1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.EnableAppearanceOddRow = true;
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colUnvan1, DevExpress.Data.ColumnSortOrder.Ascending)});
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
            // colHareketDurumu
            // 
            this.colHareketDurumu.FieldName = "HareketDurumu";
            this.colHareketDurumu.Name = "colHareketDurumu";
            this.colHareketDurumu.OptionsColumn.ReadOnly = true;
            this.colHareketDurumu.Visible = true;
            this.colHareketDurumu.VisibleIndex = 1;
            this.colHareketDurumu.Width = 100;
            // 
            // colAciklama
            // 
            this.colAciklama.FieldName = "Aciklama";
            this.colAciklama.Name = "colAciklama";
            this.colAciklama.Visible = true;
            this.colAciklama.VisibleIndex = 2;
            // 
            // colEvrakTarihi
            // 
            this.colEvrakTarihi.FieldName = "EvrakTarihi";
            this.colEvrakTarihi.Name = "colEvrakTarihi";
            this.colEvrakTarihi.Visible = true;
            this.colEvrakTarihi.VisibleIndex = 3;
            this.colEvrakTarihi.Width = 78;
            // 
            // colMusteriKodu
            // 
            this.colMusteriKodu.FieldName = "MusteriKodu";
            this.colMusteriKodu.Name = "colMusteriKodu";
            this.colMusteriKodu.Visible = true;
            this.colMusteriKodu.VisibleIndex = 4;
            this.colMusteriKodu.Width = 84;
            // 
            // colUnvan1
            // 
            this.colUnvan1.FieldName = "Unvan1";
            this.colUnvan1.Name = "colUnvan1";
            this.colUnvan1.Visible = true;
            this.colUnvan1.VisibleIndex = 5;
            // 
            // colBaslangicTarih
            // 
            this.colBaslangicTarih.FieldName = "BaslangicTarih";
            this.colBaslangicTarih.Name = "colBaslangicTarih";
            this.colBaslangicTarih.Visible = true;
            this.colBaslangicTarih.VisibleIndex = 5;
            this.colBaslangicTarih.Width = 93;
            // 
            // colBitisTarihi
            // 
            this.colBitisTarihi.FieldName = "BitisTarihi";
            this.colBitisTarihi.Name = "colBitisTarihi";
            this.colBitisTarihi.Visible = true;
            this.colBitisTarihi.VisibleIndex = 6;
            // 
            // colPeriyotAraligi
            // 
            this.colPeriyotAraligi.FieldName = "PeriyotAraligi";
            this.colPeriyotAraligi.Name = "colPeriyotAraligi";
            this.colPeriyotAraligi.Visible = true;
            this.colPeriyotAraligi.VisibleIndex = 7;
            this.colPeriyotAraligi.Width = 88;
            // 
            // colBakimBilgisi
            // 
            this.colBakimBilgisi.FieldName = "BakimBilgisi";
            this.colBakimBilgisi.Name = "colBakimBilgisi";
            this.colBakimBilgisi.Visible = true;
            this.colBakimBilgisi.VisibleIndex = 8;
            this.colBakimBilgisi.Width = 77;
            // 
            // colNotlar
            // 
            this.colNotlar.FieldName = "Notlar";
            this.colNotlar.Name = "colNotlar";
            this.colNotlar.Visible = true;
            this.colNotlar.VisibleIndex = 9;
            // 
            // colBakimTarihi
            // 
            this.colBakimTarihi.FieldName = "BakimTarihi";
            this.colBakimTarihi.Name = "colBakimTarihi";
            this.colBakimTarihi.Visible = true;
            this.colBakimTarihi.VisibleIndex = 10;
            this.colBakimTarihi.Width = 78;
            // 
            // colAciklama1
            // 
            this.colAciklama1.FieldName = "Aciklama1";
            this.colAciklama1.Name = "colAciklama1";
            this.colAciklama1.Visible = true;
            this.colAciklama1.VisibleIndex = 11;
            // 
            // colKapatanServisFormNo
            // 
            this.colKapatanServisFormNo.FieldName = "KapatanServisFormNo";
            this.colKapatanServisFormNo.Name = "colKapatanServisFormNo";
            this.colKapatanServisFormNo.Visible = true;
            this.colKapatanServisFormNo.VisibleIndex = 13;
            this.colKapatanServisFormNo.Width = 137;
            // 
            // colDetayHareketDurumuStr
            // 
            this.colDetayHareketDurumuStr.Caption = "Detay Durumu";
            this.colDetayHareketDurumuStr.FieldName = "DetayHareketDurumuStr";
            this.colDetayHareketDurumuStr.Name = "colDetayHareketDurumuStr";
            this.colDetayHareketDurumuStr.OptionsColumn.ReadOnly = true;
            this.colDetayHareketDurumuStr.Visible = true;
            this.colDetayHareketDurumuStr.VisibleIndex = 12;
            this.colDetayHareketDurumuStr.Width = 149;
            // 
            // colDetayID
            // 
            this.colDetayID.FieldName = "DetayID";
            this.colDetayID.Name = "colDetayID";
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
            // imgToolBar
            // 
            this.imgToolBar.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imgToolBar.ImageStream")));
            this.imgToolBar.Images.SetKeyName(0, "export_csv.png");
            this.imgToolBar.Images.SetKeyName(1, "export_excel.png");
            this.imgToolBar.Images.SetKeyName(2, "export_pdf.png");
            this.imgToolBar.Images.SetKeyName(3, "export_text.png");
            // 
            // tblBakimAnlasmasi_DetayTableAdapter
            // 
            this.tblBakimAnlasmasi_DetayTableAdapter.ClearBeforeFill = true;
            // 
            // frmPeriyodikBakimlar1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1156, 680);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmPeriyodikBakimlar1";
            this.Text = "[PERİYODİK BAKIMLAR #1]";
            this.Load += new System.EventHandler(this.frmPeriyodikBakimlar1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblBakimAnlasmalari1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblBakimAnlasmasiDetayBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgToolBar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource tblBakimAnlasmalari1BindingSource;
        private Dataset dataset;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btnYenile;
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
        private DatasetTableAdapters.tblBakimAnlasmalari1TableAdapter tblBakimAnlasmalari1TableAdapter;
        private DevExpress.Utils.ImageCollection imgToolBar;
        private System.Windows.Forms.BindingSource tblBakimAnlasmasiDetayBindingSource;
        private DatasetTableAdapters.tblBakimAnlasmasi_DetayTableAdapter tblBakimAnlasmasi_DetayTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colEvrakNo;
        private DevExpress.XtraGrid.Columns.GridColumn colHareketDurumu;
        private DevExpress.XtraGrid.Columns.GridColumn colAciklama;
        private DevExpress.XtraGrid.Columns.GridColumn colEvrakTarihi;
        private DevExpress.XtraGrid.Columns.GridColumn colMusteriKodu;
        private DevExpress.XtraGrid.Columns.GridColumn colUnvan1;
        private DevExpress.XtraGrid.Columns.GridColumn colBaslangicTarih;
        private DevExpress.XtraGrid.Columns.GridColumn colBitisTarihi;
        private DevExpress.XtraGrid.Columns.GridColumn colPeriyotAraligi;
        private DevExpress.XtraGrid.Columns.GridColumn colBakimBilgisi;
        private DevExpress.XtraGrid.Columns.GridColumn colNotlar;
        private DevExpress.XtraGrid.Columns.GridColumn colBakimTarihi;
        private DevExpress.XtraGrid.Columns.GridColumn colAciklama1;
        private DevExpress.XtraGrid.Columns.GridColumn colDetayHareketDurumu;
        private DevExpress.XtraGrid.Columns.GridColumn colKapatanServisFormNo;
        private DevExpress.XtraGrid.Columns.GridColumn colDetayHareketDurumuStr;
        private DevExpress.XtraGrid.Columns.GridColumn colDetayID;
    }
}