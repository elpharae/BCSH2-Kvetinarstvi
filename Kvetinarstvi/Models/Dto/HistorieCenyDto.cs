using System;

namespace Kvetinarstvi.Models.Dto;

public record HistorieCenyDto(
    DateTime CenaOd,
    DateTime CenaDo,
    KvetinaDto Kvetina,
    CenaDto Cena
);