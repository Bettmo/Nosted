﻿using Microsoft.AspNetCore.Mvc;
using Vinsj.Data;
using Vinsj.Models;

namespace Vinsj.Controllers
{
    public class SjekklisteController : Controller
    {
        private readonly ApplicationDbContext _context;

        public SjekklisteController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<IActionResult> CreateSjekkliste(SjekklisteView model)
        {
            if (ModelState.IsValid)
            {
                var serviceOrdre = new ServiceOrdre();
                {

                }

                var Komponent_service = new Komponent_service()
                {
                    Komponent = model.komponentKomponent,
                    Avdeling = model.komponentAvdeling,
                    Komponent_Status = model.komponentKomponent_Status
                };

                var Funksjons_test = new Funksjons_test()
                {
                    TestVinsj = model.funksjonsTestVinsj,
                    Trekkraft = model.funksjonsTrekkraft,
                    Bremsekraft = model.funksjonsBremsekraft
                };

                var Trykk_settinger = new trykk_settinger()
                {
                    Bar = model.trykkBar
                };

                var SignaturerModel = new SignaturerModel()
                {
                    Kommentar = model.signaturKommentar,
                    Signatur = model.signaturSignatur,
                    Dato = model.signaturDato
                };

                _context.Add(Komponent_service);
                _context.Add(Funksjons_test);
                _context.Add(Trykk_settinger);
                _context.Add(SignaturerModel);

                await _context.SaveChangesAsync();

                return RedirectToAction("Sjekkliste", controllerName:"Home");

            }

            return View("~/Views/Home/Sjekkliste.cshtml", model);
        }
    }
}
