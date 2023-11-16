using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Vinsj.Models;

public class trykk_settinger
{
    [Key, ForeignKey(ServiceOrdreID)]
    public int ServiceOrdreID_FK { get; set; }
    
    public float Bar { get; set; }
}