namespace Vinsj.Models.Checklist;

public class Serviceordre_Ordreinfo
{
    public Guid OrdreID { get; set; }
    public Guid ProdID_FK { get; set; }
    public Guid ID_Hyd_FK { get; set; }
    public Guid ID_Mek_FK { get; set; }
    public Guid ID_El_FK { get; set; }
    
    public string? KundeNavn { get; set; }
    public string? KundeAdresse { get; set; }
    public string? KundeTelefon { get; set; }
    public string? KundeEpost { get; set; }
    public string Reperasjonsbeskrivelse { get; set; }
    public string? Medgåttedeler { get; set; }
    public int? Arbeidstimer { get; set; }
    public int? UtskiftetDelerReturnert { get; set; }
    public string? Forsendelsesmåte { get; set; }
    
    public DateOnly FerdigstiltDato { get; set; }
    public DateOnly DatoSkapt { get; set; }
    
    //kobling med tre sjekkliste saker, ansatt_delegering og serviceordre_produktinfo
}