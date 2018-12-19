using BandRegister.Data;
using BandRegister.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace BandRegister.Controllers
{
    public class BandController : Controller
    {
        public IActionResult Index()
        {
            using (var db = new BandRegisterDbContex())
            {
                List<Band> bands = db.Bands.ToList();

                return View(bands);
            }

        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Band band)
        {
            if (ModelState.IsValid)
            {
                using (var db = new BandRegisterDbContex())
                {
                    db.Bands.Add(band);
                    db.SaveChanges();
                }

                return RedirectToAction("Index");
            }

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            using (var db = new BandRegisterDbContex())
            {
                Band bandToEdit = db.Bands.SingleOrDefault(b => b.Id == id);
                if (bandToEdit == null)
                {
                    return RedirectToAction("index");
                }

                return View(bandToEdit);
            }
        }

        [HttpPost]
        public IActionResult Edit(Band edittedBand)
        {
            if (ModelState.IsValid)
            {
                using (var db = new BandRegisterDbContex())
                {
                    var bandToEdit = db.Bands
                        .SingleOrDefault(b => b.Id == edittedBand.Id);

                    bandToEdit.Name = edittedBand.Name;
                    bandToEdit.Members = edittedBand.Members;
                    bandToEdit.Honorarium = edittedBand.Honorarium;
                    bandToEdit.Genre = edittedBand.Genre;
                    db.SaveChanges();
                }

                return RedirectToAction("Index");
            }

            return View(edittedBand);
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            using (var db = new BandRegisterDbContex())
            {
                Band bandToDelete = db.Bands
                    .SingleOrDefault(b => b.Id == id);

                if (bandToDelete == null)
                {
                    return RedirectToAction("Index");
                }

                return View(bandToDelete);
            }
        }

        [HttpPost]
        public IActionResult Delete(Band band)
        {
            using (var db = new BandRegisterDbContex())
            {
                var bandToDelete = db.Bands
                    .SingleOrDefault(b => b.Id == band.Id);

                if (bandToDelete == null)
                {
                    return RedirectToAction("Index");
                }

                db.Remove(bandToDelete);
                db.SaveChanges();
            }

            return RedirectToAction("Index");
        }
    }
}