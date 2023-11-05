namespace Kvetinarstvi.Models;

public class KvetinaModel
{
    public int Id { get; set; }
    public string Nazev { get; set; }
    public int Pocet { get; set; }
    public string? Popis { get; set; }

    public BarvaModel Barva { get; set; }
    public KategorieModel Kategorie { get; set; }
    public CenaModel cena { get; set; } //TODO asi bude entita mezi kvetinou a cenou
    public ObrazekModel? Obrazek{ get; set; }

    public KvetinaModel(int id, string nazev, int pocet, string? popis, BarvaModel barva, KategorieModel kategorie, CenaModel cena, ObrazekModel? obrazek)
    {
        Id = id;
        Nazev = nazev;
        Pocet = pocet;
        Popis = popis;
        Barva = barva;
        Kategorie = kategorie;
        this.cena = cena;
        Obrazek = obrazek;
    }
}