namespace Kvetinarstvi.Models;

public class CenaModel
{
    public int Id { get; set; }
    public double Hodnota { get; set; }

    public CenaModel(int id, double hodnota)
    {
        Id = id;
        Hodnota = hodnota;
    }
}