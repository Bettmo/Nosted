using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Vinsj.Models;

public class Produkt_informasjon
{
    [Key]
    [ForeignKey("ServiceOrdre")]
    public int ServiceOrdreIDFK { get; set; }
    
    public string? ProduktType { get; set; }
    
    public int Arsmodell { get; set; }
    
    public string? Serienummer { get; set; }
    
    public string? Garanti { get; set; }
    
    public string? DatoMottat { get; set; }
    
    // Navigasjon for Foreign Key, 
    public ServiceOrdre ServiceOrdre { get; set; }
}