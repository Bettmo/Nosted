using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Vinsj.Models;

public class Komponent_service
{
    [Key, Column(Order = 0)]
    public int ServiceOrdreID_FK { get; set; }

    [Key, Column(Order = 1)]
    public string Komponent { get; set; }

    public string Avdeling { get; set; }

    public string Komponent_Status { get; set; }

    // Navigation property for related ServiceInstance
    [ForeignKey("ServiceOrdreID_FK")]
    public ServiceInstance ServiceInstance { get; set; }
}