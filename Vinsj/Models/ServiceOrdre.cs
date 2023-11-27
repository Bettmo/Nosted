using System.ComponentModel.DataAnnotations;

namespace Vinsj.Models;

public class ServiceOrdre
{
    [Key]
    public int ServiceOrdreID { get; set; }
    
    public ICollection<Kunde_informasjon> KundeInformasjons { get; set; }
    public ICollection<Produkt_informasjon> ProduktInformasjons { get; set; }
}