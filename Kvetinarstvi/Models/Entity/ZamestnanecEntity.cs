namespace Kvetinarstvi.Models.Entity;

public class ZamestnanecEntity
{
    public long ID { get; set; }
    public string Jmeno { get; set; }
    public string Prijmeni { get; set; }
    public string Email { get; set; }
    public string HesloBcrypt { get; set; }
    public double Mzda { get; set; }
    
    public PracovisteEntity Pracoviste { get; set; }
    public PracovniPoziceEntity PracovniPozice { get; set; }
    public AdresaEntity Adresa { get; set; }
    public OpravneniEntity Opravneni { get; set; }
    public ObrazekEntity? Obrazek { get; set; }
}