using System.Collections.Generic;

namespace Kvetinarstvi.Models.Dto;

public class KvetinaDTO
{
    public long ID { get; set; }
    public string Nazev { get; set; }
    public ulong Pocet { get; set; }
    public double Cena { get; set; }
    public string? Popis { get; set; } 
    
    public BarvaDTO Barva { get; set; }
    public KategorieDTO Kategorie { get; set; }
    public ObrazekDTO? Obrazek { get; set; }
    public List<HistorieCenyDTO> HistorieCen { get; set; }
    
}