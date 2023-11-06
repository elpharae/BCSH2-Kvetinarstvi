namespace Kvetinarstvi.Models;

public class OpravneniModel
{
    public int Id { get; set; }
    public string Nazev { get; set; }
    public int UrovenOpravneni { get; set; }

    public OpravneniModel(int id, string nazev, int urovenOpravneni)
    {
        Id = id;
        Nazev = nazev;
        UrovenOpravneni = urovenOpravneni;
    }
}