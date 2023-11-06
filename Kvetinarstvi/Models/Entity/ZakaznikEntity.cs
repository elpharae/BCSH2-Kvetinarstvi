using System.Collections.Generic;

namespace Kvetinarstvi.Models.Entity;

public class ZakaznikEntity
{
    public long ID { get; set; }
    public string Jmeno { get; set; }
    public string Prijmeni { get; set; }
    public string Email { get; set; }
    public string? HesloBcrypt { get; set; }
    
    public OpravneniEntity Opravneni { get; set; }
    public AdresaEntity Adresa { get; set; }
    public ObrazekEntity? Obrazek { get; set; }
    
    public List<ObjednavkaEntity>? Objednavka { get; set; }
}