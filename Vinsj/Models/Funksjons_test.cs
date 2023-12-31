﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Vinsj.Models;

public class Funksjons_test
{
    [Key]
    [ForeignKey("ServiceOrdre")]
    public int ServiceOrdreID_FK { get; set; }
    
    public string? TestVinsj { get; set; }
    
    public float Trekkraft { get; set; }
    
    public float Bremsekraft { get; set; }
    
    // Navigasjon for Foreign Key, 
    public ServiceOrdre ServiceOrdre { get; set; }
}