namespace Vinsj.Models
{
    public class SjekklisteView
    {

        //Properties from Komponent_service
        public string? Komponent { get; set; }
        public string? Avdeling { get; set; } 
        public string? Komponent_Status { get; set; }

        //Properties from Funksjons_test
        public string? TestVinsj { get; set; }
        public float Trekkraft { get; set; }
        public float Bremsekraft { get; set; }

        //Properties from trykk_settinger
        public float Bar { get; set; }

        //Properties from SignaturerModel
        public string? Kommentar { get; set; }
        public string? Signatur { get; set; }
        public string? Dato { get; set; }
    }


}
