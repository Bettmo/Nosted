namespace Vinsj.Models.Checklist;

public class Elektrisk
{
    public Guid ID_El { get; set; }
    public string SjekkLedningsnett { get; set; }
    public string SjekkTestRadio { get; set; }
    public string SjekkTestKnappekasse { get; set; }
    public string Bar { get; set; }
    public string testVinsjKjorAlt { get; set; }
    public string TrekkraftKN { get; set; }
    public string BremsekreaftKN { get; set; }
    public string? Kommentar { get; set; }
    
    //legg til kobling til serviceordre modell
}