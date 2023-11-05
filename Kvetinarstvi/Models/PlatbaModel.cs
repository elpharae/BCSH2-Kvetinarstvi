namespace Kvetinarstvi.Models;

public class PlatbaModel
{
    public int Id { get; set; }
    public string Nazev { get; set; }

    public PlatbaModel(int id, string nazev)
    {
        Id = id;
        this.Nazev = nazev;
    }
}