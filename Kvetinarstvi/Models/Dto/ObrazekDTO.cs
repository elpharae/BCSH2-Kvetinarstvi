namespace Kvetinarstvi.Models.Dto;

public class ObrazekDTO
{
    public long ID { get; set; }
    public byte[] Data { get; set; }
    public string Nazev { get; set; } 
    public string? Popis { get; set; }
}