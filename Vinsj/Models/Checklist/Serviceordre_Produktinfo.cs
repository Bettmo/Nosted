namespace Vinsj.Models.Checklist;

public class Serviceordre_Produktinfo
{
    public Guid ProdID { get; set; }
    
    public int Serienummer { get; set; }
    public string Modell { get; set; }
    public string ServiceGaranti { get; set; }
    
    
    //Lage kobling til serviceordre_ordreinfo
}