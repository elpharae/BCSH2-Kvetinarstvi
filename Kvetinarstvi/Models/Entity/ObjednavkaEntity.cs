using System;
using System.Collections.Generic;

namespace Kvetinarstvi.Models.Entity;

public class ObjednavkaEntity
{
    public long ID { get; set; }
    public double CelkovaCena { get; set; } 
    public DateTime DatumObjednavky { get; set; }
    
    public ZakaznikEntity Zakaznik { get; set; }
    public PlatbaEntity Platba { get; set; }
    
    public List<ObjednanaKvetinaEntity> ObjednaneKvetiny { get; set; }
}