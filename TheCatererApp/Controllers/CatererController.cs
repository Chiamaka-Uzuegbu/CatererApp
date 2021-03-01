using EntityLayerModel;
using EntityLayerModel.DataAccess;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheCatererApp.Models;

namespace TheCatererApp.Controllers
{
    public class CatererController : Controller
    {
        private readonly CatererDbContext _db;

        public CatererController (CatererDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<Caterer> objList = _db.Caterers;
            return View(objList);
        }

        //GET - CREATE
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        //POST CREATE

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Caterer obj)
        {
            if (ModelState.IsValid)
            {
                _db.Caterers.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");

            }
            return View(obj);
        }

        //GET-EDIT
        public IActionResult Edit(int? Id)
        {
            if (Id == null || Id == 0)
            {
                return NotFound();
            }

            var obj = _db.Caterers.Find(Id);

            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }

        //POST EDIT

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Caterer obj)
        {
            if (ModelState.IsValid)
            {
                _db.Caterers.Update(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");

            }
            return View(obj);

        }

        //GET-DELETE
        public IActionResult Delete(int? Id)
        {
            if (Id == null || Id == 0)
            {
                return NotFound();
            }

            var obj = _db.Caterers.Find(Id);

            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }

        //POST DELETE

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePost(int? Id)
        {
            var obj = _db.Caterers.Find(Id);
            if (obj == null)
            {
                return NotFound();
            }

            _db.Caterers.Remove(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}
