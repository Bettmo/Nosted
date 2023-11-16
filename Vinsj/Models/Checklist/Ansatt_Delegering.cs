namespace Vinsj.Models.Checklist;

public class Ansatt_Delegering
{
    public Guid AnsattID_FK { get; set; }
    public Guid OrdreID_FK { get; set; }
    
    //sette kobling for både ansatt og serviceordre_ordreinfo
}