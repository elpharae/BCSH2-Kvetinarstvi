namespace Kvetinarstvi.Models.Dto;

public record KvetinaDto(
    int ID,
    string Nazev,
    uint Pocet,
    string? Popis,
    BarvaDto Barva,
    KategorieDto Kategorie,
    ObrazekDto? Obrazek
);