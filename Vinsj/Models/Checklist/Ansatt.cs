namespace Vinsj.Models.Checklist;

public class Ansatt
{
    public Guid AnsattID { get; set; }
    public string Navn { get; set; }
    public string AnsattRolle { get; set; }
    
    //Sette opp kobling til Ansatt_Delegering
}