namespace Kvetinarstvi.Models.Dto;

public record PracovisteDto(
    int ID,
    string Nazev,
    AdresaDto Adresa
);