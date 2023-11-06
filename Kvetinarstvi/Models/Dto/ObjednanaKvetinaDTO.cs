namespace Kvetinarstvi.Models.Dto;

public class ObjednanaKvetinaDTO
{
    public ulong Mnozstvi { get; set; }
    public double CenaZaKus { get; set; }
    
    public ObjednavkaDTO Objednavka { get; set; }
    public KvetinaDTO Kvetina { get; set; }
}