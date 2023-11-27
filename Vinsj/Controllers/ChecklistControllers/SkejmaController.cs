using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Vinsj.Data;
using Vinsj.Models;

namespace Vinsj.Controllers.ChecklistControllers
{
    public class SkejmaController : Controller
        private readonly ApplicationDbContext _context;


    {
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(ServiceOrdre)
        {
            if (ModelState.IsValid)
            {
                
            }

            return View();
        }
    }
}
