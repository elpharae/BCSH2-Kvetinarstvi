namespace Kvetinarstvi.Models.Entity;

public class ObjednanaKvetinaEntity
{
    public ulong Mnozstvi { get; set; }
    public double CenaZaKus { get; set; }
    
    public ObjednavkaEntity Objednavka { get; set; }
    public KvetinaEntity Kvetina { get; set; }
}