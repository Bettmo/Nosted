namespace Vinsj.Models
{
    public class SjekklisteView
    {

        public int ServiceOrdreID { get; set; }

        //Properties from Komponent_service
        public string? komponentKomponent { get; set; }
        public string? komponentAvdeling { get; set; } 
        public string? komponentKomponent_Status { get; set; }

        //Properties from Funksjons_test
        public string? funksjonsTestVinsj { get; set; }
        public float funksjonsTrekkraft { get; set; }
        public float funksjonsBremsekraft { get; set; }

        //Properties from trykk_settinger
        public float trykkBar { get; set; }

        //Properties from SignaturerModel
        public string? signaturKommentar { get; set; }
        public string? signaturSignatur { get; set; }
        public string? signaturDato { get; set; }
    }


}
