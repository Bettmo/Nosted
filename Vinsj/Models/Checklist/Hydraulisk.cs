using Vinsj.Models.Dashboard;
using System.ComponentModel.DataAnnotations.Schema;

public class Hydraulisk
{
    public int ID { get; set; }
    
    [ForeignKey("ServiceOrdre")]
    public int ServiceOrdreID { get; set; } // ForeignKey for ServiceOrdre
    public int Ordrenummer { get; set; }
    
    public string? sjekkpunkt { get; set; } // Henter Sjekkpunktet
    public bool ok { get; set; } // Bool som sjekker om ok er true
    public bool borSkiftes { get; set; } // Bool som sjekker om borSKiftes er true
    public bool defekt { get; set; } // Bool som sjekker om defekt er true
    public string? Kommentar { get; set; } // Kommentarfelt
    
    public ServiceOrdre? ServiceOrdre { get; set; }
}

public class HydrauliskListViewModel
{
    public List<Hydraulisk> HydrauliskListe { get; set; } = new List<Hydraulisk>();
    public ServiceOrdre? ServiceOrdreInfo { get; set; } 
    
    public int ServiceOrdreID { get; set; } 
    public int Ordrenummer { get; set; } 
    public string? Produkttype { get; set; } 
    public string? Årsmodell { get; set; } 
    public string? Serienummer { get; set; } 
    public string? Status { get; set; } 
    public string? Fornavn { get; set; } 
    public string? Etternavn { get; set; } 
    public string? Telefonnummer { get; set; } 
    public string? Feilbeskrivelse { get; set; } 
    public string? KommentarFraKunde { get; set; } 
    public string? Kommentar { get; set; } 
}