using System;

namespace Kvetinarstvi.Models;

public class HistorieCenyModel
{
    public DateTime CasOd { get; set; }
    public DateTime CasDo { get; set; }
    public KvetinaModel Kvetina{ get; set; }
    public CenaModel Cena{ get; set; }

    public HistorieCenyModel(DateTime casOd, DateTime casDo, KvetinaModel kvetina, CenaModel cena)
    {
        CasOd = casOd;
        CasDo = casDo;
        Kvetina = kvetina;
        Cena = cena;
    }
}