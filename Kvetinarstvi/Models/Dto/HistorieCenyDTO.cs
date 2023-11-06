using System;

namespace Kvetinarstvi.Models.Dto;

public class HistorieCenyDTO
{
    public DateTime CenaOd { get; set; }   
    public DateTime CenaDo { get; set; }
    
    public KvetinaDTO Kvetina { get; set; }
    public CenaDTO Cena { get; set; }
}