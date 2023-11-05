using System.Collections.Generic;

namespace Kvetinarstvi.Models;

public class KategorieModel
{
    public int Id { get; set; }
    public string Nazev { get; set; }
    public KategorieModel Nadkategorie { get; set; }

    public KategorieModel(int id, string nazev, KategorieModel nadkategorie)
    {
        Id = id;
        Nazev = nazev;
        Nadkategorie = nadkategorie;
    }
}