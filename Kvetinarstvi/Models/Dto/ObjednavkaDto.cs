using System;

namespace Kvetinarstvi.Models.Dto;

public record ObjednavkaDto(
    int ID,
    double CelkovaCena,
    DateTime DatumObjednavky,
    StavDto Stav,
    PlatbaDto Platba,
    ZakaznikDto Zakaznik
);