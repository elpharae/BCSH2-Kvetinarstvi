namespace Kvetinarstvi.Models;

public class ObjednaneKvetinyModel
{
    public int Mnozstvi { get; set; }
    public double CenaZaKus { get; set; }
    public KvetinaModel Kvetina { get; set; }
    public ObjednavkaModel Objednavka { get; set; }

    public ObjednaneKvetinyModel(int mnozstvi, double cenaZaKus, KvetinaModel kvetina, ObjednavkaModel objednavka)
    {
        Mnozstvi = mnozstvi;
        CenaZaKus = cenaZaKus;
        Kvetina = kvetina;
        Objednavka = objednavka;
    }
}