using System.Drawing;

namespace Kvetinarstvi.Models;

public class ObrazekModel
{
    public int Id { get; set; }
    public Image Data{ get; set; }
    public string Nazev{ get; set; }
    public string? Popis{ get; set; }

    public ObrazekModel(int id, Image data, string nazev, string? popis)
    {
        Id = id;
        Data = data;
        Nazev = nazev;
        Popis = popis;
    }
}