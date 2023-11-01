using Microsoft.AspNetCore.Mvc;
using Vinsj.Data;




public class HydrauliskController : Controller
{
    //Trym: Setter opp en dependency injection for hydraulisk modellen, muligens må endres å for å få det funksjonelt.
    private void HydrauliskInsertData()
    {
        using (var dbContext = new ApplicationDbContext())
        {
            var hyVariabel = new Hydraulisk();
            dbContext.hydraulisk.Add(hyVariabel);
            dbContext.SaveChanges();
        }
    }



    // GET
    public IActionResult Index()
    {
        return View();
    }


    //Trym: Denne funksjonen lager et "hydraulisk" objekt og oppdaterer databasen
    [HttpPost]
    public IActionResult CreateHydraulisk(Hydraulisk hydraulisk)
    {

        if (ModelState.IsValid)
        {
            try
            {
                // Trym: Henter funksjonen som setter opp en entity basert på modellen.
                HydrauliskInsertData();

                // Trym: Her bør en passende action for suksess bli lagt til.
                return RedirectToAction("Success");
            }
            //Trym: Fanger alle exceptions og gir en feilmelding, ex variablet gjør at vi kan se hva som ble feil med objektet.
            catch (Exception ex)
            {
                ModelState.AddModelError(string.Empty, "En feil oppstod under lagringen av data.");
            }
        }

        // Trym: Hvis modellen ikke er valid returneres viewet med feil
        return View(hydraulisk);
    }

}