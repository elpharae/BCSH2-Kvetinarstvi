namespace Kvetinarstvi.Models.Dto;

public class KategorieDTO
{
    public long ID { get; set; }
    public string Nazev { get; set; }
    
    public KategorieDTO Nadkategorie { get; set; }
}