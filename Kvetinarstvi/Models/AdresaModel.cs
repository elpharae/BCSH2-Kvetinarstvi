namespace Kvetinarstvi.Models;

public class AdresaModel
{
    public int Id { get; set; }
    public string Psc { get; set; }
    public string Ulice { get; set; }
    public string Mesto { get; set; }
    public string Cp { get; set; }

    public AdresaModel(int id, string psc, string ulice, string mesto, string cp)
    {
        Id = id;
        Psc = psc;
        Ulice = ulice;
        Mesto = mesto;
        Cp = cp;
    }
}