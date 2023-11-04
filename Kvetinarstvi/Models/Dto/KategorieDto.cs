namespace Kvetinarstvi.Models.Dto;

public record KategorieDto(
    int ID,
    string Nazev,
    KategorieDto? Nadkategorie
);