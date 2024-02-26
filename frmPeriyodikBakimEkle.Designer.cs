namespace TeknikServis
{
    partial class frmPeriyodikBakimEkle
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
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition1 = new DevExpress.XtraGrid.StyleFormatCondition();
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition2 = new DevExpress.XtraGrid.StyleFormatCondition();
            this.colHareketDurumu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtMusteri = new DevExpress.XtraEditors.GridLookUpEdit();
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtVergiNo = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtVergiDairesi = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtTel = new DevExpress.XtraEditors.TextEdit();
            this.txtUnvan1 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.tblBakimAnlasmaDetayiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.dtEvrakTarihi = new DevExpress.XtraEditors.DateEdit();
            this.txtEvrakNo = new DevExpress.XtraEditors.TextEdit();
            this.btnVazgec = new DevExpress.XtraEditors.SimpleButton();
            this.btnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gwPeriyotlar = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBakimEvrakNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBakimTarihi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAciklama = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKapatanServisFormNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKapatmaTarihSaati = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKapatanKullaniciAdiSoyadi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEkleyenTarihSaati = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEkleyenKullaniciAdiSoyadi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDegistirTarihSaati = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDegistirenKullaniciAdiSoyadi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.txtBakimBilgisi = new DevExpress.XtraEditors.MemoEdit();
            this.xtraTabPage3 = new DevExpress.XtraTab.XtraTabPage();
            this.txtNotlar = new DevExpress.XtraEditors.MemoEdit();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnOlustur = new DevExpress.XtraEditors.SimpleButton();
            this.txtPeriyot = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.dtBaslangicTarihi = new DevExpress.XtraEditors.DateEdit();
            this.dtBitisTarihi = new DevExpress.XtraEditors.DateEdit();
            this.sorgular1 = new TeknikServis.DatasetTableAdapters.sorgular();
            this.cariTanimlariTableAdapter = new TeknikServis.DatasetTableAdapters.CariTanimlariTableAdapter();
            this.tblBakimAnlasmaDetayiTableAdapter1 = new TeknikServis.DatasetTableAdapters.tblBakimAnlasmaDetayiTableAdapter();
            this.tblBakimAnlasmalariTableAdapter1 = new TeknikServis.DatasetTableAdapters.tblBakimAnlasmalariTableAdapter();
            this.btnSozlesmeyiKapat = new DevExpress.XtraEditors.SimpleButton();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.txtMusteri.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cariTanimlariBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMusteriView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAdres2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAdres1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVergiNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVergiDairesi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUnvan1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblBakimAnlasmaDetayiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtEvrakTarihi.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtEvrakTarihi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEvrakNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gwPeriyotlar)).BeginInit();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtBakimBilgisi.Properties)).BeginInit();
            this.xtraTabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNotlar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPeriyot.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtBaslangicTarihi.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtBaslangicTarihi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtBitisTarihi.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtBitisTarihi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // colHareketDurumu
            // 
            this.colHareketDurumu.FieldName = "HareketDurumu";
            this.colHareketDurumu.Name = "colHareketDurumu";
            this.colHareketDurumu.Width = 90;
            // 
            // txtMusteri
            // 
            this.txtMusteri.EditValue = "";
            this.txtMusteri.EnterMoveNextControl = true;
            this.txtMusteri.Location = new System.Drawing.Point(133, 57);
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
            this.txtMusteri.Size = new System.Drawing.Size(280, 20);
            this.txtMusteri.TabIndex = 50;
            this.txtMusteri.Closed += new DevExpress.XtraEditors.Controls.ClosedEventHandler(this.txtMusteri_Closed);
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
            this.labelControl10.Location = new System.Drawing.Point(9, 135);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(124, 20);
            this.labelControl10.TabIndex = 61;
            this.labelControl10.Text = "ADRES-2";
            // 
            // txtAdres2
            // 
            this.txtAdres2.Location = new System.Drawing.Point(133, 135);
            this.txtAdres2.Name = "txtAdres2";
            this.txtAdres2.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtAdres2.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtAdres2.Properties.ReadOnly = true;
            this.txtAdres2.Size = new System.Drawing.Size(280, 20);
            this.txtAdres2.TabIndex = 62;
            this.txtAdres2.TabStop = false;
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl9.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl9.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl9.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.labelControl9.Location = new System.Drawing.Point(9, 109);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(124, 20);
            this.labelControl9.TabIndex = 59;
            this.labelControl9.Text = "ADRES-1";
            // 
            // txtAdres1
            // 
            this.txtAdres1.Location = new System.Drawing.Point(133, 109);
            this.txtAdres1.Name = "txtAdres1";
            this.txtAdres1.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtAdres1.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtAdres1.Properties.ReadOnly = true;
            this.txtAdres1.Size = new System.Drawing.Size(280, 20);
            this.txtAdres1.TabIndex = 60;
            this.txtAdres1.TabStop = false;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.labelControl1.Location = new System.Drawing.Point(9, 57);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(124, 20);
            this.labelControl1.TabIndex = 51;
            this.labelControl1.Text = "ÜNVAN-1";
            // 
            // txtVergiNo
            // 
            this.txtVergiNo.Location = new System.Drawing.Point(262, 187);
            this.txtVergiNo.Name = "txtVergiNo";
            this.txtVergiNo.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtVergiNo.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtVergiNo.Properties.ReadOnly = true;
            this.txtVergiNo.Size = new System.Drawing.Size(151, 20);
            this.txtVergiNo.TabIndex = 58;
            this.txtVergiNo.TabStop = false;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.labelControl2.Location = new System.Drawing.Point(9, 83);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(124, 20);
            this.labelControl2.TabIndex = 52;
            this.labelControl2.Text = "ÜNVAN-2";
            // 
            // txtVergiDairesi
            // 
            this.txtVergiDairesi.Location = new System.Drawing.Point(133, 187);
            this.txtVergiDairesi.Name = "txtVergiDairesi";
            this.txtVergiDairesi.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtVergiDairesi.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtVergiDairesi.Properties.ReadOnly = true;
            this.txtVergiDairesi.Size = new System.Drawing.Size(129, 20);
            this.txtVergiDairesi.TabIndex = 57;
            this.txtVergiDairesi.TabStop = false;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl4.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl4.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.labelControl4.Location = new System.Drawing.Point(9, 187);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(124, 20);
            this.labelControl4.TabIndex = 56;
            this.labelControl4.Text = "VERGİ DAİRESİ && NO";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.labelControl3.Location = new System.Drawing.Point(9, 160);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(124, 20);
            this.labelControl3.TabIndex = 53;
            this.labelControl3.Text = "TEL";
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(133, 160);
            this.txtTel.Name = "txtTel";
            this.txtTel.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtTel.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtTel.Properties.ReadOnly = true;
            this.txtTel.Size = new System.Drawing.Size(129, 20);
            this.txtTel.TabIndex = 55;
            this.txtTel.TabStop = false;
            // 
            // txtUnvan1
            // 
            this.txtUnvan1.Location = new System.Drawing.Point(133, 83);
            this.txtUnvan1.Name = "txtUnvan1";
            this.txtUnvan1.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtUnvan1.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtUnvan1.Properties.ReadOnly = true;
            this.txtUnvan1.Size = new System.Drawing.Size(280, 20);
            this.txtUnvan1.TabIndex = 54;
            this.txtUnvan1.TabStop = false;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl5.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl5.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl5.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.labelControl5.Location = new System.Drawing.Point(9, 31);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(124, 20);
            this.labelControl5.TabIndex = 63;
            this.labelControl5.Text = "Evrak No";
            // 
            // tblBakimAnlasmaDetayiBindingSource
            // 
            this.tblBakimAnlasmaDetayiBindingSource.DataMember = "tblBakimAnlasmaDetayi";
            this.tblBakimAnlasmaDetayiBindingSource.DataSource = this.dataset;
            // 
            // groupControl1
            // 
            this.groupControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.groupControl1.Appearance.Options.UseFont = true;
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.Controls.Add(this.labelControl11);
            this.groupControl1.Controls.Add(this.dtEvrakTarihi);
            this.groupControl1.Controls.Add(this.txtUnvan1);
            this.groupControl1.Controls.Add(this.txtTel);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.txtMusteri);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl10);
            this.groupControl1.Controls.Add(this.txtVergiDairesi);
            this.groupControl1.Controls.Add(this.txtAdres2);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl9);
            this.groupControl1.Controls.Add(this.txtVergiNo);
            this.groupControl1.Controls.Add(this.txtAdres1);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.txtEvrakNo);
            this.groupControl1.Location = new System.Drawing.Point(7, 5);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(499, 226);
            this.groupControl1.TabIndex = 66;
            this.groupControl1.Text = "MÜŞTERİ BİLGİLERİ";
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl11.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl11.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl11.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.labelControl11.Location = new System.Drawing.Point(225, 30);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(75, 20);
            this.labelControl11.TabIndex = 66;
            this.labelControl11.Text = "Evrak Tarihi";
            // 
            // dtEvrakTarihi
            // 
            this.dtEvrakTarihi.EditValue = null;
            this.dtEvrakTarihi.Location = new System.Drawing.Point(300, 30);
            this.dtEvrakTarihi.Name = "dtEvrakTarihi";
            this.dtEvrakTarihi.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.dtEvrakTarihi.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.dtEvrakTarihi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtEvrakTarihi.Properties.Mask.EditMask = "";
            this.dtEvrakTarihi.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.dtEvrakTarihi.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dtEvrakTarihi.Size = new System.Drawing.Size(113, 20);
            this.dtEvrakTarihi.TabIndex = 65;
            this.dtEvrakTarihi.TabStop = false;
            // 
            // txtEvrakNo
            // 
            this.txtEvrakNo.Location = new System.Drawing.Point(133, 31);
            this.txtEvrakNo.Name = "txtEvrakNo";
            this.txtEvrakNo.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtEvrakNo.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtEvrakNo.Properties.ReadOnly = true;
            this.txtEvrakNo.Size = new System.Drawing.Size(81, 20);
            this.txtEvrakNo.TabIndex = 64;
            // 
            // btnVazgec
            // 
            this.btnVazgec.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnVazgec.Appearance.Options.UseFont = true;
            this.btnVazgec.Location = new System.Drawing.Point(307, 628);
            this.btnVazgec.Name = "btnVazgec";
            this.btnVazgec.Size = new System.Drawing.Size(95, 23);
            this.btnVazgec.TabIndex = 67;
            this.btnVazgec.Text = "Vazgeç";
            this.btnVazgec.Click += new System.EventHandler(this.btnVazgec_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnKaydet.Appearance.Options.UseFont = true;
            this.btnKaydet.Location = new System.Drawing.Point(408, 628);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(93, 23);
            this.btnKaydet.TabIndex = 68;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // groupControl2
            // 
            this.groupControl2.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.groupControl2.AppearanceCaption.Options.UseFont = true;
            this.groupControl2.Controls.Add(this.xtraTabControl1);
            this.groupControl2.Controls.Add(this.panelControl1);
            this.groupControl2.Location = new System.Drawing.Point(7, 238);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(498, 382);
            this.groupControl2.TabIndex = 69;
            this.groupControl2.Text = "BAKIM PERİYOTLARI";
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(2, 90);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.PaintStyleName = "PropertyView";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(494, 290);
            this.xtraTabControl1.TabIndex = 65;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2,
            this.xtraTabPage3});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.gridControl1);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(492, 269);
            this.xtraTabPage1.Text = "BAKIM PERİYOTLARI";
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.tblBakimAnlasmaDetayiBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gwPeriyotlar;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(492, 269);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gwPeriyotlar,
            this.gridView1});
            // 
            // gwPeriyotlar
            // 
            this.gwPeriyotlar.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID1,
            this.colBakimEvrakNo,
            this.colBakimTarihi,
            this.colAciklama,
            this.colHareketDurumu,
            this.colKapatanServisFormNo,
            this.colKapatmaTarihSaati,
            this.colKapatanKullaniciAdiSoyadi,
            this.colEkleyenTarihSaati,
            this.colEkleyenKullaniciAdiSoyadi,
            this.colDegistirTarihSaati,
            this.colDegistirenKullaniciAdiSoyadi});
            styleFormatCondition1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            styleFormatCondition1.Appearance.Options.UseBackColor = true;
            styleFormatCondition1.ApplyToRow = true;
            styleFormatCondition1.Column = this.colHareketDurumu;
            styleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal;
            styleFormatCondition1.Value1 = "1";
            styleFormatCondition2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            styleFormatCondition2.Appearance.Options.UseBackColor = true;
            styleFormatCondition2.ApplyToRow = true;
            styleFormatCondition2.Column = this.colHareketDurumu;
            styleFormatCondition2.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal;
            styleFormatCondition2.Value1 = "0";
            this.gwPeriyotlar.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[] {
            styleFormatCondition1,
            styleFormatCondition2});
            this.gwPeriyotlar.GridControl = this.gridControl1;
            this.gwPeriyotlar.Name = "gwPeriyotlar";
            this.gwPeriyotlar.OptionsBehavior.Editable = false;
            this.gwPeriyotlar.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gwPeriyotlar.OptionsView.ColumnAutoWidth = false;
            this.gwPeriyotlar.OptionsView.ShowGroupPanel = false;
            // 
            // colID1
            // 
            this.colID1.FieldName = "ID";
            this.colID1.Name = "colID1";
            this.colID1.OptionsColumn.ReadOnly = true;
            // 
            // colBakimEvrakNo
            // 
            this.colBakimEvrakNo.FieldName = "BakimEvrakNo";
            this.colBakimEvrakNo.Name = "colBakimEvrakNo";
            this.colBakimEvrakNo.Width = 85;
            // 
            // colBakimTarihi
            // 
            this.colBakimTarihi.Caption = "Bakım Tarihi";
            this.colBakimTarihi.FieldName = "BakimTarihi";
            this.colBakimTarihi.Name = "colBakimTarihi";
            this.colBakimTarihi.Visible = true;
            this.colBakimTarihi.VisibleIndex = 0;
            this.colBakimTarihi.Width = 89;
            // 
            // colAciklama
            // 
            this.colAciklama.Caption = "Açıklama";
            this.colAciklama.FieldName = "Aciklama";
            this.colAciklama.Name = "colAciklama";
            this.colAciklama.Visible = true;
            this.colAciklama.VisibleIndex = 1;
            this.colAciklama.Width = 77;
            // 
            // colKapatanServisFormNo
            // 
            this.colKapatanServisFormNo.Caption = "Servis Formu";
            this.colKapatanServisFormNo.FieldName = "KapatanServisFormNo";
            this.colKapatanServisFormNo.Name = "colKapatanServisFormNo";
            this.colKapatanServisFormNo.Visible = true;
            this.colKapatanServisFormNo.VisibleIndex = 2;
            this.colKapatanServisFormNo.Width = 137;
            // 
            // colKapatmaTarihSaati
            // 
            this.colKapatmaTarihSaati.Caption = "Servis Form Tarihi";
            this.colKapatmaTarihSaati.FieldName = "KapatmaTarihSaati";
            this.colKapatmaTarihSaati.Name = "colKapatmaTarihSaati";
            this.colKapatmaTarihSaati.Visible = true;
            this.colKapatmaTarihSaati.VisibleIndex = 3;
            this.colKapatmaTarihSaati.Width = 118;
            // 
            // colKapatanKullaniciAdiSoyadi
            // 
            this.colKapatanKullaniciAdiSoyadi.FieldName = "KapatanKullaniciAdiSoyadi";
            this.colKapatanKullaniciAdiSoyadi.Name = "colKapatanKullaniciAdiSoyadi";
            this.colKapatanKullaniciAdiSoyadi.Width = 145;
            // 
            // colEkleyenTarihSaati
            // 
            this.colEkleyenTarihSaati.FieldName = "EkleyenTarihSaati";
            this.colEkleyenTarihSaati.Name = "colEkleyenTarihSaati";
            this.colEkleyenTarihSaati.Width = 103;
            // 
            // colEkleyenKullaniciAdiSoyadi
            // 
            this.colEkleyenKullaniciAdiSoyadi.FieldName = "EkleyenKullaniciAdiSoyadi";
            this.colEkleyenKullaniciAdiSoyadi.Name = "colEkleyenKullaniciAdiSoyadi";
            this.colEkleyenKullaniciAdiSoyadi.Width = 142;
            // 
            // colDegistirTarihSaati
            // 
            this.colDegistirTarihSaati.FieldName = "DegistirTarihSaati";
            this.colDegistirTarihSaati.Name = "colDegistirTarihSaati";
            this.colDegistirTarihSaati.Width = 102;
            // 
            // colDegistirenKullaniciAdiSoyadi
            // 
            this.colDegistirenKullaniciAdiSoyadi.FieldName = "DegistirenKullaniciAdiSoyadi";
            this.colDegistirenKullaniciAdiSoyadi.Name = "colDegistirenKullaniciAdiSoyadi";
            this.colDegistirenKullaniciAdiSoyadi.Width = 153;
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.txtBakimBilgisi);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(492, 269);
            this.xtraTabPage2.Text = "BAKIM BİLGİSİ";
            // 
            // txtBakimBilgisi
            // 
            this.txtBakimBilgisi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBakimBilgisi.Location = new System.Drawing.Point(0, 0);
            this.txtBakimBilgisi.Name = "txtBakimBilgisi";
            this.txtBakimBilgisi.Size = new System.Drawing.Size(492, 269);
            this.txtBakimBilgisi.TabIndex = 0;
            // 
            // xtraTabPage3
            // 
            this.xtraTabPage3.Controls.Add(this.txtNotlar);
            this.xtraTabPage3.Name = "xtraTabPage3";
            this.xtraTabPage3.Size = new System.Drawing.Size(492, 269);
            this.xtraTabPage3.Text = "NOTLAR";
            // 
            // txtNotlar
            // 
            this.txtNotlar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNotlar.Location = new System.Drawing.Point(0, 0);
            this.txtNotlar.Name = "txtNotlar";
            this.txtNotlar.Size = new System.Drawing.Size(492, 269);
            this.txtNotlar.TabIndex = 1;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnOlustur);
            this.panelControl1.Controls.Add(this.txtPeriyot);
            this.panelControl1.Controls.Add(this.labelControl8);
            this.panelControl1.Controls.Add(this.labelControl6);
            this.panelControl1.Controls.Add(this.labelControl7);
            this.panelControl1.Controls.Add(this.dtBaslangicTarihi);
            this.panelControl1.Controls.Add(this.dtBitisTarihi);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(2, 24);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(494, 66);
            this.panelControl1.TabIndex = 66;
            // 
            // btnOlustur
            // 
            this.btnOlustur.Location = new System.Drawing.Point(255, 32);
            this.btnOlustur.Name = "btnOlustur";
            this.btnOlustur.Size = new System.Drawing.Size(157, 23);
            this.btnOlustur.TabIndex = 67;
            this.btnOlustur.Text = "Oluştur";
            this.btnOlustur.Visible = false;
            this.btnOlustur.Click += new System.EventHandler(this.btnOlustur_Click);
            // 
            // txtPeriyot
            // 
            this.txtPeriyot.EditValue = "0";
            this.txtPeriyot.Location = new System.Drawing.Point(351, 7);
            this.txtPeriyot.Name = "txtPeriyot";
            this.txtPeriyot.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtPeriyot.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtPeriyot.Properties.Mask.EditMask = "f0";
            this.txtPeriyot.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtPeriyot.Size = new System.Drawing.Size(61, 20);
            this.txtPeriyot.TabIndex = 66;
            this.txtPeriyot.TabStop = false;
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl8.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl8.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl8.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.labelControl8.Location = new System.Drawing.Point(255, 7);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(96, 20);
            this.labelControl8.TabIndex = 65;
            this.labelControl8.Text = "PERİYOT (AY)";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl6.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl6.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl6.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.labelControl6.Location = new System.Drawing.Point(7, 6);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(124, 20);
            this.labelControl6.TabIndex = 61;
            this.labelControl6.Text = "BAŞLANGIÇ TARİHİ";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl7.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl7.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl7.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.labelControl7.Location = new System.Drawing.Point(7, 32);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(124, 20);
            this.labelControl7.TabIndex = 63;
            this.labelControl7.Text = "BİTİŞ TARİHİ";
            // 
            // dtBaslangicTarihi
            // 
            this.dtBaslangicTarihi.EditValue = null;
            this.dtBaslangicTarihi.Location = new System.Drawing.Point(131, 6);
            this.dtBaslangicTarihi.Name = "dtBaslangicTarihi";
            this.dtBaslangicTarihi.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.dtBaslangicTarihi.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.dtBaslangicTarihi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtBaslangicTarihi.Properties.Mask.EditMask = "";
            this.dtBaslangicTarihi.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.dtBaslangicTarihi.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dtBaslangicTarihi.Size = new System.Drawing.Size(112, 20);
            this.dtBaslangicTarihi.TabIndex = 62;
            this.dtBaslangicTarihi.TabStop = false;
            // 
            // dtBitisTarihi
            // 
            this.dtBitisTarihi.EditValue = null;
            this.dtBitisTarihi.Location = new System.Drawing.Point(131, 32);
            this.dtBitisTarihi.Name = "dtBitisTarihi";
            this.dtBitisTarihi.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.dtBitisTarihi.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.dtBitisTarihi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtBitisTarihi.Properties.Mask.EditMask = "";
            this.dtBitisTarihi.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.dtBitisTarihi.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dtBitisTarihi.Size = new System.Drawing.Size(112, 20);
            this.dtBitisTarihi.TabIndex = 64;
            this.dtBitisTarihi.TabStop = false;
            // 
            // cariTanimlariTableAdapter
            // 
            this.cariTanimlariTableAdapter.ClearBeforeFill = true;
            // 
            // tblBakimAnlasmaDetayiTableAdapter1
            // 
            this.tblBakimAnlasmaDetayiTableAdapter1.ClearBeforeFill = true;
            // 
            // tblBakimAnlasmalariTableAdapter1
            // 
            this.tblBakimAnlasmalariTableAdapter1.ClearBeforeFill = true;
            // 
            // btnSozlesmeyiKapat
            // 
            this.btnSozlesmeyiKapat.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnSozlesmeyiKapat.Appearance.ForeColor = System.Drawing.Color.Red;
            this.btnSozlesmeyiKapat.Appearance.Options.UseFont = true;
            this.btnSozlesmeyiKapat.Appearance.Options.UseForeColor = true;
            this.btnSozlesmeyiKapat.Location = new System.Drawing.Point(10, 627);
            this.btnSozlesmeyiKapat.Name = "btnSozlesmeyiKapat";
            this.btnSozlesmeyiKapat.Size = new System.Drawing.Size(130, 23);
            this.btnSozlesmeyiKapat.TabIndex = 70;
            this.btnSozlesmeyiKapat.Text = "Anlaşmayı Sonlandır";
            this.btnSozlesmeyiKapat.Click += new System.EventHandler(this.btnSozlesmeyiKapat_Click);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID1,
            this.colBakimEvrakNo,
            this.colBakimTarihi,
            this.colAciklama,
            this.colHareketDurumu,
            this.colKapatanServisFormNo,
            this.colKapatmaTarihSaati,
            this.colKapatanKullaniciAdiSoyadi,
            this.colEkleyenTarihSaati,
            this.colEkleyenKullaniciAdiSoyadi,
            this.colDegistirTarihSaati,
            this.colDegistirenKullaniciAdiSoyadi});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // frmPeriyodikBakimEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 659);
            this.Controls.Add(this.btnSozlesmeyiKapat);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.btnVazgec);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmPeriyodikBakimEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "[PERİYODİK BAKIM EKLE]";
            this.Load += new System.EventHandler(this.frmPeriyodikBakimEkle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtMusteri.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cariTanimlariBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMusteriView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAdres2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAdres1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVergiNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVergiDairesi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUnvan1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblBakimAnlasmaDetayiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtEvrakTarihi.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtEvrakTarihi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEvrakNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gwPeriyotlar)).EndInit();
            this.xtraTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtBakimBilgisi.Properties)).EndInit();
            this.xtraTabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtNotlar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtPeriyot.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtBaslangicTarihi.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtBaslangicTarihi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtBitisTarihi.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtBitisTarihi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

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
        private DevExpress.XtraEditors.LabelControl labelControl10;
        public DevExpress.XtraEditors.TextEdit txtAdres2;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        public DevExpress.XtraEditors.TextEdit txtAdres1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        public DevExpress.XtraEditors.TextEdit txtVergiNo;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        public DevExpress.XtraEditors.TextEdit txtVergiDairesi;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        public DevExpress.XtraEditors.TextEdit txtTel;
        public DevExpress.XtraEditors.TextEdit txtUnvan1;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnVazgec;
        private DevExpress.XtraEditors.SimpleButton btnKaydet;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DatasetTableAdapters.sorgular sorgular1;
        private DevExpress.XtraEditors.TextEdit txtEvrakNo;
        private Dataset dataset;
        private System.Windows.Forms.BindingSource cariTanimlariBindingSource;
        private DatasetTableAdapters.CariTanimlariTableAdapter cariTanimlariTableAdapter;
        private DatasetTableAdapters.tblBakimAnlasmaDetayiTableAdapter tblBakimAnlasmaDetayiTableAdapter1;
        private System.Windows.Forms.BindingSource tblBakimAnlasmaDetayiBindingSource;
        private DatasetTableAdapters.tblBakimAnlasmalariTableAdapter tblBakimAnlasmalariTableAdapter1;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.DateEdit dtEvrakTarihi;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gwPeriyotlar;
        private DevExpress.XtraGrid.Columns.GridColumn colID1;
        private DevExpress.XtraGrid.Columns.GridColumn colBakimEvrakNo;
        private DevExpress.XtraGrid.Columns.GridColumn colBakimTarihi;
        private DevExpress.XtraGrid.Columns.GridColumn colAciklama;
        private DevExpress.XtraGrid.Columns.GridColumn colHareketDurumu;
        private DevExpress.XtraGrid.Columns.GridColumn colKapatanServisFormNo;
        private DevExpress.XtraGrid.Columns.GridColumn colKapatmaTarihSaati;
        private DevExpress.XtraGrid.Columns.GridColumn colKapatanKullaniciAdiSoyadi;
        private DevExpress.XtraGrid.Columns.GridColumn colEkleyenTarihSaati;
        private DevExpress.XtraGrid.Columns.GridColumn colEkleyenKullaniciAdiSoyadi;
        private DevExpress.XtraGrid.Columns.GridColumn colDegistirTarihSaati;
        private DevExpress.XtraGrid.Columns.GridColumn colDegistirenKullaniciAdiSoyadi;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraEditors.MemoEdit txtBakimBilgisi;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage3;
        private DevExpress.XtraEditors.MemoEdit txtNotlar;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnOlustur;
        public DevExpress.XtraEditors.TextEdit txtPeriyot;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.DateEdit dtBaslangicTarihi;
        private DevExpress.XtraEditors.DateEdit dtBitisTarihi;
        private DevExpress.XtraEditors.SimpleButton btnSozlesmeyiKapat;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}