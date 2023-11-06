namespace Kvetinarstvi.Models.Entity;

public class PracovisteEntity
{
    public long ID { get; set; }
    public string Nazev { get; set; }
    
    public AdresaEntity Adresa { get; set; }
}