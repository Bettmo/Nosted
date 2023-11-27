using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Vinsj.Models;

public class ServiceOrdre
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int ServiceOrdreID { get; set; }
    
    public ICollection<Kunde_informasjon> KundeInformasjons { get; set; }
    public ICollection<Produkt_informasjon> ProduktInformasjons { get; set; }
    public ICollection<ServiceSkjema> ServiceSkjemas { get; set; }
    public ICollection<Komponent_service> KomponentServices { get; set; }
    public ICollection<SignaturerModel> SignaturerModels { get; set; }
    public ICollection<trykk_settinger> TrykkSettingers { get; set; }
    public ICollection<Funksjons_test> FunksjonsTests { get; set; }
    public object ServiceOrderID { get; set; }
}