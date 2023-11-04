namespace Kvetinarstvi.Models;

public class BarvaModel
{
    public int Id { get; set; }
    public string Nazev { get; set; }

    public BarvaModel(int id, string nazev)
    {
        Id = id;
        Nazev = nazev;
    }
}