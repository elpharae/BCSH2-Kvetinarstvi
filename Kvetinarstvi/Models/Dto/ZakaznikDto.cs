namespace Kvetinarstvi.Models.Dto;

public record ZakaznikDto(
    int ID,
    string Email,
    string Jmeno,
    string Prijmeni,
    string? HesloBcrypt,
    AdresaDto Adresa,
    OpravneniDto Opravneni,
    ObrazekDto? Obrazek
);