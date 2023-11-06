namespace Kvetinarstvi.Models;

public class ZamestnanecModel
{
    public int Id{ get; set; }
    public string Jmeno{ get; set; }
    public string Prijmeni{ get; set; }
    public string Email{ get; set; }
    public string HesloBcrypt{ get; set; }
    public double Mzda{ get; set; }
    
    public ObrazekModel? Obrazek{ get; set; }
    public AdresaModel Adresa{ get; set; }
    public PracovisteModel Pracoviste{ get; set; }
    public OpravneniModel Opravneni{ get; set; }
    public PracovniPoziceModel PracovniPozice{ get; set; }

    public ZamestnanecModel(int id, string jmeno, string prijmeni, string email, string hesloBcrypt, double mzda, ObrazekModel obrazek, AdresaModel adresa, PracovisteModel pracoviste, OpravneniModel opravneni, PracovniPoziceModel pracovniPozice)
    {
        Id = id;
        Jmeno = jmeno;
        Prijmeni = prijmeni;
        Email = email;
        HesloBcrypt = hesloBcrypt;
        Mzda = mzda;
        Obrazek = obrazek;
        Adresa = adresa;
        Pracoviste = pracoviste;
        Opravneni = opravneni;
        PracovniPozice = pracovniPozice;
    }
}