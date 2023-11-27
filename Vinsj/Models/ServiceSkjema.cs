using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Vinsj.Models;

public class ServiceSkjema
{
    [Key]
    [ForeignKey("ServiceOrdre")]
    public int ServiceOrdreIDFK { get; set; }
    
    public string? AvtaltKunde { get; set; }
    public string? RepBeskrivelse { get; set; }
    public string? DelerBrukt { get; set; }
    
    public int AbreidsTimer { get; set; }
    public string? FerdigDato { get; set; }
    public string? DelerRetunert { get; set; }
    public string? ForsendelseMate { get; set; }
    public string? SignKunde { get; set; }
    public string? SignRep { get; set; }
    
    
    // Navigasjon for Foreign Key, 
    public ServiceOrdre ServiceOrdre { get; set; }
}