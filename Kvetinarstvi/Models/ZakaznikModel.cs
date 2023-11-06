using System.Collections.Generic;

namespace Kvetinarstvi.Models;

public class ZakaznikModel
{
    public int Id { get; set; }
    public string Jmeno { get; set; }
    public string Prijmeni { get; set; }

    public string Email { get; set; }
    public ObrazekModel? Obrazek{ get; set; }
    public OpravneniModel Opravneni { get; set; }
    public AdresaModel Adresa { get; set; }
    public List<ObjednavkaModel> Objednavky { get; set; } //TODO to be changed .. or not
    public string? HesloBcrypt{ get; set; }

    public ZakaznikModel(int id, string jmeno, string prijmeni, string email, ObrazekModel obrazek, OpravneniModel opravneni, AdresaModel adresa, List<ObjednavkaModel> objednavky, string? hesloBcrypt)
    {
        Id = id;
        Jmeno = jmeno;
        Prijmeni = prijmeni;
        Email = email;
        Obrazek = obrazek;
        Opravneni = opravneni;
        Adresa = adresa;
        Objednavky = objednavky;
        HesloBcrypt = hesloBcrypt;
    }
}