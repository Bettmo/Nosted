
using Microsoft.AspNetCore.Mvc;

namespace Vinsj.Controllers.ChecklistControllers;

/*public class ElektriskController : Controller
{
    private readonly ApplicationDbContext _context;
    
    public ElektriskController(ApplicationDbContext context)
    {
        _context = context;
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
                _context.Elektrisk.Add(elektrisk);
                _context.SaveChanges();

                // Brage: Her bør en passende action for suksess bli lagt til.
                return RedirectToAction("Success");
            }
            //Brage: Fanger alle exceptions og gir en feilmelding
            catch (Exception ex)
            {
                ModelState.AddModelError(string.Empty, "En feil oppstod under lagringen av data.");
            }
        }

        // Hvis modellen ikke er valid returneres viewet med feil
        return View(elektrisk);
    }
    
}
*/