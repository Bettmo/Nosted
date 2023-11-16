namespace Vinsj.Models.Checklist;
public class Mekanisk
{
    public Guid ID_Mek { get; set; }
    public string SjekkClutch { get; set; }
    public string SjekkBremser { get; set; }
    public string SjekkLagerForTrommel { get; set; }
    public string SjekkPTO { get; set; }
    public string SjekkKjedeStrammer { get; set; }
    public string SjekkWire { get; set; }
    public string SjekkPinionLager { get; set; }
    public string SjekkKileKjedehjul { get; set; }
    public string? Kommentar { get; set; }
    
    //legg til kobling til serviceordre modell
}