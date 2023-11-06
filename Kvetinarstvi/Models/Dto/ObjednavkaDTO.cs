using System;
using System.Collections.Generic;

namespace Kvetinarstvi.Models.Dto;

public class ObjednavkaDTO
{
    public long ID { get; set; }
    public double CelkovaCena { get; set; } 
    public DateTime DatumObjednavky { get; set; }
    
    public ZakaznikDTO Zakaznik { get; set; }
    public PlatbaDTO Platba { get; set; }
    public List<ObjednanaKvetinaDTO> ObjednaneKvetiny { get; set; }
}