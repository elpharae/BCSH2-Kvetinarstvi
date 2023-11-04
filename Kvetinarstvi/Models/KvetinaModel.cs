namespace Kvetinarstvi.Models;

public class KvetinaModel
{
    public int Id { get; set; }
    public string Nazev { get; set; }
    public int Pocet { get; set; }
    public string Popis { get; set; }

    public BarvaModel Barva { get; set; }

    public KvetinaModel(int id, string nazev, int pocet, string popis,BarvaModel barva)
    {
        Id = id;
        Nazev = nazev;
        Pocet = pocet;
        Popis = popis;
        Barva = barva;
    }
}