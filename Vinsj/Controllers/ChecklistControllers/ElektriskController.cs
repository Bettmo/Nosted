using Microsoft.AspNetCore.Mvc;
using Vinsj.Data;




public class ElektriskController : Controller
{
    private void ElektriskInsertData()
    {
        using (var dbContext = new ApplicationDbContext())
        {
            var elVariabel = new Elektrisk();
            dbContext.elektrisk.Add(elVariabel);
            dbContext.SaveChanges();
        }
    }



    // GET
    public IActionResult Index()
    {
        return View();
    }


    //Brage: Denne funksjonen lager et "elektrisk" objekt og oppdaterer databasen
    [HttpPost]
    public IActionResult CreateElektrisk(Elektrisk elektrisk)
    {

        if (ModelState.IsValid)
        {
            try
            {
                // Brage: DbContext har ikke blitt satt opp ordentlig, må bli gjort.
                //Her tas dependency injectionen inn
                ElektriskInsertData();

                // Brage: Her bør en passende action for suksess bli lagt til.
                return RedirectToAction("Success");
            }
            //Brage: Fanger alle exceptions og gir en feilmelding
            catch (Exception ex)
            {
                ModelState.AddModelError(string.Empty, "En feil oppstod under lagringen av data.");
            }
        }

        // Trym: Hvis modellen ikke er valid returneres viewet med feil
        return View(elektrisk);
    }

}