namespace Kvetinarstvi.Models;

public class PracovisteModel
{
    public int Id{ get; set; }
    public string Nazev{ get; set; }
    public AdresaModel Adresa { get; set; }

    public PracovisteModel(int id, string nazev, AdresaModel adresa)
    {
        Id = id;
        Nazev = nazev;
        Adresa = adresa;
    }
}