namespace Kvetinarstvi.Models.Dto;

public record ObjednaneKvetinyDto(
    uint Mnozstvi,
    double CenaZaKus,
    ObjednavkaDto Objednavka,
    KvetinaDto Kvetina
);