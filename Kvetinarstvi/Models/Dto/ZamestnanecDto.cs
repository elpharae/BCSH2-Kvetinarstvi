namespace Kvetinarstvi.Models.Dto;

public record ZamestnanecDto(
    int ID,
    string Jmeno,
    string Prijmeni,
    string Email,
    string HesloBcrypt,
    double Mzda,
    AdresaDto Adresa,
    PracovisteDto Pracoviste,
    OpravneniDto Opravneni,
    PracovniPoziceDto PracovniPozice,
    ObrazekDto? Obrazek
);