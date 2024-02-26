namespace TeknikServis
{
    partial class frmServisFormu
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
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmServisFormu));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtUnvan1 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtTel = new DevExpress.XtraEditors.TextEdit();
            this.txtVergiDairesi = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtVergiNo = new DevExpress.XtraEditors.TextEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl15 = new DevExpress.XtraEditors.LabelControl();
            this.lblArizaVeBakimEvrakBaslik = new DevExpress.XtraEditors.LabelControl();
            this.txtArizaFormNo = new DevExpress.XtraEditors.ButtonEdit();
            this.labelControl14 = new DevExpress.XtraEditors.LabelControl();
            this.txtMusteri = new DevExpress.XtraEditors.GridLookUpEdit();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.cariTanimlariBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataset = new TeknikServis.Dataset();
            this.txtMusteriView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHesapKodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnvan1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnvan2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAdres1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAdres2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAdres3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVergiDairesi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVergiHesapNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTelefon1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.txtAdres2 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.txtAdres1 = new DevExpress.XtraEditors.TextEdit();
            this.cmbIslemTipi = new DevExpress.XtraEditors.ComboBoxEdit();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.btnTikerSil = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.tblServiseGidenPersonellerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gwTekniker = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colServisEvrakNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKullaniciAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAdiSoyadi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemGridLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.tblKullanicilarLookUpBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colAdiSoyadi1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.dtEvrakTaihi = new DevExpress.XtraEditors.DateEdit();
            this.txtEvrakNo = new DevExpress.XtraEditors.ButtonEdit();
            this.txtIsEmri = new DevExpress.XtraEditors.ButtonEdit();
            this.tblServisFormlariBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblKullanilanMalzemelerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblStokKartlariBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cariTanimlariTableAdapter = new TeknikServis.DatasetTableAdapters.CariTanimlariTableAdapter();
            this.tblServiseGidenPersonellerTableAdapter = new TeknikServis.DatasetTableAdapters.tblServiseGidenPersonellerTableAdapter();
            this.tblKullanicilar_LookUpTableAdapter = new TeknikServis.DatasetTableAdapters.tblKullanicilar_LookUpTableAdapter();
            this.tblKullanilanMalzemelerTableAdapter = new TeknikServis.DatasetTableAdapters.tblKullanilanMalzemelerTableAdapter();
            this.tblStokKartlariTableAdapter = new TeknikServis.DatasetTableAdapters.tblStokKartlariTableAdapter();
            this.barManager2 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnYenile = new DevExpress.XtraBars.BarButtonItem();
            this.btnKaydet = new DevExpress.XtraBars.BarButtonItem();
            this.btnSil = new DevExpress.XtraBars.BarButtonItem();
            this.btnYazdir = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControl1 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl2 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl3 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl4 = new DevExpress.XtraBars.BarDockControl();
            this.imgMenu = new DevExpress.Utils.ImageCollection(this.components);
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.txtGenelTutar = new DevExpress.XtraEditors.TextEdit();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.txtMalzemeTutari = new DevExpress.XtraEditors.TextEdit();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.txtHizmetTutari = new DevExpress.XtraEditors.TextEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colStokAdi1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStokKodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.pageServisNotu = new DevExpress.XtraTab.XtraTabPage();
            this.txtServisNotu = new DevExpress.XtraEditors.MemoEdit();
            this.pageNotlar = new DevExpress.XtraTab.XtraTabPage();
            this.txtNotlar = new DevExpress.XtraEditors.MemoEdit();
            this.pageKullanilanMalzemeler = new DevExpress.XtraTab.XtraTabPage();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.gwKullanilanMalzemeler = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStokAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemGridLookUpEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.colAciklama = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAciklama1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMiktar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.maskMiktar = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colBirimFiyat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.maskBirimFiyat = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colTutar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.maskTutar = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colServisEvrakNo1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pageArizaBilgileri = new DevExpress.XtraTab.XtraTabPage();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.groupControl5 = new DevExpress.XtraEditors.GroupControl();
            this.txtArizaliUrunler = new DevExpress.XtraEditors.MemoEdit();
            this.groupControl6 = new DevExpress.XtraEditors.GroupControl();
            this.txtAriza = new DevExpress.XtraEditors.MemoEdit();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.dtBaslangicTarihSaati = new DevExpress.XtraEditors.DateEdit();
            this.dtBitisTarihSaati = new DevExpress.XtraEditors.DateEdit();
            this.colID3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colServisFormID2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAciklama2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAciklama11 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMiktar1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBirimFiyat1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTutar1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colID4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colServisFormID3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStokAdi2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAciklama3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAciklama12 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMiktar2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBirimFiyat2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTutar2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sorgular1 = new TeknikServis.DatasetTableAdapters.sorgular();
            this.tblServisFormlariTableAdapter = new TeknikServis.DatasetTableAdapters.tblServisFormlariTableAdapter();
            this.tblArizaFormlariTableAdapter1 = new TeknikServis.DatasetTableAdapters.tblArizaFormlariTableAdapter();
            this.report1 = new FastReport.Report();
            ((System.ComponentModel.ISupportInitialize)(this.txtUnvan1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVergiDairesi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVergiNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtArizaFormNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMusteri.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cariTanimlariBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMusteriView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAdres2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAdres1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbIslemTipi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblServiseGidenPersonellerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gwTekniker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblKullanicilarLookUpBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtEvrakTaihi.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtEvrakTaihi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEvrakNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIsEmri.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblServisFormlariBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblKullanilanMalzemelerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblStokKartlariBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
            this.groupControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtGenelTutar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMalzemeTutari.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHizmetTutari.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.pageServisNotu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtServisNotu.Properties)).BeginInit();
            this.pageNotlar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNotlar.Properties)).BeginInit();
            this.pageKullanilanMalzemeler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gwKullanilanMalzemeler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maskMiktar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maskBirimFiyat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maskTutar)).BeginInit();
            this.pageArizaBilgileri.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl5)).BeginInit();
            this.groupControl5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtArizaliUrunler.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl6)).BeginInit();
            this.groupControl6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAriza.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtBaslangicTarihSaati.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtBaslangicTarihSaati.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtBitisTarihSaati.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtBitisTarihSaati.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.report1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.labelControl1.Location = new System.Drawing.Point(14, 33);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(124, 20);
            this.labelControl1.TabIndex = 24;
            this.labelControl1.Text = "ÜNVAN-1";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.labelControl2.Location = new System.Drawing.Point(14, 59);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(124, 20);
            this.labelControl2.TabIndex = 26;
            this.labelControl2.Text = "ÜNVAN-2";
            // 
            // txtUnvan1
            // 
            this.txtUnvan1.Location = new System.Drawing.Point(138, 59);
            this.txtUnvan1.Name = "txtUnvan1";
            this.txtUnvan1.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtUnvan1.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtUnvan1.Properties.ReadOnly = true;
            this.txtUnvan1.Size = new System.Drawing.Size(327, 20);
            this.txtUnvan1.TabIndex = 29;
            this.txtUnvan1.TabStop = false;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.labelControl3.Location = new System.Drawing.Point(14, 136);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(124, 20);
            this.labelControl3.TabIndex = 28;
            this.labelControl3.Text = "TEL";
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(138, 136);
            this.txtTel.Name = "txtTel";
            this.txtTel.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtTel.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtTel.Properties.ReadOnly = true;
            this.txtTel.Size = new System.Drawing.Size(157, 20);
            this.txtTel.TabIndex = 30;
            this.txtTel.TabStop = false;
            // 
            // txtVergiDairesi
            // 
            this.txtVergiDairesi.Location = new System.Drawing.Point(138, 163);
            this.txtVergiDairesi.Name = "txtVergiDairesi";
            this.txtVergiDairesi.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtVergiDairesi.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtVergiDairesi.Properties.ReadOnly = true;
            this.txtVergiDairesi.Size = new System.Drawing.Size(157, 20);
            this.txtVergiDairesi.TabIndex = 32;
            this.txtVergiDairesi.TabStop = false;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl4.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl4.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.labelControl4.Location = new System.Drawing.Point(14, 163);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(124, 20);
            this.labelControl4.TabIndex = 31;
            this.labelControl4.Text = "VERGİ DAİRESİ && NO";
            // 
            // txtVergiNo
            // 
            this.txtVergiNo.Location = new System.Drawing.Point(295, 163);
            this.txtVergiNo.Name = "txtVergiNo";
            this.txtVergiNo.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtVergiNo.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtVergiNo.Properties.ReadOnly = true;
            this.txtVergiNo.Size = new System.Drawing.Size(170, 20);
            this.txtVergiNo.TabIndex = 33;
            this.txtVergiNo.TabStop = false;
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.Controls.Add(this.labelControl15);
            this.groupControl1.Controls.Add(this.lblArizaVeBakimEvrakBaslik);
            this.groupControl1.Controls.Add(this.txtArizaFormNo);
            this.groupControl1.Controls.Add(this.labelControl14);
            this.groupControl1.Controls.Add(this.txtMusteri);
            this.groupControl1.Controls.Add(this.labelControl10);
            this.groupControl1.Controls.Add(this.txtAdres2);
            this.groupControl1.Controls.Add(this.labelControl9);
            this.groupControl1.Controls.Add(this.txtAdres1);
            this.groupControl1.Controls.Add(this.cmbIslemTipi);
            this.groupControl1.Controls.Add(this.groupControl3);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.txtVergiNo);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.txtVergiDairesi);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.txtTel);
            this.groupControl1.Controls.Add(this.txtUnvan1);
            this.groupControl1.Controls.Add(this.dtEvrakTaihi);
            this.groupControl1.Controls.Add(this.txtEvrakNo);
            this.groupControl1.Controls.Add(this.txtIsEmri);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 34);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(983, 273);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "MÜŞTERİ BİLGİLERİ";
            // 
            // labelControl15
            // 
            this.labelControl15.Appearance.BackColor = System.Drawing.Color.Red;
            this.labelControl15.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.labelControl15.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl15.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl15.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.labelControl15.Location = new System.Drawing.Point(493, 33);
            this.labelControl15.Name = "labelControl15";
            this.labelControl15.Size = new System.Drawing.Size(82, 23);
            this.labelControl15.TabIndex = 53;
            this.labelControl15.Text = "İş Emri";
            // 
            // lblArizaVeBakimEvrakBaslik
            // 
            this.lblArizaVeBakimEvrakBaslik.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblArizaVeBakimEvrakBaslik.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblArizaVeBakimEvrakBaslik.Appearance.ForeColor = System.Drawing.Color.Black;
            this.lblArizaVeBakimEvrakBaslik.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblArizaVeBakimEvrakBaslik.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.lblArizaVeBakimEvrakBaslik.Location = new System.Drawing.Point(606, 92);
            this.lblArizaVeBakimEvrakBaslik.Name = "lblArizaVeBakimEvrakBaslik";
            this.lblArizaVeBakimEvrakBaslik.Size = new System.Drawing.Size(124, 20);
            this.lblArizaVeBakimEvrakBaslik.TabIndex = 52;
            this.lblArizaVeBakimEvrakBaslik.Text = "ARIZA FORM NO";
            // 
            // txtArizaFormNo
            // 
            this.txtArizaFormNo.EnterMoveNextControl = true;
            this.txtArizaFormNo.Location = new System.Drawing.Point(730, 92);
            this.txtArizaFormNo.Name = "txtArizaFormNo";
            this.txtArizaFormNo.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.txtArizaFormNo.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtArizaFormNo.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtArizaFormNo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.SpinLeft, "", 15, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F3), serializableAppearanceObject1, "", null, null, true),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4), serializableAppearanceObject2, "", null, null, true)});
            this.txtArizaFormNo.Properties.Mask.EditMask = "f0";
            this.txtArizaFormNo.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtArizaFormNo.Properties.MaxLength = 6;
            this.txtArizaFormNo.Properties.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.txtArizaFormNo_Properties_ButtonClick);
            this.txtArizaFormNo.Size = new System.Drawing.Size(111, 20);
            this.txtArizaFormNo.TabIndex = 5;
            this.txtArizaFormNo.Leave += new System.EventHandler(this.txtArizaFormNo_Leave);
            // 
            // labelControl14
            // 
            this.labelControl14.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.labelControl14.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl14.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl14.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl14.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.labelControl14.Location = new System.Drawing.Point(14, 196);
            this.labelControl14.Name = "labelControl14";
            this.labelControl14.Size = new System.Drawing.Size(124, 20);
            this.labelControl14.TabIndex = 51;
            this.labelControl14.Text = "İŞLEM TİPİ";
            // 
            // txtMusteri
            // 
            this.txtMusteri.EditValue = "";
            this.txtMusteri.EnterMoveNextControl = true;
            this.txtMusteri.Location = new System.Drawing.Point(138, 33);
            this.txtMusteri.MenuManager = this.barManager1;
            this.txtMusteri.Name = "txtMusteri";
            this.txtMusteri.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtMusteri.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtMusteri.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit;
            this.txtMusteri.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtMusteri.Properties.DataSource = this.cariTanimlariBindingSource;
            this.txtMusteri.Properties.DisplayMember = "Unvan1";
            this.txtMusteri.Properties.ImmediatePopup = true;
            this.txtMusteri.Properties.NullText = "";
            this.txtMusteri.Properties.PopupFormSize = new System.Drawing.Size(600, 0);
            this.txtMusteri.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.txtMusteri.Properties.ValueMember = "HesapKodu";
            this.txtMusteri.Properties.View = this.txtMusteriView;
            this.txtMusteri.Properties.ViewType = DevExpress.XtraEditors.Repository.GridLookUpViewType.GridView;
            this.txtMusteri.Size = new System.Drawing.Size(327, 20);
            this.txtMusteri.TabIndex = 1;
            this.txtMusteri.Closed += new DevExpress.XtraEditors.Controls.ClosedEventHandler(this.txtMusteri_Closed);
            // 
            // barManager1
            // 
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.MaxItemId = 219;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 34);
            this.barDockControlTop.Size = new System.Drawing.Size(983, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 727);
            this.barDockControlBottom.Size = new System.Drawing.Size(983, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 34);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 693);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(983, 34);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 693);
            // 
            // cariTanimlariBindingSource
            // 
            this.cariTanimlariBindingSource.DataMember = "CariTanimlari";
            this.cariTanimlariBindingSource.DataSource = this.dataset;
            // 
            // dataset
            // 
            this.dataset.DataSetName = "Dataset";
            this.dataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtMusteriView
            // 
            this.txtMusteriView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colHesapKodu,
            this.colUnvan1,
            this.colUnvan2,
            this.colAdres1,
            this.colAdres2,
            this.colAdres3,
            this.colVergiDairesi,
            this.colVergiHesapNo,
            this.colTelefon1});
            this.txtMusteriView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.txtMusteriView.Name = "txtMusteriView";
            this.txtMusteriView.OptionsBehavior.Editable = false;
            this.txtMusteriView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.txtMusteriView.OptionsView.ColumnAutoWidth = false;
            this.txtMusteriView.OptionsView.ShowGroupPanel = false;
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.OptionsColumn.ReadOnly = true;
            // 
            // colHesapKodu
            // 
            this.colHesapKodu.FieldName = "HesapKodu";
            this.colHesapKodu.Name = "colHesapKodu";
            this.colHesapKodu.Visible = true;
            this.colHesapKodu.VisibleIndex = 0;
            this.colHesapKodu.Width = 154;
            // 
            // colUnvan1
            // 
            this.colUnvan1.FieldName = "Unvan1";
            this.colUnvan1.Name = "colUnvan1";
            this.colUnvan1.Visible = true;
            this.colUnvan1.VisibleIndex = 1;
            this.colUnvan1.Width = 223;
            // 
            // colUnvan2
            // 
            this.colUnvan2.FieldName = "Unvan2";
            this.colUnvan2.Name = "colUnvan2";
            this.colUnvan2.Visible = true;
            this.colUnvan2.VisibleIndex = 2;
            this.colUnvan2.Width = 193;
            // 
            // colAdres1
            // 
            this.colAdres1.FieldName = "Adres1";
            this.colAdres1.Name = "colAdres1";
            // 
            // colAdres2
            // 
            this.colAdres2.FieldName = "Adres2";
            this.colAdres2.Name = "colAdres2";
            // 
            // colAdres3
            // 
            this.colAdres3.FieldName = "Adres3";
            this.colAdres3.Name = "colAdres3";
            // 
            // colVergiDairesi
            // 
            this.colVergiDairesi.FieldName = "VergiDairesi";
            this.colVergiDairesi.Name = "colVergiDairesi";
            // 
            // colVergiHesapNo
            // 
            this.colVergiHesapNo.FieldName = "VergiHesapNo";
            this.colVergiHesapNo.Name = "colVergiHesapNo";
            this.colVergiHesapNo.Width = 85;
            // 
            // colTelefon1
            // 
            this.colTelefon1.FieldName = "Telefon1";
            this.colTelefon1.Name = "colTelefon1";
            this.colTelefon1.Visible = true;
            this.colTelefon1.VisibleIndex = 3;
            this.colTelefon1.Width = 168;
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl10.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl10.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl10.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.labelControl10.Location = new System.Drawing.Point(14, 111);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(124, 20);
            this.labelControl10.TabIndex = 48;
            this.labelControl10.Text = "ADRES-2";
            // 
            // txtAdres2
            // 
            this.txtAdres2.Location = new System.Drawing.Point(138, 111);
            this.txtAdres2.Name = "txtAdres2";
            this.txtAdres2.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtAdres2.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtAdres2.Properties.ReadOnly = true;
            this.txtAdres2.Size = new System.Drawing.Size(327, 20);
            this.txtAdres2.TabIndex = 49;
            this.txtAdres2.TabStop = false;
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl9.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl9.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl9.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.labelControl9.Location = new System.Drawing.Point(14, 85);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(124, 20);
            this.labelControl9.TabIndex = 46;
            this.labelControl9.Text = "ADRES-1";
            // 
            // txtAdres1
            // 
            this.txtAdres1.Location = new System.Drawing.Point(138, 85);
            this.txtAdres1.Name = "txtAdres1";
            this.txtAdres1.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtAdres1.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtAdres1.Properties.ReadOnly = true;
            this.txtAdres1.Size = new System.Drawing.Size(327, 20);
            this.txtAdres1.TabIndex = 47;
            this.txtAdres1.TabStop = false;
            // 
            // cmbIslemTipi
            // 
            this.cmbIslemTipi.EnterMoveNextControl = true;
            this.cmbIslemTipi.Location = new System.Drawing.Point(138, 196);
            this.cmbIslemTipi.MenuManager = this.barManager1;
            this.cmbIslemTipi.Name = "cmbIslemTipi";
            this.cmbIslemTipi.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cmbIslemTipi.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.5F);
            this.cmbIslemTipi.Properties.Appearance.Options.UseBackColor = true;
            this.cmbIslemTipi.Properties.Appearance.Options.UseFont = true;
            this.cmbIslemTipi.Properties.Appearance.Options.UseTextOptions = true;
            this.cmbIslemTipi.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.cmbIslemTipi.Properties.AppearanceDropDown.Font = new System.Drawing.Font("Tahoma", 25F);
            this.cmbIslemTipi.Properties.AppearanceDropDown.Options.UseFont = true;
            serializableAppearanceObject3.BackColor = System.Drawing.Color.Red;
            serializableAppearanceObject3.BorderColor = System.Drawing.Color.Red;
            serializableAppearanceObject3.Options.UseBackColor = true;
            serializableAppearanceObject3.Options.UseBorderColor = true;
            this.cmbIslemTipi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.DropDown, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject3, "", null, null, true)});
            this.cmbIslemTipi.Properties.ImmediatePopup = true;
            this.cmbIslemTipi.Properties.Items.AddRange(new object[] {
            "TEKNİK SERVİS FORMU",
            "ŞİRKET İÇİ SERVİS",
            "PERİYODİK BAKIM FORMU"});
            this.cmbIslemTipi.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cmbIslemTipi.Size = new System.Drawing.Size(157, 20);
            this.cmbIslemTipi.TabIndex = 2;
            this.cmbIslemTipi.SelectedIndexChanged += new System.EventHandler(this.cmbIslemTipi_SelectedIndexChanged);
            // 
            // groupControl3
            // 
            this.groupControl3.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.groupControl3.AppearanceCaption.Options.UseFont = true;
            this.groupControl3.Controls.Add(this.btnTikerSil);
            this.groupControl3.Controls.Add(this.gridControl1);
            this.groupControl3.Location = new System.Drawing.Point(606, 118);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(235, 140);
            this.groupControl3.TabIndex = 6;
            this.groupControl3.Text = "TEKNİKER";
            // 
            // btnTikerSil
            // 
            this.btnTikerSil.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnTikerSil.Appearance.ForeColor = System.Drawing.Color.Red;
            this.btnTikerSil.Appearance.Options.UseFont = true;
            this.btnTikerSil.Appearance.Options.UseForeColor = true;
            this.btnTikerSil.Location = new System.Drawing.Point(210, 3);
            this.btnTikerSil.Name = "btnTikerSil";
            this.btnTikerSil.Size = new System.Drawing.Size(20, 15);
            this.btnTikerSil.TabIndex = 51;
            this.btnTikerSil.Text = "X";
            this.btnTikerSil.Click += new System.EventHandler(this.btnTikerSil_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.tblServiseGidenPersonellerBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(2, 21);
            this.gridControl1.MainView = this.gwTekniker;
            this.gridControl1.MenuManager = this.barManager1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemGridLookUpEdit1});
            this.gridControl1.Size = new System.Drawing.Size(231, 117);
            this.gridControl1.TabIndex = 7;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gwTekniker});
            // 
            // tblServiseGidenPersonellerBindingSource
            // 
            this.tblServiseGidenPersonellerBindingSource.DataMember = "tblServiseGidenPersoneller";
            this.tblServiseGidenPersonellerBindingSource.DataSource = this.dataset;
            // 
            // gwTekniker
            // 
            this.gwTekniker.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID1,
            this.colServisEvrakNo,
            this.colKullaniciAdi,
            this.colAdiSoyadi});
            this.gwTekniker.GridControl = this.gridControl1;
            this.gwTekniker.Name = "gwTekniker";
            this.gwTekniker.OptionsNavigation.AutoFocusNewRow = true;
            this.gwTekniker.OptionsNavigation.EnterMoveNextColumn = true;
            this.gwTekniker.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gwTekniker.OptionsView.ColumnAutoWidth = false;
            this.gwTekniker.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gwTekniker.OptionsView.ShowGroupPanel = false;
            this.gwTekniker.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gwTekniker_KeyDown);
            // 
            // colID1
            // 
            this.colID1.FieldName = "ID";
            this.colID1.Name = "colID1";
            this.colID1.OptionsColumn.ReadOnly = true;
            // 
            // colServisEvrakNo
            // 
            this.colServisEvrakNo.FieldName = "ServisEvrakNo";
            this.colServisEvrakNo.Name = "colServisEvrakNo";
            // 
            // colKullaniciAdi
            // 
            this.colKullaniciAdi.FieldName = "KullaniciAdi";
            this.colKullaniciAdi.Name = "colKullaniciAdi";
            this.colKullaniciAdi.Width = 90;
            // 
            // colAdiSoyadi
            // 
            this.colAdiSoyadi.ColumnEdit = this.repositoryItemGridLookUpEdit1;
            this.colAdiSoyadi.FieldName = "AdiSoyadi";
            this.colAdiSoyadi.Name = "colAdiSoyadi";
            this.colAdiSoyadi.Visible = true;
            this.colAdiSoyadi.VisibleIndex = 0;
            this.colAdiSoyadi.Width = 206;
            // 
            // repositoryItemGridLookUpEdit1
            // 
            this.repositoryItemGridLookUpEdit1.AutoHeight = false;
            this.repositoryItemGridLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEdit1.DataSource = this.tblKullanicilarLookUpBindingSource;
            this.repositoryItemGridLookUpEdit1.DisplayMember = "AdiSoyadi";
            this.repositoryItemGridLookUpEdit1.ImmediatePopup = true;
            this.repositoryItemGridLookUpEdit1.Name = "repositoryItemGridLookUpEdit1";
            this.repositoryItemGridLookUpEdit1.NullText = "";
            this.repositoryItemGridLookUpEdit1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.repositoryItemGridLookUpEdit1.ValueMember = "AdiSoyadi";
            this.repositoryItemGridLookUpEdit1.View = this.gridView3;
            this.repositoryItemGridLookUpEdit1.ViewType = DevExpress.XtraEditors.Repository.GridLookUpViewType.GridView;
            this.repositoryItemGridLookUpEdit1.Closed += new DevExpress.XtraEditors.Controls.ClosedEventHandler(this.repositoryItemGridLookUpEdit1_Closed);
            // 
            // tblKullanicilarLookUpBindingSource
            // 
            this.tblKullanicilarLookUpBindingSource.DataMember = "tblKullanicilar_LookUp";
            this.tblKullanicilarLookUpBindingSource.DataSource = this.dataset;
            // 
            // gridView3
            // 
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colAdiSoyadi1});
            this.gridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView3.OptionsView.ShowGroupPanel = false;
            // 
            // colAdiSoyadi1
            // 
            this.colAdiSoyadi1.FieldName = "AdiSoyadi";
            this.colAdiSoyadi1.Name = "colAdiSoyadi1";
            this.colAdiSoyadi1.Visible = true;
            this.colAdiSoyadi1.VisibleIndex = 0;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl6.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl6.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl6.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.labelControl6.Location = new System.Drawing.Point(606, 59);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(124, 20);
            this.labelControl6.TabIndex = 37;
            this.labelControl6.Text = "EVRAK TARİHİ";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl5.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl5.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl5.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.labelControl5.Location = new System.Drawing.Point(606, 34);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(124, 20);
            this.labelControl5.TabIndex = 35;
            this.labelControl5.Text = "EVRAK NO";
            // 
            // dtEvrakTaihi
            // 
            this.dtEvrakTaihi.EditValue = null;
            this.dtEvrakTaihi.EnterMoveNextControl = true;
            this.dtEvrakTaihi.Location = new System.Drawing.Point(730, 59);
            this.dtEvrakTaihi.Name = "dtEvrakTaihi";
            this.dtEvrakTaihi.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.dtEvrakTaihi.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.dtEvrakTaihi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtEvrakTaihi.Properties.Mask.EditMask = "";
            this.dtEvrakTaihi.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.dtEvrakTaihi.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dtEvrakTaihi.Size = new System.Drawing.Size(111, 20);
            this.dtEvrakTaihi.TabIndex = 4;
            // 
            // txtEvrakNo
            // 
            this.txtEvrakNo.EnterMoveNextControl = true;
            this.txtEvrakNo.Location = new System.Drawing.Point(730, 34);
            this.txtEvrakNo.Name = "txtEvrakNo";
            this.txtEvrakNo.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtEvrakNo.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtEvrakNo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.SpinLeft, "", 15, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F3), serializableAppearanceObject4, "", null, null, true),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4), serializableAppearanceObject5, "", null, null, true)});
            this.txtEvrakNo.Properties.MaxLength = 6;
            this.txtEvrakNo.Properties.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.txtEvrakNo_Properties_ButtonClick);
            this.txtEvrakNo.Size = new System.Drawing.Size(111, 20);
            this.txtEvrakNo.TabIndex = 3;
            this.txtEvrakNo.Leave += new System.EventHandler(this.txtEvrakNo_Leave);
            // 
            // txtIsEmri
            // 
            this.txtIsEmri.EnterMoveNextControl = true;
            this.txtIsEmri.Location = new System.Drawing.Point(493, 55);
            this.txtIsEmri.MenuManager = this.barManager1;
            this.txtIsEmri.Name = "txtIsEmri";
            this.txtIsEmri.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4), serializableAppearanceObject6, "", null, null, true)});
            this.txtIsEmri.Properties.MaxLength = 6;
            this.txtIsEmri.Properties.ReadOnly = true;
            this.txtIsEmri.Properties.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.txtIsEmri_Properties_ButtonClick);
            this.txtIsEmri.Size = new System.Drawing.Size(82, 20);
            this.txtIsEmri.TabIndex = 2;
            this.txtIsEmri.TabStop = false;
            // 
            // tblServisFormlariBindingSource
            // 
            this.tblServisFormlariBindingSource.DataMember = "tblServisFormlari";
            this.tblServisFormlariBindingSource.DataSource = this.dataset;
            // 
            // tblKullanilanMalzemelerBindingSource
            // 
            this.tblKullanilanMalzemelerBindingSource.DataMember = "tblKullanilanMalzemeler";
            this.tblKullanilanMalzemelerBindingSource.DataSource = this.dataset;
            // 
            // tblStokKartlariBindingSource
            // 
            this.tblStokKartlariBindingSource.DataMember = "tblStokKartlari";
            this.tblStokKartlariBindingSource.DataSource = this.dataset;
            // 
            // cariTanimlariTableAdapter
            // 
            this.cariTanimlariTableAdapter.ClearBeforeFill = true;
            // 
            // tblServiseGidenPersonellerTableAdapter
            // 
            this.tblServiseGidenPersonellerTableAdapter.ClearBeforeFill = true;
            // 
            // tblKullanicilar_LookUpTableAdapter
            // 
            this.tblKullanicilar_LookUpTableAdapter.ClearBeforeFill = true;
            // 
            // tblKullanilanMalzemelerTableAdapter
            // 
            this.tblKullanilanMalzemelerTableAdapter.ClearBeforeFill = true;
            // 
            // tblStokKartlariTableAdapter
            // 
            this.tblStokKartlariTableAdapter.ClearBeforeFill = true;
            // 
            // barManager2
            // 
            this.barManager2.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2});
            this.barManager2.DockControls.Add(this.barDockControl1);
            this.barManager2.DockControls.Add(this.barDockControl2);
            this.barManager2.DockControls.Add(this.barDockControl3);
            this.barManager2.DockControls.Add(this.barDockControl4);
            this.barManager2.Form = this;
            this.barManager2.Images = this.imgMenu;
            this.barManager2.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnYenile,
            this.btnKaydet,
            this.btnSil,
            this.btnYazdir});
            this.barManager2.MainMenu = this.bar2;
            this.barManager2.MaxItemId = 4;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnYenile, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnKaydet, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnSil, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnYazdir, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
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
            // btnKaydet
            // 
            this.btnKaydet.Caption = "Kaydet";
            this.btnKaydet.Id = 1;
            this.btnKaydet.ImageIndex = 4;
            this.btnKaydet.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnKaydet.ItemAppearance.Normal.Options.UseFont = true;
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnKaydet_ItemClick);
            // 
            // btnSil
            // 
            this.btnSil.Caption = "Sil";
            this.btnSil.Id = 2;
            this.btnSil.ImageIndex = 1;
            this.btnSil.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnSil.ItemAppearance.Normal.Options.UseFont = true;
            this.btnSil.Name = "btnSil";
            this.btnSil.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSil_ItemClick);
            // 
            // btnYazdir
            // 
            this.btnYazdir.Caption = "Yazdir";
            this.btnYazdir.Id = 3;
            this.btnYazdir.ImageIndex = 5;
            this.btnYazdir.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnYazdir.ItemAppearance.Normal.Options.UseFont = true;
            this.btnYazdir.Name = "btnYazdir";
            this.btnYazdir.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnYazdir_ItemClick);
            // 
            // barDockControl1
            // 
            this.barDockControl1.CausesValidation = false;
            this.barDockControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControl1.Location = new System.Drawing.Point(0, 0);
            this.barDockControl1.Size = new System.Drawing.Size(983, 34);
            // 
            // barDockControl2
            // 
            this.barDockControl2.CausesValidation = false;
            this.barDockControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControl2.Location = new System.Drawing.Point(0, 727);
            this.barDockControl2.Size = new System.Drawing.Size(983, 0);
            // 
            // barDockControl3
            // 
            this.barDockControl3.CausesValidation = false;
            this.barDockControl3.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControl3.Location = new System.Drawing.Point(0, 34);
            this.barDockControl3.Size = new System.Drawing.Size(0, 693);
            // 
            // barDockControl4
            // 
            this.barDockControl4.CausesValidation = false;
            this.barDockControl4.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControl4.Location = new System.Drawing.Point(983, 34);
            this.barDockControl4.Size = new System.Drawing.Size(0, 693);
            // 
            // imgMenu
            // 
            this.imgMenu.ImageSize = new System.Drawing.Size(24, 24);
            this.imgMenu.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imgMenu.ImageStream")));
            this.imgMenu.Images.SetKeyName(0, "Add.png");
            this.imgMenu.Images.SetKeyName(1, "Delete.png");
            this.imgMenu.Images.SetKeyName(2, "Edit.png");
            this.imgMenu.Images.SetKeyName(3, "Refresh.png");
            this.imgMenu.Images.SetKeyName(4, "Save.png");
            this.imgMenu.Images.SetKeyName(5, "1387483055_print.png");
            // 
            // groupControl4
            // 
            this.groupControl4.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.groupControl4.AppearanceCaption.Options.UseFont = true;
            this.groupControl4.Controls.Add(this.labelControl11);
            this.groupControl4.Controls.Add(this.txtGenelTutar);
            this.groupControl4.Controls.Add(this.labelControl13);
            this.groupControl4.Controls.Add(this.txtMalzemeTutari);
            this.groupControl4.Controls.Add(this.labelControl12);
            this.groupControl4.Controls.Add(this.txtHizmetTutari);
            this.groupControl4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl4.Location = new System.Drawing.Point(2, 340);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.Size = new System.Drawing.Size(979, 78);
            this.groupControl4.TabIndex = 10;
            this.groupControl4.Text = "Faturalanacak";
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl11.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl11.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl11.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.labelControl11.Location = new System.Drawing.Point(706, 27);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(124, 20);
            this.labelControl11.TabIndex = 43;
            this.labelControl11.Text = "Genel Tutar";
            // 
            // txtGenelTutar
            // 
            this.txtGenelTutar.EditValue = "0";
            this.txtGenelTutar.EnterMoveNextControl = true;
            this.txtGenelTutar.Location = new System.Drawing.Point(706, 47);
            this.txtGenelTutar.Name = "txtGenelTutar";
            this.txtGenelTutar.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtGenelTutar.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtGenelTutar.Properties.Mask.EditMask = "n2";
            this.txtGenelTutar.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtGenelTutar.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtGenelTutar.Properties.NullText = "0";
            this.txtGenelTutar.Properties.ReadOnly = true;
            this.txtGenelTutar.Size = new System.Drawing.Size(124, 20);
            this.txtGenelTutar.TabIndex = 13;
            // 
            // labelControl13
            // 
            this.labelControl13.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.labelControl13.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl13.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl13.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl13.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.labelControl13.Location = new System.Drawing.Point(576, 27);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(124, 20);
            this.labelControl13.TabIndex = 41;
            this.labelControl13.Text = "Malzeme Tutar";
            // 
            // txtMalzemeTutari
            // 
            this.txtMalzemeTutari.EditValue = "0";
            this.txtMalzemeTutari.EnterMoveNextControl = true;
            this.txtMalzemeTutari.Location = new System.Drawing.Point(576, 47);
            this.txtMalzemeTutari.Name = "txtMalzemeTutari";
            this.txtMalzemeTutari.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtMalzemeTutari.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtMalzemeTutari.Properties.Mask.EditMask = "n2";
            this.txtMalzemeTutari.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtMalzemeTutari.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtMalzemeTutari.Properties.NullText = "0";
            this.txtMalzemeTutari.Properties.ReadOnly = true;
            this.txtMalzemeTutari.Size = new System.Drawing.Size(124, 20);
            this.txtMalzemeTutari.TabIndex = 12;
            this.txtMalzemeTutari.EditValueChanged += new System.EventHandler(this.txtMalzemeTutari_EditValueChanged);
            // 
            // labelControl12
            // 
            this.labelControl12.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.labelControl12.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl12.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl12.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl12.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.labelControl12.Location = new System.Drawing.Point(446, 27);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(124, 20);
            this.labelControl12.TabIndex = 39;
            this.labelControl12.Text = "Hizmet Tutar";
            // 
            // txtHizmetTutari
            // 
            this.txtHizmetTutari.EditValue = "0";
            this.txtHizmetTutari.EnterMoveNextControl = true;
            this.txtHizmetTutari.Location = new System.Drawing.Point(446, 47);
            this.txtHizmetTutari.Name = "txtHizmetTutari";
            this.txtHizmetTutari.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtHizmetTutari.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtHizmetTutari.Properties.Mask.EditMask = "n2";
            this.txtHizmetTutari.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtHizmetTutari.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtHizmetTutari.Properties.NullText = "0";
            this.txtHizmetTutari.Size = new System.Drawing.Size(124, 20);
            this.txtHizmetTutari.TabIndex = 11;
            this.txtHizmetTutari.EditValueChanged += new System.EventHandler(this.txtHizmetTutari_EditValueChanged);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colStokAdi1,
            this.colStokKodu});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colStokAdi1
            // 
            this.colStokAdi1.FieldName = "StokAdi";
            this.colStokAdi1.Name = "colStokAdi1";
            this.colStokAdi1.Visible = true;
            this.colStokAdi1.VisibleIndex = 0;
            // 
            // colStokKodu
            // 
            this.colStokKodu.FieldName = "StokKodu";
            this.colStokKodu.Name = "colStokKodu";
            // 
            // groupControl2
            // 
            this.groupControl2.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.groupControl2.AppearanceCaption.Options.UseFont = true;
            this.groupControl2.Controls.Add(this.xtraTabControl1);
            this.groupControl2.Controls.Add(this.panelControl1);
            this.groupControl2.Controls.Add(this.groupControl4);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 307);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(983, 420);
            this.groupControl2.TabIndex = 8;
            this.groupControl2.Text = "SERVİS BİLGİLERİ";
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.HeaderAutoFill = DevExpress.Utils.DefaultBoolean.False;
            this.xtraTabControl1.Location = new System.Drawing.Point(2, 87);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.PaintStyleName = "PropertyView";
            this.xtraTabControl1.SelectedTabPage = this.pageServisNotu;
            this.xtraTabControl1.Size = new System.Drawing.Size(979, 253);
            this.xtraTabControl1.TabIndex = 9;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.pageServisNotu,
            this.pageNotlar,
            this.pageKullanilanMalzemeler,
            this.pageArizaBilgileri});
            // 
            // pageServisNotu
            // 
            this.pageServisNotu.Appearance.HeaderActive.BackColor = System.Drawing.Color.Red;
            this.pageServisNotu.Appearance.HeaderActive.Options.UseBackColor = true;
            this.pageServisNotu.Controls.Add(this.txtServisNotu);
            this.pageServisNotu.Name = "pageServisNotu";
            this.pageServisNotu.Size = new System.Drawing.Size(977, 232);
            this.pageServisNotu.Text = "SERVİS NOTU";
            // 
            // txtServisNotu
            // 
            this.txtServisNotu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtServisNotu.Location = new System.Drawing.Point(0, 0);
            this.txtServisNotu.MenuManager = this.barManager1;
            this.txtServisNotu.Name = "txtServisNotu";
            this.txtServisNotu.Size = new System.Drawing.Size(977, 232);
            this.txtServisNotu.TabIndex = 1;
            // 
            // pageNotlar
            // 
            this.pageNotlar.Appearance.HeaderActive.BackColor = System.Drawing.Color.Red;
            this.pageNotlar.Appearance.HeaderActive.Options.UseBackColor = true;
            this.pageNotlar.Controls.Add(this.txtNotlar);
            this.pageNotlar.Name = "pageNotlar";
            this.pageNotlar.Size = new System.Drawing.Size(977, 232);
            this.pageNotlar.Text = "NOTLAR";
            // 
            // txtNotlar
            // 
            this.txtNotlar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNotlar.Location = new System.Drawing.Point(0, 0);
            this.txtNotlar.MenuManager = this.barManager1;
            this.txtNotlar.Name = "txtNotlar";
            this.txtNotlar.Size = new System.Drawing.Size(977, 232);
            this.txtNotlar.TabIndex = 2;
            // 
            // pageKullanilanMalzemeler
            // 
            this.pageKullanilanMalzemeler.Appearance.HeaderActive.BackColor = System.Drawing.Color.Red;
            this.pageKullanilanMalzemeler.Appearance.HeaderActive.Options.UseBackColor = true;
            this.pageKullanilanMalzemeler.Controls.Add(this.gridControl2);
            this.pageKullanilanMalzemeler.Name = "pageKullanilanMalzemeler";
            this.pageKullanilanMalzemeler.Size = new System.Drawing.Size(977, 232);
            this.pageKullanilanMalzemeler.Text = "KULLANILAN MALZEMELER";
            // 
            // gridControl2
            // 
            this.gridControl2.DataSource = this.tblKullanilanMalzemelerBindingSource;
            this.gridControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl2.Location = new System.Drawing.Point(0, 0);
            this.gridControl2.MainView = this.gwKullanilanMalzemeler;
            this.gridControl2.MenuManager = this.barManager1;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemGridLookUpEdit2,
            this.maskMiktar,
            this.maskBirimFiyat,
            this.maskTutar});
            this.gridControl2.Size = new System.Drawing.Size(977, 232);
            this.gridControl2.TabIndex = 3;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gwKullanilanMalzemeler});
            // 
            // gwKullanilanMalzemeler
            // 
            this.gwKullanilanMalzemeler.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID2,
            this.colStokAdi,
            this.colAciklama,
            this.colAciklama1,
            this.colMiktar,
            this.colBirimFiyat,
            this.colTutar,
            this.colServisEvrakNo1});
            this.gwKullanilanMalzemeler.GridControl = this.gridControl2;
            this.gwKullanilanMalzemeler.Name = "gwKullanilanMalzemeler";
            this.gwKullanilanMalzemeler.OptionsNavigation.AutoFocusNewRow = true;
            this.gwKullanilanMalzemeler.OptionsNavigation.EnterMoveNextColumn = true;
            this.gwKullanilanMalzemeler.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gwKullanilanMalzemeler.OptionsView.ColumnAutoWidth = false;
            this.gwKullanilanMalzemeler.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gwKullanilanMalzemeler.OptionsView.ShowFooter = true;
            this.gwKullanilanMalzemeler.OptionsView.ShowGroupPanel = false;
            this.gwKullanilanMalzemeler.BeforeLeaveRow += new DevExpress.XtraGrid.Views.Base.RowAllowEventHandler(this.gwKullanilanMalzemeler_BeforeLeaveRow);
            this.gwKullanilanMalzemeler.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gwKullanilanMalzemeler_KeyDown);
            // 
            // colID2
            // 
            this.colID2.FieldName = "ID";
            this.colID2.Name = "colID2";
            this.colID2.OptionsColumn.ReadOnly = true;
            // 
            // colStokAdi
            // 
            this.colStokAdi.ColumnEdit = this.repositoryItemGridLookUpEdit2;
            this.colStokAdi.FieldName = "StokAdi";
            this.colStokAdi.Name = "colStokAdi";
            this.colStokAdi.Visible = true;
            this.colStokAdi.VisibleIndex = 0;
            this.colStokAdi.Width = 130;
            // 
            // repositoryItemGridLookUpEdit2
            // 
            this.repositoryItemGridLookUpEdit2.AutoHeight = false;
            this.repositoryItemGridLookUpEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEdit2.DataSource = this.tblStokKartlariBindingSource;
            this.repositoryItemGridLookUpEdit2.DisplayMember = "StokAdi";
            this.repositoryItemGridLookUpEdit2.ImmediatePopup = true;
            this.repositoryItemGridLookUpEdit2.Name = "repositoryItemGridLookUpEdit2";
            this.repositoryItemGridLookUpEdit2.NullText = "";
            this.repositoryItemGridLookUpEdit2.ValueMember = "StokKodu";
            this.repositoryItemGridLookUpEdit2.View = this.gridView1;
            this.repositoryItemGridLookUpEdit2.ViewType = DevExpress.XtraEditors.Repository.GridLookUpViewType.GridView;
            // 
            // colAciklama
            // 
            this.colAciklama.FieldName = "Aciklama";
            this.colAciklama.Name = "colAciklama";
            this.colAciklama.Visible = true;
            this.colAciklama.VisibleIndex = 1;
            this.colAciklama.Width = 139;
            // 
            // colAciklama1
            // 
            this.colAciklama1.FieldName = "Aciklama1";
            this.colAciklama1.Name = "colAciklama1";
            this.colAciklama1.Visible = true;
            this.colAciklama1.VisibleIndex = 2;
            this.colAciklama1.Width = 173;
            // 
            // colMiktar
            // 
            this.colMiktar.ColumnEdit = this.maskMiktar;
            this.colMiktar.FieldName = "Miktar";
            this.colMiktar.Name = "colMiktar";
            this.colMiktar.Visible = true;
            this.colMiktar.VisibleIndex = 3;
            // 
            // maskMiktar
            // 
            this.maskMiktar.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.maskMiktar.AutoHeight = false;
            this.maskMiktar.Mask.EditMask = "n4";
            this.maskMiktar.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.maskMiktar.Mask.UseMaskAsDisplayFormat = true;
            this.maskMiktar.Name = "maskMiktar";
            this.maskMiktar.NullText = "0";
            this.maskMiktar.ValidateOnEnterKey = true;
            this.maskMiktar.Leave += new System.EventHandler(this.maskMiktar_Leave);
            // 
            // colBirimFiyat
            // 
            this.colBirimFiyat.ColumnEdit = this.maskBirimFiyat;
            this.colBirimFiyat.FieldName = "BirimFiyat";
            this.colBirimFiyat.Name = "colBirimFiyat";
            this.colBirimFiyat.Visible = true;
            this.colBirimFiyat.VisibleIndex = 4;
            // 
            // maskBirimFiyat
            // 
            this.maskBirimFiyat.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.maskBirimFiyat.AutoHeight = false;
            this.maskBirimFiyat.Mask.EditMask = "n6";
            this.maskBirimFiyat.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.maskBirimFiyat.Mask.UseMaskAsDisplayFormat = true;
            this.maskBirimFiyat.Name = "maskBirimFiyat";
            this.maskBirimFiyat.NullText = "0";
            this.maskBirimFiyat.ValidateOnEnterKey = true;
            this.maskBirimFiyat.Leave += new System.EventHandler(this.maskBirimFiyat_Leave);
            // 
            // colTutar
            // 
            this.colTutar.ColumnEdit = this.maskTutar;
            this.colTutar.FieldName = "Tutar";
            this.colTutar.Name = "colTutar";
            this.colTutar.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Tutar", "{0:n2}")});
            this.colTutar.Visible = true;
            this.colTutar.VisibleIndex = 5;
            // 
            // maskTutar
            // 
            this.maskTutar.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.maskTutar.AutoHeight = false;
            this.maskTutar.Mask.EditMask = "n2";
            this.maskTutar.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.maskTutar.Mask.UseMaskAsDisplayFormat = true;
            this.maskTutar.Name = "maskTutar";
            this.maskTutar.ValidateOnEnterKey = true;
            // 
            // colServisEvrakNo1
            // 
            this.colServisEvrakNo1.FieldName = "ServisEvrakNo";
            this.colServisEvrakNo1.Name = "colServisEvrakNo1";
            this.colServisEvrakNo1.Width = 116;
            // 
            // pageArizaBilgileri
            // 
            this.pageArizaBilgileri.Appearance.HeaderActive.BackColor = System.Drawing.Color.Red;
            this.pageArizaBilgileri.Appearance.HeaderActive.Options.UseBackColor = true;
            this.pageArizaBilgileri.Controls.Add(this.splitContainerControl1);
            this.pageArizaBilgileri.Name = "pageArizaBilgileri";
            this.pageArizaBilgileri.PageVisible = false;
            this.pageArizaBilgileri.Size = new System.Drawing.Size(977, 232);
            this.pageArizaBilgileri.Text = "ARIZA BİLGİLERİ";
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.groupControl5);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.groupControl6);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(977, 232);
            this.splitContainerControl1.SplitterPosition = 563;
            this.splitContainerControl1.TabIndex = 0;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // groupControl5
            // 
            this.groupControl5.Controls.Add(this.txtArizaliUrunler);
            this.groupControl5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl5.Location = new System.Drawing.Point(0, 0);
            this.groupControl5.Name = "groupControl5";
            this.groupControl5.Size = new System.Drawing.Size(563, 232);
            this.groupControl5.TabIndex = 0;
            this.groupControl5.Text = "ARIZALI ÜRÜNLER";
            // 
            // txtArizaliUrunler
            // 
            this.txtArizaliUrunler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtArizaliUrunler.Location = new System.Drawing.Point(2, 21);
            this.txtArizaliUrunler.Name = "txtArizaliUrunler";
            this.txtArizaliUrunler.Properties.ReadOnly = true;
            this.txtArizaliUrunler.Size = new System.Drawing.Size(559, 209);
            this.txtArizaliUrunler.TabIndex = 2;
            // 
            // groupControl6
            // 
            this.groupControl6.Controls.Add(this.txtAriza);
            this.groupControl6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl6.Location = new System.Drawing.Point(0, 0);
            this.groupControl6.Name = "groupControl6";
            this.groupControl6.Size = new System.Drawing.Size(408, 232);
            this.groupControl6.TabIndex = 1;
            this.groupControl6.Text = "ÜRÜN ARIZASI";
            // 
            // txtAriza
            // 
            this.txtAriza.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtAriza.Location = new System.Drawing.Point(2, 21);
            this.txtAriza.Name = "txtAriza";
            this.txtAriza.Properties.ReadOnly = true;
            this.txtAriza.Size = new System.Drawing.Size(404, 209);
            this.txtAriza.TabIndex = 3;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.labelControl7);
            this.panelControl1.Controls.Add(this.labelControl8);
            this.panelControl1.Controls.Add(this.dtBaslangicTarihSaati);
            this.panelControl1.Controls.Add(this.dtBitisTarihSaati);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(2, 24);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(979, 63);
            this.panelControl1.TabIndex = 1;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl7.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl7.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl7.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.labelControl7.Location = new System.Drawing.Point(12, 9);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(124, 20);
            this.labelControl7.TabIndex = 41;
            this.labelControl7.Text = "BAŞLANGIÇ TARİHİ";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl8.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl8.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl8.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.labelControl8.Location = new System.Drawing.Point(12, 35);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(124, 20);
            this.labelControl8.TabIndex = 43;
            this.labelControl8.Text = "BİTİŞ TARİHİ";
            // 
            // dtBaslangicTarihSaati
            // 
            this.dtBaslangicTarihSaati.EditValue = null;
            this.dtBaslangicTarihSaati.EnterMoveNextControl = true;
            this.dtBaslangicTarihSaati.Location = new System.Drawing.Point(136, 9);
            this.dtBaslangicTarihSaati.Name = "dtBaslangicTarihSaati";
            this.dtBaslangicTarihSaati.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.dtBaslangicTarihSaati.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.dtBaslangicTarihSaati.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtBaslangicTarihSaati.Properties.Mask.EditMask = "G";
            this.dtBaslangicTarihSaati.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.dtBaslangicTarihSaati.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dtBaslangicTarihSaati.Size = new System.Drawing.Size(177, 20);
            this.dtBaslangicTarihSaati.TabIndex = 9;
            // 
            // dtBitisTarihSaati
            // 
            this.dtBitisTarihSaati.EditValue = null;
            this.dtBitisTarihSaati.EnterMoveNextControl = true;
            this.dtBitisTarihSaati.Location = new System.Drawing.Point(136, 35);
            this.dtBitisTarihSaati.Name = "dtBitisTarihSaati";
            this.dtBitisTarihSaati.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.dtBitisTarihSaati.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.dtBitisTarihSaati.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtBitisTarihSaati.Properties.Mask.EditMask = "G";
            this.dtBitisTarihSaati.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.dtBitisTarihSaati.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dtBitisTarihSaati.Size = new System.Drawing.Size(177, 20);
            this.dtBitisTarihSaati.TabIndex = 10;
            // 
            // colID3
            // 
            this.colID3.FieldName = "ID";
            this.colID3.Name = "colID3";
            this.colID3.OptionsColumn.ReadOnly = true;
            // 
            // colServisFormID2
            // 
            this.colServisFormID2.FieldName = "ServisFormID";
            this.colServisFormID2.Name = "colServisFormID2";
            // 
            // colAciklama2
            // 
            this.colAciklama2.FieldName = "Aciklama";
            this.colAciklama2.Name = "colAciklama2";
            // 
            // colAciklama11
            // 
            this.colAciklama11.FieldName = "Aciklama1";
            this.colAciklama11.Name = "colAciklama11";
            // 
            // colMiktar1
            // 
            this.colMiktar1.FieldName = "Miktar";
            this.colMiktar1.Name = "colMiktar1";
            // 
            // colBirimFiyat1
            // 
            this.colBirimFiyat1.FieldName = "BirimFiyat";
            this.colBirimFiyat1.Name = "colBirimFiyat1";
            // 
            // colTutar1
            // 
            this.colTutar1.FieldName = "Tutar";
            this.colTutar1.Name = "colTutar1";
            // 
            // colID4
            // 
            this.colID4.FieldName = "ID";
            this.colID4.Name = "colID4";
            this.colID4.OptionsColumn.ReadOnly = true;
            // 
            // colServisFormID3
            // 
            this.colServisFormID3.FieldName = "ServisFormID";
            this.colServisFormID3.Name = "colServisFormID3";
            // 
            // colStokAdi2
            // 
            this.colStokAdi2.FieldName = "StokAdi";
            this.colStokAdi2.Name = "colStokAdi2";
            // 
            // colAciklama3
            // 
            this.colAciklama3.FieldName = "Aciklama";
            this.colAciklama3.Name = "colAciklama3";
            // 
            // colAciklama12
            // 
            this.colAciklama12.FieldName = "Aciklama1";
            this.colAciklama12.Name = "colAciklama12";
            // 
            // colMiktar2
            // 
            this.colMiktar2.FieldName = "Miktar";
            this.colMiktar2.Name = "colMiktar2";
            // 
            // colBirimFiyat2
            // 
            this.colBirimFiyat2.FieldName = "BirimFiyat";
            this.colBirimFiyat2.Name = "colBirimFiyat2";
            // 
            // colTutar2
            // 
            this.colTutar2.FieldName = "Tutar";
            this.colTutar2.Name = "colTutar2";
            // 
            // tblServisFormlariTableAdapter
            // 
            this.tblServisFormlariTableAdapter.ClearBeforeFill = true;
            // 
            // tblArizaFormlariTableAdapter1
            // 
            this.tblArizaFormlariTableAdapter1.ClearBeforeFill = true;
            // 
            // report1
            // 
            this.report1.ReportResourceString = resources.GetString("report1.ReportResourceString");
            this.report1.RegisterData(this.tblServisFormlariBindingSource, "tblServisFormlariBindingSource");
            // 
            // frmServisFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 727);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Controls.Add(this.barDockControl3);
            this.Controls.Add(this.barDockControl4);
            this.Controls.Add(this.barDockControl2);
            this.Controls.Add(this.barDockControl1);
            this.KeyPreview = true;
            this.Name = "frmServisFormu";
            this.Text = "[SERVİS FORMU]";
            this.Load += new System.EventHandler(this.frmServisFormu_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmServisFormu_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.txtUnvan1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVergiDairesi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVergiNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtArizaFormNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMusteri.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cariTanimlariBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMusteriView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAdres2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAdres1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbIslemTipi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblServiseGidenPersonellerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gwTekniker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblKullanicilarLookUpBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtEvrakTaihi.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtEvrakTaihi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEvrakNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIsEmri.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblServisFormlariBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblKullanilanMalzemelerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblStokKartlariBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            this.groupControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtGenelTutar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMalzemeTutari.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHizmetTutari.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.pageServisNotu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtServisNotu.Properties)).EndInit();
            this.pageNotlar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtNotlar.Properties)).EndInit();
            this.pageKullanilanMalzemeler.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gwKullanilanMalzemeler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maskMiktar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maskBirimFiyat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maskTutar)).EndInit();
            this.pageArizaBilgileri.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl5)).EndInit();
            this.groupControl5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtArizaliUrunler.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl6)).EndInit();
            this.groupControl6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtAriza.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtBaslangicTarihSaati.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtBaslangicTarihSaati.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtBitisTarihSaati.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtBitisTarihSaati.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.report1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        public DevExpress.XtraEditors.TextEdit txtUnvan1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        public DevExpress.XtraEditors.TextEdit txtTel;
        public DevExpress.XtraEditors.TextEdit txtVergiDairesi;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        public DevExpress.XtraEditors.TextEdit txtVergiNo;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gwTekniker;
        private DevExpress.XtraEditors.ComboBoxEdit cmbIslemTipi;
        private Dataset dataset;
        private System.Windows.Forms.BindingSource cariTanimlariBindingSource;
        private DatasetTableAdapters.CariTanimlariTableAdapter cariTanimlariTableAdapter;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        public DevExpress.XtraEditors.TextEdit txtAdres2;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        public DevExpress.XtraEditors.TextEdit txtAdres1;
        private DevExpress.XtraEditors.GridLookUpEdit txtMusteri;
        private DevExpress.XtraGrid.Views.Grid.GridView txtMusteriView;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colHesapKodu;
        private DevExpress.XtraGrid.Columns.GridColumn colUnvan1;
        private DevExpress.XtraGrid.Columns.GridColumn colUnvan2;
        private DevExpress.XtraGrid.Columns.GridColumn colAdres1;
        private DevExpress.XtraGrid.Columns.GridColumn colAdres2;
        private DevExpress.XtraGrid.Columns.GridColumn colAdres3;
        private DevExpress.XtraGrid.Columns.GridColumn colVergiDairesi;
        private DevExpress.XtraGrid.Columns.GridColumn colVergiHesapNo;
        private DevExpress.XtraGrid.Columns.GridColumn colTelefon1;
        private DevExpress.XtraEditors.DateEdit dtEvrakTaihi;
        private System.Windows.Forms.BindingSource tblServiseGidenPersonellerBindingSource;
        private DatasetTableAdapters.tblServiseGidenPersonellerTableAdapter tblServiseGidenPersonellerTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colID1;
        private DevExpress.XtraGrid.Columns.GridColumn colKullaniciAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colAdiSoyadi;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEdit1;
        private System.Windows.Forms.BindingSource tblKullanicilarLookUpBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DatasetTableAdapters.tblKullanicilar_LookUpTableAdapter tblKullanicilar_LookUpTableAdapter;
        private DevExpress.XtraEditors.SimpleButton btnTikerSil;
        private System.Windows.Forms.BindingSource tblKullanilanMalzemelerBindingSource;
        private DatasetTableAdapters.tblKullanilanMalzemelerTableAdapter tblKullanilanMalzemelerTableAdapter;
        private System.Windows.Forms.BindingSource tblStokKartlariBindingSource;
        private DatasetTableAdapters.tblStokKartlariTableAdapter tblStokKartlariTableAdapter;
        private DevExpress.XtraBars.BarDockControl barDockControl3;
        private DevExpress.XtraBars.BarDockControl barDockControl4;
        private DevExpress.XtraBars.BarDockControl barDockControl2;
        private DevExpress.XtraBars.BarDockControl barDockControl1;
        private DevExpress.XtraBars.BarManager barManager2;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btnYenile;
        private DevExpress.XtraBars.BarButtonItem btnKaydet;
        private DevExpress.XtraBars.BarButtonItem btnSil;
        private DevExpress.XtraBars.BarButtonItem btnYazdir;
        private DevExpress.XtraEditors.GroupControl groupControl4;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        public DevExpress.XtraEditors.TextEdit txtGenelTutar;
        private DevExpress.XtraEditors.LabelControl labelControl13;
        public DevExpress.XtraEditors.TextEdit txtMalzemeTutari;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        public DevExpress.XtraEditors.TextEdit txtHizmetTutari;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage pageServisNotu;
        private DevExpress.XtraEditors.MemoEdit txtServisNotu;
        private DevExpress.XtraTab.XtraTabPage pageNotlar;
        private DevExpress.XtraEditors.MemoEdit txtNotlar;
        private DevExpress.XtraTab.XtraTabPage pageKullanilanMalzemeler;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gwKullanilanMalzemeler;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEdit2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit maskMiktar;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit maskBirimFiyat;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit maskTutar;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.DateEdit dtBaslangicTarihSaati;
        private DevExpress.XtraEditors.DateEdit dtBitisTarihSaati;
        private DevExpress.XtraGrid.Columns.GridColumn colID3;
        private DevExpress.XtraGrid.Columns.GridColumn colServisFormID2;
        private DevExpress.XtraGrid.Columns.GridColumn colAciklama2;
        private DevExpress.XtraGrid.Columns.GridColumn colAciklama11;
        private DevExpress.XtraGrid.Columns.GridColumn colMiktar1;
        private DevExpress.XtraGrid.Columns.GridColumn colBirimFiyat1;
        private DevExpress.XtraGrid.Columns.GridColumn colTutar1;
        private DevExpress.XtraGrid.Columns.GridColumn colID4;
        private DevExpress.XtraGrid.Columns.GridColumn colServisFormID3;
        private DevExpress.XtraGrid.Columns.GridColumn colStokAdi2;
        private DevExpress.XtraGrid.Columns.GridColumn colAciklama3;
        private DevExpress.XtraGrid.Columns.GridColumn colAciklama12;
        private DevExpress.XtraGrid.Columns.GridColumn colMiktar2;
        private DevExpress.XtraGrid.Columns.GridColumn colBirimFiyat2;
        private DevExpress.XtraGrid.Columns.GridColumn colTutar2;
        private DevExpress.XtraGrid.Columns.GridColumn colID2;
        private DevExpress.XtraGrid.Columns.GridColumn colStokAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colAciklama;
        private DevExpress.XtraGrid.Columns.GridColumn colAciklama1;
        private DevExpress.XtraGrid.Columns.GridColumn colMiktar;
        private DevExpress.XtraGrid.Columns.GridColumn colBirimFiyat;
        private DevExpress.XtraGrid.Columns.GridColumn colTutar;
        private DevExpress.XtraEditors.LabelControl lblArizaVeBakimEvrakBaslik;
        private DevExpress.XtraEditors.LabelControl labelControl14;
        private DevExpress.XtraGrid.Columns.GridColumn colStokAdi1;
        private DevExpress.XtraTab.XtraTabPage pageArizaBilgileri;
        private DevExpress.XtraGrid.Columns.GridColumn colServisEvrakNo;
        private DevExpress.XtraGrid.Columns.GridColumn colAdiSoyadi1;
        private DevExpress.XtraGrid.Columns.GridColumn colServisEvrakNo1;
        private DatasetTableAdapters.sorgular sorgular1;
        private System.Windows.Forms.BindingSource tblServisFormlariBindingSource;
        private DatasetTableAdapters.tblServisFormlariTableAdapter tblServisFormlariTableAdapter;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.GroupControl groupControl5;
        private DevExpress.XtraEditors.GroupControl groupControl6;
        private DevExpress.XtraEditors.MemoEdit txtArizaliUrunler;
        private DevExpress.XtraEditors.MemoEdit txtAriza;
        private DatasetTableAdapters.tblArizaFormlariTableAdapter tblArizaFormlariTableAdapter1;
        private DevExpress.Utils.ImageCollection imgMenu;
        private FastReport.Report report1;
        public DevExpress.XtraEditors.ButtonEdit txtArizaFormNo;
        public DevExpress.XtraEditors.ButtonEdit txtEvrakNo;
        private DevExpress.XtraEditors.LabelControl labelControl15;
        public DevExpress.XtraEditors.ButtonEdit txtIsEmri;
        private DevExpress.XtraGrid.Columns.GridColumn colStokKodu;
    }
}