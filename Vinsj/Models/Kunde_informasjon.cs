using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Vinsj.Models;

public class Kunde_informasjon
{
    [Key]
    [ForeignKey("ServiceOrdre")]
    public int ServiceOrdreIDFK { get; set; }
    
    public string? Adresse { get; set; }
    
    public string? Epost { get; set; }
    
    public int Telefon { get; set; }
    
    // Navigasjon for fremmednøkkel tullet
    public ServiceOrdre ServiceOrdre { get; set; }
}