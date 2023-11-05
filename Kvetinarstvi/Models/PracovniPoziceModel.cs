namespace Kvetinarstvi.Models;

public class PracovniPoziceModel
{
    public int Id{ get; set; }
    public string Nazev{ get; set; }

    public PracovniPoziceModel(int id, string nazev)
    {
        Id = id;
        Nazev = nazev;
    }
}