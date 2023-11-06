namespace Kvetinarstvi.Models.Entity;

public class ObrazekEntity
{
    public long ID { get; set; }
    public byte[] Data { get; set; }
    public string Nazev { get; set; } 
    public string? Popis { get; set; }
}