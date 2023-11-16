namespace Vinsj.Models.Checklist;
public class Hydraulisk
{
    public Guid ID_Hyd { get; set; }
    public string SjekkSylinderForLekkasje { get; set; }
    public string SjekkSlangerForSkader { get; set; }
    public string TestHydraulikkBlokk { get; set; }
    public string SjekkOljeTank { get; set; }
    public string SjekkOljeGirboks { get; set; }
    public string SjekkRingsylinder { get; set; }
    public string SjekkBremsesylinder { get; set; }
    public string? Kommentar { get; set; }
    
    //legg til kobling til serviceordre modell
}