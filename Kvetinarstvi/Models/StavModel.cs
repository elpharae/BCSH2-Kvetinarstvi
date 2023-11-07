namespace Kvetinarstvi.Models;

public class StavModel
{
    public int Id { get; set; }
    public string Nazev { get; set; }

    public StavModel(int id, string nazev)
    {
        Id = id;
        Nazev = nazev;
    }
}