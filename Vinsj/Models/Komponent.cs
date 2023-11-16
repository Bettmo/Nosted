using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Vinsj.Models;

public class Komponent_service
{
    /* Eric: [Key] markerer ServiceOrdreID_FK som en primærnøkkel.
     [Column(Order = 0)] definerer at feltet er den første kolonnen i en sammensatt primærnøkkel (Composite).*/
    
    [Key, Column(Order = 0)]
    [ForeignKey("ServiceOrdre")]
    public int ServiceOrdreID_FK { get; set; }

    /* Eric: [Column(Order = 1)] definerer at feltet er den andre [0,1,2,3] kolonnen i en sammensatt primærnøkkel (composite). */
    
    [Key, Column(Order = 1)]
    public string Komponent { get; set; }

    public string Avdeling { get; set; } /* Eric: Avdelingen komponenten/sjekkpunktet tilhører; Elektrisk, Hydraulisk og Mekanisk */

    public string Komponent_Status { get; set; } /* Eric: Statusen på komponenten/sjekkpunktet ; OK, Bør Skiftes, Defekt */

    // Navigasjon for fremmednøkkel tullet
    public ServiceOrdre ServiceOrdre { get; set; }
}