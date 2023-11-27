namespace Vinsj.Models;

public class ServiceSkjemaView
{
    public int ServiceOrdreID { get; set; } // This might be set automatically if it's a generated key

    // Properties from Kunde_informasjon
    public string KundeNavn { get; set; }
    public string KundeAdresse { get; set; }
    public string KundeEpost { get; set; }
    public int KundeTelefon { get; set; }

    // Properties from Produkt_informasjon
    public string ProduktType { get; set; }
    public int ProduktArsmodell { get; set; }
    public string ProduktSerienummer { get; set; }
    public string ProduktGaranti { get; set; }
    public string ProduktMottat { get; set; }
    
    // Properties from ServiceSkjema
    
    public string SAvtaltKunde { get; set; }
    public string SRepBeskrivelse { get; set; }
    public string SDelerBrukt { get; set; }
    public int SAbreidsTimer { get; set; }
    public string SFerdigDato { get; set; }
    public string SDelerRetunert { get; set; }
    public string SForsendelseMate { get; set; }
    public string SSignKunde { get; set; }
    public string SSignRep { get; set; }
}