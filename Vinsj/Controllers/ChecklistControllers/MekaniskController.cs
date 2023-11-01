using Microsoft.AspNetCore.Mvc;
using Vinsj.Data;



public class MekaniskController : Controller
{
    //Brage: Setter opp en dependency injection for hydraulisk modellen, muligens må endres å for å få det funksjonelt.
    private void MekaniskInsertData()
    {
        using (var dbContext = new ApplicationDbContext())
        {
            var meVariabel = new Mekanisk();
            dbContext.hydraulisk.Add(meVariabel);
            dbContext.SaveChanges();
        }
    }



    // GET
    public IActionResult Index()
    {
        return View();
    }


    //Brage: Denne funksjonen lager et "mekanisk" objekt og oppdaterer databasen
    [HttpPost]
    public IActionResult CreateMekanisk(Hydraulisk mekanisk)
    {

        if (ModelState.IsValid)
        {
            try
            {
                // Brage: Henter funksjonen som setter opp en entity basert på modellen.
                MekaniskInsertData();

                // Brage: Her bør en passende action for suksess bli lagt til.
                return RedirectToAction("Success");
            }
            //Brage: Fanger alle exceptions og gir en feilmelding, ex variablet gjør at vi kan se hva som ble feil med objektet.
            catch (Exception ex)
            {
                ModelState.AddModelError(string.Empty, "En feil oppstod under lagringen av data.");
            }
        }

        // Brage: Hvis modellen ikke er valid returneres viewet med feil
        return View(mekanisk);
    }

}