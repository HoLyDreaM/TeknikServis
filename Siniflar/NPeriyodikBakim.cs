using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public class NPeriyodikBakim
{   
    public int ID { get; set; }
    public int evrakNo { get; set; }
    public DateTime evrakTarihi { get; set; }
    public string musteriKodu  { get; set; }
    public DateTime baslangicTarihi { get; set; }
    public DateTime bitisTarihi { get; set; }
    public int periyotAraligi { get; set; }
    public string hareketDurumu { get; set; }
    public string bakimBilgisi { get; set; }
    public string notlar { get; set; }
}

