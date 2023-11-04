namespace Kvetinarstvi.Models.Dto;

public record UzivatelDto(
    int ID, 
    string Jmeno, 
    string Prijmeni, 
    string Email,
    string? HesloBcrypt,
    AdresaDto Adresa,
    ObrazekDto Obrazek,
    OpravneniDto Opravneni
);