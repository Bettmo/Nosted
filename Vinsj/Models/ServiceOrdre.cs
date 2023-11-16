using System.ComponentModel.DataAnnotations;

namespace Vinsj.Models;

public class ServiceOrdre
{
    [Key]
    public int ServiceOrdreID { get; set; }
    
    public ICollection<Arbeidskjema> Arbeidskjemas { get; set; }
    public ICollection<Serviceskjema> Serviceskjemar { get; set; }
}