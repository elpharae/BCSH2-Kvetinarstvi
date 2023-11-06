namespace Kvetinarstvi.Models.Dto;

public class ZakaznikDTO
{
    public long ID { get; set; }
    public string Jmeno { get; set; }
    public string Prijmeni { get; set; }
    public string Email { get; set; }
    public string? HesloBcrypt { get; set; }
    
    public OpravneniDTO Opravneni { get; set; }
    public AdresaDTO Adresa { get; set; }
    public ObrazekDTO? Obrazek { get; set; }
}