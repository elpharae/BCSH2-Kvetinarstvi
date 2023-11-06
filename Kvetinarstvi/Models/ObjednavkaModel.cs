using System;
using System.Collections.Generic;

namespace Kvetinarstvi.Models;

public class ObjednavkaModel
{
    public int Id { get; set; }
    public double CelkovaCena { get; set; }
    public DateTime DatumObjednavy { get; set; }

    public StavModel Stav { get; set; }
    public PlatbaModel Platba { get; set;}
    public ZakaznikModel Zakaznik { get; set; }
    public List<KvetinaModel> Kvetiny { get; set; }

    public ObjednavkaModel(int id, double celkovaCena, DateTime datumObjednavy, StavModel stav, PlatbaModel platba, ZakaznikModel zakaznik, List<KvetinaModel> kvetiny)
    {
        Id = id;
        CelkovaCena = celkovaCena;
        DatumObjednavy = datumObjednavy;
        Stav = stav;
        Platba = platba;
        Zakaznik = zakaznik;
        Kvetiny = kvetiny;
    }
}