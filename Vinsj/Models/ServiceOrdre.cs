using System.ComponentModel.DataAnnotations;

namespace Vinsj.Models;

public class ServiceOrdre
{
    [Key]
    public int ServiceOrdreID { get; set; }
    
    public ICollection<trykk_settinger> TrykkSettingers { get; set; }
    public ICollection<Komponent_service> KomponentServices { get; set; }
}