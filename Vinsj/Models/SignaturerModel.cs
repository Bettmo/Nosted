namespace Vinsj.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

    public class SignaturerModel
    {
    [Key]
    [ForeignKey("ServiceOrdre")]
    public int ServiceOrdreIDFK { get; set; }

    public string? Kommentar { get; set; }
    public string? Signatur { get; set; }
    public string? Dato { get; set; }

    // Navigasjon for fremmednøkkel
    public ServiceOrdre ServiceOrdre { get; set; }
}
}
