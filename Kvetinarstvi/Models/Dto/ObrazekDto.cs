namespace Kvetinarstvi.Models.Dto;

public record ObrazekDto(
    int ID,
    byte[] Data,
    string Nazev,
    string? Popis
);