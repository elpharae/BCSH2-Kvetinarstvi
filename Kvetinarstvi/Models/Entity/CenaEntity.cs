using System;

namespace Kvetinarstvi.Models.Entity;

public class CenaEntity
{
    public long ID { get; set; }
    public double Hodnota { get; set; }
    public DateTime CenaOd { get; set; }
    public DateTime CenaDo { get; set; }
}