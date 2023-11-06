namespace Kvetinarstvi.Models.Dto;

public class PracovisteDTO
{
    public long ID { get; set; }
    public string Nazev { get; set; }
    
    public AdresaDTO Adresa { get; set; }
}