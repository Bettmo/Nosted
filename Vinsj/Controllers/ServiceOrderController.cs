using Microsoft.AspNetCore.Mvc;
using Vinsj.Data;
using Vinsj.Models;


namespace Vinsj.Controllers;

public class ServiceOrderController : Controller
{
    private readonly ApplicationDbContext _context;

    public ServiceOrderController(ApplicationDbContext context)
    {
        _context = context;
    }

    [HttpPost]
    public async Task<IActionResult> CreateServiceOrder(ServiceSkjemaView model)
    {
        if (ModelState.IsValid)
        {
            var serviceOrdre = new ServiceOrdre();

            var kundeInformasjon = new Kunde_informasjon();

            var produktInformasjon = new Produkt_informasjon();

            var serviceskjemaInformasjon = new ServiceSkjema();

            _context.Add(serviceOrdre);
            _context.Add(kundeInformasjon);
            _context.Add(produktInformasjon);
            _context.Add(serviceskjemaInformasjon);

            await _context.SaveChangesAsync();

            return RedirectToAction("Success");
            
        }

        return View(model);
    }
}