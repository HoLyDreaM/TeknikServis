using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraPrinting;
using DevExpress.XtraPrinting.Export;
using DevExpress.XtraPrinting.Exports;
using DevExpress.XtraReports.UI;

namespace TeknikServis
{
    public class Fonksiyonlar
    {
        public enum ciktiTuru
        {
            Excel = 0, Csv = 2, Pdf = 3, Text = 4
        }

        public void ps_disariAktar(DevExpress.XtraGrid.Views.Grid.GridView gv, ciktiTuru ciktiTuru)
        {
            try
            {
                if (gv.RowCount < 1)
                    System.Windows.Forms.MessageBox.Show("Raporlanacak Kayıt Bulunamadı!");
                {
                    System.Windows.Forms.SaveFileDialog raporKaydet = new System.Windows.Forms.SaveFileDialog();
                    raporKaydet.Title = "Rapor Kaydet!";
                    raporKaydet.DefaultExt = "Rapor Kaydet";

                    System.Windows.Forms.DialogResult DialogResult = new System.Windows.Forms.DialogResult();

                    switch (ciktiTuru)
                    {
                        case ciktiTuru.Excel:
                            raporKaydet.Filter = "Excel Dosyaları (*.xls)|*.xls";
                            break;

                        case ciktiTuru.Text:
                            raporKaydet.Filter = "Excel Dosyaları (*.txt)|*.txt";
                            break;

                        case ciktiTuru.Pdf:
                            raporKaydet.Filter = "Excel Dosyaları (*.pdf)|*.pdf";
                            break;

                        case ciktiTuru.Csv:
                            raporKaydet.Filter = "Excel Dosyaları (*.csv)|*.csv";
                            break;
                    }

                    DialogResult = raporKaydet.ShowDialog();

                    if (DialogResult == System.Windows.Forms.DialogResult.Yes)
                    {
                        string filePath = raporKaydet.FileName;

                        switch (ciktiTuru)
                        {
                            case ciktiTuru.Excel:
                                gv.ExportToXls(filePath, new XlsExportOptions(TextExportMode.Value));
                                break;

                            case ciktiTuru.Text:
                                gv.ExportToTextOld(filePath);
                                break;

                            case ciktiTuru.Pdf:
                                gv.ExportToPdf(filePath);
                                break;

                            case ciktiTuru.Csv:
                                gv.ExportToCsv(filePath);
                                break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message.ToString());
            }
        }

    }
}
