namespace Kvetinarstvi.Models.Entity;

public class KategorieEntity
{
    public long ID { get; set; }
    public string Nazev { get; set; }
    
    public KategorieEntity Nadkategorie { get; set; }
}