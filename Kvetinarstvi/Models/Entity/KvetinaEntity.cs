using System.Collections.Generic;

namespace Kvetinarstvi.Models.Entity;

public class KvetinaEntity
{
    public long ID { get; set; }
    public string Nazev { get; set; }
    public ulong Pocet { get; set; }
    public double Cena { get; set; }
    public string? Popis { get; set; } 
    
    public BarvaEntity Barva { get; set; }
    public KategorieEntity Kategorie { get; set; }
    public ObrazekEntity? Obrazek { get; set; }
    
    public List<CenaEntity> Ceny { get; set; }
    
}